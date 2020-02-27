﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TastyAndHealthy.Models
{
    public class DishProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
