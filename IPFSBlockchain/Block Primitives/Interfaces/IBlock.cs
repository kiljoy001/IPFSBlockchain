using System;
using System.Collections.Generic;
using System.Text;
using IPFSBlockchain.Block_Primatives;
using MerkleTools;
/// <summary>
/// Interface which defines what should be in a block object. Note the property Transactions is stored as a MerkleTree. Headers are grouped into a BlockHeader object for SOLID purposes.
/// </summary>
namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface IBlock
    {
        IBlockHeader header { get; }
        MerkleTree Transactions {get; }
        void AddTransaction(ITransaction transaction);
        string CalculateHash();
        Block MiningBlock(UInt64 difficulty, List<string> data);
    }
}
