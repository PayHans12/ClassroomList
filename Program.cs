using School;

Console.Clear();
List<Student> students = new ();

Teacher teacher = new Teacher("professor", students);

Student bryan = new Student(95.2, "Bryan");
Student evan = new Student(63.6, "Evan");
Student ally = new Student(76.8, "Ally");
Student ellie = new Student(66.7, "Ellie");
Student bob = new Student(83.4, "Bob");

teacher.AddStudent(bryan);
teacher.AddStudent(evan);
teacher.AddStudent(ally);
teacher.AddStudent(ellie);
teacher.AddStudent(bob);

teacher.DisplayStudents();

Console.WriteLine($"Average Grade: {teacher.CalulateAverageGrade()}");