using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FileCopierAdvanced
{
    class FileCopiers
    {
        /*
        private const int MAXNUMOFFORMS = 10;
        private Form2[] _forms;
        private int FormNumber = 0;
        private bool FormOpened;
        File_Copier _FC = new File_Copier();
        public FileCopiers(int _x, File_Copier _fc)
        {
            _forms = new Form2[_x];
            MonitorForms(_x, _fc);
        }
        private void MonitorForms(int _f, File_Copier _fc)
        {
            if (FormNumber > 0)
            {
                for (int i = 1; i < _f; i++)
                {
                    _forms[i].FormClosed += FormWasClosed;
                }
            }
            if (_fc._buttonClicked) 
            {
                FormNumber += 1;
                _forms[FormNumber].Name = $"File Copier {FormNumber}";
                _forms[FormNumber].Show();
            }
        }
        private void FormWasClosed(object o, FormClosedEventArgs e)
        {
            if (FormNumber > 0)
            {
                FormNumber -= 1;
                if (FormNumber < 0) { FormNumber = 0; }
            }
        }
        */
    }
}
