﻿using System.ComponentModel.DataAnnotations;

namespace InvMgmt.Models
{
    public class Product
    {
   
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Quantity { get; set; } = 0;
    }
}
