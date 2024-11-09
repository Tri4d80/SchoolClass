namespace SchoolClassProject.Models;

public class SchoolClass
{
    private int _schoolYear;
    private char _classLetter;
    private int _classMoney;

    public SchoolClass()
    {
        _classMoney = -1;
        _classLetter = 'X';
        _schoolYear = 0;
    }

    public SchoolClass(int schoolYear, char classLetter, int classMoney)
    {
        _classMoney = classMoney;
        _classLetter = classLetter;
        _schoolYear = schoolYear;
    }
    
    public int SchoolYear { get => _schoolYear; set => _schoolYear = value; }
    public char ClassLetter { get => _classLetter; set => _classLetter = value; }
    public int ClassMoney { get => _classMoney; set => _classMoney = value; }
}