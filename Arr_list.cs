using System;
// See https://aka.ms/new-console-template for more information

//! ARRAY DATA STRUCTURE

// Set up, nhập chiều dài của mảng
int n;
Console.WriteLine("Vui lòng nhập chiều dài mảng của bạn!");
n=Convert.ToInt32(Console.ReadLine());
string[] ExampleString = new string[n];

// Nhập dữ liệu trong mảng
Console.WriteLine("Nhập dữ liệu cho mảng của bạn");
for(var index =0; index < n; index++) {
    Console.Write($"Nhập phần tử mảng thứ {index}, có giá trị là : ");
    ExampleString[index] = Console.ReadLine();    
}

// Duyệt qua từng phần tử trong mảng
int LengthArrayEx = ExampleString.Length;
for (var index = 0; index < LengthArrayEx; index++)
{   
    Console.WriteLine($"Index: {index}, Value: {ExampleString[index]}");
}

//! LIST 

// Khởi tạo và thêm giá trị cho list
int count;
Console.WriteLine("Vui lòng nhập chiều dài của list !");
count=Convert.ToInt32(Console.ReadLine());
List<string> ClubList = new List<string>(count);

// Thêm giá trị cho list
for(var x=0 ; x < count ; x++) {
    Console.Write($"Nhập giá trị của list ứng với count {x} ");
    ClubList.Add(Console.ReadLine());
}

// In ra list
for(int isCount = 0; isCount < ClubList.Count; isCount++) {
    Console.Write($"Giá trị từng list ứng với {isCount} là: ");
    Console.WriteLine(ClubList[isCount]);
}

// Loại bỏ một element ra khỏi list
/* Cách 1: Loại bỏ một element khi biết value element đó
   Syntax: <name_list>.Remove("Value cần loại bỏ");
   
   Cách 2: Loại bỏ một element khi biết index element đó
   Syntax: <Name_List>.RemoveAt("index_element");
*/




//! Part 1: Attribute ARRAY

// Initialization array type int
int[] number = {1,2,4,3,5,6,7,12,47};

// Attribute 1: Length -- Cho biết độ dài của mảng
int LengthArr = number.Length;
Console.WriteLine($"Chiều dài của chuỗi là: {LengthArr}");

// Attribute 2: Rank -- Cho biết số chiều của mảng
int Ranks = number.Rank;
Console.WriteLine($"Số chiều của mảng là: {Ranks}");

// Attribute 3: Min()-- Cho biết phần tử có giá trị nhỏ nhất trong mảng
int min = number.Min();
Console.WriteLine($"Giá trị nhỏ nhất của mảng là: {min}");

// Attribute 4: Max()-- Cho biết phần tử có giá trị lớn nhất trong mảng
int max =  number.Max();
Console.WriteLine($"Giá trị max của mảng là: {max}");

// Attribute 5: Sum()-- Trả về tổng tất cả các phần tử trong mảng
int sum = number.Sum();
Console.WriteLine($"Tổng tất cả các phần tử trong mảng là: {sum}");


//! Part 2: METHOD STATIC ARRAY !

// dùng dữ liệu của bài toán nhập xuất ở phần trên

// Method 1: Sort() -- Arrange
Array.Sort(ExampleString);
for (var i = 0; i < LengthArrayEx; i++)
{   
    Console.WriteLine($"Index: {i}, Value: {ExampleString[i]}");
}

// Method 2: Using ForEach() Loop  -- duyệt qua các phần tử trong mảng
/* Syntax : foreach (type variable_Name in array_name) {
    -- Code block to be executed
}
*/
foreach (var element in number) {
    Console.WriteLine($"Duyệt qua lần lượt các phần tử trong mảng: {element}");
}
// Method 3: Array.ForEach -- Duyệt qua các phần tử trong mảng
//* Syntax : Array.ForEach<typeData>(callbacks func)

// create func
static void testForEach() {
    int[] numbers = {1,3,5,7,9,11,13,12,17,18,19};
    // iterate all element type int and print element
    //create arrow func
     Array.ForEach<int>(numbers, (int n)=> {
              Console.WriteLine(n);
    });
}

// call func
testForEach();

// METHOD 4: Array.BinarySearch(array, value) 

//Search element in arr return index element
int index1 = Array.BinarySearch(number, 13);
Console.WriteLine($"Giá trị cần tìm có chỉ số là: {index1}");










