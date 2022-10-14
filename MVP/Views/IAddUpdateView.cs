using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views;

public interface IAddUpdateView
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    decimal Score { get; set; }
    DateTime DateOfBirth { get; set; }


    event EventHandler SaveEvent;
    event EventHandler CancelEvent;
    
    DialogResult ShowDialog();
}