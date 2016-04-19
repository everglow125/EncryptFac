using EncryptBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptFac
{
    public partial class Form1 : Form
    {
        static List<string> encrypts = new List<string> { 
            "3DES","AES","Base64","DES","Encode","MD5_16","MD5_32","RC2","RSA","SHA1"
        };
        static List<string> encodes = new List<string> { 
            "utf-8","gb2312","default","ascii"
        };
        public Form1()
        {
            InitializeComponent();
            this.cbxType.DataSource = encrypts;
            this.cbxEncode.DataSource = encodes;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptInfo encrypt = new EncryptInfo(this.txtSource.Text, Encoding.GetEncoding(this.cbxEncode.SelectedValue.ToString()));
                encrypt.Iv = this.txtIV.Text;
                encrypt.Key = this.txtKey.Text;
                IEncrypt obj = (IEncrypt)CreateInstance("EncryptBLL.Encrypt" + this.cbxType.SelectedValue);
                this.txtPassword.Text = obj.Encrypt(encrypt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptInfo encrypt = new EncryptInfo(this.txtSource.Text, Encoding.GetEncoding(this.cbxEncode.SelectedValue.ToString()));
                encrypt.Iv = this.txtIV.Text;
                encrypt.Key = this.txtKey.Text;
                IEncrypt obj = (IEncrypt)CreateInstance("EncryptBLL.Encrypt" + this.cbxType.SelectedValue);
                this.txtPassword.Text = obj.Dencrypt(encrypt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtPassword.Text = "";
        }

        public object CreateInstance(string fullTypeName, string assemblyPath = "")
        {
            Type type = assemblyPath == "" ? Type.GetType(fullTypeName)
                                           : Assembly.LoadFile(assemblyPath).GetType(fullTypeName);
            if (type == null)
            {
                FileInfo exeFile = new FileInfo(Assembly.GetExecutingAssembly().Location);
                FileInfo[] files = exeFile.Directory.GetFiles("*.dll");
                foreach (FileInfo fi in files)
                {
                    type = GetType(fi.FullName, fullTypeName);
                    if (type != null)
                    {
                        break;
                    }
                }
            }
            if (type == null)
            {
                return null;
            }
            return Activator.CreateInstance(type);
        }

        private Type GetType(string dllFile, string fullTypeName)
        {
            Type type = Assembly.LoadFile(dllFile).GetType(fullTypeName);
            return type;
        }
    }
}
