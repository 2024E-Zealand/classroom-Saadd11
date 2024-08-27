using System.Dynamic;

namespace ClassRoomNet60;

public class ClassRoom
{
    //Instans
    public string _ClassName;
    public List<Student> StudentList;
    public int _DatetimeSemesterStart;

    //Prob
    public string ClassName
    {
        get { return _ClassName; }
        set { ClassName = value; }
    }

    public int DatetimeSemesterStart
    {
        get { return _DatetimeSemesterStart;}
        set { DatetimeSemesterStart = value; }
    }

    public List<Student> StudentList1
    {
        get {return StudentList; }
        set { StudentList = value; }
    }


    public ClassRoom(string className, List<Student> studentList, int datetimeSemesterStart)
    {
        _ClassName = className;
        StudentList = studentList;
        _DatetimeSemesterStart = datetimeSemesterStart;
    }
}