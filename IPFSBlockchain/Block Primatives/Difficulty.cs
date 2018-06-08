using System;
using System.Collections.Generic;
using System.Text;
using IPFSBlockchain.Block_Primatives;

namespace IPFSBlockchain.Block_Primatives
{
    public class Difficulty
    {
        private UInt64 _currentDifficulty;
        private UInt64 _updatedDifficulty;
        private Blockchain _chain;

        public Difficulty(UInt64 difficulty, Blockchain chain)
        {
            _currentDifficulty = difficulty;
            _chain = chain;
        }

        private UInt64 calculateNext()
        {
            Block lastBlock = _chain.LastBlock.Previous.Value;

            //Last 10 blocks
            Block[] last10 = new Block[9];
            for(long i =0; i > last10.Length; i++)
            {
                last10[i] = -_chain.LastBlock.
            }

        }
    }
}
