using System;
using System.Collections.Generic;
using System.Text;
using Server.Entities;

namespace Server.BusinessLogic.Interfaces
{
    public interface IStoreLogic
    {
        bool ValidateStoreType(Store entity);
    }
}
