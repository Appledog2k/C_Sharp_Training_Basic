using System;
// See https://aka.ms/new-console-template for more information

//! IF_ELSE IF_ ELSE

/*  Syntax:
   if(<Condition>) {
       Commands
   } else if (<Condition>) {
       Commands
   } else {
       Commands
   }
*/

int a,b;
Console.Write("Nhập số a: ");
a=Convert.ToInt16(Console.ReadLine());
Console.Write("Nhập số b: ");
b=Convert.ToInt16(Console.ReadLine());

if( a > b ) {
    Console.WriteLine ("A lớn hơn B");
} else if ( a < b ){
    Console.WriteLine ("A nhỏ hơn B ");
} else {
    Console.WriteLine("A bằng B");
}

//! CÂU LỆNH BA THÀNH PHẦN VỚI TOÁN TỬ

// syntax : rs = expr1 ? expr2 : expr3 ;

var c=1;
var d=2;
var e=3;
var max = (c >= d) ? (c >= e ? c : e) : ( d >= e ? d : e ) ;
Console.WriteLine($"Số lớn nhất trong ba số là {max}");

//! SWITCH --- CASE

/*
    switch (expr) {
        case expr1:
             ...commands
        break;

        case expr2:
             ...commands
        break;

        case expr3:
             ...commands
        break;
        ...
        default:
             ...commands
        break;
    }
*/
Console.WriteLine(@"
Các phép tính có thể thực hiện:
1, Tính tổng
2, Tính hiệu
3, Tính tích
4, Tính thương");

char f;

L1:

Console.WriteLine("Hãy nhập lệnh cần tính.");
f=Console.ReadKey().KeyChar;
Console.WriteLine();
Console.WriteLine($"Lệnh vừa nhập là: {f}");

switch(f) {
    case '1':
    Console.WriteLine( $"Tổng của hai số sum = {a+b}" );
    break;
    case '2':
    Console.WriteLine( $"Hiệu của hai số difference = {a-b}" );
    break;
    case '3':
    Console.WriteLine( $"Tích của hai số product = {a*b}");
    break;
    case '4':
    Console.WriteLine( $"Thương của hai số = {a/b}");
    break;
    default:
    Console.WriteLine("Không có phép tính nào được thực hiên vui lòng nhập lại.");
    goto L1;
}


