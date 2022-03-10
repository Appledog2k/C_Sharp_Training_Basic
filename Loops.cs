// See https://aka.ms/new-console-template for more information


//! FOR LOOP
/* 
for ( Initialization; Condition; Update ) {
  ...Commands...
}
*/

// printf Hello, World !
 for(int i=1 ; i<=10 ; i++) {
     Console.WriteLine($"Giá trị của i là: {i}");
     Console.WriteLine("Hello, World!");
}

// printf tất cả các số chẵn từ 0-a
int a;
Console.Write("Nhập vào số a:");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Số a vừa nhập là: {a}");
for(int i=0; i<=a ;i++) {
    if(i % 2 != 0) continue;
    Console.WriteLine($"{i} là số chẵn");
}

