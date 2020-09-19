using System;
using System.Collections.Generic;
using System.Text;
using GeneralSample.Interfaces;

namespace GeneralSample
{
    public class DefaultLoyaltyDiscountCalculator:ILoyaltyDiscountCalculator
    {
        public decimal ApplyDiscount(decimal price, int timeOfHavingAccountInYears)
        {
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > Constants.MAXIMUN_DISCOUNT_FOR_LOYALTY)
                ? (decimal)Constants.MAXIMUN_DISCOUNT_FOR_LOYALTY / 100
                : (decimal)timeOfHavingAccountInYears / 100;

            return price - (discountForLoyaltyInPercentage * price);
        }
    }
}
