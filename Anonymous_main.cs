using System;
using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information


// Type data  anonymous 
// object property read only
// new {nameAttribute1 =value, nameAttribute2 =value}
using System.Linq;

var product = new
{
    name = "IPhone",
    Price = 500,
    YearOfManufacture = 2018,
};
System.Console.WriteLine(product.name);




List<Anomynuos.student> Students = new List<Anomynuos.student>() {
    new Anomynuos.student() {
    Name = "Name1",
    YearOfBirth =   2000,
    PlaceOfBirth ="BG"

    },
    new Anomynuos.student() {
    Name = "Name2",
    YearOfBirth =   2002,
    PlaceOfBirth ="BN"

    },
    new Anomynuos.student() {
    Name = "Name3",
    YearOfBirth =   2003,
    PlaceOfBirth ="HN"

    },
    new Anomynuos.student() {
    Name = "Name4",
    YearOfBirth =   20004,
    PlaceOfBirth ="HP"

    }
};

// using Linq
var results = from Student in Students
              where Student.Name.Contains("a")
              select new {
                 Name = Student.Name,
                 PlaceOfBirth = Student.PlaceOfBirth
              };

        foreach (var Student in results)
        {
              System.Console.WriteLine(Student.Name+ " - "+Student.PlaceOfBirth);
        }
              
