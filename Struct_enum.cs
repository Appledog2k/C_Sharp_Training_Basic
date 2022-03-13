// See https://aka.ms/new-console-template for more information
//struct
// struct is pass by value ==- create new value by copying the original

//use Product
Struct.Product Product01;
Product01.nameProduct = "Iphone";
Product01.priceProduct = 500;



Struct.Product Product02 = new Struct.Product("Nokia", 200);





System.Console.WriteLine(Product01.GetInfo());
System.Console.WriteLine(Product02.GetInfo());
System.Console.WriteLine(Product02.Info);


