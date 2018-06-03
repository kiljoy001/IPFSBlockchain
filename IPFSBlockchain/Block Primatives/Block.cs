using System;
using System.Collections.Generic;
using System.Text;

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
        private uint nonce;

        //Constructor
        public Block(List<string> data, string previousHash)
        {
            _data = data;
            _previoushash = previousHash;
            long epochTicks = new DateTime(1970, 1, 1,0,0,0, DateTimeKind.Utc).Ticks;
            timestamp = epochTicks / TimeSpan.TicksPerSecond;
            _hash = CalculateHash();
        }

        //Properties
        public string Hash { get { return _hash; } }
        public string LastHash { get { return _previoushash; }  }
        public List<string> BlockData { get { return _data; } }

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
        public void MiningBlock(int difficulty)
        {
            string target = new string(new char[difficulty]).Replace('\0', '0');
            while(!Hash.Substring(0,difficulty).Equals(target))
            {
                nonce++;
                _hash = CalculateHash();
            }
        }
    }
}
