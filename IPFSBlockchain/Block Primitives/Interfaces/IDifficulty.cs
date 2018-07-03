using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    interface IDifficulty
    {
        UInt64 calculateNext();
    }
}
