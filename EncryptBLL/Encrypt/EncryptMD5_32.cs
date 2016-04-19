using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    public class EncryptMD5_32 : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            byte[] result = model.Encode.GetBytes(model.Source);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

        public string Dencrypt(EncryptInfo model)
        {
            throw new Exception("该方法没有实现方式");
        }
        public string Check(EncryptInfo model)
        {
            return "";
        }
    }
}
