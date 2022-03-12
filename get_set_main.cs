using System.Security.Principal;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Quan điểm của tính đóng gói : dữ liệu của 1 đối tượng không nên được truy cập trực tiếp bên ngoài lớp bới bính bản thân nó mà việc này cần thực hiện gián tiếp qua các thành phần public khác
*/
/* sử dụng cặp getter/setter
   Tạo lớp mô tả thông tin sinh viên gồm : mã sv, tên , email, tuổi
*/

encapsulation_get_set.Student Hùng =new encapsulation_get_set.Student(20182556, "Hùng", "hung.nq182556@sis.hust.edu.vn", 20);
System.Console.WriteLine("Tuổi:" + Hùng.GetAge());

Hùng.SetAge(Hùng.GetAge()+1);
System.Console.WriteLine("Tuổi:" + Hùng.GetAge());
System.Console.WriteLine("Tên:" + Hùng.GetFirstName());
