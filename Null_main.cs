// See https://aka.ms/new-console-template for more information
Null.Null a = new Null.Null();

//if a!= null access method Hi
a?.Hi();


// nullAble

int? age;
age =null;

age =10;
if( age.HasValue ) {
    int _age = age.Value;
    System.Console.WriteLine(_age);
}


