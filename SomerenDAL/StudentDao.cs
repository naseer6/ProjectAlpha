using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT Id, FirstName, LastName, Tel, Class FROM [Students]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }



        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Id = (int)dr["Id"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    Tel = dr["Tel"].ToString(),
                    Class = dr["Class"].ToString()
,
                };
                students.Add(student);
            }
            return students;
        }

        public List<int> GetAllStudentIds()
        {
            string query = "SELECT Id FROM Students";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable resultTable = ExecuteSelectQuery(query, sqlParameters);

            List<int> studentIds = new List<int>();
            foreach (DataRow row in resultTable.Rows)
            {
                int studentId = Convert.ToInt32(row["Id"]);
                studentIds.Add(studentId);
            }
            return studentIds;
        }

        public void AddStudent(Student student)
        {
            string query = "INSERT INTO Students (Id, FirstName, LastName, Tel, Class) VALUES (@Id, @FirstName, @LastName, @Tel, @Class)";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", student.Id),
                new SqlParameter("@FirstName", student.FirstName),
                new SqlParameter("@LastName", student.LastName),
                new SqlParameter("@Tel", student.Tel),
                new SqlParameter("@Class", student.Class)
                };
            ExecuteEditQuery(query, parameters);
        }

        public void UpdateStudent(Student student)
        {
            string query = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Tel = @Tel, Class = @Class WHERE Id = @Id";
            SqlParameter[] parameters = {
        new SqlParameter("@FirstName", student.FirstName),
        new SqlParameter("@LastName", student.LastName),
        new SqlParameter("@Tel", student.Tel),
        new SqlParameter("@Class", student.Class),
        new SqlParameter("@Id", student.Id)
                 };
            ExecuteEditQuery(query, parameters);
        }

        public void DeleteStudent(int studentId)
        {
            string query = "DELETE FROM [Students] WHERE Id = @Id";
            SqlParameter[] parameters =
               {
                new SqlParameter("@Id", studentId)
            };
            ExecuteEditQuery(query, parameters);
        }

        public List<Student> GetByActivityId(int id)
        {
            string query = "SELECT * FROM [students] WHERE [Id] IN ( SELECT [StudentId] FROM [Student_Participate] WHERE [ActivityId] = @id);";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", id)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Student> GetNonAssignedStudents(int id)
        {
            string query = "SELECT * FROM [students] WHERE [Id] NOT IN ( SELECT [StudentId] FROM [Student_Participate] WHERE [ActivityId] = @id);";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", id)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


    }
}