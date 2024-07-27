using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarangayHealthAid;
using BarangayHealthAid.Core;
using System.Security.Cryptography;
using System.IO;

namespace BarangayHealthAid.Sop
{
    public static class Encryption
    {
        public static String key = PublicVariables.SecurityKey;

        //checker if sakto ang Code
        //public static bool EncryptionCode(this string Key)
        //{
        //    if (Key == keycheck)
        //        return true;
        //    else
        //        return false;
        //}

        public static string EncryptString(this string String)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(String);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string DecryptString(this string cipherText)
        {
            byte[] data = Convert.FromBase64String(cipherText);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
