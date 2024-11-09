using System.Diagnostics.Metrics;

namespace SchoolClassProject.Models;

public class SchoolClass
{
    private static int _idCounter = 0;
    private int _id;
    private int _schoolYear;
    private char _classLetter;
    private int _classMoney;

    public SchoolClass()
    {
        _classMoney = -1;
        _classLetter = 'x';
        _schoolYear = 0;
        _id = Counter();
    }

    public SchoolClass(int schoolYear, char classLetter, int classMoney)
    {
        _classMoney = classMoney;
        _classLetter = char.ToLower(classLetter);
        _schoolYear = schoolYear;
        _id = Counter();
    }

    private int Counter()
    {
        return _idCounter++;
    }
    
    
    public int Id { get => _id; }
    public int SchoolYear { get => _schoolYear; set => _schoolYear = value; }
    public char ClassLetter { get => _classLetter; set => _classLetter = char.ToLower(value); }
    public int ClassMoney { get => _classMoney; set => _classMoney = value; }

    public override string ToString()
    {
        return $"Osztály: (ID: {_id}){_schoolYear}.{_classLetter}, osztálypénze: {_classMoney} Ft";
    }

    public string GetClassName()
    {
        return $"{SchoolYear}.{ClassLetter}";
    }
}