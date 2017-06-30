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
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Pkcs;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
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
            tabPage1.
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

        // TO DO 
        //########################## General ######################################

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.textBox_Path.Text))
            {
                MessageBox.Show("Invalid Path");
                return;
            }            
             
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            GroupBox_1.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {            
        }
        public uint StepNum()
        {
            if (GroupBox_1.Visible == true)
                return 1;
            else if (GroupBox_2.Visible == true)
                return 2;
            else
                return 0;
        }
        private void Goupbox1_VisibleChanged(object sender, EventArgs e)
        {
            int osbit = 86;
            if (GroupBox_1.Visible)
                GroupBox_2.Visible = false;
            else
            {
                GroupBox_2.Visible = true;
                string step1_report = ReportFolder + "/Step1.txt";
                if (Directory.Exists("C:/Windows/SysWOW64"))
                    osbit = 64;
                try
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(step1_report, false);
                    sw.WriteLine("Environment info:" + FriendlyName() + "x" + osbit);
                    sw.WriteLine("Browsers: ");
                    if (checkBox_Chrome.Checked)//TODO   获取各浏览器的版本
                    {
                        sw.Write("Chrome; ");
                    }
                    if (checkBox_Firefox.Checked)
                    {
                        sw.Write("Firefox; ");
                    }
                    if (checkBox_ie.Checked)
                    {
                        var ieVersion = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer").GetValue("Version").ToString();
                        sw.Write("IE:" + ieVersion + "; ");
                    }
                    if (checkBox_edge.Checked)
                    {
                        sw.Write("Edge.\n\n");
                    }
                    sw.Close();
                }
                catch { }

            }
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
        //################################# Step  1 ############################################
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

        private void textBox_Path_TextChanged(object sender, EventArgs e)
        {
            ///create report folder
            ReportFolder = string.Format(@"{0}\{1}", this.textBox_Path.Text.Substring(0, textBox_Path.Text.LastIndexOf("\\")), "Report_install_package");
            System.IO.Directory.CreateDirectory(ReportFolder);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_https_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_chrome_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenBrowserUrl(textBox_https.Text);
            BrowserHelper.OpenBrowserUrl(textBox_http.Text);
        }

        private void button_firefox_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenFireFox(textBox_https.Text);
            BrowserHelper.OpenFireFox(textBox_http.Text);
        }

        private void button_ie_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenIe(textBox_https.Text);
            BrowserHelper.OpenIe(textBox_http.Text);
        }

        private void button_edge_click(object sender, EventArgs e)
        {
            BrowserHelper.OpenDefaultBrowserUrl(textBox_https.Text);
            BrowserHelper.OpenDefaultBrowserUrl(textBox_http.Text);
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
        private void button_SaveNote_Click(object sender, EventArgs e)
        {
            Note_box.SaveFile(ReportFolder + "\\Step" + StepNum() + ".rtf", RichTextBoxStreamType.PlainText);
        }

        private void button_ClearNote_Click(object sender, EventArgs e)
        {
            Note_box.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}




