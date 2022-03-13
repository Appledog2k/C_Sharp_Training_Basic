// See https://aka.ms/new-console-template for more information
/* là sự kết hợp bằng cách định nghĩa cặp get/set trong bản thân môt property
   không sử dụng cặp ngoặc ()
   có kiểu trả về là kiểu của trường mà nó đóng gói

*/

encapsulation_get_set.Student Hùng = new encapsulation_get_set.Student(2018000, "Hùng", "hung.nq182556@sis.hust.edu.vn", 20);
System.Console.WriteLine("Tuổi:" + Hùng.Age);
Hùng.Age++;
System.Console.WriteLine("Tuổi:" + Hùng.Age);
System.Console.WriteLine("Tên:" + Hùng.FirstName);
Hùng.ID = 20182556;
System.Console.WriteLine("Mã sinh viên:" + Hùng.ID);
