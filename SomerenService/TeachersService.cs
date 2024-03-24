using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class TeachersService
    {
        private LecturerDao teacherdb;

        public TeachersService()
        {
            teacherdb = new LecturerDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllLecturers();
            return teachers;
        }
        public List<Teacher> GetByActivityId(int id)
        {
            return teacherdb.GetByActivityId(id);
        }
        public List<Teacher> GetNonAssignedLecturers(int id)
        {
            return teacherdb.GetNonAssignedLecturers(id);
        }
    }
}
