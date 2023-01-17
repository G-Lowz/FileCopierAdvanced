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
        private const int MAXNUMBEROFFORM = 10;
        Form2 _form = new Form2();
        private int FormNumberOpen = 0;
        public File_Copier()
        {
            InitializeComponent();
            OpenLabel.Text = $"Number of Copiers Open: 0";
            MonitoringForm();
        }
        private void MonitoringForm()
        {
            _form._formClosing += _forms_FormClosing;
        }
        private void _forms_FormClosing(object sender, EventArgs e)
        {
            button1.Enabled = true;
            FormNumberOpen -= 1;
            OpenLabel.Text = $"Number of File Copier Open: {FormNumberOpen}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormNumberOpen += 1;
            _form.Text = $"File Copier {FormNumberOpen}";
            if (_form.IsDisposed)
            {
                _form = new Form2();
                _form.Show();
                MonitoringForm();
            }
            else
            {
                _form.Show();
            }
            OpenLabel.Text = $"Number of File Copier Open: {FormNumberOpen}";
            button1.Enabled = false;
        }

        // For has reached the max the button will be disabled.


    }
}
