using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class EndForm : Form
    {
        private string  _selectedFName;
        private string  _selectedLName;

        public EndForm(String SelectedFName, string SelectedLName)
        {
            InitializeComponent();
            this._selectedFName = SelectedFName;
            this._selectedLName = SelectedLName;
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            label1.Text = _selectedFName;
            label2.Text = _selectedLName;
        }

        private void EndForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
