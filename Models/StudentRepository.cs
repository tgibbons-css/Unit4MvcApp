namespace Unit4MvcApp.Models;

     public class StudentRepository
    {
        static private List<StudentModel> students = new List<StudentModel>();

        public StudentRepository()
        {
            students.Add(new StudentModel(1001, "Tom", 16));
            students.Add(new StudentModel(1002, "Sabah", 16));
            students.Add(new StudentModel(1003, "Sarah", 16));
        }

        public List<StudentModel> getAllStudents()
        {
            return students;
        }

        public StudentModel getStudentById(int id)
        {
            return students.Find(s => s.Id == id);
        }

        public void addStudent(StudentModel student)
        {
            students.Add(student);
        }
    }