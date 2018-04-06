using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Public_Brute_and_Checker
{
    class Help
    {
        public static string time = System.DateTime.Now.ToString("HH_mm_ss");
        public static object lockers = new object();
        public static Random Rand = new Random();

        public static string Parsing(string strSource, string strStart, string strEnd, int startPos)
        {
            int iPos, iEnd, lenStart = strStart.Length;
            string strResult = "";

            iPos = strSource.IndexOf(strStart, startPos);
            iEnd = strSource.IndexOf(strEnd, iPos + lenStart);

            if (iPos != -1 & iEnd != -1)
            {
                strResult = strSource.Substring(iPos + lenStart, iEnd - (iPos + lenStart));
            }
            return strResult;
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static string GetProxy()
        {
            return Convert.ToString(Listing.proxyList[Rand.Next(0, Listing.proxyList.Count)]);
        }
        public static string CreateSHAHash(string PasswordSHA512)
        {
            System.Security.Cryptography.SHA512Managed sha512 = new System.Security.Cryptography.SHA512Managed();
            Byte[] EncryptedSHA512 = sha512.ComputeHash(System.Text.Encoding.UTF8.GetBytes(PasswordSHA512));
            sha512.Clear();
            return Convert.ToBase64String(EncryptedSHA512);
        }
    }
}

