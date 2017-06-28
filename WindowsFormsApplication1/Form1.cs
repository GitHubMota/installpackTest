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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList GetAll(DirectoryInfo dir)//搜索文件夹中的文件
        {
            ArrayList FileList = new ArrayList();
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                FileList.Add(fi.Name);
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                foreach (object ele in GetAll(d))
                    FileList.Add(d.Name+'\\'+ele);
            }
            return FileList;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dirTextBox_DoubleClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dirTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dirTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //判断文件还是文件夹
            ArrayList Flst = new ArrayList();
            bool fileOnly = false;
            string filename = null;

            if (File.Exists(dirTextBox.Text))
            {
                Flst.Add(file);
                fileOnly = true;
            }
            else if (Directory.Exists(dirTextBox.Text))
            {

                DirectoryInfo dirs = new DirectoryInfo(dirTextBox.Text);
                Flst = GetAll(dirs);
            }
            else
            {
                MessageBox.Show("Please enter a valid file or folder path!");
                return;
            }
            foreach (object outElement in Flst)
            {
                if (fileOnly)
                {
                    filename = dirTextBox.Text;
                }
                else
                {
                    filename = dirTextBox.Text + '\\' + outElement;
                }
                string aLastName = filename.Substring(filename.LastIndexOf(".") + 1, (filename.Length - filename.LastIndexOf(".") - 1));   //扩展名
                if (String.Compare(aLastName, "DLL", true) == 0 ||
                  String.Compare(aLastName, "EXE", true) == 0 ||
                  String.Compare(aLastName, "msi", true) == 0 ||
                  String.Compare(aLastName, "cab", true) == 0 ||
                  String.Compare(aLastName, "ocx", true) == 0 ||
                  String.Compare(aLastName, "vbd", true) == 0)
                {
                    ListViewItem i_item = listViewOutput.Items.Add((listViewOutput.Items.Count + 1) + "\n");
                    if (fileOnly)
                    {
                        i_item.SubItems.Add(filename + "\n");
                    }
                    else
                    {
                        i_item.SubItems.Add(outElement + "\n");
                    }

                    try
                    {
                        //需要错误签名文件验证是否能取出信息
                        X509Certificate2 cert = new X509Certificate2(filename); ;

                        if (VerifySign.AuthenticodeTools.IsSignedOK(filename)) //文件很大时特别耗时， 10s 500MB
                        {//TODO 双签名
                            i_item.SubItems.Add("");
                            i_item.SubItems.Add("");
                            string timetamp = VerifySign.AuthenticodeTools.getTimestamp(filename);
                            //|后面为多个timestamp
                            string[] signers = timetamp.Split('|');
                            bool sflag = false;
                            foreach (string signer in signers) {
                                string[] signerInfo = signer.Split(';');
                                if (signerInfo.Length >= 2)
                                {
                                    i_item.SubItems[2].Text = i_item.SubItems[2].Text + signerInfo[0] + ", " + signerInfo[1] + "    ";
                                    i_item.SubItems[3].Text = i_item.SubItems[3].Text + signerInfo[2] + " ";
                                }
                                else
                                {
                                    //第一个二进制文件取出来的时间戳要覆盖vData解码出来的时间戳,避免重复
                                    if(!sflag)
                                    {
                                        i_item.SubItems[3].Text = signerInfo[0];
                                        sflag = true;
                                    } else
                                    {
                                        i_item.SubItems[3].Text = i_item.SubItems[3].Text + ", " + signerInfo[0];
                                    }
                                }
                            }
                        }
                        else
                        {
                            i_item.SubItems.Add("Wrong cert!!\n");
                        }
                    }
                    catch
                    {
                        i_item.SubItems.Add("No cert!!\n");
                    }

                    try
                    {
                        //文件的fileversion
                        Shell32.Shell shell = new Shell32.Shell();
                        Shell32.Folder objFolder;

                        string file_name = filename.Substring(filename.LastIndexOf('\\') + 1);
                        string parentfolder = filename.Substring(0, filename.LastIndexOf('\\'));
                        objFolder = shell.NameSpace(parentfolder);
                        Shell32.FolderItem Item = objFolder.ParseName(file_name);
                        i_item.SubItems.Add("");
                        i_item.SubItems.Add("");
                        i_item.SubItems.Add("");
                        // flag当文件版本和版权均找到后置为0x3, 退出循环
                        short flag = 0;
                        for (int i = 0; i < 600; i++)
                        {
                            string key = objFolder.GetDetailsOf(null, i);
                            string strfileVer = objFolder.GetDetailsOf(Item, i);
                            if (String.Compare(key, "Copyright") == 0 || String.Compare(key, "版权") == 0)
                            {
                                i_item.SubItems[4].Text = strfileVer;
                                flag |= 0x1;
                                // i_item.SubItems.Add(i+":"+strfileVer + "\n");
                            }
                            if (String.Compare(key, "File version") == 0 || String.Compare(key, "文件版本") == 0)
                            {
                                i_item.SubItems[5].Text = strfileVer;
                                flag |= 0x2;
                            }
                            if (flag == 0x3)
                            {
                                break;
                            }
                        }
                    }
                    catch {
                        
                    }
                    i_item.EnsureVisible();
                }
            }
            MessageBox.Show("Finished");
        }



        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ExportToExecl();        
        }

        /// <summary>
        /// 执行导出数据
        /// </summary>
        public void ExportToExecl()
        {
            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "xls";
            sfd.Filter = "Excel文件(*.xls)|*.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DoExport(listViewOutput, sfd.FileName);
            }
        }
        /// <summary>
        /// 具体导出的方法
        /// </summary>
        /// <param name="listView">ListView</param>
        /// <param name="strFileName">导出到的文件名</param>
        private void DoExport(ListView listView, string strFileName)
        {          
            int rowNum = listView.Items.Count;
            int columnNum = listView.Items[0].SubItems.Count;
            int rowIndex = 1;
            int columnIndex = 0;
            if (rowNum == 0 || string.IsNullOrEmpty(strFileName))
            {
                return;
            }
            if (rowNum > 0)
            {
                Excel.Application xlApp = new Excel.ApplicationClass();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建excel对象，可能您的系统没有安装excel");
                    return;
                }
                xlApp.DefaultFilePath = "";
                xlApp.DisplayAlerts = true;
                xlApp.SheetsInNewWorkbook = 1;
                Microsoft.Office.Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
                //将ListView的列名导入Excel表第一行
                foreach (ColumnHeader dc in listView.Columns)
                {
                    columnIndex++;
                    xlApp.Cells[rowIndex, columnIndex] = dc.Text;
                }
                //将ListView中的数据导入Excel中
                for (int i = 0; i < rowNum; i++)
                {
                    rowIndex++;
                    columnIndex = 0;
                    for (int j = 0; j < columnNum; j++)
                    {
                        columnIndex++;
                        //注意这个在导出的时候加了“\t” 的目的就是避免导出的数据显示为科学计数法。可以放在每行的首尾。
                        xlApp.Cells[rowIndex, columnIndex] = Convert.ToString(listView.Items[i].SubItems[j].Text) + "\t";
                    }
                }
                //例外需要说明的是用strFileName,Excel.XlFileFormat.xlExcel9795保存方式时 当你的Excel版本不是95、97 而是2003、2007 时导出的时候会报一个错误：异常来自 HRESULT:0x800A03EC。 解决办法就是换成strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal。
                xlBook.SaveAs(strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xlApp = null;
                xlBook = null;
                MessageBox.Show("OK");
            }
        }

        private void listViewOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dirTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            dirTextBox.Text = path;
            this.dirTextBox.Cursor = System.Windows.Forms.Cursors.IBeam; //还原鼠标形状  
        }

        private void dirTextBox_Dragenter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.dirTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;  //指定鼠标形状（更好看）  
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void Button_Clear(object sender, EventArgs e)
        {
            listViewOutput.Items.Clear();
        }


        // TO DO 
        //########################## General ######################################
        int index = 0;
        private void button_Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (index++)%tabControl1.TabPages.Count;

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            GroupBox_1.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_OS.Items.Add("Win 10 x64");
            comboBox_OS.Items.Add("Win 10 x32");
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
                this.dirTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;  //指定鼠标形状（更好看）  
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Goupbox1_VisibleChanged(object sender, EventArgs e)
        {
            if (GroupBox_1.Visible)
                GroupBox_2.Visible = false;
            else
                GroupBox_2.Visible = true;
        }

        private void textBox_Path_TextChanged(object sender, EventArgs e)
        {
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

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.FullPath+"; "+e.Name);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show(e.Name+" "+e.OldName+" "+e.Name);
        }
    }
}




