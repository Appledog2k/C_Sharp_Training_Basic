using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
namespace encapsulation_get_set
{
    class Student
    {
        private int id;
        private string firstName;
        private string email;
        private int age;
        public Student(int id, string firstName, string email, int age)
        {
            ID = id;
            FirstName = firstName;
            Email = email;
            Age = age;
        }

        // property --- get +set
        public int ID
        {
            get => id;
            set
            {
                if (value > 0 && value <= 30000000)
                {
                    this.id = value;
                }
                else
                {
                    System.Console.WriteLine("Vui lòng nhập lại mã sinh viên");
                }
            }
        }


        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 200)
                {
                    System.Console.WriteLine("Tuổi nhập không hợp lệ.");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string FirstName
        {
            get => firstName;

            set
            {
                if (value.Length > 0 && value.Length <= 15)
                {
                    this.firstName = value;
                }
                else
                {
                    System.Console.WriteLine("Tên không hợp lệ.");
                }

            }


        }
        public string Email
        {
            get => email;
            set => email = value;

        }
    }
    
    
}