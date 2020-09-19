using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDemo
{
    public static class priceExtensions
    {
        public static decimal ApplyDiscountForAccountStatus(this decimal price, decimal discountSize)
        {
            return price - (discountSize * price);
        }

        public static decimal ApplyDiscountForTimeOfHavingAccount(this decimal price, int timeOfHavingAccountYears)
        {
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountYears > Constants.MAXIMUN_DISCOUNT_FOR_LOYALTY)
                ? (decimal)Constants.MAXIMUN_DISCOUNT_FOR_LOYALTY / 100
                : (decimal)timeOfHavingAccountYears / 100;

            return price - (discountForLoyaltyInPercentage * price);
        }
    }
}
