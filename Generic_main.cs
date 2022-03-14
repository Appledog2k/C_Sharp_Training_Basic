// See https://aka.ms/new-console-template for more information
double a=5;
double b=50;

System.Console.WriteLine($"a: {a}, b: {b}");


Generic.Generic.Swap(ref a, ref b);

// able chose T = double
Generic.Generic.Swap<double>(ref a, ref b);

System.Console.WriteLine($"a: {a}, b: {b}");

Generic01.Product<string> product01 = new Generic01.Product<string>();
product01.SetID("fun");
product01.PrintID();

Generic01.Product<int> product02 =new Generic01.Product<int>();
product02.SetID(123);
product02.PrintID();


List<int>  list01 = new List<int>();
Stack<int> stack;
Queue<double> queue;
list01.Add(1);
System.Console.WriteLine(list01[0]);

