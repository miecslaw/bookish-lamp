using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFrameworkSF
{
    class Products
    {
        public string productName { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }

        public Products(string productName, string unitPrice, string quantityPerUnit, string unitsInStock, string unitsOnOrder)
        {
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.quantityPerUnit = quantityPerUnit;
            this.unitsInStock = unitsInStock;
            this.unitsOnOrder = unitsOnOrder;
        }

    }
}