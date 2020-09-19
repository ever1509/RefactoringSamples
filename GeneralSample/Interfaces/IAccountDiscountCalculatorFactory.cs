using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralSample.Interfaces
{
    public interface IAccountDiscountCalculatorFactory
    {
        IAccountDiscountCalculator GetAccountDiscountCalculator(AccountStatus accountStatus);
    }
}
