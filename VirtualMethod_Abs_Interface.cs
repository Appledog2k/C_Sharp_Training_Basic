// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



MyApp.Iphone iphone01 = new MyApp.Iphone();
iphone01.TestProduct();
iphone01.GetProduct();
MyApp.Rectangle ABCD = new MyApp.Rectangle(4,5);
System.Console.WriteLine("Perimeter: " + ABCD.Perimeter());

MyApp.IGeometry EFGH = new MyApp.Rectangle(6,7);
System.Console.WriteLine("Acreage:" + EFGH.Acreage());
