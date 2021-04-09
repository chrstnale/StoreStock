using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreStock.Models
{
    public class ProductModel
    {
        [Required]
        public int ID  { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int Price { get; set; }

        public ProductModel()
        {
            ID = 0;
            Code = "Product Code";
            Name = "Product Name";
            Amount = 0;
            Price = 0;
        }

        public ProductModel(int id, string code, string name, int amount, int price)
        {
            ID = id;
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
        }
    }
}