namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader NO;
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Certificate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Copyright = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.GroupBox_1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_http = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox_https = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox_Firefox = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox_Chrome = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox_OS = new System.Windows.Forms.ComboBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Edge = new System.Windows.Forms.Button();
            this.button_IE = new System.Windows.Forms.Button();
            this.button_firefox = new System.Windows.Forms.Button();
            this.button_chrome = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.GroupBox_2 = new System.Windows.Forms.GroupBox();
            this.button_back = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NO
            // 
            NO.Text = "NO";
            NO.Width = 32;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(762, 46);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(83, 21);
            this.buttonOpenFolder.TabIndex = 0;
            this.buttonOpenFolder.Text = "Open folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(851, 46);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(83, 21);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // listViewOutput
            // 
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            NO,
            this.file,
            this.Certificate,
            this.TimeStamp,
            this.Copyright,
            this.FileVersion});
            this.listViewOutput.FullRowSelect = true;
            this.listViewOutput.GridLines = true;
            this.listViewOutput.Location = new System.Drawing.Point(656, 365);
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.Size = new System.Drawing.Size(261, 168);
            this.listViewOutput.TabIndex = 4;
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
            this.listViewOutput.SelectedIndexChanged += new System.EventHandler(this.listViewOutput_SelectedIndexChanged);
            // 
            // file
            // 
            this.file.Text = "File";
            this.file.Width = 100;
            // 
            // Certificate
            // 
            this.Certificate.Text = "(No.) Cert.";
            this.Certificate.Width = 218;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Text = "TimeStamp";
            this.TimeStamp.Width = 250;
            // 
            // Copyright
            // 
            this.Copyright.Text = "Copyright";
            this.Copyright.Width = 160;
            // 
            // FileVersion
            // 
            this.FileVersion.Text = "FileVersion";
            this.FileVersion.Width = 102;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(936, 153);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(44, 29);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(936, 96);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(44, 29);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.Button_Clear);
            // 
            // GroupBox_1
            // 
            this.GroupBox_1.Controls.Add(this.checkBox2);
            this.GroupBox_1.Controls.Add(this.checkBox1);
            this.GroupBox_1.Controls.Add(this.textBox_http);
            this.GroupBox_1.Controls.Add(this.textBox6);
            this.GroupBox_1.Controls.Add(this.textBox_https);
            this.GroupBox_1.Controls.Add(this.textBox4);
            this.GroupBox_1.Controls.Add(this.checkBox_Firefox);
            this.GroupBox_1.Controls.Add(this.textBox3);
            this.GroupBox_1.Controls.Add(this.checkBox_Chrome);
            this.GroupBox_1.Controls.Add(this.textBox1);
            this.GroupBox_1.Controls.Add(this.comboBox_OS);
            this.GroupBox_1.Controls.Add(this.textBox_Path);
            this.GroupBox_1.Controls.Add(this.textBox2);
            this.GroupBox_1.Location = new System.Drawing.Point(5, 2);
            this.GroupBox_1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_1.Name = "GroupBox_1";
            this.GroupBox_1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_1.Size = new System.Drawing.Size(350, 248);
            this.GroupBox_1.TabIndex = 8;
            this.GroupBox_1.TabStop = false;
            this.GroupBox_1.Text = "Step 1";
            this.GroupBox_1.VisibleChanged += new System.EventHandler(this.Goupbox1_VisibleChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(191, 124);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Edge";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 124);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "IE";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_http
            // 
            this.textBox_http.Location = new System.Drawing.Point(43, 87);
            this.textBox_http.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_http.Name = "textBox_http";
            this.textBox_http.Size = new System.Drawing.Size(278, 21);
            this.textBox_http.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(4, 89);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(34, 14);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Http:";
            // 
            // textBox_https
            // 
            this.textBox_https.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_https.Location = new System.Drawing.Point(43, 68);
            this.textBox_https.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_https.Name = "textBox_https";
            this.textBox_https.Size = new System.Drawing.Size(278, 21);
            this.textBox_https.TabIndex = 8;
            this.textBox_https.TextChanged += new System.EventHandler(this.textBox_https_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(4, 70);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(34, 14);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Https:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox_Firefox
            // 
            this.checkBox_Firefox.AutoSize = true;
            this.checkBox_Firefox.Location = new System.Drawing.Point(76, 124);
            this.checkBox_Firefox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Firefox.Name = "checkBox_Firefox";
            this.checkBox_Firefox.Size = new System.Drawing.Size(66, 16);
            this.checkBox_Firefox.TabIndex = 6;
            this.checkBox_Firefox.Text = "Firefox";
            this.checkBox_Firefox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(4, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(220, 14);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Select browser explorer(s) to use:";
            // 
            // checkBox_Chrome
            // 
            this.checkBox_Chrome.AutoSize = true;
            this.checkBox_Chrome.Location = new System.Drawing.Point(4, 124);
            this.checkBox_Chrome.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Chrome.Name = "checkBox_Chrome";
            this.checkBox_Chrome.Size = new System.Drawing.Size(60, 16);
            this.checkBox_Chrome.TabIndex = 4;
            this.checkBox_Chrome.Text = "Chrome";
            this.checkBox_Chrome.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(4, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 14);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select Win OS:";
            // 
            // comboBox_OS
            // 
            this.comboBox_OS.FormattingEnabled = true;
            this.comboBox_OS.Location = new System.Drawing.Point(132, 40);
            this.comboBox_OS.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_OS.Name = "comboBox_OS";
            this.comboBox_OS.Size = new System.Drawing.Size(92, 20);
            this.comboBox_OS.TabIndex = 2;
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(132, 13);
            this.textBox_Path.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(188, 21);
            this.textBox_Path.TabIndex = 1;
            this.textBox_Path.TextChanged += new System.EventHandler(this.textBox_Path_TextChanged);
            this.textBox_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathTextBox_DragDrop);
            this.textBox_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTextBox_Dragenter);
            this.textBox_Path.DoubleClick += new System.EventHandler(this.PathTextBox_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(4, 15);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 14);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Installation Package Path：";
            // 
            // button_Edge
            // 
            this.button_Edge.Location = new System.Drawing.Point(307, 418);
            this.button_Edge.Margin = new System.Windows.Forms.Padding(2);
            this.button_Edge.Name = "button_Edge";
            this.button_Edge.Size = new System.Drawing.Size(58, 38);
            this.button_Edge.TabIndex = 16;
            this.button_Edge.Text = "Open Edge";
            this.button_Edge.UseVisualStyleBackColor = true;
            this.button_Edge.Click += new System.EventHandler(this.button_edge_click);
            // 
            // button_IE
            // 
            this.button_IE.Location = new System.Drawing.Point(213, 418);
            this.button_IE.Margin = new System.Windows.Forms.Padding(2);
            this.button_IE.Name = "button_IE";
            this.button_IE.Size = new System.Drawing.Size(58, 38);
            this.button_IE.TabIndex = 15;
            this.button_IE.Text = "Open IE";
            this.button_IE.UseVisualStyleBackColor = true;
            this.button_IE.Click += new System.EventHandler(this.button_ie_click);
            // 
            // button_firefox
            // 
            this.button_firefox.Location = new System.Drawing.Point(121, 418);
            this.button_firefox.Margin = new System.Windows.Forms.Padding(2);
            this.button_firefox.Name = "button_firefox";
            this.button_firefox.Size = new System.Drawing.Size(58, 38);
            this.button_firefox.TabIndex = 14;
            this.button_firefox.Text = "Open Firefox";
            this.button_firefox.UseVisualStyleBackColor = true;
            this.button_firefox.Click += new System.EventHandler(this.button_firefox_click);
            // 
            // button_chrome
            // 
            this.button_chrome.Location = new System.Drawing.Point(33, 418);
            this.button_chrome.Margin = new System.Windows.Forms.Padding(2);
            this.button_chrome.Name = "button_chrome";
            this.button_chrome.Size = new System.Drawing.Size(58, 38);
            this.button_chrome.TabIndex = 13;
            this.button_chrome.Text = "Open Chrome";
            this.button_chrome.UseVisualStyleBackColor = true;
            this.button_chrome.Click += new System.EventHandler(this.button_chrome_click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(324, 345);
            this.button_Next.Margin = new System.Windows.Forms.Padding(2);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(71, 28);
            this.button_Next.TabIndex = 9;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // GroupBox_2
            // 
            this.GroupBox_2.Location = new System.Drawing.Point(501, 349);
            this.GroupBox_2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_2.Name = "GroupBox_2";
            this.GroupBox_2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_2.Size = new System.Drawing.Size(371, 214);
            this.GroupBox_2.TabIndex = 10;
            this.GroupBox_2.TabStop = false;
            this.GroupBox_2.Text = "Step 2 Env Clear";
            this.GroupBox_2.Visible = false;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(254, 349);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(56, 25);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dirTextBox
            // 
            this.dirTextBox.AllowDrop = true;
            this.dirTextBox.Location = new System.Drawing.Point(146, 47);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(611, 21);
            this.dirTextBox.TabIndex = 1;
            this.dirTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dirTextBox_DragDrop);
            this.dirTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dirTextBox_Dragenter);
            this.dirTextBox.DoubleClick += new System.EventHandler(this.dirTextBox_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Skip";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.Path = "C:\\Windows\\System32\\Dynamsoft";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(525, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 138);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(270, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 267);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupBox_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 564);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_Edge);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_IE);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_firefox);
            this.Controls.Add(this.GroupBox_2);
            this.Controls.Add(this.button_chrome);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listViewOutput);
            this.Controls.Add(this.dirTextBox);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonOpenFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Installation Package Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_1.ResumeLayout(false);
            this.GroupBox_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader Certificate;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader FileVersion;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColumnHeader Copyright;
        private System.Windows.Forms.ColumnHeader TimeStamp;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox GroupBox_1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.GroupBox GroupBox_2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.ComboBox comboBox_OS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox_Firefox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox_Chrome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_http;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_https;
        private System.Windows.Forms.Button button_Edge;
        private System.Windows.Forms.Button button_IE;
        private System.Windows.Forms.Button button_firefox;
        private System.Windows.Forms.Button button_chrome;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}


