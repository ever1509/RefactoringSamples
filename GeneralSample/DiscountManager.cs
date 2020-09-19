using System;
using System.Collections.Generic;
using System.Text;
using GeneralSample.Interfaces;

namespace GeneralSample
{
    public class DiscountManager
    {
        public readonly IAccountDiscountCalculatorFactory _factory;
        public readonly ILoyaltyDiscountCalculator _loyaltyDiscountCalculator;

        public DiscountManager(IAccountDiscountCalculatorFactory factory, ILoyaltyDiscountCalculator loyaltyDiscountCalculator)
        {
            _factory = factory;
            _loyaltyDiscountCalculator = loyaltyDiscountCalculator;
        }
        public decimal ApplyDiscount(decimal price, AccountStatus accountStatus, int timeofHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            priceAfterDiscount = _factory.GetAccountDiscountCalculator(accountStatus).ApplyDiscount(price);
            return _loyaltyDiscountCalculator.ApplyDiscount(price, timeofHavingAccountInYears);         
            
        }
    }
}
