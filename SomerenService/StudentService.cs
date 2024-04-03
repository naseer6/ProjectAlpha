using SomerenDAL;
using SomerenModel;
using System;
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

        public List<int> GetStudentIds()
        {
            List<int> studentIds = studentdb.GetAllStudentIds();
            return studentIds;
        }

        public bool AddStudent(Student student)
        {
            try
            {
                studentdb.AddStudent(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding student: " + ex.Message);
                return false;
            }
        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                studentdb.UpdateStudent(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating student: " + ex.Message);
                return false;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            try
            {
                studentdb.DeleteStudent(studentId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting student: " + ex.Message);
                return false;
            }
        }
    }
}