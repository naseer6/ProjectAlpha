﻿using SomerenModel;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

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
    }
}
