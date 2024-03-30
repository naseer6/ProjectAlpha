using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using SomerenModel;

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
,                };
                students.Add(student);
            }
            return students;
        }
    }
}