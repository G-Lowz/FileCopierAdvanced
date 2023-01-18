using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using Timer = System.Timers.Timer;

namespace FileCopierAdvanced
{
    public partial class Form2 : Form
    {
        private FileInfo[] _tempList = new FileInfo[500];
        private List<string> _tempListFileNames = new List<string>();
        private List<string> _tempListSorted = new List<string>();
        private FileInfo[] _compareList = new FileInfo[500];
        private List<string> _compareListSorted = new List<string>();
        private string fileName;
        private double _time;
        private static System.Timers.Timer aTimer;
        public event EventHandler _formClosing;
        // Initialising...
        public Form2()
        {
            InitializeComponent();
            FileKeyword.Focus();
            SourcePath.ReadOnly = true;
            TargetPath.ReadOnly = true;
            ResetForm();
            this.FormClosing += Form2_FormClosing;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_formClosing != null)
            {
                _formClosing?.Invoke(this.Name, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("_formClosing is NULL");
            }
        }
        // Source browse button
        private void button1_Click(object sender, EventArgs e)
        {
            SourcePath.Text = "";
            FolderBrowserDialog _folderBrowser = new FolderBrowserDialog();
            _folderBrowser.Description = "Source Path";
            if (_folderBrowser.ShowDialog() == DialogResult.OK)
            {
                SourcePath.Text = _folderBrowser.SelectedPath.ToString();
            }
        }
        // Target browse button
        private void button2_Click(object sender, EventArgs e)
        {
            TargetPath.Text = "";
            FolderBrowserDialog _folderBrowser = new FolderBrowserDialog();
            _folderBrowser.Description = "Target Path";
            if (_folderBrowser.ShowDialog() == DialogResult.OK)
            {
                TargetPath.Text = _folderBrowser.SelectedPath.ToString();
            }
        }
        //  Copy File button
        private void button3_Click(object sender, EventArgs e)
        {
            if (SourcePath.Text == "" || SourcePath.Text == "Choose Source Path" || TargetPath.Text == "" || TargetPath.Text == "Choose Source Path")
            {
                MessageBox.Show("Missing Info: Path(s)", "Info Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (FileKeyword.Text == "" || FileKeyword.Text == "Enter a keyword of the file")
            {
                MessageBox.Show("Missing Info: File Keyword", "Info Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    _time = double.Parse(TimeBox.Text);
                    _time *= 1000 * 360 * 24;
                    RunTimer(_time);
                    CopyingInProgress();
                }
                catch
                {
                    MessageBox.Show("Wrong or missing Info: Time Interval", "Info Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TimeBox.Text = "";
                    TimeBox.Focus();
                }
            }
        }
        // Timer 
        private void RunTimer(double _t)
        {
            aTimer = new System.Timers.Timer(_t);
            aTimer.Elapsed += (sender, e) => CopyFilesToFolder(sender, e, FileKeyword.Text, SourcePath.Text, TargetPath.Text);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Start();
            NextLabel.Text = DateTime.Now.AddDays(double.Parse(TimeBox.Text)).ToString();
        }
        private void CopyFilesToFolder(Object sender, ElapsedEventArgs e, string _fk, string _sp, string _tp)
        {
            _tempListSorted.Clear();
            _tempListFileNames.Clear();

            DirectoryInfo sourceLines = new DirectoryInfo(_sp);
            _tempList = sourceLines.GetFiles();

            if (_tempList.Length > 0)
            {
                for (int i = 0; i < _tempList.Length; i++)
                {
                    string s = _tempList[i].Name.ToString().ToLower();
                    for (int j = 0; j < (s.Length - _fk.Length); j++)
                    {
                        string y = s.Substring(j, _fk.Length);
                        if (y == _fk.ToLower())
                        {
                            _tempListSorted.Add(_tempList[i].ToString());
                            _tempListFileNames.Add(_tempList[i].Name.ToString());
                        }
                    }
                }
            }
            for (int i = 0; i < _tempListSorted.Count; i++)
            {
                fileName = _tempListFileNames[i].ToString();
                string sourcePath = _sp.Trim();
                string targetPath = _tp.Trim();

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                try
                {
                    if (System.IO.File.Exists(sourceFile))
                    {
                        System.IO.File.Copy(sourceFile, destFile, true);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show($"Error : {e1}");
                }
            }
            this.NextLabel.Invoke((MethodInvoker)delegate { NextLabel.Text = DateTime.Now.AddDays(double.Parse(TimeBox.Text)).ToString(); });
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strpath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string sourceFilePath = Path.Combine(strpath.Remove(strpath.Length - 4), "Files\\Source.txt");
                string destinationFilePath = Path.Combine(strpath.Remove(strpath.Length - 4), "Files\\Destination.txt");
                using StreamWriter _sw1 = new StreamWriter(sourceFilePath);
                _sw1.WriteLine(SourcePath.Text);
                _sw1.Close();
                using StreamWriter _sw2 = new StreamWriter(destinationFilePath);
                _sw2.WriteLine(TargetPath.Text);
                _sw2.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("Error in saving source file name : " + es.ToString());
            }
            aTimer.Stop();
            ResetForm();
        }
        private void CopyingInProgress()
        {
            StopButton.Enabled = true;
            button3.Enabled = false;
            FileKeyword.Enabled = false;
            TimeBox.Enabled = false;
            StopButton.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            FilesToLeaveBox.Enabled = false;
        }
        private void ResetForm()
        {
            FileKeyword.Enabled = true;
            button3.Enabled = true;
            StopButton.Enabled = false;
            TimeBox.Enabled = true;
            FileKeyword.Focus();
            button1.Enabled = true;
            button2.Enabled = true;
            FilesToLeaveBox.Enabled = true;
            NextLabel.Text = "00/00/0000 00:00:00 AM";
        }
    }
}
