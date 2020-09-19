using System;
using System.Collections.Generic;
using System.Text;
using GeneralSample.Interfaces;

namespace GeneralSample
{
    public class NotRegisteredDiscountCalcultor:IAccountDiscountCalculator
    {        
        public decimal ApplyDiscount(decimal price)
        {
            return price;
        }
    }
}
