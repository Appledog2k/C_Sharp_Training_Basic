namespace Struct
{
    public struct Product
    {
        // data
        public string nameProduct;
        public double priceProduct;
        public string Info
        {
            get
            {
                return $"{nameProduct}, {priceProduct}";
            }
        }
        // method
        public string GetInfo()
        {
            return $"Name Product: {nameProduct} , Price Product: {priceProduct}";
        }

        // constructor
        public Product(string nameProduct, double priceProduct)
        {
            this.nameProduct = nameProduct;
            this.priceProduct = priceProduct;
        }

    }
}