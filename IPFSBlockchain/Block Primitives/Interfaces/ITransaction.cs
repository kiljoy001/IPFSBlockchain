using System;
using System.Collections.Generic;
using System.Text;
using MerkleTools;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    public interface ITransaction
    {
        string CalculateTransactionHash();
        string TransactionDetails();
        string[] ReturnToPool(ITransactionPool pool);
        IPermission GetPermission();
    }
}
