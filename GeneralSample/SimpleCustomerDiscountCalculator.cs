using System;
using System.Collections.Generic;
using System.Text;
using GeneralSample.Interfaces;

namespace GeneralSample
{
    public class SimpleCustomerDiscountCalculator:IAccountDiscountCalculator
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price - (Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS * price);
        }
    }
}
