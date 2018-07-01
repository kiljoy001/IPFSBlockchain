using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface IBlockHeader
    {
        //Properties
        string Hash { get; }
        string LastHash { get; }
        List<string> BlockData { get; }
        //These are set by the blockchain 
        ulong BlockNumber { get; set; }
        ulong Difficulty { get; set; }
    }
}
