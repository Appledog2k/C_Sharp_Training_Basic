using System.Reflection.Metadata.Ecma335;
namespace encapsulation_get_set {
    class Student {
        private int id;
        private string firstName;
        private string email;
        private int age;
        public Student()
        {
            
        }
        public Student(int id, string firstName, string email, int age) {
            this.id = id;
            this.firstName=firstName;
            this.email=email;
            if(age < 0 || age >200) {
                System.Console.WriteLine("Tuổi nhập không hợp lệ. Vui lòng nhập lại.");
                this.age = default;
            } else {
                this.age = age;
            }
        }

        // Set
        public void SetAge(int newAge) {
            if(newAge < 0 || newAge >200) {
                System.Console.WriteLine("Tuổi nhập không hợp lệ. Vui lòng nhập lại.");
                this.age = default;
            } else {
                this.age = newAge;
            }
        }

        // Get không nhận tham số cùng kiểu với thứ muốn lấy ra'
        public int GetAge() {
            return this.age;
        }

        //set
        public void SetFirstName(string newName) {
            if(newName.Length > 0 && newName.Length <= 15) {
                this.firstName = newName;
            } else {
                System.Console.WriteLine("Tên không hợp lệ.");
            }
        }
        //get
        public string GetFirstName() {
            return this.firstName;
        }


    }
}