using System;
namespace MyApp
//! Class Abstract :The class is only used as a base for derived class
//!  Object cannot be instantiated
{

    // create abstract class
    abstract class Product
    {
        public float Price { get; set; }

        // create method virtual -- can be overridden by inherited methods
        public virtual void GetInfo() => System.Console.WriteLine($"Price Product: {Price}");
        public void TestProduct() => GetInfo();

        // create method abstract
        // method abstract has no body
        // method abstract must be declared in derived class
        public abstract void GetProduct();
    }
    class Iphone : Product
    {
        public Iphone() => Price = 500;
        public override void GetProduct() => System.Console.WriteLine("This is Iphone");

        // overide methods
        // public override void GetInfo() => System.Console.WriteLine("Iphone 13");
        // if want take method base syntax : base.<method_base>
    }
}