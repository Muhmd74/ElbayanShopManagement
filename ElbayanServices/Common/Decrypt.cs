﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ElbayanServices.Common
{
    public static class Decrypt
    {
        public static string ToDecrypt(this string password)
        {
            const string encryptionKey = "abc123";
            password = password.Replace(" ", "+");
            var cipherBytes = Convert.FromBase64String(password);
            using var encryptor = Aes.Create();
            var pdb = new Rfc2898DeriveBytes(encryptionKey,
                new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            if (encryptor == null) return password;
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using var ms = new MemoryStream();
            using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(),
                CryptoStreamMode.Write))
            {
                cs.Write(cipherBytes, 0, cipherBytes.Length);
                cs.Close();
            }

            password = Encoding.Unicode.GetString(ms.ToArray());

            return password;
        }
    }
}