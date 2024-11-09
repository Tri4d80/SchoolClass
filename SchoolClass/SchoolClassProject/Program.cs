using SchoolClassProject.Models;

namespace SchoolClassProject;

class Program
{
    private static void Main()
    {
        SchoolClass class9A = new SchoolClass(9, 'A', 70000);
        SchoolClass class9B = new SchoolClass(9, 'b', 55000);

        Console.WriteLine(class9A);
        Console.WriteLine(class9B);

        if (class9A.ClassMoney > class9B.ClassMoney)
        {
            Console.WriteLine($"{class9A.GetClassName()} " +
                              $"osztály többet fizet mint {class9B.GetClassName()} osztály " +
                              $"{class9A.ClassMoney - class9B.ClassMoney} Ft-tal" );
        } else if (class9A.ClassMoney < class9B.ClassMoney)
        {
            Console.WriteLine($"{class9B.GetClassName()} " +
                              $"osztály többet fizet mint {class9A.GetClassName()} osztály " +
                              $"{class9B.ClassMoney - class9A.ClassMoney} Ft-tal" );
        }
        else
        {
            Console.WriteLine($"{class9A.GetClassName()} osztály ugyanannyit fizet mint {class9B.ClassMoney}");
        }
    }
}