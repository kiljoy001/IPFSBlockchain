using IPFSBlockchain.Block_Primitives.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ParallelRandomClassLib;
using System.Numerics;
using IPFSBlockchain.Block_Primatives;

namespace IPFSBlockchain.Block_Primitives
{
    public class Transaction : ITransaction
    {
        private string _hash;
        private readonly IPermission _permission;
        private readonly PRNG nonce;

        public Transaction(decimal Fee, IPermission permission)
        {
            this.Fee = Fee;
            _permission = permission;
            nonce = new PRNG();
            _hash = CalculateTransactionHash();
            
        }
        public decimal Fee { get;  private set; }

        public string CalculateTransactionHash()
        {
            string input =
            Fee.ToString() +
            _permission.GetPermission() +
            nonce.Next(new BigInteger(ulong.MinValue), new BigInteger(ulong.MaxValue)).ToString();

            return StringUtil.ApplyBlake2(input);
        }

        public int CompareTo(ITransaction other)
        {
            if (Fee > other.Fee) return -1;
            if (Fee == other.Fee) return 0;
            return 1;
        }

        public IPermission GetPermission()
        {
            return _permission;
        }

        public ITransaction ReturnToPool(ITransactionPool pool)
        {
            throw new NotImplementedException();
        }

        public string TransactionDetails()
        {
            throw new NotImplementedException();
        }
    }
}
