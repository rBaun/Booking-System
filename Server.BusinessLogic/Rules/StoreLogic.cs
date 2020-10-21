using System;
using System.Collections.Generic;
using System.Text;
using Server.BusinessLogic.Interfaces;
using Server.Entities;

namespace Server.BusinessLogic.Rules
{
    /**
     * Used to ensure the business rules is implemented.
     */
    public class StoreLogic : IStoreLogic
    {
        public bool ValidateStoreType(Store entity)
        {
            throw new NotImplementedException();
        }
    }
}
