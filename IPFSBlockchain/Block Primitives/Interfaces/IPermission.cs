using System;
using System.Collections.Generic;
using System.Text;

namespace IPFSBlockchain.Block_Primitives.Interfaces
{
    public enum EPermissions
    {
        Global,
        ShareToOne,
        ShareToMany,
        Group,
        ShareToGroup
    }

    public interface IPermission
    {
        void SetPermission(EPermissions Permission);
        Tuple<IPermission> GetPermission();
    }
}
