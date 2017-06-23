using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Common
{
    public static class Encryptor
    {
        //Mã hóa password
        public static string EncryptorPassword(string text)
        {
            string hash = "f0xle@rn";
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    var results = Convert.ToBase64String(result, 0, result.Length);

                    return results;
                }
            }
        }
        public static string DecryptorPassword(string text)
        {
            string hash = "f0xle@rn";
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    var results = UTF8Encoding.UTF8.GetString(result);

                    return results;
                }
            }
        }
    }
}
