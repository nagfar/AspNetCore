﻿using erp_usitronic.business.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace erp_usitronic.business.interfaces
{
    public interface ITelephoneRepository : IRepository<Telephone>
    {
        Task RemoveByPersonId(int personId);
    }
}
