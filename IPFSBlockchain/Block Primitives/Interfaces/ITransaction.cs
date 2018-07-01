using System;
using System.Collections.Generic;
using System.Text;
using MerkleTools;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface ITransaction
    {
        string CalculateTransactionHash();
        string TransactionDetails();
        string[] ReturnToPool(ITransactionPool pool);
    }
}
