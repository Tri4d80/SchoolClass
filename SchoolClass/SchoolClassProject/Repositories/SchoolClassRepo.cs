using SchoolClassProject.Interfaces;
using SchoolClassProject.Models;

namespace SchoolClassProject.Repositories;

public class SchoolClassRepo : ISchoolClassRepo
{
    public int NumberOfSchoolClasses => SchoolClasses.Count;
    public List<SchoolClass> SchoolClasses { get; }

    public SchoolClassRepo()
    {
        SchoolClasses = new();
    }

    public List<SchoolClassWithPublicData> GetSchoolClassesPerYear(int schoolClassYear)
    {
        return new List<SchoolClassWithPublicData>();
    }

    public SchoolClassWithPublicData GetSchoolClass(int schoolClassYear, char schoolClassId)
    {
        return new SchoolClassWithPublicData();
    }

    public void Add(SchoolClass schoolClass)
    {
        SchoolClasses.Add(schoolClass);
    }

    public void Remove(int schoolYear, char schoolClassId)
    {
        SchoolClass? removeByClass = SchoolClasses.Find(sc => sc.SchoolYear == schoolYear && sc.ClassLetter == schoolClassId);
        if (removeByClass is not null) 
        {
            SchoolClasses.Remove(removeByClass);
        }
    }

    public void Remove(int id)
    {
        SchoolClass? removeById = SchoolClasses.Find(sc => sc.Id == id);
        if (removeById is not null)
        {
            SchoolClasses.Remove(removeById);
        }
    }

    public void Update(int schoolYear, char schoolClassId, int schoolClassMoney)
    {
        SchoolClass? updateByClass= SchoolClasses.Find(sc => sc.SchoolYear == schoolYear && sc.ClassLetter == schoolClassId);
        if (updateByClass is not null)
        {
            updateByClass.ClassMoney = schoolClassMoney;
        }
    }
}