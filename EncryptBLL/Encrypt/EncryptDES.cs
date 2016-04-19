using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    /// <summary>
    /// key 为8位
    /// IV 为8位
    /// </summary>
    public class EncryptDES : IEncrypt
    {

        public string Encrypt(EncryptInfo model)
        {
            string result = "";
            byte[] byKey = model.Encode.GetBytes(model.Key);
            byte[] byIV = model.Encode.GetBytes(model.Iv);
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            int i = cryptoProvider.KeySize;
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write))
            using (StreamWriter sw = new StreamWriter(cst))
            {
                sw.Write(model.Source);
                sw.Flush();
                cst.FlushFinalBlock();
                sw.Flush();
                result = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            }

            return result;
        }

        public string Dencrypt(EncryptInfo model)
        {
            string result = "";
            byte[] byKey = model.Encode.GetBytes(model.Key);
            byte[] byIV = model.Encode.GetBytes(model.Iv);
            byte[] byEnc = Convert.FromBase64String(model.Source);
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            using (MemoryStream ms = new MemoryStream(byEnc))
            using (CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read))
            using (StreamReader sr = new StreamReader(cst))
                result = sr.ReadToEnd();
            return result;
        }
        public string Check(EncryptInfo model)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(model.Key))
                sb.Append("秘钥不能为空,");
            else if (model.Key.Length != 8)
                sb.Append("秘钥长度必须为8,");
            if (!string.IsNullOrEmpty(model.Iv) && model.Iv.Length != 8)
                sb.Append("向量长度必须为8,");
            return sb.ToString();
        }
    }
}
