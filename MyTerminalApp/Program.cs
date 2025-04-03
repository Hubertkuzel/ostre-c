using System;
// list<Student> Student = new List<Student>() Lista;

class Student
{
    public string imie {get; set;}
    static string nazwisko {get; set;}

    public Student(string imie, string nazwisko){
        imie = imie;
        nazwisko = nazwisko;
    }

}
class Program
{
    static void Main()
    {
        List<Student> Studenci = new List<Student>();


        bool running = true;
        int decision = int.Parse(Console.ReadLine());
        while (running)
        {
            switch (decision)
            {
                case 1:
                    break;
            }
        }
    }
    
}

