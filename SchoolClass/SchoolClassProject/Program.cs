using SchoolClassProject.Models;

namespace SchoolClassProject;

class Program
{
    static void Main()
    {
        SchoolClass class9A = new SchoolClass(9, 'A', 70000);
        SchoolClass class9B = new SchoolClass(9, 'b', 55000);

        Console.WriteLine(class9A);
        Console.WriteLine(class9B);
    }
}