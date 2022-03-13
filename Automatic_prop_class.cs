namespace automatic_property
{
    class automatic
    {

        public automatic(int id=2018000, string Subject="C# programming language")
        {
                Id=id;
                this.Subject = new automatic_property.Subject(Subject);
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        
        public float Salary { get; set; }
        public Subject Subject { get; set; }
        
        


    }
}