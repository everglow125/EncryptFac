using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptBLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace EncryptBLL.Tests
{
    [TestClass()]
    public class EncryptRSATests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            IEncrypt encrypt = new EncryptRSA();
            EncryptInfo pwd = new EncryptInfo("123456", Encoding.UTF8);
            //pwd.Key = @"<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
            //var result = encrypt.Encrypt(pwd);
            //var result1 = new EncryptSHA1().Encrypt(pwd);
            //pwd.Source = "us=张三&xin=113";
            //var result2 = new EncryptEncode().Encrypt(pwd);
            //Assert.AreEqual("us%3d%e5%bc%a0%e4%b8%89%26xin%3d113", result2);
            //Assert.AreEqual("7c4a8d09ca3762af61e59520943dc26494f8941b", result1.ToLower());
            pwd.Key = "12345678901234567890ab";
            pwd.Iv = "1234567890abcd";
            var temp = new EncryptAES().Encrypt(pwd);
            pwd.Source = temp;
            var temp2 = new EncryptAES().Dencrypt(pwd);
        }
        [TestMethod()]
        public void DencryptTest()
        {
            IEncrypt encrypt = new EncryptRSA();
            EncryptInfo pwd = new EncryptInfo("QNKz7wMTPJt0UVfOtat0e/az3DrBs00kybYWaC2dhPn+dGATC7xkyBPXitiZfJHxcefunio4aW1Oc3BlC3QIggo/XT2cRE3lRsClOOxyrrTHWmynYkF4pSKr/xIl64fdjm+taOAJHjdeg6iW5V4AMEpnYLNwLoIQCwzNU5+o5yM=", Encoding.UTF8);
            pwd.Key = @"<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent><P>/hf2dnK7rNfl3lbqghWcpFdu778hUpIEBixCDL5WiBtpkZdpSw90aERmHJYaW2RGvGRi6zSftLh00KHsPcNUMw==</P><Q>6Cn/jOLrPapDTEp1Fkq+uz++1Do0eeX7HYqi9rY29CqShzCeI7LEYOoSwYuAJ3xA/DuCdQENPSoJ9KFbO4Wsow==</Q><DP>ga1rHIJro8e/yhxjrKYo/nqc5ICQGhrpMNlPkD9n3CjZVPOISkWF7FzUHEzDANeJfkZhcZa21z24aG3rKo5Qnw==</DP><DQ>MNGsCB8rYlMsRZ2ek2pyQwO7h/sZT8y5ilO9wu08Dwnot/7UMiOEQfDWstY3w5XQQHnvC9WFyCfP4h4QBissyw==</DQ><InverseQ>EG02S7SADhH1EVT9DD0Z62Y0uY7gIYvxX/uq+IzKSCwB8M2G7Qv9xgZQaQlLpCaeKbux3Y59hHM+KpamGL19Kg==</InverseQ><D>vmaYHEbPAgOJvaEXQl+t8DQKFT1fudEysTy31LTyXjGu6XiltXXHUuZaa2IPyHgBz0Nd7znwsW/S44iql0Fen1kzKioEL3svANui63O3o5xdDeExVM6zOf1wUUh/oldovPweChyoAdMtUzgvCbJk1sYDJf++Nr0FeNW1RB1XG30=</D></RSAKeyValue>";
            var result = encrypt.Dencrypt(pwd);
            Assert.AreEqual("123456", result);
        }
    }
}
