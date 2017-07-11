using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Collections;
using Microsoft.Win32;


namespace WindowsFormsApplication1
{
    public class MonitorWindowsReg
    {
        [DllImport("advapi32.dll", EntryPoint = "RegNotifyChangeKeyValue")]
        private static extern int RegNotifyChangeKeyValue(IntPtr hKey, bool bWatchSubtree, int dwNotifyFilter, int hEvent, bool fAsynchronus);
        [DllImport("advapi32.dll", EntryPoint = "RegOpenKey")]
        private static extern int RegOpenKey(uint hKey, string lpSubKey, ref IntPtr phkResult);
        [DllImport("advapi32.dll", EntryPoint = "RegCloseKey")]
        private static extern int RegCloseKey(IntPtr hKey);
        private static uint HKEY_CLASSES_ROOT = 0x80000000;
        private static uint HKEY_CURRENT_USER = 0x80000001;
        private static uint HKEY_LOCAL_MACHINE = 0x80000002;
        private static uint HKEY_USERS = 0x80000003;
        private static uint HKEY_PERFORMANCE_DATA = 0x80000004;
        private static uint HKEY_CURRENT_CONFIG = 0x80000005;
        private static uint HKEY_DYN_DATA = 0x80000006;
        private static int REG_NOTIFY_CHANGE_NAME = 0x1;
        private static int REG_NOTIFY_CHANGE_ATTRIBUTES = 0x2;
        private static int REG_NOTIFY_CHANGE_LAST_SET = 0x4;
        private static int REG_NOTIFY_CHANGE_SECURITY = 0x8;
        /// <summary>
        /// 打开的注册表句饼
        /// </summary>
        private IntPtr _OpenIntPtr = IntPtr.Zero;
        private RegistryKey _OpenReg;
        private Hashtable _Date = new Hashtable();
        private Hashtable _DateKey = new Hashtable();
        public string _Text;
        /// <summary>
        /// 监视注册表 
        /// </summary>
        /// <param name="MonitorKey">Microsfot.Win32.RegistryKey</param>
        public MonitorWindowsReg(RegistryKey MonitorKey)
        {
            if (MonitorKey == null) throw new Exception("注册表参数不能为NULL");
            _OpenReg = MonitorKey;
            string[] _SubKey = MonitorKey.Name.Split('\\');
            uint _MonitorIntPrt = HKEY_CURRENT_USER;
            switch (_SubKey[0])
            {
                case "HKEY_CLASSES_ROOT":
                    _MonitorIntPrt = HKEY_CLASSES_ROOT;
                    break;
                case "HKEY_CURRENT_USER":
                    _MonitorIntPrt = HKEY_CURRENT_USER;
                    break;
                case "HKEY_LOCAL_MACHINE":
                    _MonitorIntPrt = HKEY_LOCAL_MACHINE;
                    break;
                case "HKEY_USERS":
                    _MonitorIntPrt = HKEY_USERS;
                    break;
                case "HKEY_PERFORMANCE_DATA":
                    _MonitorIntPrt = HKEY_PERFORMANCE_DATA;
                    break;
                case "HKEY_CURRENT_CONFIG":
                    _MonitorIntPrt = HKEY_CURRENT_CONFIG;
                    break;
                case "HKEY_DYN_DATA":
                    _MonitorIntPrt = HKEY_DYN_DATA;
                    break;
                default:
                    break;
            }
            //_Text = MonitorKey.Name;
            _Text = MonitorKey.Name.Remove(0, MonitorKey.Name.IndexOf('\\') + 1);
            RegOpenKey(_MonitorIntPrt, _Text, ref _OpenIntPtr);
        }
        public string GetRegFullName()
        {
            return _OpenReg.Name;
        }
        /// <summary>
        /// 开始监控
        /// </summary>
        public void Star()
        {
            if (_OpenIntPtr == IntPtr.Zero)
            {
                throw new Exception("不能打开的注册项！");
            }
            GetOldRegData();

            System.Threading.Thread _Thread = new System.Threading.Thread(new System.Threading.ThreadStart(Monitor));
            StarMonitor = true;
            _Thread.Start();
        }
        /// <summary>
        /// 更新老的数据表
        /// </summary>
        private void GetOldRegData()
        {
            _Date.Clear();
            _DateKey.Clear();
            string[] OldName = new String[1]; ;
            try { OldName = _OpenReg.GetValueNames(); } catch
            {
                if (OldName == null || OldName[0] == null) return;
            }
            for (int i = 0; i != OldName.Length; i++)
            {
                _Date.Add(OldName[i], _OpenReg.GetValue(OldName[i]));
            }
            string[] OldKey = _OpenReg.GetSubKeyNames();
            for (int i = 0; i != OldKey.Length; i++)
            {
                _DateKey.Add(OldKey[i], "");
            }
        }
        /// <summary>
        /// 停止监控
        /// </summary>
        public void Stop()
        {
            StarMonitor = false;
            RegCloseKey(_OpenIntPtr);
        }
        /// <summary>
        /// 停止标记
        /// </summary>
        private bool StarMonitor = false;
        /// <summary>
        /// 开始监听
        /// </summary>
        public void Monitor()
        {
            while (StarMonitor)
            {
                //System.Threading.Thread.Sleep(1000);
                RegNotifyChangeKeyValue(_OpenIntPtr, false, REG_NOTIFY_CHANGE_NAME + REG_NOTIFY_CHANGE_ATTRIBUTES + REG_NOTIFY_CHANGE_LAST_SET + REG_NOTIFY_CHANGE_SECURITY, 0, false);
                System.Threading.Thread.Sleep(0);
                GetUpdate();
            }
        }
        /// <summary>
        /// 检查数据
        /// </summary>
        private void GetUpdate()
        {
                string[] NewName = new String[1];
                try
                {
                    NewName = _OpenReg.GetValueNames();  //获取当前的名称
                }
                catch { }//Rename cause a IO Exception
            foreach (string Key in _Date.Keys)
            {
                for (int i = 0; i != NewName.Length; i++)     //循环比较
                {
                    if (Key == NewName[i])
                    {
                        if (_Date[NewName[i]].ToString() != _OpenReg.GetValue(NewName[i]).ToString())
                        {
                            //修改
                            if (UpReg != null) UpReg(_OpenReg.Name + '\\' + NewName[i], _Date[NewName[i]], _OpenReg.Name + '\\' + NewName[i], _OpenReg.GetValue(NewName[i]));
                        }
                        NewName[i] = "nullbug"; //标记该value已被比较, value name can be ""
                        break;
                    }
                    else if (i == NewName.Length - 1)
                    {
                        if (UpReg != null) UpReg(_OpenReg.Name + '\\' + Key, _Date[Key], "", "");      //删除 
                    }
                }
                if (0 == NewName.Length)
                {
                    if (UpReg != null) UpReg(_OpenReg.Name + '\\' + Key, _Date[Key], "", "");      //删除 
                }
                }
                for (int i = 0; i != NewName.Length; i++)     //循环比较
                {
                if (NewName[i] != "nullbug") //NewName[i] != null && 
                {
                        if (UpReg != null) UpReg("", "", _OpenReg.Name + '\\' + NewName[i], _OpenReg.GetValue(NewName[i]));   //添加
                    }
                }

            //subkeys
            string[] NewKey = new String[1];
            try
            {
                NewKey = _OpenReg.GetSubKeyNames();  //获取当前的名称
            }
            catch {
                if (NewKey[0] == null)
                {
                    GetOldRegData();
                    //TODO HOW TO avoid reach here
                    //MessageBox.Show(_OpenReg.Name + " get null reg key!");
                    return;
                }
                else
                {
                    MessageBox.Show(_OpenReg.Name + " :" + NewKey);
                    return;
                }

            }//Rename cause a IO Exception
            foreach (string Key in _DateKey.Keys)
            {
                for (int i = 0; i != NewKey.Length; i++)     //循环比较
                {
                    if (Key == NewKey[i])
                    {
                        NewKey[i] = ""; //标记该value已被比较
                        break;
                    }
                    else if (i == NewKey.Length - 1)
                    {
                        if (UpReg != null) UpReg(_OpenReg.Name + '\\' + Key, "_key_", "", "");      //删除 
                    }
                }
                if (0 == NewKey.Length)
                {
                    if (UpReg != null) UpReg(_OpenReg.Name + '\\' + Key, "_key_", "", "");      //删除 
                }
            }
            for (int i = 0; i != NewKey.Length; i++)     //循环比较
            {
                if (NewKey[i] != "")
                {
                    if (UpReg != null) UpReg("", "", _OpenReg.Name + '\\' + NewKey[i], "_key_");   //添加

                }
            }
            GetOldRegData();
                return;
        }
        public delegate void UpdataReg(string OldText, object OldValue, string NewText, object NewValue);
        public event UpdataReg UpReg;


    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new Form1());
        }

    }
}
