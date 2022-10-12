using MVP.Models;
using MVP.Views;

namespace MVP.Presenters;

public class MainPresenter
{
    private readonly IMainView _mainView = null!;
    private readonly IAddView _addView = null!;
    private readonly BindingSource _bindingSource;
    private readonly List<Student> _students;

    public MainPresenter(IMainView mainView, IAddView add)
    {
        _mainView = mainView;
        _addView = add;


        _students = new List<Student>()
        {
            new Student("Kamran","Karimzada", new DateOnly(1999, 3, 27), 11.2f),
            new Student("Elsad","Hasanov", new DateOnly(2005, 3, 25), 9.8f),
            new Student("Tural","Tural", new DateOnly(2007, 6, 24), 10.6f)
        };


        //// Binding Source
        _bindingSource = new();
        _bindingSource.DataSource = _students;
        _mainView.SetStudentListBindingSource(_bindingSource);


        //// Event
        _mainView.SearchEvent += _mainView_SearchEvent;
        _mainView.DeleteEvent += _mainView_DeleteEvent;
        _mainView.AddEvent += _mainView_AddEvent;

    }


    private void _mainView_SearchEvent(object? sender, EventArgs e)
    {
        var searchValue = _mainView.SearchValue;
        if (!string.IsNullOrWhiteSpace(_mainView.SearchValue))
            _bindingSource.DataSource = _students
                .Where(s =>
                s.FirstName
                .ToLower()
                .Contains(searchValue.ToLower())
                || s.LastName
                .ToLower()
                .Contains(searchValue.ToLower())).ToList();
        else
            _bindingSource.DataSource = _students;
    }

    private void _mainView_DeleteEvent(object? sender, EventArgs e)
    {
        var deletedItem = _bindingSource.Current;

        if (deletedItem is null)
            return;

        _bindingSource.Remove(deletedItem);
    }

    private void _mainView_AddEvent(object? sender, EventArgs e)
    {
        var result = ((Form)_addView).ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        var student = new Student()
        {
            FirstName = _addView.FirstName,
            LastName = _addView.LastName,
            DateOfBirth = DateOnly.Parse(_addView.DateOfBirth.ToShortDateString()),
            Score = (float)_addView.Score,
        };

        _bindingSource.Add(student);
        MessageBox.Show("Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


}
