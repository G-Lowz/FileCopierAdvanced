using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FileCopierAdvanced
{
    public partial class File_Copier : Form
    {
        private const int MAXNUMBEROFFORM = 5;
        Form2[] _form = new Form2[MAXNUMBEROFFORM];
        TestIfFormIsOpen _FormNumTest;
        private int _i;
        public File_Copier()
        {
            InitializeComponent();
            _FormNumTest = new TestIfFormIsOpen(MAXNUMBEROFFORM);
            OpenLabel.Text = $"Number of File Copier Open: {_FormNumTest.RequestForFormOpened()}";
            MonitoringForm();
            MaxLabel.Visible = false;
        }
        private void MonitoringForm()
        {
            int _r = _FormNumTest.RequestForFormOpened();
            if ( _r > 0)
            {
                for (_i = 0; _i < _r; _i++)
                {
                    _form[_i]._formClosing += _forms_FormClosing; // how to send the number to the event handeler?
                }
            } 
        }
        private void _forms_FormClosing(object sender, EventArgs e)  /// SUBSCRIPTION ISSUE
        {
            // *** request to close form 
            int _t = int.Parse(sender.ToString());
            if (!button1.Enabled) 
            { 
                button1.Enabled = true;
                MaxLabel.Visible = false;
            }
            _FormNumTest.RequestToCloseForm(_t);
            OpenLabel.Text = $"Number of File Copier Open: {_FormNumTest.RequestForFormOpened()}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Test if this is open.
            int _formNum = _FormNumTest.RequestingFormNum();

            // Open the form if not opened or 
            _form[_formNum] = new Form2();
            _form[_formNum].Text = $"File Copier {_formNum+1}";
            _form[_formNum].Name = _formNum.ToString();
            if (_form[_formNum].IsDisposed)
            {
                _form[_formNum] = new Form2();
                _form[_formNum].Show();
            }
            else
            {
                _form[_formNum].Show();
            }
            MonitoringForm();

            OpenLabel.Text = $"Number of File Copier Open: {_FormNumTest.RequestForFormOpened()}";
            if (_FormNumTest.RequestForFormOpened() >= MAXNUMBEROFFORM)
            {
                button1.Enabled = false;
                MaxLabel.Visible = true;
            }
            
        }

        // For has reached the max the button will be disabled.


    }
}
