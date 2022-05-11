

using System.Globalization;
using ThirdHomeWork;

// Phone klase/datu tips - tad piešķir mainīgā nosaukums (mobile)
// mainīgais satur iekšā bjektus (folderi folderos iekšā - iet dziļāk iekšā saturā)
// Phone ir kā sākuma mape
// new - tad sauc konstruktoru (tā ir īpaša funkcija kas tiek izsaukt pie klases izveides)
// nevar izveidit jaunu klas/objektu nepasaucot konstruktoru

Phone mobile = new Phone();

mobile.Size = "6.7";
mobile.Model = "iPhone 13 Pro Max";

string mobileName = mobile.Model;
Console.WriteLine($"Mobile phone name: {mobileName}");

mobile.Call();
mobile.Sms();

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();


Car auto = new Car();
auto.Brand = "AUDI A6";
auto.NumberPlate = "GE 8024";
auto.Speed = 100;

string autoName = auto.Brand;
Console.WriteLine($"Car brend name: {autoName}");

string autoNumberPlate = auto.NumberPlate;
Console.WriteLine($"Car registration number: {autoNumberPlate} and speed is: {auto.Speed} km/h");

auto.StartToDrive();
auto.GoFaster();
auto.Beep();    
auto.SlowDown();
auto.Stop();

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

//3. uzdevums
//Prece Izveidot klasi prece.
//Lai izveidotu jebkuru preci,
//tai obligāti ir jābūt garumam platumam un svaram,
//kuri nedrīkst tapt meinīti pēc preces izveidošnas.
//Lietotājs izveido preci. Izvadām visus preces parametrus.


Console.WriteLine("Please Enter Height of a product");
double heightFromUser = double.Parse(Console.ReadLine());

Console.WriteLine("Please Enter Width of a product");
double widthFromUser = double.Parse(Console.ReadLine());

Console.WriteLine("Please Enter Weight of a product");
double weightFromUser = double.Parse(Console.ReadLine());

Product product = new Product(heightFromUser, widthFromUser, weightFromUser);

// Vērtības ir uzstādītas objekta izveidošanas brīdī.

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

// 4. uzdevums - Persona Izveidot klasi persona.
// Pesonai ir Vārds, Uzvārds, dzimšanas datums, hobijs, dzimums.
// Iegūstam personas visus datus no lietotāja.
// Izveidojam funkcijas, ka persona māk sasveicināties
// un zin aprēķināt cik personai ir gadi.
// Persona sasveicinās aptuveni pēc parauga
// "Hello my name is {name} {surname} and I am {yearsOld}"
// Pēc personas izveides personas sveiciens tiek izvadīts konsolē

Person person = new Person();

Console.WriteLine("Please Write Your Name");
string namedatetext = Console.ReadLine();
person.Name = namedatetext;


Console.WriteLine("Please Write Your Surname");
string surnamedatetext = Console.ReadLine();
person.Surname = surnamedatetext;

Console.WriteLine("Please Write Your Hobby");
string hobbytext = Console.ReadLine();
person.Surname = hobbytext;


Console.WriteLine("What is your birth year yyyy?");
string birthYear = Console.ReadLine();
person.BirthDate = int.Parse(birthYear);

int age = person.GetAge();

Console.WriteLine($"Tu esi {age} gadus vecs");
