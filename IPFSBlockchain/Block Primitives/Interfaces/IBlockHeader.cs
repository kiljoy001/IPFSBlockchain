using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    public interface IBlockHeader
    {
        //Properties
        string Hash { get; }
        string LastHash { get; }
        ulong Timestamp { get; }
        //These are set by the blockchain object
        ulong BlockNumber { get; set; }
        ulong Difficulty { get; set; }
        
    }
}
