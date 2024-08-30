using ClassObjectMethodDataExample;
Result student1Result = new Result();
student1Result.MathScore = 100;
student1Result.PhysicsScore = 90;
student1Result.ChemistryScore = 78;
Student student1 = new Student("76353-8353");
student1.Name = "Rana";
student1.StudentResult = student1Result;

double avgScore = student1.StudentResult.GetAvgScore();
//Console.WriteLine(avgScore.ToString());

Result student2Result = new Result();
student2Result.MathScore = 78;
student2Result.PhysicsScore = 96;
student2Result.ChemistryScore = 80;
Student student2 = new Student("652356423-2376");
student2.Name = "Milon";
student2.StudentResult = student2Result;

avgScore = student2.StudentResult.GetAvgScore();
//Console.WriteLine(avgScore.ToString());

Department department = new Department();
department.AddStudents(student1);
department.AddStudents(student2);

department.GetStudents().Add(student1);

Console.WriteLine(department.GetStudents().Count);
foreach (Student student in department.GetStudents())
{
    Console.WriteLine(student.Name + ": " + student.StudentResult.GetAvgScore());
}