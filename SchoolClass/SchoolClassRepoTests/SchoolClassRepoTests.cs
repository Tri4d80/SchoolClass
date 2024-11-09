using SchoolClassProject.Models;
using SchoolClassProject.Repositories;

namespace SchoolClassRepoTests;

[TestClass]
public class SchoolClassRepoTests
{
    [TestMethod]
    public void Test_AddSchoolClass()
    {
        // Arrange:
        SchoolClassRepo schoolClassRepo = new SchoolClassRepo();
        
        // Act:
        SchoolClass sc1A = new SchoolClass(1, 'A', 70000);
        schoolClassRepo.Add(sc1A);

        // Assert:
        Assert.AreEqual(1, schoolClassRepo.NumberOfSchoolClasses, "Osztály hozzáadása sikertelen volt!");
        bool existsClass = (schoolClassRepo.SchoolClasses.Exists(sc => sc.SchoolYear == 1)) 
                           && schoolClassRepo.SchoolClasses.Exists(sc => sc.ClassLetter == 'a');
        Assert.IsTrue(existsClass, "Ezekkel a paraméterekkel nem létezik osztály a repo-ban!");
    }
}