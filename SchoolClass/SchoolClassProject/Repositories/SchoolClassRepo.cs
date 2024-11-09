using SchoolClassProject.Interfaces;
using SchoolClassProject.Models;

namespace SchoolClassProject.Repositories;

public class SchoolClassRepo : ISchoolClassRepo
{
    private List<SchoolClass> _schoolClasses = new();

    public List<SchoolClassWithPublicData> GetSchoolClassesPerYear(int schoolClassYear)
    {
        return new List<SchoolClassWithPublicData>();
    }

    public SchoolClassWithPublicData GetSchoolClass(int schoolClassYear, char schoolClassId)
    {
        return new SchoolClassWithPublicData();
    }

    public void Add(SchoolClass schoolClass) {}
    public void Remove(SchoolClass schoolClass) {}
    public void Remove(int id) {}
    public void Update(int schoolYear, char schoolClassId, int schoolClassMoney) {}
}