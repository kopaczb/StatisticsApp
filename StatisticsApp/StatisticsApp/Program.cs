// ------------------------------------------------------------------------------------
//Lekcja
// ------------------------------------------------------------------------------------


User user1 = new User();
// albo var user1 = ...
User user2 = new User();
// albo var user2 = ...
User user3 = new User();
// albo var user3 = ...

class User
{
    string login;
    string password;
}

// ------------------------------------------------------------------------------------
//Lekcja
// ------------------------------------------------------------------------------------

User user1 = new User();
User user2 = new User();
User user3 = new User();

user1.login = "Adam";

class User
{
    public string login;
    public string password;
}

// ------------------------------------------------------------------------------------
//Lekcja
// ------------------------------------------------------------------------------------

User user1 = new User("Adam");
User user2 = new User("Monika");
User user3 = new User("Damian");


class User
{
    private string login;
    private string password;
    private string name;


    // konstruktor
    public User(string login)
    {
        this.login = login;
    }
}

// ------------------------------------------------------------------------------------
//Lekcja
// ------------------------------------------------------------------------------------

User user1 = new User();
User user2 = new User("Adam", "");
User user3 = new User("Damian");


class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }

    public User(string login)
    {
        this.login = login;
        this.password = "-";
        this.name = "-";
    }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
}

// ------------------------------------------------------------------------------------
//Lekcja
// ------------------------------------------------------------------------------------

User user1 = new User();
User user2 = new User("Adam", "");
User user3 = new User("Damian");


class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }

    public User(string login)
    {
        this.login = login;
        this.password = "-";
        this.name = "-";
    }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
}

// ------------------------------------------------------------------------------------
//Lekcja
// ------------------------------------------------------------------------------------

User user1 = new User("Adam", "123123123");
User user2 = new User("Monika", "123123123");
User user3 = new User("Zuzia", "123123123");
User user4 = new User("Damian", "123123123");

var name = user1.Login;

class User
{
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public string Login { get; private set; }
    public string Password { get; private set; }
}

// ------------------------------------------------------------------------------------
//Lekcja - Metody
// ------------------------------------------------------------------------------------

User user1 = new User("Adam", "123123123");
User user2 = new User("Monika", "123123123");
User user3 = new User("Zuzia", "123123123");
User user4 = new User("Damian", "123123123");


user1.AddScore(5);

class User
{
    private int score;

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }

    public string Login { get; private set; }

    public string Password { get; private set; }


    public void AddScore(int number)
    {
        this.score += number;
    }
}

// ------------------------------------------------------------------------------------
//Lekcja 8 - Metody i hermetyzacja
// ------------------------------------------------------------------------------------

User user1 = new User("Adam", "123123123");
User user2 = new User("Monika", "123123123");
User user3 = new User("Zuzia", "123123123");
User user4 = new User("Damian", "123123123");


user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Cosnole.WriteLine(result)

class User
{
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;

    }

    public string Login { get; private set; }

    public string Password { get; private set; }

    public string Result
    {
        get
        {
            return this.score.Sum();
        }
    }


    public void AddScore(int number)
    {
        this.scoreAdd(number);
    }
}

// ------------------------------------------------------------------------------------
//Lekcja 9 - Zmienne i metody statyczne
// ------------------------------------------------------------------------------------

User user1 = new User("Adam", "123123123");
User user2 = new User("Monika", "123123123");
User user3 = new User("Zuzia", "123123123");
User user4 = new User("Damian", "123123123");


user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Cosnole.WriteLine(result)
var name = User.GameName;
var pi = Math.PI;

class User
{
    public static string GameName = "Diablo";

    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;

    }

    public string Login { get; private set; }

    public string Password { get; private set; }

    public string Result
    {
        get
        {
            return this.score.Sum();
        }
    }


    public void AddScore(int number
    {
        this.scoreAdd(number);
    }

    public static void AddScore(int number)
    {
        this.score.Add(number);
    }
}


/// 1. Stwórz klasę Employee, w której przechowasz: imię, nazwisko,
///    wiek oraz punkty pracownika w postaci liczb całkowitych.
///
/// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen
///    z zakresu od 1 do 10.
///
/// 3. Napisz program, który wyszuka pracownika z największą
///    liczbą ocen, a nastepnie wyświetl jego dane oraz wynik.



using System.Linq;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employeee employee1 = new Employeee("Adam", "Kowalski", 30);
            Employeee employee2 = new Employeee("Monika", "Duda", 70);
            Employeee employee3 = new Employeee("Damian", "Tusk", 20);

            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            var result1 = employee1.Result;
            Console.WriteLine($"{employee1.name} suma punktów: {result1}.");


            employee2.AddGrade(2);
            employee2.AddGrade(3);
            employee2.AddGrade(4);
            employee2.AddGrade(5);
            employee2.AddGrade(6);
            var result2 = employee2.Result;
            Console.WriteLine($"{employee2.name} suma punktów: {result2}.");


            employee3.AddGrade(3);
            employee3.AddGrade(4);
            employee3.AddGrade(5);
            employee3.AddGrade(6);
            employee3.AddGrade(7);
            var result3 = employee3.Result;
            Console.WriteLine($"{employee3.name} suma punktów: {result3}.");


            var sumGrades = new List<int>();
            sumGrades.Add(0);
            sumGrades.Add(result1);
            sumGrades.Add(result2);
            sumGrades.Add(result3);

            var sumHigh = int.MinValue;
            var sumLow = int.MaxValue;

            foreach (var sum in sumGrades)
            {
                sumHigh = Math.Max(sum, sumHigh);
                sumLow = Math.Min(sum, sumLow);
            }

            Console.WriteLine($"Największa suma: {sumHigh}");
            Console.WriteLine($"Najmniejsza suma: {sumLow}");



        }

        class Employeee
        {
            private List<int> grades = new List<int>();

            public Employeee(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            public void AddGrade(int grade)
            {
                this.grades.Add(grade);
            }


            public string name { get; private set; }
            public string surname { get; private set; }
            public int age { get; private set; }

            public int Result
            {
                get
                {
                    return this.grades.Sum();
                }
            }

        }
    }
}