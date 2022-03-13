// See https://aka.ms/new-console-template for more information

encapsulation_get_set.Student Hùng = new encapsulation_get_set.Student(2018000, "Hùng", "hung.nq182556@sis.hust.edu.vn", 20);
System.Console.WriteLine("Tuổi:" + Hùng.Age);
Hùng.Age++;
Hùng.ID = 20182556;

System.Console.WriteLine("Tuổi:" + Hùng.Age);
System.Console.WriteLine("Tên:" + Hùng.FirstName);
System.Console.WriteLine("Mã sinh viên:" + Hùng.ID);
System.Console.WriteLine("Email:" + Hùng.Email);