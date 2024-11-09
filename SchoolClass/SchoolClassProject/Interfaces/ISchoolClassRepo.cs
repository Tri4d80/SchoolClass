using SchoolClassProject.Models;

namespace SchoolClassProject.Interfaces;

public interface ISchoolClassRepo
{
    List<SchoolClassWithPublicData> GetSchoolClassesPerYear(int schoolClassYear);
    SchoolClassWithPublicData GetSchoolClass(int schoolClassYear, char schoolClassId);
    
    void Add(SchoolClass schoolClass);
    void Remove(SchoolClass schoolClass);
    void Remove(int id);
    void Update(int schoolYear, char schoolClassId, int schoolClassMoney);
}