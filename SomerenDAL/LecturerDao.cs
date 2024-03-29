using SomerenModel;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        public List<Teacher> GetAllLecturers()
        {
            string query = "SELECT Id, FirstName, LastName, TelephoneNumber, Age FROM [lecturers]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetByActivityId(int id)
        {
            string query = "SELECT * FROM [lecturers] WHERE [Id] IN ( SELECT [LecturerId] FROM [Lecturer_Supervises] WHERE [ActivityId] = @id);";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", id)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetNonAssignedLecturers(int id)
        {
            string query = "SELECT * FROM [lecturers] WHERE [Id] NOT IN ( SELECT [LecturerId] FROM [Lecturer_Supervises] WHERE [ActivityId] = @id);";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id", id)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Id = (int)dr["Id"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    TelephoneNumber = (int)dr["TelephoneNumber"],
                    Age = (int)dr["Age"]

                };
                teachers.Add(teacher);
            }
            return teachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            string query = "INSERT INTO lecturers (Id, FirstName, LastName, TelephoneNumber, Age) VALUES (@Id, @FirstName, @LastName, @TelephoneNumber, @Age)";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", teacher.Id),
                new SqlParameter("@FirstName", teacher.FirstName),
                new SqlParameter("@LastName", teacher.LastName),
                new SqlParameter("@TelephoneNumber", teacher.TelephoneNumber),
                new SqlParameter("@Age", teacher.Age)
    };
            ExecuteEditQuery(query, parameters);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            string query = "UPDATE lecturers SET FirstName = @FirstName, LastName = @LastName, TelephoneNumber = @TelephoneNumber, Age = @Age WHERE Id = @Id";
            SqlParameter[] parameters = {
        new SqlParameter("@FirstName", teacher.FirstName),
        new SqlParameter("@LastName", teacher.LastName),
        new SqlParameter("@TelephoneNumber", teacher.TelephoneNumber),
        new SqlParameter("@Age", teacher.Age),
        new SqlParameter("@Id", teacher.Id)
    };
            ExecuteEditQuery(query, parameters);
        }

        public void DeleteTeacher(int teacherId)
        {
            string query = "DELETE FROM [lecturers] WHERE Id = @Id";
            SqlParameter[] parameters =
               {
                new SqlParameter("@Id", teacherId)
            };
            ExecuteEditQuery(query, parameters);
        }

        public List<int> GetAllLecturersIds()
        {
            string query = "SELECT Id FROM lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable resultTable = ExecuteSelectQuery(query, sqlParameters);

            List<int> teacherIds = new List<int>();
            foreach (DataRow row in resultTable.Rows)
            {
                int teacherId = Convert.ToInt32(row["Id"]);
                teacherIds.Add(teacherId);
            }
            return teacherIds;
        }
    }
}
