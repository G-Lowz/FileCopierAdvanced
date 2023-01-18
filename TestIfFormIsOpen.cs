using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FileCopierAdvanced
{
    class TestIfFormIsOpen
    {
        //private const int MaxNumberOfForms = 4;

        private int MaxNumberOfForms; 
        private int iInputFormNum  
        { 
            set { iInputFormNum = value; }
        }
        private bool bInputFormNumOK 
        { 
            get { return bInputFormNumOK; }
        }
        private bool[] aFormNumbers;
        public TestIfFormIsOpen(int _max)  // initialisation
        {
            MaxNumberOfForms = _max;
            aFormNumbers = new bool[MaxNumberOfForms];
            for (int i = 0; i < MaxNumberOfForms; i++)
            {
                aFormNumbers[i] = false;
            }
        }
        public int RequestForFormOpened()
        {
            int _tempNum = 0;
            for (int i = 0; i < MaxNumberOfForms; i++)
            {
                if (aFormNumbers[i] == true)
                {
                    _tempNum += 1;
                }
            }
            return _tempNum;
        }
        public void RequestToCloseForm(int _fn)
        {
            aFormNumbers[_fn] = false;
        }
        public int RequestingFormNum() // request for a copier number unused
        {
            int i;
            int _tempNum = 0;
            //int j = 1;
            try
            {
                for (i = 0; i < MaxNumberOfForms; i++)
                {
                    if (aFormNumbers[i] == false)
                    {
                        _tempNum = i;
                        aFormNumbers[i] = true;
                        break;
                    }
                    /*
                    else
                    {
                        j += 1;
                        if (j >= MaxNumberOfForms)
                        {
                            _tempNum = MaxNumberOfForms - 1;
                            MessageBox.Show("Maximum Number of Forms opened");
                            break;
                        } 
                    } */
                }
                return _tempNum;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error {e}");
                return 0;
            }
        }
    }
}
