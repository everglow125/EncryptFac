using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    /// <summary>
    /// key的长度必须为24位
    /// </summary>
    public class Encrypt3DES : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            DES.Key = model.Encode.GetBytes(model.Key);
            DES.Mode = CipherMode.ECB;
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            byte[] Buffer = model.Encode.GetBytes(model.Source);
            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        public string Dencrypt(EncryptInfo model)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            DES.Key = model.Encode.GetBytes(model.Key);
            DES.Mode = CipherMode.ECB;
            DES.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            ICryptoTransform DESDecrypt = DES.CreateDecryptor();
            byte[] Buffer = Convert.FromBase64String(model.Source);
            return model.Encode.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        public string Check(EncryptInfo model)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(model.Key))
                sb.Append("秘钥不能为空");
            else if (model.Key.Length != 24)
                sb.Append("秘钥长度必须为24");
            return sb.ToString();
        }
    }
}
