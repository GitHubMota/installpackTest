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
            this.Registry_Watcher = new System.Windows.Forms.TabPage();
            this.button_Clear = new System.Windows.Forms.Button();
            this.comboBox_RegPath3 = new System.Windows.Forms.ComboBox();
            this.comboBox_RegPath2 = new System.Windows.Forms.ComboBox();
            this.comboBox_RegPath1 = new System.Windows.Forms.ComboBox();
            this.label_RegPath = new System.Windows.Forms.Label();
            this.textBox_RegPath3 = new System.Windows.Forms.TextBox();
            this.textBox_RegPath2 = new System.Windows.Forms.TextBox();
            this.textBox_RegPath1 = new System.Windows.Forms.TextBox();
            this.richTextBox_Reg = new System.Windows.Forms.RichTextBox();
            this.button_StopMonitor = new System.Windows.Forms.Button();
            this.button_StartMonitor = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher4 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBox_ServiceDir_Path = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TextBox_Installed_Path = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TextBox_StartMenu = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.TextBox_UserPath = new System.Windows.Forms.TextBox();
            this.richTextBox_ServiceDir = new System.Windows.Forms.RichTextBox();
            this.richTextBox_InstalledDir = new System.Windows.Forms.RichTextBox();
            this.richTextBox_startMenu = new System.Windows.Forms.RichTextBox();
            this.richTextBox_UserPath = new System.Windows.Forms.RichTextBox();
            this.button_ServiceDir = new System.Windows.Forms.Button();
            this.button_InstalledDir = new System.Windows.Forms.Button();
            this.button_StartMenu = new System.Windows.Forms.Button();
            this.button_UserPath = new System.Windows.Forms.Button();
            this.Files_Watcher = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_openInstallPkg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GroupBox_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Registry_Watcher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).BeginInit();
            this.Files_Watcher.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_1
            // 
            this.GroupBox_1.Controls.Add(this.groupBox1);
            this.GroupBox_1.Controls.Add(this.textBox_https);
            this.GroupBox_1.Controls.Add(this.textBox4);
            this.GroupBox_1.Location = new System.Drawing.Point(32, 37);
            this.GroupBox_1.Name = "GroupBox_1";
            this.GroupBox_1.Size = new System.Drawing.Size(588, 269);
            this.GroupBox_1.TabIndex = 8;
            this.GroupBox_1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_IE);
            this.groupBox1.Controls.Add(this.button_chrome);
            this.groupBox1.Controls.Add(this.button_firefox);
            this.groupBox1.Controls.Add(this.button_Edge);
            this.groupBox1.Location = new System.Drawing.Point(9, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 115);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // button_IE
            // 
            this.button_IE.Location = new System.Drawing.Point(288, 28);
            this.button_IE.Name = "button_IE";
            this.button_IE.Size = new System.Drawing.Size(77, 51);
            this.button_IE.TabIndex = 15;
            this.button_IE.Text = "Open IE";
            this.button_IE.UseVisualStyleBackColor = true;
            this.button_IE.Click += new System.EventHandler(this.button_ie_click);
            // 
            // button_chrome
            // 
            this.button_chrome.Location = new System.Drawing.Point(48, 28);
            this.button_chrome.Name = "button_chrome";
            this.button_chrome.Size = new System.Drawing.Size(77, 51);
            this.button_chrome.TabIndex = 13;
            this.button_chrome.Text = "Open Chrome";
            this.button_chrome.UseVisualStyleBackColor = true;
            this.button_chrome.Click += new System.EventHandler(this.button_chrome_click);
            // 
            // button_firefox
            // 
            this.button_firefox.Location = new System.Drawing.Point(165, 28);
            this.button_firefox.Name = "button_firefox";
            this.button_firefox.Size = new System.Drawing.Size(77, 51);
            this.button_firefox.TabIndex = 14;
            this.button_firefox.Text = "Open Firefox";
            this.button_firefox.UseVisualStyleBackColor = true;
            this.button_firefox.Click += new System.EventHandler(this.button_firefox_click);
            // 
            // button_Edge
            // 
            this.button_Edge.Location = new System.Drawing.Point(413, 28);
            this.button_Edge.Name = "button_Edge";
            this.button_Edge.Size = new System.Drawing.Size(77, 51);
            this.button_Edge.TabIndex = 16;
            this.button_Edge.Text = "Open Edge";
            this.button_Edge.UseVisualStyleBackColor = true;
            this.button_Edge.Click += new System.EventHandler(this.button_edge_click);
            // 
            // textBox_https
            // 
            this.textBox_https.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_https.Location = new System.Drawing.Point(57, 30);
            this.textBox_https.Name = "textBox_https";
            this.textBox_https.Size = new System.Drawing.Size(497, 22);
            this.textBox_https.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(5, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(45, 15);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Url:";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(37, 384);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(466, 22);
            this.textBox_Path.TabIndex = 1;
            this.textBox_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathTextBox_DragDrop);
            this.textBox_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathTextBox_Dragenter);
            this.textBox_Path.DoubleClick += new System.EventHandler(this.PathTextBox_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(32, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(185, 15);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Installation Package";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Files_Watcher);
            this.tabControl2.Controls.Add(this.Registry_Watcher);
            this.tabControl2.Location = new System.Drawing.Point(636, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(681, 700);
            this.tabControl2.TabIndex = 18;
            // 
            // Registry_Watcher
            // 
            this.Registry_Watcher.Controls.Add(this.button_Clear);
            this.Registry_Watcher.Controls.Add(this.comboBox_RegPath3);
            this.Registry_Watcher.Controls.Add(this.comboBox_RegPath2);
            this.Registry_Watcher.Controls.Add(this.comboBox_RegPath1);
            this.Registry_Watcher.Controls.Add(this.label_RegPath);
            this.Registry_Watcher.Controls.Add(this.textBox_RegPath3);
            this.Registry_Watcher.Controls.Add(this.textBox_RegPath2);
            this.Registry_Watcher.Controls.Add(this.textBox_RegPath1);
            this.Registry_Watcher.Controls.Add(this.richTextBox_Reg);
            this.Registry_Watcher.Controls.Add(this.button_StopMonitor);
            this.Registry_Watcher.Controls.Add(this.button_StartMonitor);
            this.Registry_Watcher.Location = new System.Drawing.Point(4, 25);
            this.Registry_Watcher.Name = "Registry_Watcher";
            this.Registry_Watcher.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Registry_Watcher.Size = new System.Drawing.Size(673, 671);
            this.Registry_Watcher.TabIndex = 1;
            this.Registry_Watcher.Text = "Registry Watcher";
            this.Registry_Watcher.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(289, 180);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 31);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // comboBox_RegPath3
            // 
            this.comboBox_RegPath3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RegPath3.FormattingEnabled = true;
            this.comboBox_RegPath3.Location = new System.Drawing.Point(41, 113);
            this.comboBox_RegPath3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_RegPath3.Name = "comboBox_RegPath3";
            this.comboBox_RegPath3.Size = new System.Drawing.Size(188, 24);
            this.comboBox_RegPath3.TabIndex = 6;
            // 
            // comboBox_RegPath2
            // 
            this.comboBox_RegPath2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RegPath2.FormattingEnabled = true;
            this.comboBox_RegPath2.Location = new System.Drawing.Point(41, 79);
            this.comboBox_RegPath2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_RegPath2.Name = "comboBox_RegPath2";
            this.comboBox_RegPath2.Size = new System.Drawing.Size(188, 24);
            this.comboBox_RegPath2.TabIndex = 6;
            // 
            // comboBox_RegPath1
            // 
            this.comboBox_RegPath1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RegPath1.FormattingEnabled = true;
            this.comboBox_RegPath1.Location = new System.Drawing.Point(39, 44);
            this.comboBox_RegPath1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_RegPath1.Name = "comboBox_RegPath1";
            this.comboBox_RegPath1.Size = new System.Drawing.Size(191, 24);
            this.comboBox_RegPath1.TabIndex = 6;
            // 
            // label_RegPath
            // 
            this.label_RegPath.AutoSize = true;
            this.label_RegPath.Location = new System.Drawing.Point(39, 16);
            this.label_RegPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RegPath.Name = "label_RegPath";
            this.label_RegPath.Size = new System.Drawing.Size(102, 17);
            this.label_RegPath.TabIndex = 5;
            this.label_RegPath.Text = "Register Path: ";
            // 
            // textBox_RegPath3
            // 
            this.textBox_RegPath3.Location = new System.Drawing.Point(239, 112);
            this.textBox_RegPath3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RegPath3.Name = "textBox_RegPath3";
            this.textBox_RegPath3.Size = new System.Drawing.Size(421, 22);
            this.textBox_RegPath3.TabIndex = 4;
            // 
            // textBox_RegPath2
            // 
            this.textBox_RegPath2.Location = new System.Drawing.Point(239, 77);
            this.textBox_RegPath2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RegPath2.Name = "textBox_RegPath2";
            this.textBox_RegPath2.Size = new System.Drawing.Size(421, 22);
            this.textBox_RegPath2.TabIndex = 4;
            // 
            // textBox_RegPath1
            // 
            this.textBox_RegPath1.Location = new System.Drawing.Point(239, 43);
            this.textBox_RegPath1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_RegPath1.Name = "textBox_RegPath1";
            this.textBox_RegPath1.Size = new System.Drawing.Size(424, 22);
            this.textBox_RegPath1.TabIndex = 4;
            // 
            // richTextBox_Reg
            // 
            this.richTextBox_Reg.Location = new System.Drawing.Point(39, 220);
            this.richTextBox_Reg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_Reg.Name = "richTextBox_Reg";
            this.richTextBox_Reg.Size = new System.Drawing.Size(624, 383);
            this.richTextBox_Reg.TabIndex = 3;
            this.richTextBox_Reg.Text = "";
            // 
            // button_StopMonitor
            // 
            this.button_StopMonitor.Location = new System.Drawing.Point(165, 181);
            this.button_StopMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_StopMonitor.Name = "button_StopMonitor";
            this.button_StopMonitor.Size = new System.Drawing.Size(100, 31);
            this.button_StopMonitor.TabIndex = 2;
            this.button_StopMonitor.Text = "Stop";
            this.button_StopMonitor.UseVisualStyleBackColor = true;
            this.button_StopMonitor.Click += new System.EventHandler(this.button_StopMon);
            // 
            // button_StartMonitor
            // 
            this.button_StartMonitor.Location = new System.Drawing.Point(39, 181);
            this.button_StartMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_StartMonitor.Name = "button_StartMonitor";
            this.button_StartMonitor.Size = new System.Drawing.Size(100, 31);
            this.button_StartMonitor.TabIndex = 1;
            this.button_StartMonitor.Text = "Start";
            this.button_StartMonitor.UseVisualStyleBackColor = true;
            this.button_StartMonitor.Click += new System.EventHandler(this.button_StartMon);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.IncludeSubdirectories = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            this.fileSystemWatcher2.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher2_Created);
            this.fileSystemWatcher2.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher2_Deleted);
            this.fileSystemWatcher2.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher2_Renamed);
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.IncludeSubdirectories = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            this.fileSystemWatcher3.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher3_Created);
            this.fileSystemWatcher3.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher3_Deleted);
            this.fileSystemWatcher3.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher3_Renamed);
            // 
            // fileSystemWatcher4
            // 
            this.fileSystemWatcher4.EnableRaisingEvents = true;
            this.fileSystemWatcher4.IncludeSubdirectories = true;
            this.fileSystemWatcher4.SynchronizingObject = this;
            this.fileSystemWatcher4.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher4_Created);
            this.fileSystemWatcher4.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher4_Deleted);
            this.fileSystemWatcher4.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher4_Renamed);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(31, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(91, 15);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "ServiceDir";
            // 
            // TextBox_ServiceDir_Path
            // 
            this.TextBox_ServiceDir_Path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_ServiceDir_Path.Location = new System.Drawing.Point(104, 21);
            this.TextBox_ServiceDir_Path.Name = "TextBox_ServiceDir_Path";
            this.TextBox_ServiceDir_Path.Size = new System.Drawing.Size(377, 22);
            this.TextBox_ServiceDir_Path.TabIndex = 13;
            this.TextBox_ServiceDir_Path.TextChanged += new System.EventHandler(this.TextBox_ServiceDir_Path_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(35, 182);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(91, 15);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "InstalledDir";
            // 
            // TextBox_Installed_Path
            // 
            this.TextBox_Installed_Path.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_Installed_Path.Location = new System.Drawing.Point(104, 179);
            this.TextBox_Installed_Path.Name = "TextBox_Installed_Path";
            this.TextBox_Installed_Path.Size = new System.Drawing.Size(377, 22);
            this.TextBox_Installed_Path.TabIndex = 14;
            this.TextBox_Installed_Path.TextChanged += new System.EventHandler(this.TextBox_Installed_Path_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(35, 346);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(91, 15);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "StartMenu";
            // 
            // TextBox_StartMenu
            // 
            this.TextBox_StartMenu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_StartMenu.Location = new System.Drawing.Point(104, 343);
            this.TextBox_StartMenu.Name = "TextBox_StartMenu";
            this.TextBox_StartMenu.Size = new System.Drawing.Size(377, 22);
            this.TextBox_StartMenu.TabIndex = 16;
            this.TextBox_StartMenu.TextChanged += new System.EventHandler(this.TextBox_StartMenu_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(35, 508);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(91, 15);
            this.textBox9.TabIndex = 19;
            this.textBox9.Text = "UserPath";
            // 
            // TextBox_UserPath
            // 
            this.TextBox_UserPath.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextBox_UserPath.Location = new System.Drawing.Point(104, 505);
            this.TextBox_UserPath.Name = "TextBox_UserPath";
            this.TextBox_UserPath.Size = new System.Drawing.Size(377, 22);
            this.TextBox_UserPath.TabIndex = 18;
            this.TextBox_UserPath.TextChanged += new System.EventHandler(this.TextBox_UserPath_TextChanged);
            // 
            // richTextBox_ServiceDir
            // 
            this.richTextBox_ServiceDir.Location = new System.Drawing.Point(31, 67);
            this.richTextBox_ServiceDir.Name = "richTextBox_ServiceDir";
            this.richTextBox_ServiceDir.Size = new System.Drawing.Size(450, 105);
            this.richTextBox_ServiceDir.TabIndex = 20;
            this.richTextBox_ServiceDir.Text = "";
            // 
            // richTextBox_InstalledDir
            // 
            this.richTextBox_InstalledDir.Location = new System.Drawing.Point(31, 220);
            this.richTextBox_InstalledDir.Name = "richTextBox_InstalledDir";
            this.richTextBox_InstalledDir.Size = new System.Drawing.Size(450, 105);
            this.richTextBox_InstalledDir.TabIndex = 21;
            this.richTextBox_InstalledDir.Text = "";
            // 
            // richTextBox_startMenu
            // 
            this.richTextBox_startMenu.Location = new System.Drawing.Point(31, 385);
            this.richTextBox_startMenu.Name = "richTextBox_startMenu";
            this.richTextBox_startMenu.Size = new System.Drawing.Size(450, 105);
            this.richTextBox_startMenu.TabIndex = 22;
            this.richTextBox_startMenu.Text = "";
            // 
            // richTextBox_UserPath
            // 
            this.richTextBox_UserPath.Location = new System.Drawing.Point(31, 549);
            this.richTextBox_UserPath.Name = "richTextBox_UserPath";
            this.richTextBox_UserPath.Size = new System.Drawing.Size(450, 105);
            this.richTextBox_UserPath.TabIndex = 23;
            this.richTextBox_UserPath.Text = "";
            // 
            // button_ServiceDir
            // 
            this.button_ServiceDir.Location = new System.Drawing.Point(499, 17);
            this.button_ServiceDir.Name = "button_ServiceDir";
            this.button_ServiceDir.Size = new System.Drawing.Size(59, 26);
            this.button_ServiceDir.TabIndex = 19;
            this.button_ServiceDir.Text = "Open";
            this.button_ServiceDir.UseVisualStyleBackColor = true;
            this.button_ServiceDir.Click += new System.EventHandler(this.button_ServiceDir_Click);
            // 
            // button_InstalledDir
            // 
            this.button_InstalledDir.Location = new System.Drawing.Point(499, 179);
            this.button_InstalledDir.Name = "button_InstalledDir";
            this.button_InstalledDir.Size = new System.Drawing.Size(59, 26);
            this.button_InstalledDir.TabIndex = 24;
            this.button_InstalledDir.Text = "Open";
            this.button_InstalledDir.UseVisualStyleBackColor = true;
            this.button_InstalledDir.Click += new System.EventHandler(this.button_InstalledDir_Click);
            // 
            // button_StartMenu
            // 
            this.button_StartMenu.Location = new System.Drawing.Point(499, 343);
            this.button_StartMenu.Name = "button_StartMenu";
            this.button_StartMenu.Size = new System.Drawing.Size(59, 26);
            this.button_StartMenu.TabIndex = 25;
            this.button_StartMenu.Text = "Open";
            this.button_StartMenu.UseVisualStyleBackColor = true;
            this.button_StartMenu.Click += new System.EventHandler(this.button_StartMenu_Click);
            // 
            // button_UserPath
            // 
            this.button_UserPath.Location = new System.Drawing.Point(499, 505);
            this.button_UserPath.Name = "button_UserPath";
            this.button_UserPath.Size = new System.Drawing.Size(59, 26);
            this.button_UserPath.TabIndex = 26;
            this.button_UserPath.Text = "Open";
            this.button_UserPath.UseVisualStyleBackColor = true;
            this.button_UserPath.Click += new System.EventHandler(this.button_UserPath_Click);
            // 
            // Files_Watcher
            // 
            this.Files_Watcher.Controls.Add(this.button1);
            this.Files_Watcher.Controls.Add(this.button_UserPath);
            this.Files_Watcher.Controls.Add(this.button_StartMenu);
            this.Files_Watcher.Controls.Add(this.button_InstalledDir);
            this.Files_Watcher.Controls.Add(this.button_ServiceDir);
            this.Files_Watcher.Controls.Add(this.richTextBox_UserPath);
            this.Files_Watcher.Controls.Add(this.richTextBox_startMenu);
            this.Files_Watcher.Controls.Add(this.richTextBox_InstalledDir);
            this.Files_Watcher.Controls.Add(this.richTextBox_ServiceDir);
            this.Files_Watcher.Controls.Add(this.TextBox_UserPath);
            this.Files_Watcher.Controls.Add(this.textBox9);
            this.Files_Watcher.Controls.Add(this.TextBox_StartMenu);
            this.Files_Watcher.Controls.Add(this.textBox8);
            this.Files_Watcher.Controls.Add(this.TextBox_Installed_Path);
            this.Files_Watcher.Controls.Add(this.textBox7);
            this.Files_Watcher.Controls.Add(this.TextBox_ServiceDir_Path);
            this.Files_Watcher.Controls.Add(this.textBox1);
            this.Files_Watcher.Location = new System.Drawing.Point(4, 25);
            this.Files_Watcher.Name = "Files_Watcher";
            this.Files_Watcher.Padding = new System.Windows.Forms.Padding(3);
            this.Files_Watcher.Size = new System.Drawing.Size(673, 671);
            this.Files_Watcher.TabIndex = 0;
            this.Files_Watcher.Text = "Files Watcher";
            this.Files_Watcher.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(507, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DirWatcher_Clearall_Click);
            // 
            // Button_openInstallPkg
            // 
            this.Button_openInstallPkg.Location = new System.Drawing.Point(509, 381);
            this.Button_openInstallPkg.Name = "Button_openInstallPkg";
            this.Button_openInstallPkg.Size = new System.Drawing.Size(77, 26);
            this.Button_openInstallPkg.TabIndex = 27;
            this.Button_openInstallPkg.Text = "Execute";
            this.Button_openInstallPkg.UseVisualStyleBackColor = true;
            this.Button_openInstallPkg.Click += new System.EventHandler(this.Button_openInstallPkg_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 57);
            this.button2.TabIndex = 28;
            this.button2.Text = "Control Panel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CtlPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button_openInstallPkg);
            this.Controls.Add(this.GroupBox_1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Instl. PKG TestHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_1.ResumeLayout(false);
            this.GroupBox_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Registry_Watcher.ResumeLayout(false);
            this.Registry_Watcher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).EndInit();
            this.Files_Watcher.ResumeLayout(false);
            this.Files_Watcher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage Registry_Watcher;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private System.IO.FileSystemWatcher fileSystemWatcher4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_StopMonitor;
        private System.Windows.Forms.Button button_StartMonitor;
        private System.Windows.Forms.RichTextBox richTextBox_Reg;
        private System.Windows.Forms.Label label_RegPath;
        private System.Windows.Forms.TextBox textBox_RegPath1;
        private System.Windows.Forms.ComboBox comboBox_RegPath1;
        private System.Windows.Forms.TextBox textBox_RegPath3;
        private System.Windows.Forms.TextBox textBox_RegPath2;
        private System.Windows.Forms.ComboBox comboBox_RegPath3;
        private System.Windows.Forms.ComboBox comboBox_RegPath2;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TabPage Files_Watcher;
        private System.Windows.Forms.Button button_UserPath;
        private System.Windows.Forms.Button button_StartMenu;
        private System.Windows.Forms.Button button_InstalledDir;
        private System.Windows.Forms.Button button_ServiceDir;
        private System.Windows.Forms.RichTextBox richTextBox_UserPath;
        private System.Windows.Forms.RichTextBox richTextBox_startMenu;
        private System.Windows.Forms.RichTextBox richTextBox_InstalledDir;
        private System.Windows.Forms.RichTextBox richTextBox_ServiceDir;
        private System.Windows.Forms.TextBox TextBox_UserPath;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox TextBox_StartMenu;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox TextBox_Installed_Path;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox TextBox_ServiceDir_Path;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_openInstallPkg;
        private System.Windows.Forms.Button button2;
    }
}


