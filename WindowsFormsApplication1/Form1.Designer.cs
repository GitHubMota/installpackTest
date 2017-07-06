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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox_1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_IE = new System.Windows.Forms.Button();
            this.button_chrome = new System.Windows.Forms.Button();
            this.button_firefox = new System.Windows.Forms.Button();
            this.button_Edge = new System.Windows.Forms.Button();
            this.textBox_https = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_UserPath = new System.Windows.Forms.Button();
            this.button_StartMenu = new System.Windows.Forms.Button();
            this.button_InstalledDir = new System.Windows.Forms.Button();
            this.button_ServiceDir = new System.Windows.Forms.Button();
            this.richTextBox_UserPath = new System.Windows.Forms.RichTextBox();
            this.richTextBox_startMenu = new System.Windows.Forms.RichTextBox();
            this.richTextBox_InstalledDir = new System.Windows.Forms.RichTextBox();
            this.richTextBox_ServiceDir = new System.Windows.Forms.RichTextBox();
            this.TextBox_UserPath = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.TextBox_StartMenu = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TextBox_Installed_Path = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TextBox_ServiceDir_Path = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher4 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Note_box = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Reg = new System.Windows.Forms.RichTextBox();
            this.GroupBox_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_1
            // 
            this.GroupBox_1.Controls.Add(this.groupBox1);
            this.GroupBox_1.Controls.Add(this.textBox_https);
            this.GroupBox_1.Controls.Add(this.textBox4);
            this.GroupBox_1.Controls.Add(this.textBox_Path);
            this.GroupBox_1.Controls.Add(this.textBox2);
            this.GroupBox_1.Location = new System.Drawing.Point(24, 28);
            this.GroupBox_1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox_1.Name = "GroupBox_1";
            this.GroupBox_1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox_1.Size = new System.Drawing.Size(441, 202);
            this.GroupBox_1.TabIndex = 8;
            this.GroupBox_1.TabStop = false;
            this.GroupBox_1.Text = "Step 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_IE);
            this.groupBox1.Controls.Add(this.button_chrome);
            this.groupBox1.Controls.Add(this.button_firefox);
            this.groupBox1.Controls.Add(this.button_Edge);
            this.groupBox1.Location = new System.Drawing.Point(7, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(410, 86);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // button_IE
            // 
            this.button_IE.Location = new System.Drawing.Point(216, 21);
            this.button_IE.Margin = new System.Windows.Forms.Padding(2);
            this.button_IE.Name = "button_IE";
            this.button_IE.Size = new System.Drawing.Size(58, 38);
            this.button_IE.TabIndex = 15;
            this.button_IE.Text = "Open IE";
            this.button_IE.UseVisualStyleBackColor = true;
            this.button_IE.Click += new System.EventHandler(this.button_ie_click);
            // 
            // button_chrome
            // 
            this.button_chrome.Location = new System.Drawing.Point(36, 21);
            this.button_chrome.Margin = new System.Windows.Forms.Padding(2);
            this.button_chrome.Name = "button_chrome";
            this.button_chrome.Size = new System.Drawing.Size(58, 38);
            this.button_chrome.TabIndex = 13;
            this.button_chrome.Text = "Open Chrome";
            this.button_chrome.UseVisualStyleBackColor = true;
            this.button_chrome.Click += new System.EventHandler(this.button_chrome_click);
            // 
            // button_firefox
            // 
            this.button_firefox.Location = new System.Drawing.Point(124, 21);
            this.button_firefox.Margin = new System.Windows.Forms.Padding(2);
            this.button_firefox.Name = "button_firefox";
            this.button_firefox.Size = new System.Drawing.Size(58, 38);
            this.button_firefox.TabIndex = 14;
            this.button_firefox.Text = "Open Firefox";
            this.button_firefox.UseVisualStyleBackColor = true;
            this.button_firefox.Click += new System.EventHandler(this.button_firefox_click);
            // 
            // button_Edge
            // 
            this.button_Edge.Location = new System.Drawing.Point(310, 21);
            this.button_Edge.Margin = new System.Windows.Forms.Padding(2);
            this.button_Edge.Name = "button_Edge";
            this.button_Edge.Size = new System.Drawing.Size(58, 38);
            this.button_Edge.TabIndex = 16;
            this.button_Edge.Text = "Open Edge";
            this.button_Edge.UseVisualStyleBackColor = true;
            this.button_Edge.Click += new System.EventHandler(this.button_edge_click);
            // 
            // textBox_https
            // 
            this.textBox_https.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_https.Location = new System.Drawing.Point(43, 68);
            this.textBox_https.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_https.Name = "textBox_https";
            this.textBox_https.Size = new System.Drawing.Size(374, 21);
            this.textBox_https.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(4, 70);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(34, 14);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Url:";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(132, 13);
            this.textBox_Path.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(285, 21);
            this.textBox_Path.TabIndex = 1;
            this.textBox_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathTextBox_DragDrop);
            this.textBox_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTextBox_Dragenter);
            this.textBox_Path.DoubleClick += new System.EventHandler(this.PathTextBox_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(4, 15);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 14);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Installation Package Path：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(479, 9);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(469, 525);
            this.tabControl2.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_UserPath);
            this.tabPage3.Controls.Add(this.button_StartMenu);
            this.tabPage3.Controls.Add(this.button_InstalledDir);
            this.tabPage3.Controls.Add(this.button_ServiceDir);
            this.tabPage3.Controls.Add(this.richTextBox_UserPath);
            this.tabPage3.Controls.Add(this.richTextBox_startMenu);
            this.tabPage3.Controls.Add(this.richTextBox_InstalledDir);
            this.tabPage3.Controls.Add(this.richTextBox_ServiceDir);
            this.tabPage3.Controls.Add(this.TextBox_UserPath);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.TextBox_StartMenu);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.TextBox_Installed_Path);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.TextBox_ServiceDir_Path);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(461, 499);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_UserPath
            // 
            this.button_UserPath.Location = new System.Drawing.Point(380, 370);
            this.button_UserPath.Margin = new System.Windows.Forms.Padding(2);
            this.button_UserPath.Name = "button_UserPath";
            this.button_UserPath.Size = new System.Drawing.Size(48, 25);
            this.button_UserPath.TabIndex = 26;
            this.button_UserPath.Text = "Open";
            this.button_UserPath.UseVisualStyleBackColor = true;
            this.button_UserPath.Click += new System.EventHandler(this.button_UserPath_Click);
            // 
            // button_StartMenu
            // 
            this.button_StartMenu.Location = new System.Drawing.Point(374, 249);
            this.button_StartMenu.Margin = new System.Windows.Forms.Padding(2);
            this.button_StartMenu.Name = "button_StartMenu";
            this.button_StartMenu.Size = new System.Drawing.Size(44, 25);
            this.button_StartMenu.TabIndex = 25;
            this.button_StartMenu.Text = "Open";
            this.button_StartMenu.UseVisualStyleBackColor = true;
            this.button_StartMenu.Click += new System.EventHandler(this.button_StartMenu_Click);
            // 
            // button_InstalledDir
            // 
            this.button_InstalledDir.Location = new System.Drawing.Point(374, 130);
            this.button_InstalledDir.Margin = new System.Windows.Forms.Padding(2);
            this.button_InstalledDir.Name = "button_InstalledDir";
            this.button_InstalledDir.Size = new System.Drawing.Size(44, 25);
            this.button_InstalledDir.TabIndex = 24;
            this.button_InstalledDir.Text = "Open";
            this.button_InstalledDir.UseVisualStyleBackColor = true;
            this.button_InstalledDir.Click += new System.EventHandler(this.button_InstalledDir_Click);
            // 
            // button_ServiceDir
            // 
            this.button_ServiceDir.Location = new System.Drawing.Point(374, 8);
            this.button_ServiceDir.Margin = new System.Windows.Forms.Padding(2);
            this.button_ServiceDir.Name = "button_ServiceDir";
            this.button_ServiceDir.Size = new System.Drawing.Size(44, 25);
            this.button_ServiceDir.TabIndex = 19;
            this.button_ServiceDir.Text = "Open";
            this.button_ServiceDir.UseVisualStyleBackColor = true;
            this.button_ServiceDir.Click += new System.EventHandler(this.button_ServiceDir_Click);
            // 
            // richTextBox_UserPath
            // 
            this.richTextBox_UserPath.Location = new System.Drawing.Point(23, 412);
            this.richTextBox_UserPath.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_UserPath.Name = "richTextBox_UserPath";
            this.richTextBox_UserPath.Size = new System.Drawing.Size(324, 80);
            this.richTextBox_UserPath.TabIndex = 23;
            this.richTextBox_UserPath.Text = "";
            // 
            // richTextBox_startMenu
            // 
            this.richTextBox_startMenu.Location = new System.Drawing.Point(23, 289);
            this.richTextBox_startMenu.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_startMenu.Name = "richTextBox_startMenu";
            this.richTextBox_startMenu.Size = new System.Drawing.Size(324, 80);
            this.richTextBox_startMenu.TabIndex = 22;
            this.richTextBox_startMenu.Text = "";
            // 
            // richTextBox_InstalledDir
            // 
            this.richTextBox_InstalledDir.Location = new System.Drawing.Point(23, 165);
            this.richTextBox_InstalledDir.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_InstalledDir.Name = "richTextBox_InstalledDir";
            this.richTextBox_InstalledDir.Size = new System.Drawing.Size(324, 80);
            this.richTextBox_InstalledDir.TabIndex = 21;
            this.richTextBox_InstalledDir.Text = "";
            // 
            // richTextBox_ServiceDir
            // 
            this.richTextBox_ServiceDir.Location = new System.Drawing.Point(23, 50);
            this.richTextBox_ServiceDir.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_ServiceDir.Name = "richTextBox_ServiceDir";
            this.richTextBox_ServiceDir.Size = new System.Drawing.Size(324, 80);
            this.richTextBox_ServiceDir.TabIndex = 20;
            this.richTextBox_ServiceDir.Text = "";
            // 
            // TextBox_UserPath
            // 
            this.TextBox_UserPath.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_UserPath.Location = new System.Drawing.Point(95, 379);
            this.TextBox_UserPath.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_UserPath.Name = "TextBox_UserPath";
            this.TextBox_UserPath.Size = new System.Drawing.Size(278, 21);
            this.TextBox_UserPath.TabIndex = 18;
            this.TextBox_UserPath.TextChanged += new System.EventHandler(this.TextBox_UserPath_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(26, 384);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(68, 14);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "User Path:";
            // 
            // TextBox_StartMenu
            // 
            this.TextBox_StartMenu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_StartMenu.Location = new System.Drawing.Point(90, 257);
            this.TextBox_StartMenu.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_StartMenu.Name = "TextBox_StartMenu";
            this.TextBox_StartMenu.Size = new System.Drawing.Size(278, 21);
            this.TextBox_StartMenu.TabIndex = 16;
            this.TextBox_StartMenu.TextChanged += new System.EventHandler(this.TextBox_StartMenu_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(20, 262);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(68, 14);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Start Menu:";
            // 
            // TextBox_Installed_Path
            // 
            this.TextBox_Installed_Path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_Installed_Path.Location = new System.Drawing.Point(93, 134);
            this.TextBox_Installed_Path.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_Installed_Path.Name = "TextBox_Installed_Path";
            this.TextBox_Installed_Path.Size = new System.Drawing.Size(278, 21);
            this.TextBox_Installed_Path.TabIndex = 14;
            this.TextBox_Installed_Path.TextChanged += new System.EventHandler(this.TextBox_Installed_Path_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(23, 140);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(68, 14);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Installed Path：";
            // 
            // TextBox_ServiceDir_Path
            // 
            this.TextBox_ServiceDir_Path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_ServiceDir_Path.Location = new System.Drawing.Point(84, 16);
            this.TextBox_ServiceDir_Path.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_ServiceDir_Path.Name = "TextBox_ServiceDir_Path";
            this.TextBox_ServiceDir_Path.Size = new System.Drawing.Size(278, 21);
            this.TextBox_ServiceDir_Path.TabIndex = 13;
            this.TextBox_ServiceDir_Path.TextChanged += new System.EventHandler(this.TextBox_ServiceDir_Path_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 14);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Service Path：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox_Reg);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(461, 499);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(284, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "RegisterMonitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // fileSystemWatcher4
            // 
            this.fileSystemWatcher4.EnableRaisingEvents = true;
            this.fileSystemWatcher4.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Note_box);
            this.groupBox2.Location = new System.Drawing.Point(17, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(455, 283);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note and Comment";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 64);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_ClearNote_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_SaveNote_Click);
            // 
            // Note_box
            // 
            this.Note_box.Location = new System.Drawing.Point(4, 16);
            this.Note_box.Margin = new System.Windows.Forms.Padding(2);
            this.Note_box.Name = "Note_box";
            this.Note_box.Size = new System.Drawing.Size(365, 227);
            this.Note_box.TabIndex = 0;
            this.Note_box.Text = "";
            // 
            // richTextBox_Reg
            // 
            this.richTextBox_Reg.Location = new System.Drawing.Point(5, 12);
            this.richTextBox_Reg.Name = "richTextBox_Reg";
            this.richTextBox_Reg.Size = new System.Drawing.Size(408, 201);
            this.richTextBox_Reg.TabIndex = 3;
            this.richTextBox_Reg.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 566);
            this.Controls.Add(this.GroupBox_1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Installation Package Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_1.ResumeLayout(false);
            this.GroupBox_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.GroupBox GroupBox_1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_https;
        private System.Windows.Forms.Button button_Edge;
        private System.Windows.Forms.Button button_IE;
        private System.Windows.Forms.Button button_firefox;
        private System.Windows.Forms.Button button_chrome;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TextBox_UserPath;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox TextBox_StartMenu;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox TextBox_Installed_Path;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox TextBox_ServiceDir_Path;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox richTextBox_UserPath;
        private System.Windows.Forms.RichTextBox richTextBox_startMenu;
        private System.Windows.Forms.RichTextBox richTextBox_InstalledDir;
        private System.Windows.Forms.RichTextBox richTextBox_ServiceDir;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private System.IO.FileSystemWatcher fileSystemWatcher4;
        private System.Windows.Forms.Button button_ServiceDir;
        private System.Windows.Forms.Button button_InstalledDir;
        private System.Windows.Forms.Button button_StartMenu;
        private System.Windows.Forms.Button button_UserPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Note_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox_Reg;
    }
}


