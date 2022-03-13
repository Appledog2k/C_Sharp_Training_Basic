//properties read only and write only
namespace encapsulation
{
    class Employee
    {
        private string empId;
        //read only property
        public string EmpId
        {
            get => empId;
        }
        private string empName;
        private int age;
        private string password;
        // write only property
        public string PassWord
        {
            set => password = value;
        }
        public Employee(string id, string name, int age)
        {
            this.empId = id;
        }
    }
}