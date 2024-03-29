﻿namespace DesignPattern.CQRS.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int? Stock { get; set; }
        public decimal? Price { get; set; }
    }
}
