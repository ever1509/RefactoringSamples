using System;

namespace SampleDemo
{
    public class DiscountManager
    {        
        public decimal ApplyDiscount(decimal price, AccountStatus accountStatus, int timeofHavingInYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForYearsInPercentage = (timeofHavingInYears > Constants.MAXIMUM_DISCOUNT_VALUE) ? (decimal)Constants.MAXIMUM_DISCOUNT_VALUE / 100 : (decimal)timeofHavingInYears / 100;
            switch (accountStatus) {
                case AccountStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;
                case AccountStatus.SimpleCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_SIMPLE_CUSTOMER);                                       
                    break;
                case AccountStatus.MostValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_MOST_VALUABLE_CUSTOMER);                       
                    break;
                case AccountStatus.ValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_VALUABLE_CUSTOMER);                      
                    break;

                default:
                    throw new NotImplementedException();

            } 
            priceAfterDiscount.ApplyDiscountForTimeOfHavingAccount(timeofHavingInYears);
            return priceAfterDiscount;
        }
    }
}
