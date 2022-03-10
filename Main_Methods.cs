// See https://aka.ms/new-console-template for more information
/* Phương thức Method gần giống hàm func trong lập trình hướng thủ tục
   Phương thức có thể thuộc một lớp nào đó, hoặc không tuy nhiên khai báo phương thức thì phải khai báo trong một lớp nào đó.
Hay có thể nói:
   Method chính là các hàm (func) được tạo trong class
   Tên của phương thức thường được đặt theo tên của hành động
   <Access Modifiers> <return type> <name_method> (<paramethers>) {
       ..các câu lệnh trong phương thưucs
   }
Notes:
+Access Modifies: -cho biết cấp độ được phép truy cập đến hàm này
                  -có các lever : public (cho phép bên ngoài truy cập tới phương thức)
                                 private (chỉ nội bộ những phương thức trong một lớp được gọi tới phương thức này)
                                 protect (chỉ cho phép lớp này or các lớp kế thừa từ lớp được truy cập)
                                 , internal
                 -Nếu thiếu thành phần này thì mặc định coi là internal(truy cập được ở các file cùng assembly cùng file code)
                 -Nếu cho từ khóa STATIC trước  Access Modifiers thì phương thức (hàm) đó được gọi là phương thức tĩnh (truy cập được mà không cần tạo đối tượng lớp)
                 - Thường dùng kèm AM tên public để tạo các hàm chức năng tiện ích

+Return type: kiểu trả về của hàm như int,double, string ... nếu hàm không có kiểu trả về thì để từ khóa là void
+Name method: tên của phương thức do người khởi tạo đặt
+paramethers: là các tham số của hàm nếu có, các tham số khai báo theo mẫu, nhiều tham số cách nhau bởi dấu " , "
+Hàm có kiểu trả về thì thân hàm bắt buộc phải có câu lệnh " return value"
*/

/* Hầu hết các program đều: 
   1. Create Variables
   2. Gather input
   3. Process
   4. Output Result
=> Method viết mã chỉ một lần
*/


MeetAlien();

int Result = Square(5);
Console.WriteLine(Result);
if( Result %2 == 0) {
   Console.WriteLine($"{Result} is an even number");
} else {
   Console.WriteLine($"{Result} is an uneven number");
}



//! VOID METHOD

static void MeetAlien() {
    // hàm ra một số ngẫu nhiên
     Random NumberGen = new Random();

     string nameAlien = "X-" + NumberGen.Next(10,999);
     int age = NumberGen.Next(10,500);

     Console.WriteLine("Hi, I'm " + nameAlien);
     Console.WriteLine("I'm " + age + " Years Old.");
     Console.WriteLine("I'm an Alien");
}


//! METHOD RETURN

static int Square(int number) {
   int Square = number*number;
   return Square;
}


//! THAM CHIẾU, THAM TRỊ TỪ KHÓA "ref" và "out"


//! ref
int value = 5 ;
Console.WriteLine("Value before increase: {0}", value);

// IncreaseValue(value);
IncreaseValue(ref value);

Console.WriteLine("Value after increase: {0}", value);


// Giá trị khi được đưa vào hàm để xử lí sẽ được copy ra một giá trị khác trên bộ nhớ khi mà hàm kết thúc giá trị đó bị xóa
//! Muốn thay đổi giá trị khi đưa vào hàm không bị copy ra một giá trị khác để sử dụng mà sử dụng trực tiếp giá trị đưa vào cần thêm từ khóa " ref "
//! Không muốn program copy value ra một vùng nhớ khác mà muốn lấy value để sử dụng luôn thì cần thêm từ khóa " ref "
//! từ khóa ref có trước kiểu dữ kiệu của hàm và có trước giá trị hàm sử dụng
//! Biến đầu vào có từ khóa ref phải được khởi tạo giá trị trước khi truyền vào


// static void IncreaseValue(int value) {
//    value++;
// }

static void IncreaseValue(ref int value) {
   value++;
}


//! out 
// từ khóa out không cần khởi tạo giá trị ban đầu
// parameter như 1 thùng chứa kết quả trả về khi kết thúc gọi hàm
// phải được khởi tạo ngay bên trong lời gọi hàm




