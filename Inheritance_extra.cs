namespace Inheritance
{
    //class base
    class Animal
    {
        public Animal()
        {
            System.Console.WriteLine("khởi tạo animal");

        }
        public Animal(string mess) 
        {
            System.Console.WriteLine($"Khởi tạo animal: {mess}");
        }
        public int Leg { get; set; }
        public float Weight { get; set; }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Leg}");
        }
    }
    //class inherit
    class Cat : Animal
    {
        public string Food;

       // call constructor base before
       // passing parameters between inherited and base constructor
        public Cat(string mess) : base(mess)
        {
            this.Leg = 4;
            this.Food = "Mouse";
            System.Console.WriteLine("Khởi tạo class cat");
        }
        public void Eat()
        {
            System.Console.WriteLine($"Food : {Food}");
        }
        //redeclare the base class method
        public new void ShowLegs()
        {
            Console.WriteLine($"NumberLegs of cat: {Leg}");
        }
        public void ShowInfo()
        {
            // access base class property again
            base.ShowLegs();

            // access class inherit new
            ShowLegs();

        }


    }


    // Seal class, another class don't Inherit class base
    sealed class Animal01
    {
        public int Leg { get; set; }
        public float Weight { get; set; }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Leg}");
        }

    }
}