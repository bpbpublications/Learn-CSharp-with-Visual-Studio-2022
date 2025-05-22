public class Student
{
    public string StdName { get; set; } = "Amelia";
    public int StdID { private get; set; }

    public Student(int stdId)
    {
        StdID = stdId;
    }
}
