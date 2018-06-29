using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface IBlock
    {
        IBlockHeader header { get; set; }
        ITransaction transaction {get; set;}
    }
}
