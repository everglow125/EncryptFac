using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    /// <summary>
    /// 生成的密文每次都会不同
    /// </summary>
    public class EncryptRSA : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(model.Key);
            cipherbytes = rsa.Encrypt(model.Encode.GetBytes(model.Source), false);
            return Convert.ToBase64String(cipherbytes);
        }

        public string Dencrypt(EncryptInfo model)
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(model.Key);
            cipherbytes = rsa.Decrypt(Convert.FromBase64String(model.Source), false);
            return model.Encode.GetString(cipherbytes);
        }
    }
}
