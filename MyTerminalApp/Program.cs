using System;
// list<Student> Student = new List<Student>() Lista;

class Student
{
    public string imie {get; set;}
    static string nazwisko {get; set;}
    private static double GradeAvg { get; set; }

    public Student(string imie, string nazwisko, double Avg){
        imie = imie;
        nazwisko = nazwisko;
        GradeAvg = Avg;
    }
}

class Program
{
    static void Main()
    {
        List<Student> Studenci = new List<Student>();


        bool running = true;
        int decision = int.Parse(Console.ReadLine());
        Console.WriteLine("1 - dodaj studenta\n2 - usuń studenta\n3 - wyszukiwanie studentów\n4 - obliczanie średniej ocen\n5 - wyłącz system");
        while (running)
        {
            switch (decision)
            {
                case 1:
                    Console.WriteLine("Podaj imie, nazwisko i średnią ocen");
                    string name = Console.ReadLine();
                    string nazwisko = Console.ReadLine();
                    double Avg = double.Parse(Console.ReadLine());

                    Student student = new Student(name, nazwisko, Avg);
                    Studenci.Add(student);
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Coś chyba poszło nie tak");
                    break;
            }
        }
    }
    
}