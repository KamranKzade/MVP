using MVP.Models;
using MVP.Views;

namespace MVP.Presenters;

public class MainPresenter
{
    private readonly IMainView _mainView = null!;
    private readonly IAddUpdateView _addUpdateView = null!;
    private readonly BindingSource _bindingSource;
    private readonly List<Student> _students;

    public MainPresenter(IMainView mainView, IAddUpdateView addUpdateView)
    {
        _mainView = mainView;
        _addUpdateView = addUpdateView;


        _students = new List<Student>()
        {
            new Student("Kamran","Karimzada", new DateTime(1999, 3, 27), 11.2f),
            new Student("Elsad","Hasanov", new DateTime(2005, 3, 25), 9.8f),
            new Student("Tural","Tural", new DateTime(2007, 6, 24), 10.6f)
        };


        //// Binding Source
        _bindingSource = new();
        _bindingSource.DataSource = _students;
        _mainView.SetStudentListBindingSource(_bindingSource);


        //// Event
        _mainView.SearchEvent += _mainView_SearchEvent;
        _mainView.DeleteEvent += _mainView_DeleteEvent;
        _mainView.AddEvent += _mainView_AddEvent;
        _mainView.UpdateEvent += MainView_UpdateEvent;
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
        {
            MessageBox.Show("An Error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _bindingSource.Remove(deletedItem);
        MessageBox.Show("Succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void _mainView_AddEvent(object? sender, EventArgs e)
    {
        var result = _addUpdateView.ShowDialog();

        if (result == DialogResult.Cancel)
            return;

        var student = new Student()
        {
            FirstName = _addUpdateView.FirstName,
            LastName = _addUpdateView.LastName,
            DateOfBirth = DateTime.Parse(_addUpdateView.DateOfBirth.ToShortDateString()),
            Score = (float)_addUpdateView.Score,
        };

        _bindingSource.Add(student);
        MessageBox.Show("Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    private void MainView_UpdateEvent(object? sender, EventArgs e)
    {
        var student = _bindingSource.Current as Student;

        if (student is null)
        {
            MessageBox.Show("An Error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _addUpdateView.FirstName = student.FirstName;
        _addUpdateView.LastName = student.LastName;
        _addUpdateView.Score = (decimal)student.Score;
        _addUpdateView.DateOfBirth = student.DateOfBirth;


        if (_addUpdateView.ShowDialog() == DialogResult.Cancel)
            return;


        student.FirstName = _addUpdateView.FirstName;
        student.LastName = _addUpdateView.LastName;
        student.Score = (float)_addUpdateView.Score;
        student.DateOfBirth = _addUpdateView.DateOfBirth;



        _bindingSource.ResetCurrentItem();
        MessageBox.Show("Succesfully Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


}