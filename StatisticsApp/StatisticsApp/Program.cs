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

Console.WriteLine("--------------------------------------------------------------------------------");
// ZADANIE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
Console.WriteLine("--------------------------------------------------------------------------------");


//Console.WriteLine("");
//Console.WriteLine("Operatory logiczne: &&, ||, ! - np. !(age < 50)");

//Console.WriteLine("");
//Console.WriteLine("Ważne skróty klawiszowe:");
//Console.WriteLine("Ctr + K + C");
//Console.WriteLine("Ctr + K + U");
//Console.WriteLine("Ctr + K + D");

//string name = "Ewa";
//string sex = "man";
//int age = 90;

//if (sex == "woman" && age < 30)
//{
//    Console.WriteLine("Kobieta poniżej 30 lat.");
//}
//else if (sex == "woman" && name == "Ewa" && age == 33)
//{
//    Console.WriteLine("Ewa, lat 33.");
//}
//else if (sex == "man" && age < 18)
//{
//    Console.WriteLine("Niepełnoletni mężczyzna.");
//}
//else if (sex == "woman" && age >= 60)
//{
//    Console.WriteLine("Kobieta w wieku emerytalnym.");
//}
//else
//{
//    Console.WriteLine("Brak kategorii.");
//}

Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------------------------");

// ------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------

//int[] grades = new int[5];
//string[] dayOfWeeks = new string[7];
//dayOfWeeks[0] = "poniedziałek";
//dayOfWeeks[1] = "wtorek";
//dayOfWeeks[2] = "środa";
//dayOfWeeks[3] = "czwartek";
//dayOfWeeks[4] = "piątek";
//dayOfWeeks[5] = "sobota";
//dayOfWeeks[6] = "niedziela";
//Console.WriteLine(dayOfWeeks[2]);

//string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek" };
//Console.WriteLine(dayOfWeeks2[0]);


//for (var i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//for (var i = 0; i < 10; i = i + 2)
//{
//    Console.WriteLine(i);
//}

//for (var i = 0; i < dayOfWeeks.Length; i = i + 2)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//List<string> daysOfWeeks3 = new List<string>();
//dayOfWeeks3.Add("poniedziałek");
//dayOfWeeks3.Add("wtorek");
//dayOfWeeks3.Add("środa");
//dayOfWeeks3.Add("czwartek");
//dayOfWeeks3.Add("piątek");
//dayOfWeeks3.Add("sobota");
//dayOfWeeks3.Add("niedziela");

//for (var i = 0; i < dayOfWeeks3; i++)
//{
//    Console.WriteLine(dayOfWeeks3[i]);
//}

//foreach (var day in daysOfWeeks3)
//{
//    Console.WriteLine(day);
//}


Console.WriteLine("--------------------------------------------------------------------------------");
// ZADANIE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
Console.WriteLine("--------------------------------------------------------------------------------");

// Przygotuj program, ktory policzy ile jakich
// cyfr wystepuje w podanej liczbie:
//
// Przykład:
// Wyniki dla liczby: 4566
// 0 => 0
// 1 => 0
// 2 => 0
// 3 => 0
// 4 => 0
// 5 => 0
// 6 => 0
// 7 => 0
// 8 => 0
// 9 => 0

//int number = 4566;
//string numberAsString = number.ToString();
//char[] letters = numberInString.ToArray();

//char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//int[] counts = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

//for (var i = 0; i < letters.Length; i++)
//{
//    for (var j = 0; j < digits.Length; j++)
//    {
//        if (letters[i] == digits[j])
//        {
//            counts[j] += 1;
//        }
//    }
//}

//var ccount = -1;
//foreach (var count in counts)
//{
//    ccount += 1;
//    Console.WriteLine($"Cyfra {ccount} wystepuje {counts[ccount]} razy.");
//}

//for (var k = 0; k < counts.Length; k++)
//{
//    Console.WriteLine($"Cyfra {k} wystepuje {counts[k]} razy.");
//}



Console.WriteLine("--------------------------------------------------------------------------------");
// KLasy i metody
Console.WriteLine("--------------------------------------------------------------------------------");

// ------------------------------------------------------------------------------------
//Lekcja 1
// ------------------------------------------------------------------------------------
