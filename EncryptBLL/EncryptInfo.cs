using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    public class EncryptInfo
    {
        public EncryptInfo(string source)
        {
            this.Source = source;
            this.Encode = Encoding.Default;
        }

        public EncryptInfo(string source, Encoding encode)
        {
            this.Source = source;
            this.Encode = encode;
        }
        public string Source { get; set; }
        public string Key { get; set; }
        public string Iv { get; set; }
        public Encoding Encode { get; set; }
    }
}
