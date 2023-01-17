using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileCopierAdvanced
{
    class FileCopyWindow
    {
        Label KeywordLabel = new Label();
        Label IntervalLabel = new Label();
        Label FilesToLeaveLabel = new Label();
        Label SourceFolderLabel = new Label();
        Label DestinationFolderLabel = new Label();
        Label NextFileLabel = new Label();

        TextBox KeywordTextbox = new TextBox();

        public void FileCopierAdvanced()
        {
            KeywordLabel.Left = 50;
            KeywordLabel.Text = "File Name with:";
        }
    }
}
