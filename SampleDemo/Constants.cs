using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDemo
{
    public static class Constants
    {
        public const int MAXIMUM_DISCOUNT_VALUE= 5;
        public const decimal DISCOUNT_SIMPLE_CUSTOMER = 0.1m;
        public const decimal DISCOUNT_VALUABLE_CUSTOMER = 0.5m;
        public const decimal DISCOUNT_MOST_VALUABLE_CUSTOMER = 0.7m;

        public static decimal MAXIMUN_DISCOUNT_FOR_LOYALTY { get; internal set; }
    }
}
