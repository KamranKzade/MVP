using MVP.Models;
using MVP.Views;

namespace MVP.Presenters;

public class MainPresenter
{
    private readonly IMainView _mainView = null!;
    private readonly IAddView _addView = null!;
    private readonly IUpdateView _updateView = null!;


    private readonly BindingSource _bindingSource;
    private readonly List<Student> _students;

    public MainPresenter(IMainView mainView, IAddView addeView, IUpdateView updateView)
    {
        _mainView = mainView;
        _addView = addeView;
        _updateView = updateView;


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
        var deletedItem = _bindingSource.Current as Student;

        if (deletedItem is null)
        {
            MessageBox.Show("An Error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _bindingSource.Remove(deletedItem);
        MessageBox.Show("Succesfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void _mainView_AddEvent(object? sender, EventArgs e)
    {
        if (_addView.ShowDialog() == DialogResult.Cancel)
            return;

        var student = new Student()
        {
            FirstName = _addView.FirstName,
            LastName = _addView.LastName,
            DateOfBirth = _addView.DateOfBirth,
            Score = (float)_addView.Score,
        };

        _bindingSource.Add(student);
        MessageBox.Show("Successfully Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        _addView.LastName = string.Empty;
        _addView.FirstName = string.Empty;
        _addView.Score = 0;
       _addView.DateOfBirth =  DateTime.Now;
    }


    private void MainView_UpdateEvent(object? sender, EventArgs e)
    {
        var student = _bindingSource.Current as Student;

        if (student is null)
        {
            MessageBox.Show("An Error occured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        _updateView.FirstName = student.FirstName;
        _updateView.LastName = student.LastName;
        _updateView.Score = (decimal)student.Score;
        _updateView.DateOfBirth = student.DateOfBirth;


        if (_updateView.ShowDialog() == DialogResult.Cancel)
            return;


        student.FirstName = _updateView.FirstName;
        student.LastName = _updateView.LastName;
        student.Score = (float)_updateView.Score;
        student.DateOfBirth = _updateView.DateOfBirth;



        _bindingSource.ResetCurrentItem();
        MessageBox.Show("Succesfully Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}