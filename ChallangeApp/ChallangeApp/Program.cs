// "Kobieta ponizej 30 lat"
// "Ewa, lat 33"
// "Niepelnoletni Mezczyzna"

string name = "Kobieta ponizej";
string name2 = "Ewa,";
string age = " 30 lat";
string age2 = " lat 33";
string name3 = "Niepelnoletni Mezczyzna";
string resoult = name + age;
string resoult2 = name2 + age2;
string resoult3 = name3;
Console.WriteLine(resoult);
Console.WriteLine(resoult2); 
Console.WriteLine(resoult3);

string name0 = "Inna Wersja Kodu:";
string resoult0 = name0;
Console.WriteLine(resoult0);

string sex = "kobieta";
int age4 = 27;
if (sex == "kobieta" && age4 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age4 == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (sex == "mężczyzna")
{
    if (age4 < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}

string name5 = "Ewa";
int age5 = 33;

if (name5 == "Ewa" && age5 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else 
{
    Console.WriteLine("Ewa, lat 33");
}
string name6 = "Ewa";
string sex6 = "kobieta";
int age6 = 33;

if (name6 == "Ewa" && age6 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name6 == "Ewa" && sex6 == "Mezczyzna")
{
    Console.WriteLine("Ewa, lat 33");
}
else 
{
    Console.WriteLine("Niepelnoletni Mezczyzna");
}