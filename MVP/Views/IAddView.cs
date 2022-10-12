using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views;

public interface IAddView
{
    string? FirstName { get; }
    string? LastName { get; }
    decimal Score { get; }
    DateTime DateOfBirth { get; }


    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

}