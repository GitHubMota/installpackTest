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
using System.Collections;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        string ReportFolder = null;
        private Hashtable TS = new Hashtable();
        String[] Reg = new String[] { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_CURRENT_CONFIG" };
        private List<ComboBox> ComboBoxes = new List<ComboBox>();
        private List<TextBox> TextBoxes = new List<TextBox>();
        //MonitorWindowsReg T;
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

            //Initial RegPath comboBox
            ComboBoxes.Add(comboBox_RegPath1);
            ComboBoxes.Add(comboBox_RegPath2);
            ComboBoxes.Add(comboBox_RegPath3);
            int index = 0;
            foreach (ComboBox comboxBox in ComboBoxes)
            {
                foreach (string r in Reg)
                {
                    comboxBox.Items.Add(r);
                }
                comboxBox.SelectedIndex = index++;
            }
            //Initial RegPath textBox
            TextBoxes.Add(textBox_RegPath1);
            TextBoxes.Add(textBox_RegPath2);
            TextBoxes.Add(textBox_RegPath3);
            comboBox_RegPath1.SelectedIndex = 2;
            textBox_RegPath1.Text = ("\\software\\Dynamsoft");
            //textBox_RegPath1.Text = ("\\software\\Microsoft\\Windows\\CurrentVersion\\Test");

            //register monitor
            //            Microsoft.Win32.RegistryKey _Key = Microsoft.Win32.Registry.CurrentUser;
            //_Key = _Key.OpenSubKey("SoftWare");
            //_Key = _Key.OpenSubKey("Microsoft");
            //_Key = _Key.OpenSubKey("Windows");
            //_Key = _Key.OpenSubKey("CurrentVersion");
            //_Key = _Key.OpenSubKey("Test");
            //            _Key = _Key.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Test");

            //CreateMonitor(_Key);

            //           MonitorWindowsReg tmpT = new MonitorWindowsReg(_Key);


            InitialMonitor(comboBox_RegPath1.SelectedItem.ToString() + textBox_RegPath1.Text);
            //tmpT.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
            //tmpT.Star();
            //TS[tmpT._Text] = tmpT;
            if(TS.Count != 0)
            {
                foreach (TextBox textBox in TextBoxes)
                {
                    textBox.Enabled = false;
                }
            }


        }

        RegistryKey GetRegistryKey(string text)
        {
            string[] _SubKey = text.Split('\\');
            Microsoft.Win32.RegistryKey _Key = Microsoft.Win32.Registry.CurrentUser;
            switch (_SubKey[0])
            {
                case "HKEY_CLASSES_ROOT":
                    _Key = Microsoft.Win32.Registry.ClassesRoot;
                    break;
                case "HKEY_CURRENT_USER":
                    _Key = Microsoft.Win32.Registry.CurrentUser;
                    break;
                case "HKEY_LOCAL_MACHINE":
                    _Key = Microsoft.Win32.Registry.LocalMachine;
                    break;
                case "HKEY_USERS":
                    _Key = Microsoft.Win32.Registry.Users;
                    break;
                case "HKEY_CURRENT_CONFIG":
                    _Key = Microsoft.Win32.Registry.CurrentConfig;
                    break;
                default:
                    break;
            }
            _Key = _Key.OpenSubKey(String.Join("\\", _SubKey, 1, _SubKey.Length - 1));
            return _Key;
        }

        public void InitialMonitor(string text)
        {
            string[] tmpText = text.Split('\\');
            //Trace.Assert(tmpText[1] != null);
            if (tmpText.Length <= 1 || tmpText[1] == null || tmpText[1] == "") return; //no path input
            // Monitor the upper level.
            string upperText = String.Join("\\", tmpText, 0, tmpText.Length - 1);
            if (TS.Count > 100)
            {
                MessageBox.Show("Monitor more than 100 keys!");
                return;
            }
            if (TS[upperText] != null)
            {
                return;
            }
            Microsoft.Win32.RegistryKey _Key = GetRegistryKey(upperText);
            if (_Key == null)
            {
                MessageBox.Show(text + " is not vaild path!");
                return;
            }

            MonitorWindowsReg tmpT = new MonitorWindowsReg(_Key);
            tmpT.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
            tmpT.Star();
            TS.Add(upperText, tmpT);
            // Monitor the current level recur.
            CreateMonitor(text);
        }
        public void CreateMonitor(string text)
        {
            string[] tmpText = text.Split('\\');
            //Trace.Assert(tmpText[1] != null);
            if (tmpText.Length <=1|| tmpText[1] == null || tmpText[1] == "") return; //no path input

            if (TS.Count > 100)
            {
                MessageBox.Show("Monitor more than 100 keys!");
                return;
            }
            if (TS[text] != null)
            {
                return;
            }
            Microsoft.Win32.RegistryKey _Key = GetRegistryKey(text);
            if(_Key == null)
            {
                //MessageBox.Show(text + " is not vaild path!");
                return;
            }

            MonitorWindowsReg tmpT = new MonitorWindowsReg(_Key);
            tmpT.UpReg += new MonitorWindowsReg.UpdataReg(T__UpdateReg);
            tmpT.Star();
            TS.Add(text, tmpT);
 
            foreach (string key in _Key.GetSubKeyNames())
            {
                CreateMonitor(text + '\\' + key);
            }
        }
        public void RemoveMonitor(string text)
        {
            if (TS[text] == null)
                return;


            Microsoft.Win32.RegistryKey _Key = GetRegistryKey(text);
            if(_Key!=null)
            foreach (string key in _Key.GetSubKeyNames())
            {
                RemoveMonitor(text + '\\' + key);
            }
            ((MonitorWindowsReg)TS[text]).Stop();
            TS.Remove(text);
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
                this.richTextBox_Reg.AppendText(DateTime.Now.ToLocalTime().ToString()+':'+text);
            }
        }

        void recurAppendNewKeyValue(string NewKey)
        {
            Microsoft.Win32.RegistryKey _Key = GetRegistryKey(NewKey);
            if (_Key == null)
            {
                //MessageBox.Show(text + " is not vaild path!");
                return;
            }
            RegAppendText("Create new key: " + NewKey + '\n');
            foreach (string value in _Key.GetValueNames())
            {
                RegAppendText("Create new value: " + value + " with data " + _Key.GetValue(value).ToString() + '\n');
            }
            foreach (string key in _Key.GetSubKeyNames())
            {
                recurAppendNewKeyValue(NewKey + '\\' + key);
 
            }
        }
        void T__UpdateReg(string OldText, object OldValue, string NewText, object NewValue)
        {
            object Old = OldValue;
            object New = NewValue;
            if (Old == null || Old.ToString() == "") Old = "null";
            if (New == null || New.ToString() == "") New = "null";
            string[] nameParts = NewText.Split('\\');
            if(nameParts.Length>2 && nameParts[nameParts.Length-1] == "")
            NewText = String.Join("\\", nameParts, 0, nameParts.Length-1);
            //create value
            if (OldText == "" && NewText != "")
            {
                if (NewValue == null)
                {
                    if(TS[NewText] != null)
                    {
                        RegAppendText("Delete old key: " + NewText + '\n');
                        RemoveMonitor(NewText);
                    }
                    return;
                }
                    
                if(NewValue.ToString() == "_key_")
                {
                    recurAppendNewKeyValue(NewText);
                    //RegAppendText("Create new key: " + NewText+'\n');
                    //recur key value

                    CreateMonitor(NewText);
                }
                else
                {
                    RegAppendText("Create new value: " + NewText + " with data " + New.ToString() + '\n');
                }

            }
            else if (OldText != "" && NewText == "")
            {
                if (OldValue == null)
                    return;
                if (OldValue.ToString() == "_key_")
                {
                    RegAppendText("Delete old key: " + OldText + '\n');
                    RemoveMonitor(OldText);
                }
                else
                {
                    RegAppendText("Delete old value: " + OldText + '\n');
                }
            }
            else if (OldText != "" && NewText == OldText)
            {
                RegAppendText("Update data of "+NewText+ " from "+ Old.ToString() + " to "+ New.ToString() + '\n');
            }else
            {
                RegAppendText("NewText: " + NewText + "OldText: " + OldText + " OldValue: " + Old.ToString() + " NewValue: " + New.ToString() + '\n');
            }
                //richTextBox_Reg.AppendText();
                //MessageBox.Show(OldText + ":" + Old.ToString(), NewText + ":" + New.ToString());
        }

        private void button_StopMon(object sender, EventArgs e)
        {
            if (TS.Count == 0)
            {
                MessageBox.Show("Register text not been monitoring!");
                return;
            }
            foreach (string Key in new List<object>(TS.Keys.Cast<object>()))
                //foreach (string Key in TS.Keys)//error: Collection was modified; enumeration operation may not exec
            {
                RemoveMonitor(Key);
            }

            Trace.Assert(TS.Count == 0);
                for (int i = 0; i < TextBoxes.Count; i++)
                //foreach (TextBox textBox in TextBoxes)
            {
                    ComboBoxes[i].Enabled = true;
                    TextBoxes[i].Enabled = true;
                }
        }

        private void button_StartMon(object sender, EventArgs e)
        {
            if (TS.Count > 0)
            {
                MessageBox.Show("Register text has already been monitoring!");
                return;
            }
            for (int i = 0; i < TextBoxes.Count; i++)
            //foreach (TextBox textBox in TextBoxes)
            {
                InitialMonitor(ComboBoxes[i].SelectedItem.ToString() + TextBoxes[i].Text);
            }
            if (TS.Count > 0)
            {
                for (int i = 0; i < TextBoxes.Count; i++)
                {
                    ComboBoxes[i].Enabled = false;
                    TextBoxes[i].Enabled = false;
                }
            }else
            {
                MessageBox.Show("No vaild path has been monitoring!");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Reg.Clear();
        }
    }
}




