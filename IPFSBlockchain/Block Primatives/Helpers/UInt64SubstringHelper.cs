using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primatives.Helpers
{
    public static class UInt64SubstringHelper
    {
        public static String UInt64Substring(this String str, int startIndex, UInt64 length)
        {
            char[] charArray = new char[length.ToString().Length - startIndex];
            Buffer.BlockCopy(length.ToString().ToCharArray(), startIndex * sizeof(char),
                             charArray, 0, (length.ToString().Length - startIndex) * sizeof(char));
            return new String(charArray);
        }
    }
}
