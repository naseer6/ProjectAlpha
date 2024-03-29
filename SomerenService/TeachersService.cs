using SomerenDAL;
using SomerenModel;
using System;
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

        public List<int> GetTeachersIds()
        {
            List<int> teacherIds = teacherdb.GetAllLecturersIds();
            return teacherIds;
        }

        public bool AddTeacher(Teacher teacher)
        {
            try
            {

                teacherdb.AddTeacher(teacher);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding teacher: " + ex.Message);
                return false;
            }
        }

        public bool UpdateTeacher(Teacher teacher)
        {
            try
            {

                teacherdb.UpdateTeacher(teacher);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating teacher: " + ex.Message);
                return false;
            }
        }

        public bool DeleteTeacher(int teacherId)
        {
            try
            {

                teacherdb.DeleteTeacher(teacherId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting teacher: " + ex.Message);
                return false;
            }
        }
    }
}
