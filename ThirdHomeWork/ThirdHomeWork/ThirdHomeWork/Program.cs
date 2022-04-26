

using ThirdHomeWork;

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



Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();


Person people = new Person();

Console.WriteLine("Kā Jūsu Vārds?");
string peoplename = Console.ReadLine();

Console.WriteLine("Kā Jūsu Uzvārd?");
string peoplesurnam = Console.ReadLine();

string peoplegreeting = ($"Sveiks + {peoplename} {peoplesurnam}!");
Console.WriteLine(peoplegreeting);

Console.WriteLine("Kādi ir Jūsu dzimšanas dati dd.mm.yyyy?");
string birthDateText = Console.ReadLine();
people.BirthDate = DateTime.Parse(birthDateText);

Console.WriteLine("Kā ir Jūsu hobijs");
string peoplehobby = Console.ReadLine();

people.Name = peoplename;
people.Surname = peoplesurnam;
people.Hobby = peoplehobby;

people.GetAge();
