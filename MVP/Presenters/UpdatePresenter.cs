using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters;

public class UpdatePresenter
{
    private readonly IUpdateView _updateView;

    public UpdatePresenter(IUpdateView updateView)
    {
        _updateView = updateView;

        _updateView.SaveEvent += _updateView_SaveEvent;
        _updateView.CancelEvent += _updateView_CancelEvent;
    }


    private void _updateView_SaveEvent(object? sender, EventArgs e)
    {
        StringBuilder sb = new();

        if (_updateView.FirstName.Length < 3)
            sb.Append($"{nameof(_updateView.FirstName)} is Wrong\n");

        if (_updateView.LastName.Length < 3)
            sb.Append($"{nameof(_updateView.LastName)} is Wrong\n");

        if (DateTime.Now.Year - _updateView.DateOfBirth.Year < 18)
            sb.Append($"{nameof(_updateView.DateOfBirth)} is Wrong\n");

        if (sb.Length > 0)
        {
            MessageBox.Show(sb.ToString(), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _updateView.DialogResult = DialogResult.OK;
    }


    private void _updateView_CancelEvent(object? sender, EventArgs e)
        => _updateView.DialogResult = DialogResult.Cancel;
}
