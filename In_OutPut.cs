// See https://aka.ms/new-console-template for more information

//! OUTPUT_DATA
// C# cung cấp sẵn 1 lớp tên là Console (System.console) chứa một phương thức tĩnh để nhập/xuất dữ liệu với dòng lệnh terminal

// 1. Console.Write(value) : in value ra màn hình nhưng không xuống dòng mới.
Console.Write("hello! lecture 1: Output");

// 2. Console.WriteLine(value): in value ra màn hình sau đó xuống dòng.
Console.WriteLine("Hello ! I am Hung");

// 3. Console.ForegroundColor: thuộc tính để gán màu chữ xuất ra
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Hello ! I am Hung");

// 4. Console.ReserColor(): đưa Console về màu mặc định
Console.ResetColor();
Console.WriteLine("Hello ! I am Hung");

//! TIPS

// Dùng format string để tạo ra chuỗi nhằm giảm thiểu dòng code
int a =5;
double b = 123.456;
Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);
Console.WriteLine($"Sum a,b: a+b = {a+b}");


//! INPUT_DATA

// 1. Console.Readline();  cho phép nhập dữ liệu cho đến khi nhấn ENTER

Console.Write("Nhập username: ");
Console.WriteLine($"Tên vừa nhập: {Console.ReadLine()}");

// 2. Console.Readkey(); trả về thông tin phím bấm khi người dùng bấm
//    Console.Readkey().KeyChar để lấy mã người dùng nhập vào là một kí tự 
Console.ReadKey();
char Ki_Tu = Console.ReadKey().KeyChar;

//! DATA TYPE CONVERSION (có 2 hàm chính)
// hàm Console.Readline() mặc định trả về string nếu muốn chuỗi nhập chuyển thành kiểu dữ liệu khác
// thì cần các hàm chuyển

// 1. Hàm Convert. <kiểu dữ liệu cần chuyển> (value);
Console.Write("Nhập vào tuổi của bạn!");
int tuoi = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"Tuổi của bạn là {tuoi}");

// 2. Hàm Parse: <kiểu dữ liệu cần chuyển>. Parse(value);

Console.Write("Nhập vào tuổi của bạn!");
int tuoi1 = Int16.Parse(Console.ReadLine());
Console.WriteLine($"Tuổi của bạn là {tuoi1}");


//! KHAI BÁO BIẾN NGẦM ĐỊNH VỚI VAR

// Syntax : var <name_var> = <value>;
// kiểu của biến được xác định bẳng kiểu của giá trị được gán cho nó


//! HẰNG SỐ TRONG c#
// hằng số lưu trữ các giá trị mà không thay đổi đươck nữa 
const string MON ="Thứ Hai";














