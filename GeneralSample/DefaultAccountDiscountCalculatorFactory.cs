using System;
using System.Collections.Generic;
using System.Text;
using GeneralSample.Interfaces;

namespace GeneralSample
{
    public class DefaultAccountDiscountCalculatorFactory : IAccountDiscountCalculatorFactory
    {
        public IAccountDiscountCalculator GetAccountDiscountCalculator(AccountStatus accountStatus)
        {
            IAccountDiscountCalculator calculator;
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    calculator = new NotRegisteredDiscountCalcultor();
                    break;
                case AccountStatus.SimpleCustomer: 
                    calculator= new SimpleCustomerDiscountCalculator();
                    break;
                case AccountStatus.ValuableCustomer:
                    calculator = new ValuableCustomerDiscountCalculator();
                    break;
                case AccountStatus.MostValuableCustomer:
                    calculator= new MostValuableCustomerDiscountCalculator();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return calculator;
        }
    }
}