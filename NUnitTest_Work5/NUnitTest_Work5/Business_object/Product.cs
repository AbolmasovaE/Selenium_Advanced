using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Work5
{
    class Products
    {
        public string nameProduct { get; set; }
        public string costUnitPrice { get; set; }
        public string numberQuantityPerUnit { get; set; }
        public string numberUnitsInStock { get; set; }
        public string numberUnitsOnOrder { get; set; }
        public string numberReorderLevel { get; set; }

        public Products(string nameProduct, string costUnitPrice, string numberQuantityPerUnit, string numberUnitsInStock, string numberUnitsOnOrder, string numberReorderLevel)
        {
            this.nameProduct = nameProduct;
            this.costUnitPrice = costUnitPrice;
            this.numberQuantityPerUnit = numberQuantityPerUnit;
            this.numberUnitsInStock = numberUnitsInStock;
            this.numberUnitsOnOrder = numberUnitsOnOrder;
            this.numberReorderLevel = numberReorderLevel;
        }

    }
}