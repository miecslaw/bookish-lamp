namespace WebDriverFramework.Business_object
{
    class Products
    {
        public string productName { get; set; }
        public string categoryName { get; set; }
        public string supplierName { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsInOrder { get; set; }

        public Products(string productName,
                         string unitPrice,
                         string quantityPerUnit,
                         string unitInStock,
                         string unitInOrder)
        {
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.quantityPerUnit = quantityPerUnit;
            this.unitsInStock = unitInStock;
            this.unitsInOrder = unitInOrder;
        }
    }
}
