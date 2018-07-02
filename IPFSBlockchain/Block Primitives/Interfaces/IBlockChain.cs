using IPFSBlockchain.Block_Primatives;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    public interface IBlockChain
    {
        void Add(Block block);
        bool IsValid();
        Block[] ToArray();
    }
}
