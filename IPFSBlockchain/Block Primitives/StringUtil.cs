using System;
using System.Collections.Generic;
using System.Text;
using Konscious.Security.Cryptography;
using ParallelRandomClassLib;

namespace IPFSBlockchain.Block_Primatives
{
    public class StringUtil
    {
        public static string ApplyBlake2(string input)
        {
            try
            {
                var hasher = new HMACBlake2B(512);
                hasher.Initialize();
                byte[] hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for(int i=0; i <hash.Length; i++)
                {
                    string hex = String.Format("{0:X2}", hash[i]);
                    if(hex.Length >= 1)
                    {
                        builder.Append(hex);
                    }
                }
                return builder.ToString();
            }
            catch (Exception e)
            {
                Exception argEx = new Exception($"{e.Message.ToString()} error in StringUtil.applyBlake2");
                throw argEx;
            }
        }
    }
}
