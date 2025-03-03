﻿namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double DefaultMililiters = 50;
        private const decimal DefaultPrice = 3.50M;

        public Coffee(string name, double caffeine) 
            : base(name, DefaultPrice, DefaultMililiters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
