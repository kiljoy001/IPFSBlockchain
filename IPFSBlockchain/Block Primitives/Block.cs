using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using IPFSBlockchain.Block_Primatives.Helpers;
using ParallelRandomClassLib;

namespace IPFSBlockchain.Block_Primatives
{
    public class Block
    {
        /// <summary>
        /// Implements block in blockchain
        /// Hash & Previous has exposed through properties
        /// </summary>
        /// 
        private string _hash;
        private string _previoushash;
        private List<string> _data;
        private long timestamp;
        private ulong nonce;
        private ulong _blockNumber;
        

        //Constructor
        public Block(List<string> data, string previousHash)
        {
            _data = data;
            _previoushash = previousHash;
            long epochTicks = new DateTime(1970, 1, 1,0,0,0, DateTimeKind.Utc).Ticks;
            timestamp = epochTicks / TimeSpan.TicksPerSecond;
            _hash = CalculateHash();
            _blockNumber = BlockNumber;
        }

        //Properties
        public string Hash { get { return _hash; } }
        public string LastHash { get { return _previoushash; }  }
        public List<string> BlockData { get { return _data; } }
        //These are set by the blockchain 
        public ulong BlockNumber { get; set; }
        public ulong Difficulty { get; set; }

        //Methods
        public string CalculateHash()
        {
            string createHash = StringUtil.applyBlake2
                (
                    _previoushash +
                    timestamp.ToString() +
                    nonce.ToString() +
                    ListToCSV()
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

            string target = new string(new char[difficulty]).Replace('\0', '0');
            while (!Hash.Substring(0, difficulty.ToString().Length).Equals(target))
            {
                nonce = (ulong)random.Next(biMin, biMax);
                _hash = CalculateHash();
                //testing output
                Console.WriteLine($"{_hash}");
            }
            Block newBlock = new Block(data, _hash);
            return newBlock;
        }
    }
}
