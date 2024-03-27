﻿namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetAllProductQueryResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }
        public decimal? Price { get; set; }
    }
}
