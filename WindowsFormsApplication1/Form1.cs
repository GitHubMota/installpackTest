using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//self
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        string ReportFolder = null;
        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists("C:\\Windows\\SysWOW64"))
                TextBox_ServiceDir_Path.Text = "C:\\Windows\\SysWOW64";
            else
                TextBox_ServiceDir_Path.Text = "C:\\Windows\\system32";

            if (Directory.Exists("C:\\Program Files (x86)"))
            {
                TextBox_Installed_Path.Text = "C:\\Program Files (x86)";
            }
            else
            {
                TextBox_Installed_Path.Text = "C:\\Program Files";
            }
            TextBox_StartMenu.Text="C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs";
            string a = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            var Currentuser = a.Substring(a.LastIndexOf("\\") + 1);
            TextBox_UserPath.Text = "C:\\Users\\" + Currentuser + "\\AppData\\Roaming";



            //register monitor
            Microsoft.Win32.RegistryKey _Key = Microsoft.Win32.Registry.CurrentUser;
            //_Key = _Key.OpenSubKey("SoftWare");
            //_Key = _Key.OpenSubKey("Microsoft");
            //_Key = _Key.OpenSubKey("Windows");
            //_Key = _Key.OpenSubKey("CurrentVersion");
            //_Key = _Key.OpenSubKey("Test");
            _Key = _Key.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Test");
            MonitorWindowsReg T;
            MonitorWindowsReg T2;

            T = new MonitorWindowsReg(_Key);
            T.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
            T.Star();
            Microsoft.Win32.RegistryKey _Key2 = Microsoft.Win32.Registry.CurrentUser;
            _Key2 = _Key2.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Test\\22");
            T2 = new MonitorWindowsReg(_Key2);
            T2.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
            T2.Star();

        }
        public void CreateMonitor(MonitorWindowsReg T, RegistryKey key)
        {
            T = new MonitorWindowsReg(key);
            T.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
        }

        //step1 记下测试环境，操作系统，x86/x64, browser

        public string HKLM_GetString(string path, string key)
        {

            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(path);
                if (rk == null) return "";
                return (string)rk.GetValue(key);
            }
            catch { return ""; }
        }
        public string FriendlyName()
        {
            string ProductName = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
            string CSDVersion = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion");
            if (ProductName != "")
            {
                return (ProductName.StartsWith("Microsoft") ? "" : "Microsoft ") + ProductName +
                            (CSDVersion != "" ? " " + CSDVersion : "");
            }
            return "";
        }
        //########################## General ######################################
        private void Form1_Load(object sender, EventArgs e)
        {
            int osbit = 86;
            string step1_report =   "c:\\note.rtf";
            if (Directory.Exists("C:/Windows/SysWOW64"))
                osbit = 64;
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(step1_report, false);
                sw.WriteLine("Environment info:" + FriendlyName() + "x" + osbit);                
                sw.Close();
            }
            catch { }

        }

       
        //############## directory watcher###################################################
        //service directory
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            richTextBox_ServiceDir.AppendText(e.Name + "--------" + e.ChangeType + "\n");

        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            richTextBox_ServiceDir.AppendText(e.Name + "--------" + e.ChangeType + "\n");
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            richTextBox_ServiceDir.AppendText(e.OldName + "----Renamed to----" + e.Name + "\n");
        }
        //installed path
        private void fileSystemWatcher2_Created(object sender, FileSystemEventArgs e)
        {
            richTextBox_InstalledDir.AppendText(e.Name + "--------" + e.ChangeType + "\n");

        }

        private void fileSystemWatcher2_Deleted(object sender, FileSystemEventArgs e)
        {
            richTextBox_InstalledDir.AppendText(e.Name + "--------" + e.ChangeType + "\n");
        }

        private void fileSystemWatcher2_Renamed(object sender, RenamedEventArgs e)
        {
            richTextBox_InstalledDir.AppendText(e.OldName + "----Renamed to----" + e.Name + "\n");
        }

        //start menu
        private void fileSystemWatcher3_Created(object sender, FileSystemEventArgs e)
        {
            richTextBox_startMenu.AppendText(e.Name + "--------" + e.ChangeType + "\n");

        }

        private void fileSystemWatcher3_Deleted(object sender, FileSystemEventArgs e)
        {
            richTextBox_startMenu.AppendText(e.Name + "--------" + e.ChangeType + "\n");
        }

        private void fileSystemWatcher3_Renamed(object sender, RenamedEventArgs e)
        {
            richTextBox_startMenu.AppendText(e.OldName + "----Renamed to----" + e.Name + "\n");
        }
        //User 安装目录
        private void fileSystemWatcher4_Created(object sender, FileSystemEventArgs e)
        {
            richTextBox_UserPath.AppendText(e.Name + "--------" + e.ChangeType + "\n");

        }

        private void fileSystemWatcher4_Deleted(object sender, FileSystemEventArgs e)
        {
            richTextBox_UserPath.AppendText(e.Name + "--------" + e.ChangeType + "\n");
        }

        private void fileSystemWatcher4_Renamed(object sender, RenamedEventArgs e)
        {
            richTextBox_UserPath.AppendText(e.OldName + "----Renamed to----" + e.Name + "\n");
        }
        //#############################################################################
        //installation package path 输入
        private void PathTextBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_Path.Text = this.openFileDialog1.FileName;
            }
        }
        private void PathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox_Path.Text = path;
            this.textBox_Path.Cursor = System.Windows.Forms.Cursors.IBeam; //还原鼠标形状  
        }

        private void PathTextBox_Dragenter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.textBox_Path.Cursor = System.Windows.Forms.Cursors.Arrow;  //指定鼠标形状（更好看）  
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

  //#########################################################

        private void button_chrome_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenBrowserUrl(textBox_https.Text);
        }

        private void button_firefox_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenFireFox(textBox_https.Text);
        }

        private void button_ie_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenIe(textBox_https.Text);
        }

        private void button_edge_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenDefaultBrowserUrl(textBox_https.Text);
        }

        //button open folder#########################################################
        private void button_ServiceDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", fileSystemWatcher1.Path);
        }
        private void button_InstalledDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", fileSystemWatcher2.Path);
        }

        private void button_StartMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", fileSystemWatcher3.Path);
        }
        private void button_UserPath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", fileSystemWatcher4.Path);
        }
        //filesystemwatcher##############################################################
        private void TextBox_Installed_Path_TextChanged(object sender, EventArgs e)
        {
            fileSystemWatcher2.Path = TextBox_Installed_Path.Text;
        }

        private void TextBox_ServiceDir_Path_TextChanged(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = TextBox_ServiceDir_Path.Text;
        }

        private void TextBox_StartMenu_TextChanged(object sender, EventArgs e)
        {
            fileSystemWatcher3.Path = TextBox_StartMenu.Text;
        }

        private void TextBox_UserPath_TextChanged(object sender, EventArgs e)
        {
            fileSystemWatcher4.Path = TextBox_UserPath.Text;
        }
        // notebox################################################################
        private string MergeRTF(string rtfFile1, string rtfFile2)
        {
            System.IO.FileStream fs1 = new System.IO.FileStream(rtfFile1, System.IO.FileMode.OpenOrCreate);
            //System.IO.FileStream fs2 = new System.IO.FileStream(rtfFile2, System.IO.FileMode.OpenOrCreate);
            RichTextBox richTextBox1 = new RichTextBox();
            //RichTextBox richTextBox2 = new RichTextBox();
            richTextBox1.LoadFile(fs1, RichTextBoxStreamType.PlainText);
            //richTextBox2.LoadFile(fs2, RichTextBoxStreamType.PlainText);
            fs1.Close();
            //fs2.Close();

            string f1 = richTextBox1.Rtf;
            string f2 = rtfFile2;
            string pre = @"{\rtf1";
            string end = @"}";
            return pre + f1 + f2 + end;
        }

        private void button_SaveNote_Click(object sender, EventArgs e)
        {
            //Note_box.SaveFile( "c:\\.note_temp.rtf", RichTextBoxStreamType.PlainText);
            //FileStream f = new FileStream("C:\\aa.rtf", FileMode.Create, FileAccess.Write);
            //File.WriteAllText("D:\\123.rtf", Note_box.Rtf);
            //File.AppendAllText("D:\\123.rtf", Note_box.Rtf);
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Rtf = MergeRTF("c:\\note.rtf", Note_box.Rtf);
            richTextBox1.SaveFile("c:\\note.rtf", RichTextBoxStreamType.PlainText);
        }

        private void button_ClearNote_Click(object sender, EventArgs e)
        {
            Note_box.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser;

          
            // Retrieve all the subkeys for the specified key.
            String names = rk.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders").GetValue("My Music").ToString();
                String a = System.Environment.SystemDirectory;
            Note_box.AppendText("Subkeys of " + rk.Name);
            Note_box.AppendText("-----------------------------------------------");
            Note_box.AppendText(names);
            Note_box.AppendText(a);
              //  Console.ReadKey();
        }
        delegate void RegAppendTextCallback(string text);

        private void RegAppendText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.richTextBox_Reg.InvokeRequired)
            {
                RegAppendTextCallback d = new RegAppendTextCallback(RegAppendText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox_Reg.AppendText(text);
            }
        }
        void T__UpdateReg(string OldText, object OldValue, string NewText, object NewValue)
        {
            object Old = OldValue;
            object New = NewValue;
            if (Old == null) Old = "";
            if (New == null) New = "";

            //create value
            if (OldText == "" && NewText != "")
            {
                RegAppendText("Create new value: " + NewText+'\n');
            }
            else if (OldText != "" && NewText == "")
            {
                RegAppendText("Delete old value: " + OldText + '\n');
            }
            else if (OldText != "" && NewText == OldText)
            {
                RegAppendText("Data of "+NewText+ " update from "+ Old.ToString() + " to "+ New.ToString() + '\n');
            }else
            {
                RegAppendText("NewText: " + NewText + "OldText: " + OldText + " OldValue: " + Old.ToString() + " NewValue: " + New.ToString() + '\n');
            }
                //richTextBox_Reg.AppendText();
                //MessageBox.Show(OldText + ":" + Old.ToString(), NewText + ":" + New.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
  //          Microsoft.Win32.RegistryKey _Key = Microsoft.Win32.Registry.CurrentUser;
  //          _Key = _Key.OpenSubKey("SoftWare");
  //          _Key = _Key.OpenSubKey("Microsoft");
  //          _Key = _Key.OpenSubKey("Windows");
  //          _Key = _Key.OpenSubKey("CurrentVersion");
  //          _Key = _Key.OpenSubKey("Test");
  //          //_Key = _Key.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Test");
  //          T = new MonitorWindowsReg(_Key);
  //          T.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
  //          T.Star();
        }

        private void button5_Click(object sender, EventArgs e)
        {
   //         T.Stop();
        }

    }
}




