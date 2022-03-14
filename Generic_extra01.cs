using System.Runtime.ConstrainedExecution;
namespace Generic01
{
    public class Product<A>
    {
        public A ID;
        public void SetID(A id)
        {
            this.ID = id;

        }
        public void PrintID()
        {
            System.Console.WriteLine($"ID: {this.ID}");
        }

    }
}