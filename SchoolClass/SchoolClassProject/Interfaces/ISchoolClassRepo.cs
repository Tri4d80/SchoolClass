using SchoolClassProject.Models;

namespace SchoolClassProject.Interfaces;

public interface ISchoolClassRepo
{
    
    public int NumberOfSchoolClasses { get; }
    List<SchoolClass> SchoolClasses { get; }
    
    List<SchoolClassWithPublicData> GetSchoolClassesPerYear(int schoolClassYear);
    SchoolClassWithPublicData GetSchoolClass(int schoolClassYear, char schoolClassId);
    
    void Add(SchoolClass schoolClass);
    void Remove(int schoolYear, char schoolClassId);
    void Remove(int id);
    void Update(int schoolYear, char schoolClassId, int schoolClassMoney);
}