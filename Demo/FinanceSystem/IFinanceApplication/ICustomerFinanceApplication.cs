﻿using System;
using IFinanceApplication.DTOs;
using Zaaby.Core;

namespace IFinanceApplication
{
    public interface ICustomerFinanceApplication : IZaabyAppService
    {
        bool Charge(CustomerChargeParam param);

        Guid GetId();
    }
}