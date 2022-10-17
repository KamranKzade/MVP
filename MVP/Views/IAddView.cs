
namespace MVP.Views;

public interface IAddView
{
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Score { get; set; }
    DateTime DateOfBirth { get; set; }

    DialogResult DialogResult { get; set; }

    event EventHandler SaveEvent;
    event EventHandler CancelEvent;
    
    DialogResult ShowDialog();
}