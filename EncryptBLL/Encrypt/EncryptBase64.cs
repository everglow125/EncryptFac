using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    public class EncryptBase64 : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            return Convert.ToBase64String(model.Encode.GetBytes(model.Source));
        }

        public string Dencrypt(EncryptInfo model)
        {
            return model.Encode.GetString(Convert.FromBase64String(model.Source));
        }

    }
}
