using System;
using System.Collections.Generic;
using System.Text;
using MerkleTools;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface IBlock
    {
        IBlockHeader header { get; set; }
        MerkleTree Transactions {get; set;}
        void AddTransaction(ITransaction transaction);
        string CalculateHash();
        IBlock MiningBlock(UInt64 difficulty, List<string> data);
    }
}
