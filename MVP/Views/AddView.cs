using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class AddView : Form, IAddView
    {

        public AddView()
        {
            InitializeComponent();
        }


        public string FirstName
        {
            get => txt_first.Text;
            set => txt_first.Text = value;
        }
        public string LastName
        {
            get => txt_last.Text;
            set => txt_last.Text = value;
        }
        public decimal Score
        {
            get => numeric_score.Value;
            set => numeric_score.Value = value;
        }
        public DateTime DateOfBirth
        {
            get => monthCalendar1.SelectionStart;
            set => monthCalendar1.SelectionStart = value;
        }


        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        private void btn_save_Click(object sender, EventArgs e)
        => SaveEvent?.Invoke(sender, e);

        private void btn_cancel_Click(object sender, EventArgs e)
        => CancelEvent?.Invoke(sender, e);
    }
}