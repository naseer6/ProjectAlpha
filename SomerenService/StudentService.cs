using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }
        public List<Student> GetByActivityId(int id)
        {
            return studentdb.GetByActivityId(id);
        }
        public List<Student> GetNonAssignedStudents(int id)
        {
            return studentdb.GetNonAssignedStudents(id);
        }

    }
}