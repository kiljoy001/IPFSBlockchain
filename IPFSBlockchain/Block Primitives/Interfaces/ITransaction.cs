using System;
using System.Collections.Generic;
using System.Text;
using MerkleTools;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface ITransaction
    {
        MerkleTree tree { get; set; }
        string CalculateTransactionHash();
        void AddTransaction();
        string ReturnToPool();
    }
}
