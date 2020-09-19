using System;
using System.Collections.Generic;
using System.Text;
using GeneralSample.Interfaces;

namespace GeneralSample
{
    public class MostValuableCustomerDiscountCalculator:IAccountDiscountCalculator
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price - (Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS * price);
        }
    }
}
