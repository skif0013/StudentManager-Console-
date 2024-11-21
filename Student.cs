

namespace StudentManager
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public List<Subject>? Subjects { get; set; }
        public double AverageGrade { get; set; }
        public string Grant { get; set; }

        public static List<Student> Fill()
        {
            
            return new List<Student>
            {
                new Student { Id = 1, FirstName = "Evgeniy", SecondName = "Lazarev", Age = 21, Subjects = Subject.Fill() },
                new Student { Id = 2, FirstName = "Maxim", SecondName = "Melnikov", Age = 19, Subjects = Subject.Fill() },
                new Student { Id = 3, FirstName = "Andrey", SecondName = "Kuzmenko", Age = 23, Subjects = Subject.Fill() }
            };
        }

        

        public static void SetSubjects( Student student1)
        {
            
            foreach (var subject in student1.Subjects)
            {
                subject.StudentId = student1.Id;
            }
        }

        public static void CalculateAverageGrade(Student stud)
        {
           
            double res = 0;

           foreach(var subject in stud.Subjects)
            {
                res += subject.Grade;
            }

            stud.AverageGrade = res / stud.Subjects.Count;
        }

        public static void PrintStudentInfo(Student student)
        {
            Console.WriteLine($"{"ID",-5} | {"FirstName",-15} | {"SecondName",-15} | {"Age",-5} | {"AverageGrade",-12} | {"Grant", -12}");
            Console.WriteLine(new string('-', 55));

            Console.WriteLine($"{student.Id,-5} | {student.FirstName,-15} | {student.SecondName,-15} | {student.Age,-5} | {student.AverageGrade,-12} | {student.Grant, -12}");
        }

        public static void SetGrant(Student stud)
        {
            if (stud.AverageGrade < 60)
            {
                stud.Grant = "None";
            }
            else if (stud.AverageGrade >= 60 && stud.AverageGrade < 90)
            {
                stud.Grant = "Regular";
            }
            else
            {
                stud.Grant = "Increased";
            }
        }

    }
}
