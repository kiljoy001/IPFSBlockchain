using System;
using System.Collections.Generic;
using System.Text;
using MerkleTools;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    public interface ITransaction : IComparable<ITransaction>
    {
        string CalculateTransactionHash();
        string TransactionDetails();
        ITransaction ReturnToPool(ITransactionPool pool);
        IPermission GetPermission();
        decimal Fee { get; }
    }
}
