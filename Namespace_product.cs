namespace Product {
    public partial class Product {
        public string nameProduct { get; set; }
        public decimal priceProduct { get; set; }
        public string GetInfo(){
            
            return $"name: {nameProduct}, price: {priceProduct}, description: {description}";
        }
    }
}