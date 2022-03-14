using System.Threading.Tasks.Dataflow;
// See https://aka.ms/new-console-template for more information
using Namespace_example;
using Mynamespace= Namespace_example.Abc;
Namespace_example.NameSpa.Hi();
Mynamespace.NameSpaAbc.Hi();


Product.Product product01 =new Product.Product();
product01.nameProduct = "Ipad";
product01.priceProduct =100;
product01.description= " No mess";



System.Console.WriteLine(product01.GetInfo());
