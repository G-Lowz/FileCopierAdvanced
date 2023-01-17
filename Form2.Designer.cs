
using System.ComponentModel;

namespace FileCopierAdvanced
{
    partial class Form2 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
            this.NextLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FilesToLeaveBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.FileKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Source_Folder = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TargetPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NextLabel
            // 
            this.NextLabel.AutoSize = true;
            this.NextLabel.Location = new System.Drawing.Point(158, 243);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(132, 15);
            this.NextLabel.TabIndex = 30;
            this.NextLabel.Text = "00/00/0000 00:00:00 AM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Next files saved on: ";
            // 
            // FilesToLeaveBox
            // 
            this.FilesToLeaveBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FilesToLeaveBox.Location = new System.Drawing.Point(749, 37);
            this.FilesToLeaveBox.Name = "FilesToLeaveBox";
            this.FilesToLeaveBox.Size = new System.Drawing.Size(36, 23);
            this.FilesToLeaveBox.TabIndex = 28;
            this.FilesToLeaveBox.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "No. of files to leave in source folder:";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(426, 165);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(278, 23);
            this.StopButton.TabIndex = 26;
            this.StopButton.Text = "Stop Copying Files";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Interval (day):";
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TimeBox.Location = new System.Drawing.Point(403, 37);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(118, 23);
            this.TimeBox.TabIndex = 24;
            this.TimeBox.Text = "0.00115740740";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Copy New Files From Source to Target Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FileKeyword
            // 
            this.FileKeyword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FileKeyword.Location = new System.Drawing.Point(137, 37);
            this.FileKeyword.Name = "FileKeyword";
            this.FileKeyword.Size = new System.Drawing.Size(157, 23);
            this.FileKeyword.TabIndex = 15;
            this.FileKeyword.Text = "file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "File Name with:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Target Folder:";
            // 
            // Source_Folder
            // 
            this.Source_Folder.AutoSize = true;
            this.Source_Folder.Location = new System.Drawing.Point(40, 82);
            this.Source_Folder.Name = "Source_Folder";
            this.Source_Folder.Size = new System.Drawing.Size(82, 15);
            this.Source_Folder.TabIndex = 19;
            this.Source_Folder.Text = "Source Folder:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TargetPath
            // 
            this.TargetPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TargetPath.Location = new System.Drawing.Point(137, 119);
            this.TargetPath.Name = "TargetPath";
            this.TargetPath.Size = new System.Drawing.Size(567, 23);
            this.TargetPath.TabIndex = 18;
            this.TargetPath.Text = "C:\\Users\\Glenn Lopez\\Parts\\Folder1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SourcePath
            // 
            this.SourcePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SourcePath.Location = new System.Drawing.Point(137, 79);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(567, 23);
            this.SourcePath.TabIndex = 16;
            this.SourcePath.Text = "C:\\Users\\Glenn Lopez\\Parts\\Folder2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 382);
            this.Controls.Add(this.NextLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FilesToLeaveBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FileKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Source_Folder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TargetPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SourcePath);
            this.MaximumSize = new System.Drawing.Size(842, 421);
            this.MinimumSize = new System.Drawing.Size(842, 421);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
            //this.FormClosing += Form2_FormClosing;
        }

        #endregion

        private System.Windows.Forms.Label NextLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FilesToLeaveBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox FileKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Source_Folder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TargetPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SourcePath;
        
    }
}