namespace WebDriver_Basic.Business_object
{
    class Products
    {
        public string productName { get; set; }
        public string categoryName { get; set; }
        public string supplierName { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitInStock { get; set; }
        public string unitInOrder { get; set; }

        public Products (string productName,
                         string categoryName,
                         string supplierName,
                         string unitPrice,
                         string quantityPerUnit,
                         string unitInStock,
                         string unitInOrder)
        {
            this.productName = productName;
            this.categoryName = categoryName;
            this.supplierName = supplierName;
            this.unitPrice = unitPrice;
            this.quantityPerUnit = quantityPerUnit;
            this.unitInStock = unitInStock;
            this.unitInOrder = unitInOrder;
        }
    }
}
