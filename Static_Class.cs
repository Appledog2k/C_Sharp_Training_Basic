namespace OOP_Static {
    class SavingAcc {
        public static float interestRate;
        public string accNumber;
        public double balance;

        public static void ChangeRate(float newRate) {
            interestRate = newRate;
            
        }
        static SavingAcc()
        {    System.Console.WriteLine("call static constructor");
             interestRate = 0.4f;
        }
        public SavingAcc()
        {
            System.Console.WriteLine("constructor mặc định");
        }
    
    }
}