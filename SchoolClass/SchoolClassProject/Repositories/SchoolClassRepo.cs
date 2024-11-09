using SchoolClassProject.Models;

namespace SchoolClassProject.Repositories;

public class SchoolClassRepo
{
    private List<SchoolClass> _schoolClasses = new();
    
    public void AddSchoolClass(SchoolClass schoolClass) {}
    public void RemoveSchoolClass(SchoolClass schoolClass) {}
    public void RemoveSchoolClassById(int id) {}
    public void Update(int schoolYear, char schoolClassId, int schoolClassMoney) {}
}