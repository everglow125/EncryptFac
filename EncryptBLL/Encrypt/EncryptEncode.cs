using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EncryptBLL
{
    public class EncryptEncode : IEncrypt
    {
        public string Encrypt(EncryptInfo model)
        {
            return HttpUtility.UrlEncode(model.Source, model.Encode);
        }

        public string Dencrypt(EncryptInfo model)
        {
            return HttpUtility.UrlDecode(model.Source, model.Encode);
        }
    }
}
