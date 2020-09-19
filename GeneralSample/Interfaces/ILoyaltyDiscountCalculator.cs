using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralSample.Interfaces
{
    public interface ILoyaltyDiscountCalculator
    {
        decimal ApplyDiscount(decimal price, int timeOfHavingAccountInYears);
    }
}
