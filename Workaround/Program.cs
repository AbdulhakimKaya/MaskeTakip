// Variables();

using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();

SayHello();

SayHello2("Abdulhakim");
SayHello2();

Sum();

Sum2(3, 7);
Sum2();


// Arrays -> Reference Type
string[] students = new string[3];
students[0] = "Furkan";
students[1] = "Ömer";
students[2] = "Sayit Can";
// students[3] = "Caner";   // System.IndexOutOfRangeException: Index was outside the bounds of the array.

Console.WriteLine("first for");
//       start  condition            increment
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

students = new string[4];
students[3] = "Caner";

Console.WriteLine("second for");
//       start  condition            increment
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = new[] { "Antalya", "Diyarbakır", "Bursa" };

cities2 = cities1;
cities1[0] = "Adana";

int number1 = 10;
int number2 = 20;

number2 = number1;
number1 = 30;

Console.WriteLine(cities2[0]);
Console.WriteLine(number2);

Person person2 = new Person();
person2.FirstName = "ABDULHAKİM";
person2.LastName = "KAYA";
person2.DateOfBirthYear = 2002;
person2.NationalIdentity = 1;

Person person3 = new Person();
person3.FirstName = "Engin";


foreach (string city in cities1)
{
    Console.WriteLine(city);    
}

List<string> cities3 = new List<string> { "Ankara", "İstanbul", "İzmir" };
cities3.Add("Diyarbakır");

foreach (string city in cities3)
{
    Console.WriteLine(city);
}


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person2);


// void Method
static void SayHello()
{
    Console.WriteLine("Hello");
}


// method takes parameters
static void SayHello2(string name = "noname") // default parameter
{
    Console.WriteLine("Hello " + name);
}


// int Method -> int is the return type of the method
static int Sum()
{
    return 5;
}


// method takes parameters
static int Sum2(int number1 = 5, int number2 = 9)
{
    int total = number1 + number2;
    Console.WriteLine("Total = " + total);

    return total;
}


void Variables()
{
    // variables name convention is camelCase
    string message = "Selam";
    double price = 10000;
    int number = 100;
    bool isActive = true;

    string firstName = "Abdulhakim";
    string lastName = "KAYA";
    int birthOfDay = 2002;
    long nationalIdentity = 12345678911;

    Console.WriteLine(message);
    Console.WriteLine(price * 1.18);

    Console.WriteLine(nationalIdentity);
}


// name convention is PascalCase
// public class Person
// {
//     public string firstName { get; set; }
//     public string lastName { get; set; }
//     public int birthOfDay { get; set; }
//     public long nationalIdentity { get; set; }
// }