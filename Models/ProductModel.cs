using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreStock.Models
{
    public class ProductModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public ProductModel()
        {
            Code = "TEE01-BL";
            Name = "Blue Dragon T-Shirt";
            Amount = 100;
            Price = 100000;
        }

        public ProductModel(string code, string name, int amount, int price)
        {
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
        }
    }
}