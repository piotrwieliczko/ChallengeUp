// to jest komentarz w kodzie
Console.WriteLine("Hello, World!");

// deklaracja zmiennych

//liczby całkowite
int myAge = 33;
int newAge = myAge + 5;
Console.WriteLine(newAge);
uint myVar = uint.MaxValue;
long myVar2 = long.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2=double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

//zmienne tekstowe
string name = "Piotr";
string surname = "Wieliczko";
string result = name + surname;
Console.WriteLine(result);
// char przechowuje tylko jeden symbol
char znak = 'c';

//rozdzielanie stringów na char
var result2 = name.ToArray();

//zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);


var number1 = 50;
var number2 = 10;

if (number1 < number2)
{
    {
        Console.WriteLine("jestem w linijcie 41");
    }
}else

    {
    Console.WriteLine("jestem w linijcie 47");
}