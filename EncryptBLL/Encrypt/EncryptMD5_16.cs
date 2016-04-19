using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    public class EncryptMD5_16 : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string result = BitConverter.ToString(md5.ComputeHash(model.Encode.GetBytes(model.Source)), 4, 8);
            result = result.Replace("-", "");
            return result;
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
