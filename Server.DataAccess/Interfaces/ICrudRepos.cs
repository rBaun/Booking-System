using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Server.DataAccess.Interfaces
{
    /**
     * A Generic Interface for CRUD implementation.
     */
    public interface ICrudRepos<TEntity>
    {
        Func<IDbConnection> Connection { get; set; }

        TEntity Create(TEntity entity);
        TEntity Get(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