namespace VerifySign
{


    internal static class AuthenticodeTools
    {
        public static int IndexOf(byte[] srcBytes, byte[] searchBytes, int offset = 0)
        {
            if (offset == -1) { return -1; }
            if (srcBytes == null) { return -1; }
            if (searchBytes == null) { return -1; }
            if (srcBytes.Length == 0) { return -1; }
            if (searchBytes.Length == 0) { return -1; }
            if (srcBytes.Length < searchBytes.Length) { return -1; }
            for (var i = offset; i < srcBytes.Length - searchBytes.Length; i++)
            {
                if (srcBytes[i] != searchBytes[0]) continue;
                if (searchBytes.Length == 1) { return i; }
                var flag = true;
                for (var j = 1; j < searchBytes.Length; j++)
                {
                    if (srcBytes[i + j] != searchBytes[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) { return i; }
            }
            return -1;
        }
        [DllImport("Wintrust.dll", PreserveSig = true, SetLastError = false)]
        private static extern uint WinVerifyTrust(IntPtr hWnd, IntPtr pgActionID, IntPtr pWinTrustData);
        /*
         * return : 0 - verify success; else verify error
         */
        private static uint WinVerifyTrust(string fileName)
        {
            Guid wintrust_action_generic_verify_v2 = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
            uint result = 0;
            using (WINTRUST_FILE_INFO fileInfo = new WINTRUST_FILE_INFO(fileName, Guid.Empty))
            using (UnmanagedPointer guidPtr = new UnmanagedPointer(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid))), AllocMethod.HGlobal))
            using (UnmanagedPointer wvtDataPtr = new UnmanagedPointer(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WINTRUST_DATA))), AllocMethod.HGlobal))
            {
                WINTRUST_DATA data = new WINTRUST_DATA(fileInfo);
                IntPtr pGuid = guidPtr;
                IntPtr pData = wvtDataPtr;
                Marshal.StructureToPtr(wintrust_action_generic_verify_v2, pGuid, true);
                Marshal.StructureToPtr(data, pData, true);
                result = WinVerifyTrust(IntPtr.Zero, pGuid, pData);
            }
            return result;
        }
        public static bool IsSignedOK(string fileName)
        {
            return WinVerifyTrust(fileName) == 0;
        }

        #region get time smatp
        public static string getTimestamp(string filename)
        {
            string strTimeStamp = string.Empty;
            try
            {
                int encodingType;
                int contentType;
                int formatType;
                IntPtr certStore = IntPtr.Zero;
                IntPtr cryptMsg = IntPtr.Zero;
                IntPtr context = IntPtr.Zero;
                if (!WinCrypt.CryptQueryObject(
                  WinCrypt.CERT_QUERY_OBJECT_FILE,
                  Marshal.StringToHGlobalUni(filename),
                  WinCrypt.CERT_QUERY_CONTENT_FLAG_ALL,
                  WinCrypt.CERT_QUERY_FORMAT_FLAG_ALL,
                  0,
                  out encodingType,
                  out contentType,
                  out formatType,
                  ref certStore,
                  ref cryptMsg,
                  ref context))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                // Get size of the encoded message.
                int cbData = 0;

                if (!WinCrypt.CryptMsgGetParam(cryptMsg, WinCrypt.CMSG_ENCODED_MESSAGE,//Crypt32.CMSG_SIGNER_INFO_PARAM,
                             0,
                   IntPtr.Zero,
                   ref cbData))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                var vData = new byte[cbData];

                // Get the encoded message.
                if (!WinCrypt.CryptMsgGetParam(cryptMsg, WinCrypt.CMSG_ENCODED_MESSAGE,//Crypt32.CMSG_SIGNER_INFO_PARAM,
                    0,
                    vData,
                    ref cbData))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                var signedCms = new SignedCms();
                signedCms.Decode(vData);
                foreach (var signerInfo in signedCms.SignerInfos)
                {
                    foreach (var unsignedAttribute in signerInfo.UnsignedAttributes)
                    {
                        if (unsignedAttribute.Oid.Value == WinCrypt.szOID_RSA_counterSign)
                        {
                            foreach (var counterSignInfo in signerInfo.CounterSignerInfos)
                            {
                                foreach (var signedAttribute in counterSignInfo.SignedAttributes)
                                {
                                    if (signedAttribute.Oid.Value == WinCrypt.szOID_RSA_signingTime)
                                    {
                                        Pkcs9SigningTime signingTime = (Pkcs9SigningTime)signedAttribute.Values[0];
                                        
                                        string[] signername2 = signerInfo.Certificate.Subject.ToString().Split(',');
                                        strTimeStamp += "("+ signerInfo.UnsignedAttributes.Count+") "+ counterSignInfo.Certificate.SignatureAlgorithm.FriendlyName + ";" + signername2[0] + ";" + signingTime.SigningTime.ToLocalTime();
                                    }
                                }
                            }
                        }
                    }
                }

                //byte[] byStart = { 0x30, 0x82, 0x3c, 0xc4, 0x06, 0x09, 0x2a, 0x86 };
                //获取多个签名人时间信息
                byte[] byStart = { 0x09, 0x2a, 0x86, 0x48, 0x86, 0xf7, 0x0d, 0x01, 0x09, 0x05, 0x31, 0x0f };
                var fStart = 0;
                var fNextStart = 0;

                fStart = IndexOf(vData, byStart, 0);
                if (fStart != -1) {
                    while (fNextStart < vData.Length) {
                        fNextStart = IndexOf(vData, byStart, fStart + 1);
                        if (fNextStart == -1) fNextStart = vData.Length;
                        byte[] timestamp = new byte[15];
                        Array.Copy(vData, fStart+ byStart.Length, timestamp, 0, 15);
                        Pkcs9SigningTime tmpSigningTime = new Pkcs9SigningTime(timestamp);
                        strTimeStamp+= "|"+ tmpSigningTime.SigningTime.ToLocalTime();
                        fStart = IndexOf(vData, byStart, fStart+1);
                    }
                }
            }
            catch (Exception)
            {
                // no logging
            }
            return strTimeStamp;
        }
        #endregion

    }
    internal struct WINTRUST_FILE_INFO : IDisposable
    {
        public WINTRUST_FILE_INFO(string fileName, Guid subject)
        {
            cbStruct = (uint)Marshal.SizeOf(typeof(WINTRUST_FILE_INFO));
            pcwszFilePath = fileName;
            if (subject != Guid.Empty)
            {
                pgKnownSubject = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid)));
                Marshal.StructureToPtr(subject, pgKnownSubject, true);
            }
            else
            {
                pgKnownSubject = IntPtr.Zero;
            }
            hFile = IntPtr.Zero;
        }
        public uint cbStruct;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string pcwszFilePath;
        public IntPtr hFile;
        public IntPtr pgKnownSubject;
        #region IDisposable Members
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if (pgKnownSubject != IntPtr.Zero)
            {
                Marshal.DestroyStructure(this.pgKnownSubject, typeof(Guid));
                Marshal.FreeHGlobal(this.pgKnownSubject);
            }
        }
        #endregion
    }
    enum AllocMethod
    {
        HGlobal,
        CoTaskMem
    };
    enum UnionChoice
    {
        File = 1,
        Catalog,
        Blob,
        Signer,
        Cert
    };
    enum UiChoice
    {
        All = 1,
        NoUI,
        NoBad,
        NoGood
    };
    enum RevocationCheckFlags
    {
        None = 0,
        WholeChain
    };
    enum StateAction
    {
        Ignore = 0,
        Verify,
        Close,
        AutoCache,
        AutoCacheFlush
    };
    enum TrustProviderFlags
    {
        UseIE4Trust = 1,
        NoIE4Chain = 2,
        NoPolicyUsage = 4,
        RevocationCheckNone = 16,
        RevocationCheckEndCert = 32,
        RevocationCheckChain = 64,
        RecovationCheckChainExcludeRoot = 128,
        Safer = 256,
        HashOnly = 512,
        UseDefaultOSVerCheck = 1024,
        LifetimeSigning = 2048
    };
    enum UIContext
    {
        Execute = 0,
        Install
    };
    [StructLayout(LayoutKind.Sequential)]
    internal struct WINTRUST_DATA : IDisposable
    {
        public WINTRUST_DATA(WINTRUST_FILE_INFO fileInfo)
        {
            this.cbStruct = (uint)Marshal.SizeOf(typeof(WINTRUST_DATA));
            pInfoStruct = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WINTRUST_FILE_INFO)));
            Marshal.StructureToPtr(fileInfo, pInfoStruct, false);
            this.dwUnionChoice = UnionChoice.File;
            pPolicyCallbackData = IntPtr.Zero;
            pSIPCallbackData = IntPtr.Zero;
            dwUIChoice = UiChoice.NoUI;
            fdwRevocationChecks = RevocationCheckFlags.None;
            dwStateAction = StateAction.Ignore;
            hWVTStateData = IntPtr.Zero;
            pwszURLReference = IntPtr.Zero;
            dwProvFlags = TrustProviderFlags.Safer;
            dwUIContext = UIContext.Execute;
        }
        public uint cbStruct;
        public IntPtr pPolicyCallbackData;
        public IntPtr pSIPCallbackData;
        public UiChoice dwUIChoice;
        public RevocationCheckFlags fdwRevocationChecks;
        public UnionChoice dwUnionChoice;
        public IntPtr pInfoStruct;
        public StateAction dwStateAction;
        public IntPtr hWVTStateData;
        private IntPtr pwszURLReference;
        public TrustProviderFlags dwProvFlags;
        public UIContext dwUIContext;
        #region IDisposable Members
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if (dwUnionChoice == UnionChoice.File)
            {
                WINTRUST_FILE_INFO info = new WINTRUST_FILE_INFO();
                Marshal.PtrToStructure(pInfoStruct, info);
                info.Dispose();
                Marshal.DestroyStructure(pInfoStruct, typeof(WINTRUST_FILE_INFO));
            }
            Marshal.FreeHGlobal(pInfoStruct);
        }
        #endregion
    }
    internal sealed class UnmanagedPointer : IDisposable
    {
        private IntPtr m_ptr;
        private AllocMethod m_meth;
        internal UnmanagedPointer(IntPtr ptr, AllocMethod method)
        {
            m_meth = method;
            m_ptr = ptr;
        }
        ~UnmanagedPointer()
        {
            Dispose(false);
        }
        #region IDisposable Members
        private void Dispose(bool disposing)
        {
            if (m_ptr != IntPtr.Zero)
            {
                if (m_meth == AllocMethod.HGlobal)
                {
                    Marshal.FreeHGlobal(m_ptr);
                }
                else if (m_meth == AllocMethod.CoTaskMem)
                {
                    Marshal.FreeCoTaskMem(m_ptr);
                }
                m_ptr = IntPtr.Zero;
            }
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
        public static implicit operator IntPtr(UnmanagedPointer ptr)
        {
            return ptr.m_ptr;
        }
    }
    #region time stamp
    static class WinCrypt
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct BLOB
        {
            public int cbData;
            public IntPtr pbData;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CRYPT_ALGORITHM_IDENTIFIER
        {
            public String pszObjId;
            BLOB Parameters;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CERT_ID
        {
            public int dwIdChoice;
            public BLOB IssuerSerialNumberOrKeyIdOrHashId;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SIGNER_SUBJECT_INFO
        {
            /// DWORD->unsigned int
            public uint cbSize;
            /// DWORD*
            public System.IntPtr pdwIndex;
            /// DWORD->unsigned int
            public uint dwSubjectChoice;
            /// SubjectChoiceUnion
            public SubjectChoiceUnion Union1;
        }
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct SubjectChoiceUnion
        {
            /// SIGNER_FILE_INFO*
            [FieldOffsetAttribute(0)]
            public System.IntPtr pSignerFileInfo;
            /// SIGNER_BLOB_INFO*
            [FieldOffsetAttribute(0)]
            public System.IntPtr pSignerBlobInfo;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CERT_NAME_BLOB
        {
            public uint cbData;
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)]
            public byte[] pbData;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CRYPT_INTEGER_BLOB
        {
            public UInt32 cbData;
            public IntPtr pbData;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CRYPT_ATTR_BLOB
        {
            public uint cbData;
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)]
            public byte[] pbData;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CRYPT_ATTRIBUTE
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pszObjId;
            public uint cValue;
            [MarshalAs(UnmanagedType.LPStruct)]
            public CRYPT_ATTR_BLOB rgValue;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CMSG_SIGNER_INFO
        {
            public int dwVersion;
            private CERT_NAME_BLOB Issuer;
            CRYPT_INTEGER_BLOB SerialNumber;
            CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;
            CRYPT_ALGORITHM_IDENTIFIER HashEncryptionAlgorithm;
            BLOB EncryptedHash;
            CRYPT_ATTRIBUTE[] AuthAttrs;
            CRYPT_ATTRIBUTE[] UnauthAttrs;
        }
        [DllImport("CRYPT32.DLL", EntryPoint = "CertEnumCertificatesInStore", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CertEnumCertificatesInStore(IntPtr storeProvider, IntPtr prevCertContext);
        [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean CryptQueryObject(
          int dwObjectType,
          IntPtr pvObject,
          int dwExpectedContentTypeFlags,
          int dwExpectedFormatTypeFlags,
          int dwFlags,
          out int pdwMsgAndCertEncodingType,
          out int pdwContentType,
          out int pdwFormatType,
          ref IntPtr phCertStore,
          ref IntPtr phMsg,
          ref IntPtr ppvContext);
        [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean CryptMsgGetParam(
          IntPtr hCryptMsg,
          int dwParamType,
          int dwIndex,
          IntPtr pvData,
          ref int pcbData
        );
        [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean CryptMsgGetParam(
          IntPtr hCryptMsg,
          int dwParamType,
          int dwIndex,
          [In, Out] byte[] vData,
          ref int pcbData
        );
        [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CryptDecodeObject(
         uint CertEncodingType,
         UIntPtr lpszStructType,
         byte[] pbEncoded,
         uint cbEncoded,
         uint flags,
         [In, Out] byte[] pvStructInfo,
         ref uint cbStructInfo);
        #region get signer name
        [DllImport("crypt32.dll", EntryPoint = "CertGetNameString", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern UInt32 CertGetNameString(
        IntPtr CertContext,
        UInt32 lType,
        UInt32 lFlags,
        IntPtr pTypeParameter,
        System.Text.StringBuilder str,
         UInt32 cch);



        public const uint CERT_NAME_ISSUER_FLAG = 0x1;
        public const uint CERT_NAME_EMAIL_TYPE = 1;
        public const uint CERT_NAME_RDN_TYPE = 2;
        public const uint CERT_NAME_ATTR_TYPE = 3;
        public const uint CERT_NAME_SIMPLE_DISPLAY_TYPE = 4;
        public const uint CERT_NAME_FRIENDLY_DISPLAY_TYPE = 5;
        public const uint CERT_NAME_DNS_TYPE = 6;
        public const uint CERT_NAME_URL_TYPE = 7;
        public const uint CERT_NAME_UPN_TYPE = 8;
        public const uint CERT_NAME_DISABLE_IE4_UTF8_FLAG = 0x00010000;
        #endregion
        public const int CRYPT_ASN_ENCODING = 0x00000001;
        public const int CRYPT_NDR_ENCODING = 0x00000002;
        public const int X509_ASN_ENCODING = 0x00000001;
        public const int X509_NDR_ENCODING = 0x00000002;
        public const int PKCS_7_ASN_ENCODING = 0x00010000;
        public const int PKCS_7_NDR_ENCODING = 0x00020000;
        public static UIntPtr PKCS7_SIGNER_INFO = new UIntPtr(500);
        public static UIntPtr CMS_SIGNER_INFO = new UIntPtr(501);
        public static string szOID_RSA_signingTime = "1.2.840.113549.1.9.5";
        public static string szOID_RSA_counterSign = "1.2.840.113549.1.9.6";
        //+-------------------------------------------------------------------------
        //  Get parameter types and their corresponding data structure definitions.
        //--------------------------------------------------------------------------
        public const int CMSG_TYPE_PARAM = 1;
        public const int CMSG_CONTENT_PARAM = 2;
        public const int CMSG_BARE_CONTENT_PARAM = 3;
        public const int CMSG_INNER_CONTENT_TYPE_PARAM = 4;
        public const int CMSG_SIGNER_COUNT_PARAM = 5;
        public const int CMSG_SIGNER_INFO_PARAM = 6;
        public const int CMSG_SIGNER_CERT_INFO_PARAM = 7;
        public const int CMSG_SIGNER_HASH_ALGORITHM_PARAM = 8;
        public const int CMSG_SIGNER_AUTH_ATTR_PARAM = 9;
        public const int CMSG_SIGNER_UNAUTH_ATTR_PARAM = 10;
        public const int CMSG_CERT_COUNT_PARAM = 11;
        public const int CMSG_CERT_PARAM = 12;
        public const int CMSG_CRL_COUNT_PARAM = 13;
        public const int CMSG_CRL_PARAM = 14;
        public const int CMSG_ENVELOPE_ALGORITHM_PARAM = 15;
        public const int CMSG_RECIPIENT_COUNT_PARAM = 17;
        public const int CMSG_RECIPIENT_INDEX_PARAM = 18;
        public const int CMSG_RECIPIENT_INFO_PARAM = 19;
        public const int CMSG_HASH_ALGORITHM_PARAM = 20;
        public const int CMSG_HASH_DATA_PARAM = 21;
        public const int CMSG_COMPUTED_HASH_PARAM = 22;
        public const int CMSG_ENCRYPT_PARAM = 26;
        public const int CMSG_ENCRYPTED_DIGEST = 27;
        public const int CMSG_ENCODED_SIGNER = 28;
        public const int CMSG_ENCODED_MESSAGE = 29;
        public const int CMSG_VERSION_PARAM = 30;
        public const int CMSG_ATTR_CERT_COUNT_PARAM = 31;
        public const int CMSG_ATTR_CERT_PARAM = 32;
        public const int CMSG_CMS_RECIPIENT_COUNT_PARAM = 33;
        public const int CMSG_CMS_RECIPIENT_INDEX_PARAM = 34;
        public const int CMSG_CMS_RECIPIENT_ENCRYPTED_KEY_INDEX_PARAM = 35;
        public const int CMSG_CMS_RECIPIENT_INFO_PARAM = 36;
        public const int CMSG_UNPROTECTED_ATTR_PARAM = 37;
        public const int CMSG_SIGNER_CERT_ID_PARAM = 38;
        public const int CMSG_CMS_SIGNER_INFO_PARAM = 39;
        //-------------------------------------------------------------------------
        //dwObjectType for CryptQueryObject
        //-------------------------------------------------------------------------
        public const int CERT_QUERY_OBJECT_FILE = 0x00000001;
        public const int CERT_QUERY_OBJECT_BLOB = 0x00000002;
        //-------------------------------------------------------------------------
        //dwContentType for CryptQueryObject
        //-------------------------------------------------------------------------
        //encoded single certificate
        public const int CERT_QUERY_CONTENT_CERT = 1;
        //encoded single CTL
        public const int CERT_QUERY_CONTENT_CTL = 2;
        //encoded single CRL
        public const int CERT_QUERY_CONTENT_CRL = 3;
        //serialized store
        public const int CERT_QUERY_CONTENT_SERIALIZED_STORE = 4;
        //serialized single certificate
        public const int CERT_QUERY_CONTENT_SERIALIZED_CERT = 5;
        //serialized single CTL
        public const int CERT_QUERY_CONTENT_SERIALIZED_CTL = 6;
        //serialized single CRL
        public const int CERT_QUERY_CONTENT_SERIALIZED_CRL = 7;
        //a PKCS#7 signed message
        public const int CERT_QUERY_CONTENT_PKCS7_SIGNED = 8;
        //a PKCS#7 message, such as enveloped message.  But it is not a signed message,
        public const int CERT_QUERY_CONTENT_PKCS7_UNSIGNED = 9;
        //a PKCS7 signed message embedded in a file
        public const int CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED = 10;
        //an encoded PKCS#10
        public const int CERT_QUERY_CONTENT_PKCS10 = 11;
        //an encoded PKX BLOB
        public const int CERT_QUERY_CONTENT_PFX = 12;
        //an encoded CertificatePair (contains forward and/or reverse cross certs)
        public const int CERT_QUERY_CONTENT_CERT_PAIR = 13;
        //-------------------------------------------------------------------------
        //dwExpectedConentTypeFlags for CryptQueryObject
        //-------------------------------------------------------------------------
        //encoded single certificate
        public const int CERT_QUERY_CONTENT_FLAG_CERT = (1 << CERT_QUERY_CONTENT_CERT);
        //encoded single CTL
        public const int CERT_QUERY_CONTENT_FLAG_CTL = (1 << CERT_QUERY_CONTENT_CTL);
        //encoded single CRL
        public const int CERT_QUERY_CONTENT_FLAG_CRL = (1 << CERT_QUERY_CONTENT_CRL);
        //serialized store
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE = (1 << CERT_QUERY_CONTENT_SERIALIZED_STORE);
        //serialized single certificate
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT = (1 << CERT_QUERY_CONTENT_SERIALIZED_CERT);
        //serialized single CTL
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL = (1 << CERT_QUERY_CONTENT_SERIALIZED_CTL);
        //serialized single CRL
        public const int CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL = (1 << CERT_QUERY_CONTENT_SERIALIZED_CRL);
        //an encoded PKCS#7 signed message
        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED = (1 << CERT_QUERY_CONTENT_PKCS7_SIGNED);
        //an encoded PKCS#7 message.  But it is not a signed message
        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED = (1 << CERT_QUERY_CONTENT_PKCS7_UNSIGNED);
        //the content includes an embedded PKCS7 signed message
        public const int CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED = (1 << CERT_QUERY_CONTENT_PKCS7_SIGNED_EMBED);
        //an encoded PKCS#10
        public const int CERT_QUERY_CONTENT_FLAG_PKCS10 = (1 << CERT_QUERY_CONTENT_PKCS10);
        //an encoded PFX BLOB
        public const int CERT_QUERY_CONTENT_FLAG_PFX = (1 << CERT_QUERY_CONTENT_PFX);
        //an encoded CertificatePair (contains forward and/or reverse cross certs)
        public const int CERT_QUERY_CONTENT_FLAG_CERT_PAIR = (1 << CERT_QUERY_CONTENT_CERT_PAIR);
        //content can be any type
        public const int CERT_QUERY_CONTENT_FLAG_ALL = 
           CERT_QUERY_CONTENT_FLAG_CERT |
           CERT_QUERY_CONTENT_FLAG_CTL |
           CERT_QUERY_CONTENT_FLAG_CRL |
           CERT_QUERY_CONTENT_FLAG_SERIALIZED_STORE |
           CERT_QUERY_CONTENT_FLAG_SERIALIZED_CERT |
           CERT_QUERY_CONTENT_FLAG_SERIALIZED_CTL |
           CERT_QUERY_CONTENT_FLAG_SERIALIZED_CRL |
           CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED |
           CERT_QUERY_CONTENT_FLAG_PKCS7_UNSIGNED |
           CERT_QUERY_CONTENT_FLAG_PKCS7_SIGNED_EMBED |
           CERT_QUERY_CONTENT_FLAG_PKCS10 |
           CERT_QUERY_CONTENT_FLAG_PFX |
           CERT_QUERY_CONTENT_FLAG_CERT_PAIR;
         //-------------------------------------------------------------------------
         //dwFormatType for CryptQueryObject
         //-------------------------------------------------------------------------
         //the content is in binary format
        public const int CERT_QUERY_FORMAT_BINARY = 1;
        //the content is base64 encoded
        public const int CERT_QUERY_FORMAT_BASE64_ENCODED = 2;
        //the content is ascii hex encoded with "{ASN}" prefix
        public const int CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3;
        //-------------------------------------------------------------------------
        //dwExpectedFormatTypeFlags for CryptQueryObject
        //-------------------------------------------------------------------------
        //the content is in binary format
        public const int CERT_QUERY_FORMAT_FLAG_BINARY = (1 << CERT_QUERY_FORMAT_BINARY);
        //the content is base64 encoded
        public const int CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = (1 << CERT_QUERY_FORMAT_BASE64_ENCODED);
        //the content is ascii hex encoded with "{ASN}" prefix
        public const int CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = (1 << CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED);
        //the content can be of any format
        public const int CERT_QUERY_FORMAT_FLAG_ALL =
      CERT_QUERY_FORMAT_FLAG_BINARY |
      CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED |
      CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED;
    }
    #endregion
}