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
        public int TotalAmount { get; set; }
        public int ReadyAmount { get; set; }
        public int OrderedAmount { get; set; }
        public int SoldAmount { get; set; }
        public float Price { get; set; }

        public ProductModel()
        {
            Code = "TEE01-BL";
            Name = "Blue Dragon T-Shirt";
            TotalAmount = 100;
            ReadyAmount = 90;
            OrderedAmount = 8;
            SoldAmount = 10;
            Price = 100000;
        }

        public ProductModel(string code, string name, int totalAmount, int readyAmount, int orderedAmount, int soldAmount, float price)
        {
            Code = code;
            Name = name;
            TotalAmount = totalAmount;
            ReadyAmount = readyAmount;
            OrderedAmount = orderedAmount;
            SoldAmount = soldAmount;
            Price = price;
        }
    }
}