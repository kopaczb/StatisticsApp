//int value1 = int.MinValue;
//int value2 = int.MaxValue;
//uint value3 = uint.MaxValue;
//uint value4 = uint.MinValue;
//Console.WriteLine("Integer:");
//Console.WriteLine($"Minimal value: {value1}.");
//Console.WriteLine($"Maximal value: {value2}.");
//Console.WriteLine($"If I use uint, maximal value is: {value3}");
//Console.WriteLine($"and minimal value is: {value4}.");

//long value5 = long.MinValue;
//long value6 = long.MaxValue;
//ulong value7 = ulong.MaxValue;
//ulong value8 = ulong.MinValue;
//Console.WriteLine("");
//Console.WriteLine("Long:");
//Console.WriteLine($"Minimal value: {value5}.");
//Console.WriteLine($"Maximal value: {value6}.");
//Console.WriteLine($"If I use uint, maximal value is: {value7}");
//Console.WriteLine($"and minimal value is: {value8}.");

//float value9 = float.MinValue;
//float value10 = float.MaxValue;
//Console.WriteLine("");
//Console.WriteLine("Float:");
//Console.WriteLine($"Minimal value: {value9}.");
//Console.WriteLine($"Maximal value: {value10}.");

//double value11 = double.MinValue;
//double value12 = double.MaxValue;
//Console.WriteLine("");
//Console.WriteLine("Double:");
//Console.WriteLine($"Minimal value: {value11}.");
//Console.WriteLine($"Maximal value: {value12}.");

//decimal value13 = decimal.MinValue;
//decimal value14 = decimal.MaxValue;
//Console.WriteLine("");
//Console.WriteLine("Decimal:");
//Console.WriteLine($"Minimal value: {value13}.");
//Console.WriteLine($"Maximal value: {value14}.");

//string name3 = "Bartosz ";
//string surname3 = "Kopacz ";
//int age3 = 30;
//string result = name3 + surname3 + age3;
//var result2 = result.ToArray();
//Console.WriteLine("");
//Console.WriteLine("String:");
//Console.WriteLine(result);

//Console.WriteLine("");
//Console.WriteLine("Char:");
//foreach (char value in result2)
//{
//    Console.WriteLine(value);
//}

//bool isActive = true;
//isActive = false;
//var isValid = 5 > 6;
//Console.WriteLine("");
//Console.WriteLine("Bool:");
//Console.WriteLine(isValid);

//int number1 = 100;
//int number2 = 50;

//if (number1 < number2)
//{
//    Console.WriteLine("");
//    Console.WriteLine("Jestem w linii 35.");
//}
//else
//{
//    Console.WriteLine("");
//    Console.WriteLine("Jestem w linii 39.");
//}
//Console.WriteLine("");
//Console.WriteLine("Debugowanie - do tego stawia się kropkę i analizuje działanie kodu");//Console.WriteLine("");
//Console.WriteLine("");
//Console.WriteLine("Operatory relacyjne: <, >, <=, >=, ==, !=");

//string name2 = "Michał";
//int age2 = 40;

//if (name2 == "Michał" && age2 < 50)
//{
//    Console.WriteLine("");
//    Console.WriteLine("Jestem Michałem przed 50.");
//}
//else
//{
//    Console.WriteLine("");
//    Console.WriteLine("Jestem inną osobą.");
//}

//var isActive2 = false;
//if (isActive2)
//{
//    Console.WriteLine("");
//    Console.WriteLine("Prawda");
//}
//else if (!(isActive2))
//{
//    Console.WriteLine("");
//    Console.WriteLine("Fałsz");
//}

//Console.WriteLine("");
//Console.WriteLine("Operatory logiczne: &&, ||, ! - np. !(age < 50)");

//Console.WriteLine("");
//Console.WriteLine("Ważne skróty klawiszowe:");
//Console.WriteLine("Ctr + K + C");
//Console.WriteLine("Ctr + K + U");
//Console.WriteLine("Ctr + K + D");

string name = "Ewa";
int age = 3;
string sex = "man";

if (sex == "woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (sex == "woman" && name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (sex == "man" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
