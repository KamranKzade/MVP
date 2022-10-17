using MVP.Views;
using System.Text;

namespace Source.Presenters;


public class AddPresenter
{
    private readonly IAddView _addView;

    public AddPresenter(IAddView addView)
    {
        _addView = addView;

        _addView.SaveEvent += _addView_SaveEvent;
        _addView.CancelEvent += _addView_CancelEvent;
    }


    private void _addView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new();

        if (_addView.FirstName.Length < 3)
            sb.Append($"{nameof(_addView.FirstName)} is Wrong\n");

        if (_addView.LastName.Length < 3)
            sb.Append($"{nameof(_addView.LastName)} is Wrong\n");

        if (DateTime.Now.Year - _addView.DateOfBirth.Year < 18)
            sb.Append($"{nameof(_addView.DateOfBirth)} is Wrong\n");

        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _addView.DialogResult = DialogResult.OK;
    }


    private void _addView_CancelEvent(object? sender, EventArgs e)
        => _addView.DialogResult = DialogResult.Cancel;

}