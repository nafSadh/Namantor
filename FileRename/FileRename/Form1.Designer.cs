namespace FileRename
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pathBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bottomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRegEx = new System.Windows.Forms.RadioButton();
            this.radioButtonMatchText = new System.Windows.Forms.RadioButton();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxRule = new System.Windows.Forms.TextBox();
            this.chkDirectory = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(751, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(12, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(807, 330);
            this.textBox1.TabIndex = 1;
            // 
            // pathBox2
            // 
            this.pathBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pathBox2.Location = new System.Drawing.Point(52, 0);
            this.pathBox2.Name = "pathBox2";
            this.pathBox2.Size = new System.Drawing.Size(693, 26);
            this.pathBox2.TabIndex = 2;
            this.pathBox2.Click += new System.EventHandler(this.textFilepathEvent);
            this.pathBox2.TextChanged += new System.EventHandler(this.textFilepathEvent);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bottomLabel
            // 
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(16, 17);
            this.bottomLabel.Text = "...";
            this.bottomLabel.Click += new System.EventHandler(this.bottomLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path";
            // 
            // radioButtonRegEx
            // 
            this.radioButtonRegEx.AutoSize = true;
            this.radioButtonRegEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRegEx.Location = new System.Drawing.Point(6, 9);
            this.radioButtonRegEx.Name = "radioButtonRegEx";
            this.radioButtonRegEx.Size = new System.Drawing.Size(62, 19);
            this.radioButtonRegEx.TabIndex = 6;
            this.radioButtonRegEx.Text = "RegEx";
            this.radioButtonRegEx.UseVisualStyleBackColor = true;
            this.radioButtonRegEx.CheckedChanged += new System.EventHandler(this.radioButtonRegEx_CheckedChanged);
            // 
            // radioButtonMatchText
            // 
            this.radioButtonMatchText.AutoSize = true;
            this.radioButtonMatchText.Checked = true;
            this.radioButtonMatchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMatchText.Location = new System.Drawing.Point(6, 25);
            this.radioButtonMatchText.Name = "radioButtonMatchText";
            this.radioButtonMatchText.Size = new System.Drawing.Size(85, 19);
            this.radioButtonMatchText.TabIndex = 7;
            this.radioButtonMatchText.TabStop = true;
            this.radioButtonMatchText.Text = "Match Text";
            this.radioButtonMatchText.UseVisualStyleBackColor = true;
            this.radioButtonMatchText.CheckedChanged += new System.EventHandler(this.radioButtonMatchText_CheckedChanged);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(418, 10);
            this.textBoxReplace.Multiline = true;
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(315, 34);
            this.textBoxReplace.TabIndex = 9;
            this.textBoxReplace.Text = "ReplaceText";
            this.textBoxReplace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxReplace_MouseClick);
            this.textBoxReplace.DoubleClick += new System.EventHandler(this.textBoxReplace_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxRule);
            this.groupBox1.Controls.Add(this.radioButtonRegEx);
            this.groupBox1.Controls.Add(this.textBoxReplace);
            this.groupBox1.Controls.Add(this.radioButtonMatchText);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 49);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxRule
            // 
            this.textBoxRule.Location = new System.Drawing.Point(103, 11);
            this.textBoxRule.Multiline = true;
            this.textBoxRule.Name = "textBoxRule";
            this.textBoxRule.Size = new System.Drawing.Size(309, 33);
            this.textBoxRule.TabIndex = 8;
            this.textBoxRule.Text = "RegEx/Match Text";
            this.textBoxRule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRule_MouseClick);
            this.textBoxRule.DoubleClick += new System.EventHandler(this.textBoxRule_TextChanged);
            // 
            // chkDirectory
            // 
            this.chkDirectory.AutoSize = true;
            this.chkDirectory.Location = new System.Drawing.Point(18, 32);
            this.chkDirectory.Name = "chkDirectory";
            this.chkDirectory.Size = new System.Drawing.Size(68, 17);
            this.chkDirectory.TabIndex = 11;
            this.chkDirectory.Text = "Directory";
            this.chkDirectory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 458);
            this.Controls.Add(this.chkDirectory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Filename Distiller";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pathBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel bottomLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRegEx;
        private System.Windows.Forms.RadioButton radioButtonMatchText;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkDirectory;
    }
}

