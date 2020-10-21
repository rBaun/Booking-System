using System;
using System.Collections.Generic;
using System.Text;

namespace Server.DataAccess.Interfaces
{
    /**
     * This Interface is specifically used for general store functionality.
     * Only unique store-functionality is implemented in this interface.
     */
    public interface IStoreRepos<TEntity> : ICrudRepos<TEntity>
    {
        // store-specific-features goes here...
    }
}
