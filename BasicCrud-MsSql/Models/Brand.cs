﻿namespace BasicCrud_MsSql.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int IsActive { get; set; }
    }
}
