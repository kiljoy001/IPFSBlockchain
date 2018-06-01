using System;
using System.Collections.Generic;
using System.Text;
using Konscious.Security.Cryptography;

namespace IPFSBlockchain.Block_Primatives
{
    public class StringUtil
    {
        public static string applyBlake2(string input)
        {
            try
            {
                var hasher = new HMACBlake2B(512);
                hasher.Initialize();
                byte[] hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for(int i=0; i <hash.Length; i++)
                {
                    string hex = String.Format("{0:X}", hash[i]);
                    if(hex.Length == 1)
                    {
                        builder.Append(hex);
                    }
                }
                return builder.ToString();
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new ArgumentException("Input error in applyBlake2", "input", e);
                throw argEx;
            }
        }
    }
}
