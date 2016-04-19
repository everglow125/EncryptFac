using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptBLL
{
    /// <summary>
    /// 原名Rijndael
    /// key 为8 16 24 32位
    /// IV 为16位
    /// </summary>
    public class EncryptAES : IEncrypt
    {

        public string Encrypt(EncryptInfo model)
        {
            //Rijndael rijndael = Rijndael.Create();
            //rijndael.IV = model.Encode.GetBytes(model.Iv);
            //rijndael.Key = model.Encode.GetBytes(model.Key);
            //Byte[] bytes = model.Encode.GetBytes(model.Source);
            //string result = "";
            //using (ICryptoTransform transform = rijndael.CreateEncryptor())
            //{
            //    byte[] output = transform.TransformFinalBlock(bytes, 0, bytes.Length);
            //    result = Convert.ToBase64String(output);
            //}
            //return result;
            Byte[] plainBytes = model.Encode.GetBytes(model.Source);
            Byte[] bKey = new Byte[32];
            Array.Copy(model.Encode.GetBytes(model.Key.PadRight(bKey.Length)), bKey, bKey.Length);
            Byte[] bVector = new Byte[16];
            Array.Copy(model.Encode.GetBytes(model.Iv.PadRight(bVector.Length)), bVector, bVector.Length);
            Byte[] Cryptograph = null;
            Rijndael Aes = Rijndael.Create();
            using (MemoryStream Memory = new MemoryStream())
            {
                using (CryptoStream Encryptor = new CryptoStream(Memory,
                 Aes.CreateEncryptor(bKey, bVector),
                 CryptoStreamMode.Write))
                {
                    Encryptor.Write(plainBytes, 0, plainBytes.Length);
                    Encryptor.FlushFinalBlock();
                    Cryptograph = Memory.ToArray();
                }
            }
            return Convert.ToBase64String(Cryptograph);
        }

        public string Dencrypt(EncryptInfo model)
        {

            //Rijndael rijndael = Rijndael.Create();
            //rijndael.Key = model.Encode.GetBytes(model.Key);
            //rijndael.IV = model.Encode.GetBytes(model.Iv);
            //byte[] bytes = model.Encode.GetBytes(model.Source);
            //using (ICryptoTransform transform2 = rijndael.CreateDecryptor())
            //{
            //    byte[] decryption = transform2.TransformFinalBlock(bytes, 0, bytes.Length);
            //    return model.Encode.GetString(decryption);
            //}
            Byte[] encryptedBytes = Convert.FromBase64String(model.Source);
            Byte[] bKey = new Byte[32];
            Array.Copy(model.Encode.GetBytes(model.Key.PadRight(bKey.Length)), bKey, bKey.Length);
            Byte[] bVector = new Byte[16];
            Array.Copy(model.Encode.GetBytes(model.Iv.PadRight(bVector.Length)), bVector, bVector.Length);
            Byte[] original = null;
            Rijndael Aes = Rijndael.Create();
            using (MemoryStream Memory = new MemoryStream(encryptedBytes))
            {
                using (CryptoStream Decryptor = new CryptoStream(Memory,
                Aes.CreateDecryptor(bKey, bVector),
                CryptoStreamMode.Read))
                {
                    using (MemoryStream originalMemory = new MemoryStream())
                    {
                        Byte[] Buffer = new Byte[1024];
                        Int32 readBytes = 0;
                        while ((readBytes = Decryptor.Read(Buffer, 0, Buffer.Length)) > 0)
                        {
                            originalMemory.Write(Buffer, 0, readBytes);
                        }
                        original = originalMemory.ToArray();
                    }
                }
            }
            return model.Encode.GetString(original);
        }
    }
}
