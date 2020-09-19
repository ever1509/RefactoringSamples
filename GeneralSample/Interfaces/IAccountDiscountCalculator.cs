using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralSample.Interfaces
{
    public interface IAccountDiscountCalculator
    {
        decimal ApplyDiscount(decimal price);
    }
}
