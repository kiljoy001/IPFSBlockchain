using IPFSBlockchain.Block_Primitives.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives
{
    class Header : IBlockHeader
    {
        private string _hash;
        private string _previousHash;
        private ulong _bnumber;
        private ulong _difficulty;
        private ulong _timestamp;

        public Header(string hash, string previousHash, ulong blocknumber, ulong difficulty, ulong time)
        {
            _hash = hash;
            _previousHash = previousHash;
            _bnumber = blocknumber;
            _difficulty = difficulty;
            _timestamp = time;
        }

        //Properties
        public string Hash => _hash;
        public string LastHash => _previousHash;
        public ulong BlockNumber { get => _bnumber; set { _bnumber = value; } }
        public ulong Difficulty { get => _difficulty; set { _difficulty = value; } }
        public ulong Timestamp => _timestamp;
    }
}
