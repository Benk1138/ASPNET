using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public class Product
    {
         public Product()
        {
  
    }

        public int productID { get; set;}
        public int Name { get; set; }
        public int Price { get; set; }
        public int catagoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }

    }
}

