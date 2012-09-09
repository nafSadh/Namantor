using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace FileRename
{
    enum FileRenameMethod
    {
        zero,
        regex,
        matchtext
    }
    public partial class Form1 : Form
    {
        private string[] files;
        private FileRenameMethod method;
        public Form1( )
        {
            InitializeComponent();
            files = null;
            method = FileRenameMethod.zero;
        }
        private string fileNameExtract( string fileNamePath )
        {
            return fileNamePath.Substring(
                fileNamePath.LastIndexOf('\\') + 1);
        }
        public static string GetInnerHtmltext(string data)
        {/*
            Regex objRegExp = new Regex("<(.|\n)+?>");
            string replace = objRegExp.Replace(decode, "");
            return replace.Trim("\t\r\n ".ToCharArray());*/
            return "";
        }
        private string newName( string oldname )
        {
            /*char[] chary = oldname.ToCharArray();
            int i = 0;
            while ((Char.IsDigit(chary[i]))
                || (chary[i] == ' ')
                || (chary[i] == '.')
                || (chary[i] == '-')
                || (chary[i] == '_')
                || (chary[i] == '+'))
                i++;
            //i--;
             return oldname.Substring(i);*/
            string newname="";
            switch (method)
            {
                case FileRenameMethod.matchtext:
                    {
                       newname = oldname.Replace(textBoxRule.Text, textBoxReplace.Text);
                    }break;
                case FileRenameMethod.regex:
                    {
                        Regex objRegExp = new Regex(textBoxRule.Text.Trim());
                        newname = objRegExp.Replace(oldname, textBoxReplace.Text.Trim());
                        bottomLabel.Text = textBoxRule.Text.Trim();
                    }break;
                default: break;
            }/*
            string newname = oldname.Replace("[www.DJMaza.com]", "");/*
            Regex objRegExp = new Regex("www.DJMaza.com");
            newname = objRegExp.Replace(newname, "");*/
            return newname;
            
        }
        private string nameFilter( string filepath )
        {
            string newfile;
            newfile = folderBrowserDialog1.SelectedPath + "\\" + newName(fileNameExtract(filepath));
            if (filepath != newfile) {
                try {
                    if(chkDirectory.Checked)
                    Directory.Move(filepath, newfile);
                    else File.Move(filepath, newfile);
                } catch (Exception ex) {
                    return ex.Message + "\n";
                }
                return "Renamed : " + newfile + "\n";
            }
            return "Unchanged: " + newfile + "\n";
        }

        delegate void setTextCallback( string str );

        private void addText( string str )
        {
            if (this.textBox1.InvokeRequired) {
                setTextCallback stc = new setTextCallback(addText);
                this.Invoke(stc, new object[] { str });
            } else {
                this.textBox1.AppendText(str);
            }
        }

        delegate void setLineCallback( string[] str );

        private void addLine( string[] str )
        {
            if (this.textBox1.InvokeRequired) {
                setLineCallback stc = new setLineCallback(addLine);
                this.Invoke(stc, new object[] { str });
            } else {
                this.textBox1.Lines = str;
            }
        }

        private void worker( )
        {
            addText("Found files ... " + "\n");
            addLine(files);
            addText(" " + "\n");

            addText("Filtering file names ... " + "\n");
            foreach (string filepath in files) {
                addText(nameFilter(filepath));
            }
            addText("\nDone\n");
        }
        private void setMethod()
        {
            if (radioButtonRegEx.Checked)
            {
                method = FileRenameMethod.regex;
            }
            else if (radioButtonMatchText.Checked)
            {
                method = FileRenameMethod.matchtext;
            }
            bottomLabel.Text = "Method: " + method.ToString();
        }
        private void dothejob()
        {
            setMethod();
            try {
                folderBrowserDialog1.SelectedPath = pathBox2.Text;
                if(chkDirectory.Checked)
                files = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);
                else files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                new Thread(new ThreadStart(worker)).Start();
                bottomLabel.Text = "...";
            } catch (Exception ex) {
                bottomLabel.Text = ex.Message;
            }
        }
        private void button1_Click( object sender, EventArgs e )
        {
            try {
                folderBrowserDialog1.ShowDialog();
                pathBox2.Text = folderBrowserDialog1.SelectedPath;
            } catch (Exception ex) {
                bottomLabel.Text = ex.Message;
            }
        }

        private void textFilepathEvent( object sender, EventArgs e )
        {
        }

        private void bottomLabel_Click( object sender, EventArgs e )
        {
            bottomLabel.Text = "...";
        }

        private void radioButtonRegEx_CheckedChanged(object sender, EventArgs e)
        {
            setMethod();
        }

        private void radioButtonMatchText_CheckedChanged(object sender, EventArgs e)
        {
            setMethod();
        }

        private void textBoxRule_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRule.Text == "RegEx/Match Text") textBoxRule.Text = "";  
        }

        private void textBoxReplace_TextChanged(object sender, EventArgs e)
        {
            if (textBoxReplace.Text == "ReplaceText") textBoxReplace.Text = "";       
        }

        private void textBoxReplace_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxReplace.Text == "ReplaceText") textBoxReplace.Text = "";            
        }

        private void textBoxRule_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxRule.Text == "RegEx/Match Text") textBoxRule.Text = "";    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dothejob();
        }

    }
}
