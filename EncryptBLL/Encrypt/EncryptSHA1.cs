using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    public class EncryptSHA1 : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = model.Encode.GetBytes(model.Source);
            byte[] output = sha1.ComputeHash(bytes);
            string result = BitConverter.ToString(output).Replace("-", "");
            return result;
        }

        public string Dencrypt(EncryptInfo model)
        {
            throw new Exception("该方法没有实现方式");
        }
    }
}
