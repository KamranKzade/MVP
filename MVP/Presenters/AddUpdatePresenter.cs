using MVP.Views;
using System.Text;

namespace Source.Presenters;


public class AddUpdatePresenter
{
    private readonly IAddUpdateView _addUpdateView;

    public AddUpdatePresenter(IAddUpdateView addView)
    {
        _addUpdateView = addView;

        _addUpdateView.SaveEvent += _addView_SaveEvent;
        _addUpdateView.CancelEvent += _addView_CancelEvent;
    }


    private void _addView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new();

        if (_addUpdateView.FirstName.Length < 3)
            sb.Append($"{nameof(_addUpdateView.FirstName)} is Wrong\n");

        if (_addUpdateView.LastName.Length < 3)
            sb.Append($"{nameof(_addUpdateView.LastName)} is Wrong\n");

        if (DateTime.Now.Year - _addUpdateView.DateOfBirth.Year < 18)
            sb.Append($"{nameof(_addUpdateView.DateOfBirth)} is Wrong\n");

        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _addUpdateView.DialogResult = DialogResult.OK;
    }


    private void _addView_CancelEvent(object? sender, EventArgs e)
        => _addUpdateView.DialogResult = DialogResult.Cancel;

}