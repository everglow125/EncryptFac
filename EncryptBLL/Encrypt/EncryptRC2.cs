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
    /// IV为8位
    /// key为5-16位
    /// </summary>
    public class EncryptRC2 : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            byte[] bytesIV = model.Encode.GetBytes(model.Iv);
            RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider();
            byte[] bytesInput = model.Encode.GetBytes(model.Source);
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, rc2.CreateEncryptor(model.Encode.GetBytes(model.Key),
                 bytesIV), CryptoStreamMode.Write))
            {
                cs.Write(bytesInput, 0, bytesInput.Length);
                cs.FlushFinalBlock();
                var result = Convert.ToBase64String(ms.ToArray());
                return result;
            }

        }

        public string Dencrypt(EncryptInfo model)
        {
            byte[] bytesIV = model.Encode.GetBytes(model.Iv);
            RC2CryptoServiceProvider rc2 = new RC2CryptoServiceProvider();
            byte[] bytesInput = Convert.FromBase64String(model.Source);
            using (MemoryStream ms = new MemoryStream())
            using (CryptoStream cs = new CryptoStream(ms, rc2.CreateDecryptor(Encoding.Default.GetBytes(model.Key),
                     bytesIV), CryptoStreamMode.Write))
            {
                cs.Write(bytesInput, 0, bytesInput.Length);
                cs.FlushFinalBlock();
                string result = model.Encode.GetString(ms.ToArray());
                return result;
            }
        }
        public string Check(EncryptInfo model)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(model.Key))
                sb.Append("秘钥不能为空,");
            else if (model.Key.Length < 5 || model.Key.Length > 16)
                sb.Append("秘钥长度必须为5-16之间,");
            if (!string.IsNullOrEmpty(model.Iv) && model.Iv.Length != 8)
                sb.Append("向量长度必须为8,");
            return sb.ToString();
        }
    }
}
