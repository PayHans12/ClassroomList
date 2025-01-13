namespace School;

public class Student
{
    public Student(double grade, string name)
    {
        this.grade = grade;
        this.name = name;
    }

    public double grade {get; set;}
    public string name {get; set;}
}

public class Teacher
{
    public Teacher(string name, List<Student> students)
    {
        this.name = name;
        this.students = students;
    }

    public string name {get; set;}
    public List<Student> students {get; set;}

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DisplayStudents()
    {
        foreach(Student student in students)
        {
            Console.WriteLine($"{student.name}: {student.grade}");
        }
    }

    public double CalulateAverageGrade()
    {
        double total = 0;
        foreach(Student student in students)
        {
            total += student.grade;
        }

        double average = total / students.Count;
        return average;
    }
}