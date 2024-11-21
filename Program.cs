
using StudentManager;


Console.WriteLine("Привіт юзер");



var students = Student.Fill();

for (int i = 0; i < students.Count; i++)
{
    Student.SetSubjects(students[i]);
}

for (int i = 0; i < students.Count; i++)
{
    Student.CalculateAverageGrade(students[i]);
}


for (int i = 0; i < students.Count; i++)
{
    Student.SetGrant(students[i]);
}


Console.WriteLine("список всех предметов");
foreach (var _object in Subject._allSubjects)
{
    Console.WriteLine($"ID: {_object.Id}, Name: {_object.Name}, StudentId: {_object.StudentId}, Grade: {_object.Grade}, Date: {_object.Date}");
}

Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------------------------\n");





Console.WriteLine("список всех студентов");
foreach (var studet in students)
{
    Console.WriteLine($"Id: {studet.Id}, FirstName: {studet.FirstName}, SecondName: {studet.SecondName}, Age: {studet.Age}");
}

Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------------------------\n");





Student.PrintStudentInfo(students[0]);









