namespace MyApp
{   // interface === abstract
    // Method in a interface only need to declare a name
    // A class another inherit interface must implement its 
    interface IGeometry
    {
        public double Perimeter();
        public double Acreage();
    }

    // Implement from interface
    // Can be implemented from multiple interfaces
    public class Rectangle : IGeometry
    {
        public double Perimeter() =>  2*(A+B);
        public double Acreage() => A*B;
        public Rectangle()
        {
        }

        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b;

        }
        public double A { get; set; }
        public double B { get; set; }
    }
}