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

        public UInt64 calculateNext()
        {
            Block[] blockArray = _chain.ToArray();
            if(blockArray.Length > 10)
            {
                ulong sum = 0;
                for (int i = blockArray.Length - 10; i < blockArray.Length; i++)
                {
                    sum += blockArray[i].Difficulty;
                }
                return sum++ / (ulong)blockArray.Length;
            }
            else
            {
                ulong sum = 0;
                for (int i = 0; i < blockArray.Length; i++)
                {
                    sum += blockArray[i].Difficulty;
                }
                return sum++  + (ulong)_chain.Count / (ulong)blockArray.Length;
            }
            
        }
    }
}
