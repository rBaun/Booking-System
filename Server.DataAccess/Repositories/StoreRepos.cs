using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Server.DataAccess.Interfaces;
using Server.Entities;
using Server.Entities.HairSalon;

namespace Server.DataAccess.Repositories
{
    public class StoreRepos : IStoreRepos<Store>
    {
        public Func<IDbConnection> Connection { get; set; }

        public Store Create(Store entity)
        {
            throw new NotImplementedException();
        }

        public Store Get(Store entity)
        {
            throw new NotImplementedException();
        }

        public Store Update(Store entity)
        {
            throw new NotImplementedException();
        }

        public Store Delete(Store entity)
        {
            throw new NotImplementedException();
        }
    }
}
