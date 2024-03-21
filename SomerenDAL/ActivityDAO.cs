using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {

        public List<Activity> GetAllActivities()
        {
            string query = "SELECT Id, Name, StartDate, EndDate FROM [Activities]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    Id = (int)dr["Id"],
                    Name = dr["Name"].ToString(),
                    StartDate = (DateTime)dr["StartDate"],
                    EndDate = (DateTime)dr["EndDate"]

                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
