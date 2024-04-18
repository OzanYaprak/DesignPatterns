﻿namespace DesignPattern.Facade.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }


        public List<Order> Orders { get; set; }
    }
}
