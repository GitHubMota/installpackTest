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
            this.checkBox_edge = new System.Windows.Forms.CheckBox();
            this.checkBox_ie = new System.Windows.Forms.CheckBox();
            this.textBox_http = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox_https = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox_Firefox = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox_Chrome = new System.Windows.Forms.CheckBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBox_ServiceDir_Path = new System.Windows.Forms.TextBox();
            this.TextBox_Installed_Path = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TextBox_StartMenu = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TextBox_UserPath = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.richTextBox_ServiceDir = new System.Windows.Forms.RichTextBox();
            this.richTextBox_InstalledDir = new System.Windows.Forms.RichTextBox();
            this.richTextBox_startMenu = new System.Windows.Forms.RichTextBox();
            this.richTextBox_UserPath = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher4 = new System.IO.FileSystemWatcher();
            this.button_ServiceDir = new System.Windows.Forms.Button();
            this.button_InstalledDir = new System.Windows.Forms.Button();
            this.button_StartMenu = new System.Windows.Forms.Button();
            this.button_UserPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Note_box = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GroupBox_1.SuspendLayout();
            this.GroupBox_2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_1
            // 
            this.GroupBox_1.Controls.Add(this.checkBox_edge);
            this.GroupBox_1.Controls.Add(this.checkBox_ie);
            this.GroupBox_1.Controls.Add(this.textBox_http);
            this.GroupBox_1.Controls.Add(this.textBox6);
            this.GroupBox_1.Controls.Add(this.textBox_https);
            this.GroupBox_1.Controls.Add(this.textBox4);
            this.GroupBox_1.Controls.Add(this.checkBox_Firefox);
            this.GroupBox_1.Controls.Add(this.textBox3);
            this.GroupBox_1.Controls.Add(this.checkBox_Chrome);
            this.GroupBox_1.Controls.Add(this.textBox_Path);
            this.GroupBox_1.Controls.Add(this.textBox2);
            this.GroupBox_1.Location = new System.Drawing.Point(6, 22);
            this.GroupBox_1.Name = "GroupBox_1";
            this.GroupBox_1.Size = new System.Drawing.Size(511, 331);
            this.GroupBox_1.TabIndex = 8;
            this.GroupBox_1.TabStop = false;
            this.GroupBox_1.Text = "Step 1";
            this.GroupBox_1.VisibleChanged += new System.EventHandler(this.Goupbox1_VisibleChanged);
            // 
            // checkBox_edge
            // 
            this.checkBox_edge.AutoSize = true;
            this.checkBox_edge.Location = new System.Drawing.Point(255, 165);
            this.checkBox_edge.Name = "checkBox_edge";
            this.checkBox_edge.Size = new System.Drawing.Size(63, 21);
            this.checkBox_edge.TabIndex = 12;
            this.checkBox_edge.Text = "Edge";
            this.checkBox_edge.UseVisualStyleBackColor = true;
            // 
            // checkBox_ie
            // 
            this.checkBox_ie.AutoSize = true;
            this.checkBox_ie.Location = new System.Drawing.Point(192, 165);
            this.checkBox_ie.Name = "checkBox_ie";
            this.checkBox_ie.Size = new System.Drawing.Size(42, 21);
            this.checkBox_ie.TabIndex = 11;
            this.checkBox_ie.Text = "IE";
            this.checkBox_ie.UseVisualStyleBackColor = true;
            // 
            // textBox_http
            // 
            this.textBox_http.Location = new System.Drawing.Point(57, 116);
            this.textBox_http.Name = "textBox_http";
            this.textBox_http.Size = new System.Drawing.Size(369, 22);
            this.textBox_http.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(5, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(46, 15);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Http:";
            // 
            // textBox_https
            // 
            this.textBox_https.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_https.Location = new System.Drawing.Point(57, 91);
            this.textBox_https.Name = "textBox_https";
            this.textBox_https.Size = new System.Drawing.Size(369, 22);
            this.textBox_https.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(5, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(46, 15);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Https:";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBox_Firefox
            // 
            this.checkBox_Firefox.AutoSize = true;
            this.checkBox_Firefox.Location = new System.Drawing.Point(102, 165);
            this.checkBox_Firefox.Name = "checkBox_Firefox";
            this.checkBox_Firefox.Size = new System.Drawing.Size(72, 21);
            this.checkBox_Firefox.TabIndex = 6;
            this.checkBox_Firefox.Text = "Firefox";
            this.checkBox_Firefox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(242, 15);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Select browser explorer(s) to use:";
            // 
            // checkBox_Chrome
            // 
            this.checkBox_Chrome.AutoSize = true;
            this.checkBox_Chrome.Location = new System.Drawing.Point(6, 165);
            this.checkBox_Chrome.Name = "checkBox_Chrome";
            this.checkBox_Chrome.Size = new System.Drawing.Size(79, 21);
            this.checkBox_Chrome.TabIndex = 4;
            this.checkBox_Chrome.Text = "Chrome";
            this.checkBox_Chrome.UseVisualStyleBackColor = true;
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(176, 17);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(250, 22);
            this.textBox_Path.TabIndex = 1;
            this.textBox_Path.TextChanged += new System.EventHandler(this.textBox_Path_TextChanged);
            this.textBox_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathTextBox_DragDrop);
            this.textBox_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTextBox_Dragenter);
            this.textBox_Path.DoubleClick += new System.EventHandler(this.PathTextBox_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(5, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 15);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Installation Package Path：";
            // 
            // button_Edge
            // 
            this.button_Edge.Location = new System.Drawing.Point(413, 28);
            this.button_Edge.Name = "button_Edge";
            this.button_Edge.Size = new System.Drawing.Size(78, 50);
            this.button_Edge.TabIndex = 16;
            this.button_Edge.Text = "Open Edge";
            this.button_Edge.UseVisualStyleBackColor = true;
            this.button_Edge.Click += new System.EventHandler(this.button_edge_click);
            // 
            // button_IE
            // 
            this.button_IE.Location = new System.Drawing.Point(288, 28);
            this.button_IE.Name = "button_IE";
            this.button_IE.Size = new System.Drawing.Size(78, 50);
            this.button_IE.TabIndex = 15;
            this.button_IE.Text = "Open IE";
            this.button_IE.UseVisualStyleBackColor = true;
            this.button_IE.Click += new System.EventHandler(this.button_ie_click);
            // 
            // button_firefox
            // 
            this.button_firefox.Location = new System.Drawing.Point(165, 28);
            this.button_firefox.Name = "button_firefox";
            this.button_firefox.Size = new System.Drawing.Size(78, 50);
            this.button_firefox.TabIndex = 14;
            this.button_firefox.Text = "Open Firefox";
            this.button_firefox.UseVisualStyleBackColor = true;
            this.button_firefox.Click += new System.EventHandler(this.button_firefox_click);
            // 
            // button_chrome
            // 
            this.button_chrome.Location = new System.Drawing.Point(48, 28);
            this.button_chrome.Name = "button_chrome";
            this.button_chrome.Size = new System.Drawing.Size(78, 50);
            this.button_chrome.TabIndex = 13;
            this.button_chrome.Text = "Open Chrome";
            this.button_chrome.UseVisualStyleBackColor = true;
            this.button_chrome.Click += new System.EventHandler(this.button_chrome_click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(432, 465);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(85, 33);
            this.button_Next.TabIndex = 9;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // GroupBox_2
            // 
            this.GroupBox_2.Controls.Add(this.button4);
            this.GroupBox_2.Location = new System.Drawing.Point(12, 11);
            this.GroupBox_2.Name = "GroupBox_2";
            this.GroupBox_2.Size = new System.Drawing.Size(535, 364);
            this.GroupBox_2.TabIndex = 10;
            this.GroupBox_2.TabStop = false;
            this.GroupBox_2.Text = "Step 2 Env Clear";
            this.GroupBox_2.Visible = false;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(339, 465);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 33);
            this.button_back.TabIndex = 11;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Skip";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(10, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(567, 452);
            this.tabControl.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GroupBox_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GroupBox_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(639, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(625, 700);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(617, 671);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 71);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(27, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(90, 15);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Service Path：";
            // 
            // TextBox_ServiceDir_Path
            // 
            this.TextBox_ServiceDir_Path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_ServiceDir_Path.Location = new System.Drawing.Point(112, 22);
            this.TextBox_ServiceDir_Path.Name = "TextBox_ServiceDir_Path";
            this.TextBox_ServiceDir_Path.Size = new System.Drawing.Size(369, 22);
            this.TextBox_ServiceDir_Path.TabIndex = 13;
            this.TextBox_ServiceDir_Path.TextChanged += new System.EventHandler(this.TextBox_ServiceDir_Path_TextChanged);
            // 
            // TextBox_Installed_Path
            // 
            this.TextBox_Installed_Path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_Installed_Path.Location = new System.Drawing.Point(124, 179);
            this.TextBox_Installed_Path.Name = "TextBox_Installed_Path";
            this.TextBox_Installed_Path.Size = new System.Drawing.Size(369, 22);
            this.TextBox_Installed_Path.TabIndex = 14;
            this.TextBox_Installed_Path.TextChanged += new System.EventHandler(this.TextBox_Installed_Path_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(31, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(90, 15);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Installed Path：";
            // 
            // TextBox_StartMenu
            // 
            this.TextBox_StartMenu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_StartMenu.Location = new System.Drawing.Point(120, 343);
            this.TextBox_StartMenu.Name = "TextBox_StartMenu";
            this.TextBox_StartMenu.Size = new System.Drawing.Size(369, 22);
            this.TextBox_StartMenu.TabIndex = 16;
            this.TextBox_StartMenu.TextChanged += new System.EventHandler(this.TextBox_StartMenu_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(27, 350);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(90, 15);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Start Menu:";
            // 
            // TextBox_UserPath
            // 
            this.TextBox_UserPath.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_UserPath.Location = new System.Drawing.Point(127, 505);
            this.TextBox_UserPath.Name = "TextBox_UserPath";
            this.TextBox_UserPath.Size = new System.Drawing.Size(369, 22);
            this.TextBox_UserPath.TabIndex = 18;
            this.TextBox_UserPath.TextChanged += new System.EventHandler(this.TextBox_UserPath_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(34, 512);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(90, 15);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "User Path:";
            // 
            // richTextBox_ServiceDir
            // 
            this.richTextBox_ServiceDir.Location = new System.Drawing.Point(31, 66);
            this.richTextBox_ServiceDir.Name = "richTextBox_ServiceDir";
            this.richTextBox_ServiceDir.Size = new System.Drawing.Size(430, 105);
            this.richTextBox_ServiceDir.TabIndex = 20;
            this.richTextBox_ServiceDir.Text = "";
            // 
            // richTextBox_InstalledDir
            // 
            this.richTextBox_InstalledDir.Location = new System.Drawing.Point(31, 220);
            this.richTextBox_InstalledDir.Name = "richTextBox_InstalledDir";
            this.richTextBox_InstalledDir.Size = new System.Drawing.Size(430, 105);
            this.richTextBox_InstalledDir.TabIndex = 21;
            this.richTextBox_InstalledDir.Text = "";
            // 
            // richTextBox_startMenu
            // 
            this.richTextBox_startMenu.Location = new System.Drawing.Point(31, 385);
            this.richTextBox_startMenu.Name = "richTextBox_startMenu";
            this.richTextBox_startMenu.Size = new System.Drawing.Size(430, 105);
            this.richTextBox_startMenu.TabIndex = 22;
            this.richTextBox_startMenu.Text = "";
            // 
            // richTextBox_UserPath
            // 
            this.richTextBox_UserPath.Location = new System.Drawing.Point(31, 549);
            this.richTextBox_UserPath.Name = "richTextBox_UserPath";
            this.richTextBox_UserPath.Size = new System.Drawing.Size(430, 105);
            this.richTextBox_UserPath.TabIndex = 23;
            this.richTextBox_UserPath.Text = "";
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
            // button_ServiceDir
            // 
            this.button_ServiceDir.Location = new System.Drawing.Point(499, 11);
            this.button_ServiceDir.Name = "button_ServiceDir";
            this.button_ServiceDir.Size = new System.Drawing.Size(59, 33);
            this.button_ServiceDir.TabIndex = 19;
            this.button_ServiceDir.Text = "Open";
            this.button_ServiceDir.UseVisualStyleBackColor = true;
            this.button_ServiceDir.Click += new System.EventHandler(this.button_ServiceDir_Click);
            // 
            // button_InstalledDir
            // 
            this.button_InstalledDir.Location = new System.Drawing.Point(499, 174);
            this.button_InstalledDir.Name = "button_InstalledDir";
            this.button_InstalledDir.Size = new System.Drawing.Size(59, 33);
            this.button_InstalledDir.TabIndex = 24;
            this.button_InstalledDir.Text = "Open";
            this.button_InstalledDir.UseVisualStyleBackColor = true;
            this.button_InstalledDir.Click += new System.EventHandler(this.button_InstalledDir_Click);
            // 
            // button_StartMenu
            // 
            this.button_StartMenu.Location = new System.Drawing.Point(499, 332);
            this.button_StartMenu.Name = "button_StartMenu";
            this.button_StartMenu.Size = new System.Drawing.Size(59, 33);
            this.button_StartMenu.TabIndex = 25;
            this.button_StartMenu.Text = "Open";
            this.button_StartMenu.UseVisualStyleBackColor = true;
            this.button_StartMenu.Click += new System.EventHandler(this.button_StartMenu_Click);
            // 
            // button_UserPath
            // 
            this.button_UserPath.Location = new System.Drawing.Point(506, 494);
            this.button_UserPath.Name = "button_UserPath";
            this.button_UserPath.Size = new System.Drawing.Size(64, 33);
            this.button_UserPath.TabIndex = 26;
            this.button_UserPath.Text = "Open";
            this.button_UserPath.UseVisualStyleBackColor = true;
            this.button_UserPath.Click += new System.EventHandler(this.button_UserPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_IE);
            this.groupBox1.Controls.Add(this.button_chrome);
            this.groupBox1.Controls.Add(this.button_firefox);
            this.groupBox1.Controls.Add(this.button_Edge);
            this.groupBox1.Location = new System.Drawing.Point(26, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 115);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Note_box);
            this.groupBox2.Location = new System.Drawing.Point(26, 625);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 199);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note and Comment";
            // 
            // Note_box
            // 
            this.Note_box.Location = new System.Drawing.Point(6, 21);
            this.Note_box.Name = "Note_box";
            this.Note_box.Size = new System.Drawing.Size(485, 134);
            this.Note_box.TabIndex = 0;
            this.Note_box.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_SaveNote_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_ClearNote_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Install";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 862);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Installation Package Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_1.ResumeLayout(false);
            this.GroupBox_1.PerformLayout();
            this.GroupBox_2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.GroupBox GroupBox_2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
        private System.Windows.Forms.CheckBox checkBox_edge;
        private System.Windows.Forms.CheckBox checkBox_ie;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button button4;
    }
}


