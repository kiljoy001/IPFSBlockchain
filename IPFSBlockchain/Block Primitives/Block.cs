using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using IPFSBlockchain.Block_Primatives.Helpers;
using IPFSBlockchain.Block_Primitives;
using IPFSBlockchain.Block_Primitives.Interfaces;
using MerkleTools;
using ParallelRandomClassLib;

namespace IPFSBlockchain.Block_Primatives
{
    public class Block : IBlock
    {
        /// <summary>
        /// Implements block in blockchain
        /// Hash & Previous has exposed through properties
        /// </summary>
        /// 
        private Header _header;
        private List<string> _data;
        private MerkleTree _tree;
        private ulong nonce;

        //Constructor
        public Block(List<string> data, IBlockHeader header)
        {
            _tree = new MerkleTree();
            _header = (Header)header;
        }

        //Properties
        public string Hash { get { return header.Hash; } }
        public string LastHash { get { return header.LastHash; }  }
        public List<string> BlockData { get { return _data; } }
        //These are set by the blockchain 
        public ulong BlockNumber { get; set; }
        public ulong Difficulty { get; set; }
        public IBlockHeader header { get => _header; }
        public MerkleTree Transactions { get { return _tree; } }

        //Add Transactions to the block
        public void AddTransaction(ITransaction transaction)
        {
            throw new NotImplementedException();
        }

        //Methods
        public string CalculateHash()
        {
            string createHash = StringUtil.applyBlake2
                (
                    header.LastHash +
                    header.Timestamp.ToString() +
                    nonce.ToString() +
                    ListToCSV() +
                    _tree.ToString()
                );
            return createHash;
        }

        //Return data as one csv string
        public string ListToCSV()
        {
            if (_data.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string item in _data)
                {
                    sb.Append($"{item};");
                }
                return sb.ToString();
            }
            else return "";
        }

        //Create new Blocks
        public Block MiningBlock(UInt64 difficulty, List<string> data)
        {
            PRNG random = new PRNG();
            ulong max = ulong.MaxValue;
            ulong min = ulong.MinValue;
            BigInteger biMin = new BigInteger(min);
            BigInteger biMax = new BigInteger(max);
            string hashCache = null;

            string target = new string(new char[difficulty]).Replace('\0', '0');
            while (!Hash.Substring(0, difficulty.ToString().Length).Equals(target))
            {
                nonce = (ulong)random.Next(biMin, biMax);
                hashCache = CalculateHash();
                //testing output
                Console.WriteLine($"{hashCache}");
            }
            //Create time
            long epochTicks = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
            ulong timestamp = (ulong)(epochTicks / TimeSpan.TicksPerSecond);
            //New block header
            Header blockHeaderConstructor = new Header(CalculateHash(), this.Hash, this.BlockNumber++, difficulty, timestamp);
            //Data & Header to make new block
            Block newBlock = new Block(data, blockHeaderConstructor);
            return newBlock;
        }

       

    }
}
