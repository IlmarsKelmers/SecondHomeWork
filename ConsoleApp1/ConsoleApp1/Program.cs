// See https://aka.ms/new-console-template for more information
Console.WriteLine("Labdien, pasniedzēj,");

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

// 1. pajautāt lietotajam viņa vārdu "kā jūs sauc ?"
Console.WriteLine("Kā Jūs sauc ?");

// 2. sagaidīt lietotāja ievadi viņa vārdu
string username = Console.ReadLine();

// 3. sveiks, lietotāja vārds
string usergreeting = "Sveiks " + username + "!";
Console.WriteLine(usergreeting);

// 4. pajautāt lietotajam viņa vecumu "kāds ir jūsu vecums ?"
Console.WriteLine("Kāds ir Jūsu vecums ?");

// 5. sagaidīt lietotāja skaiļa ievadi
string usernumbertext = Console.ReadLine();
int usernumber = int.Parse(usernumbertext);

// 6. nākamgad tev paliks lietotājavecums + 1, "jūs esat pilngadīgs"
int result = usernumber + 1;
Console.WriteLine(result + " Jūs esat pilngadīgs");

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

// Iegūt no lietotāja skaitļus, lai varētu... 

int num1 = 11;
int num2 = 20;

// 1 Atrādīt lietotājam lielāko skaitli izmantojot Math.Max
int largest = Math.Max(num1, num2);
Console.WriteLine(largest);

// 2 Atrādīt lietotājam mazāko skaitli izmantojot Math. Min 

int smallest = Math.Min(num1, num2);
Console.WriteLine(smallest);

// 3 Iegūt skaitļu dalījuma atlikumu izmantojot - %

int divide = num2 % num1;
Console.WriteLine(divide);

// 4 Parādīt vai lietotājs ievadījis pāra vai nepāra skaitli
Console.WriteLine("Lūdzu, ievadi skaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);




Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

// Taisnstūra laukuma aprēķināšana
// Iegūt no lietotāja taisnstūra malu vērtības un aprēķināt taisnstūra laukumu "S=a*b"

// 1. pajautāt lietotajam taisnstūra malas "a" vērtību
Console.WriteLine("Lūdzu ievadi taisnstūra a malasa izmēru");

// 2. sagaidīt lietotāja skaiļa ievadi
string userNumberText1 = Console.ReadLine();
double userNumber1 = double.Parse(userNumberText1);

// 3. pajautāt lietotajam taisnstūra malas "b" vērtību
Console.WriteLine("Lūdzu ievadi taisnstūra b malasa izmēru");

// 4. sagaidīt lietotāja skaiļa ievadi
string userNumberText2 = Console.ReadLine();
double userNumber2 = double.Parse(userNumberText2);

// 5. Sareizināt malas iegūstot laukuma vērtību

Console.WriteLine("S = a*b");
double Prase1 = userNumber1 * userNumber2;
Console.WriteLine("S = " + Prase1);

// Precīzi jāaprēķina laukums arī ja tas sanāk decimāldaļās jānoapaļo ar 2 cipariem aiz komata

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

// Trijstūra laukuma aprēķināšana
// Iegūt no lietotāja skaitli, lai aprēķinātu taisnleņķa vienādsānu trijstūra laukumu 

// 1. pajautāt lietotajam tristūra malas "a" vērtību

Console.WriteLine("Lūdzu ievadi taisnleņķa trijstūra A B malasa izmēru");

// 2. sagaidīt lietotāja skaiļa ievadi

string userNumberText3 = Console.ReadLine();
double userNumber3 = double.Parse(userNumberText3);

Console.WriteLine("Lūdzu ievadi taisnleņķa trijstūra B C malasa izmēru");

string userNumberText4 = Console.ReadLine();
double userNumber4 = double.Parse(userNumberText4);

Console.WriteLine("S (ABC) = (AB*BS)/2");
double Prase2 = (userNumber3 + userNumber4) / 2;
Console.WriteLine("S = " + Prase2);

Console.WriteLine();
Console.WriteLine("========================================================================");
Console.WriteLine();

// 1. Pajautāt lietotajam viņa vārdu "Kāds ir Jūsu vārds ?"
Console.WriteLine("Kāds ir Jūsu vārds ?");

// 2. Sagaidīt lietotāja ievadi viņa vārdu
string userName = Console.ReadLine();

// 3. Pajautāt lietotajam viņa vecumu "Kāds ir Jūsu vecums ?"
Console.WriteLine("Kāds ir Jūsu vecums ?");

// 4. sagaidīt lietotāja skaiļa ievadi
string userNumberText = Console.ReadLine();
int userNumber = int.Parse(userNumberText);

// 5. Sveiks, LietotājaVārds, Jūsu vecums ir LietotājaVecums
String userGreeting = "Sveiks " + userName + ", Jūsu vecums ir " + userNumberText + " gadi.";
Console.WriteLine(userGreeting);

Console.WriteLine();
Console.WriteLine("Ar cieņu");
Console.WriteLine("Ilmārs Kelmers");
Console.WriteLine("C# kursants");