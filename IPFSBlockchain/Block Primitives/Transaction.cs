using IPFSBlockchain.Block_Primitives.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives
{
    public class Transaction : ITransaction
    {
        private string _hash;
        private decimal _fee;
        private IPermission permission;

        public Transaction()
        {

        }
        public decimal Fee { get => _fee; set { _fee = value; } }

        public string CalculateTransactionHash()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(ITransaction other)
        {
            throw new NotImplementedException();
        }

        public IPermission GetPermission()
        {
            throw new NotImplementedException();
        }

        public string[] ReturnToPool(ITransactionPool pool)
        {
            throw new NotImplementedException();
        }

        public string TransactionDetails()
        {
            throw new NotImplementedException();
        }
    }
}
