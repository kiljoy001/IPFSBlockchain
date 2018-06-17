using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primatives.Helpers
{
    public static class LinkedListCount64 
    {
        public static ulong Count64(this LinkedList<Block> list)
        {
            int total = list.Count;
            return Convert.ToUInt64(total);
        }

    }
}
