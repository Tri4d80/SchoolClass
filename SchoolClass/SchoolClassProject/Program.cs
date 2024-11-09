using SchoolClassProject.Models;
using SchoolClassProject.Repositories;

namespace SchoolClassProject;

class Program
{
    private static void Main()
    {
        SchoolClass class9A = new SchoolClass(9, 'A', 70000);
        SchoolClass class9B = new SchoolClass(9, 'b', 55000);
        SchoolClass class10A = new SchoolClass(10, 'b', 100000);
        SchoolClass class10B = new SchoolClass(10, 'b', 155000);

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
            Console.WriteLine($"{class9A.GetClassName()} osztály ugyanannyit fizet mint {class9B.GetClassName()}");
        }
        Console.WriteLine("-------------------------------");
        
        // Add actions
        SchoolClassRepo repo = new SchoolClassRepo();
        repo.Add(class9A);
        repo.Add(class9B);
        repo.Add(class10A);
        repo.Add(class10B);
        Console.WriteLine($"Az osztályok száma a repo-ban: {repo.NumberOfSchoolClasses}");
        Console.WriteLine("-------------------------------");
        
        // Remove actions
        repo.Remove(9, 'a');
        repo.Remove(1);
        Console.WriteLine($"Az osztályok száma a repo-ban: {repo.NumberOfSchoolClasses}");
        Console.WriteLine("-------------------------------");
        
        // Update actions
        repo.Update(10, 'b', 99000);
        repo.Update(10, 'a', 20000);
        
        
        foreach (var sc in repo.SchoolClasses)    
        {
            Console.WriteLine(sc);
        }
        Console.WriteLine("-------------------------------");
        
        
    }
}