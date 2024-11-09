using SchoolClassProject.Interfaces;
using SchoolClassProject.Models;

namespace SchoolClassProject.Repositories;

public class SchoolClassRepo : ISchoolClassRepo
{
    private List<SchoolClass> _schoolClasses = new();
    
    public void Add(SchoolClass schoolClass) {}
    public void Remove(SchoolClass schoolClass) {}
    public void Remove(int id) {}
    public void Update(int schoolYear, char schoolClassId, int schoolClassMoney) {}
}