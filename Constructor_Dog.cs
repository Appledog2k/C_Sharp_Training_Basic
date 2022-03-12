using System.Runtime.CompilerServices;
namespace Constructor {
    public class Dog{
        public string name;
        public int age;
        public string color;

        // public Dog() : this("" , 0)  // constructor hiện tại gọi đến constructor 2 biến bên dưới xử lí trước
        // {
        //     color = "Yellow";

        // }

        // public Dog(string name, int age) {
        //     this.name = name;
        //     this.age = age;
        //     color = "White";

        // }

        // public Dog(string name, int age, string color) {
        //     this.name = name;
        //     this.age = age;
        //     this.color = color;

        // }

        public Dog(string name = "chó đỏ", int age = 3, string color = " red") {
            this.name = name;
            this.age = age;
            this.color = color;

        }



    }
}

