

namespace StudentManager
{
    public class Subject
    {
        public static List<Subject> _allSubjects = new List<Subject>();

        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public static List<Subject> Fill()
        {
            var random = new Random();
            var subjects = new List<string> { "Math", "Physics", "Chemistry", "Biology", "History" };
            var subjectList = new List<Subject>();

            
            for (int i = 0; i < 5; i++)
            {
                subjectList.Add(new Subject
                {
                    Id = random.Next(1, 1000),
                    Name = subjects[random.Next(subjects.Count)],
                    
                    Grade = random.Next(50, 101),
                    Date = DateTime.Now.AddDays(-random.Next(1, 30))
                });
            }

            _allSubjects.AddRange(subjectList);

           
            return subjectList;
        }


        public static List<Subject> GetByStudentId(int studentId)
        {
            return _allSubjects.Where(s => s.StudentId == studentId).ToList();
        }

    }
}
