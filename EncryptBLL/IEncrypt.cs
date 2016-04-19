using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    public interface IEncrypt
    {
        string Encrypt(EncryptInfo model);
        string Dencrypt(EncryptInfo model);
    }
}
