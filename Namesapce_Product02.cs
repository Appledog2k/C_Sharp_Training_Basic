using System;
namespace Product
{
    public partial class Product
    {
        public Manufactory manufactory { get; set; }
        public class Manufactory
        {
            public string nameFactory { get; set; }
            public string addr { get; set; }
        }
        public string description { get; set; }

    }

}