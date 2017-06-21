namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> OrdersList { get; set; }

        public decimal Bill { get; set; }
    }
}
