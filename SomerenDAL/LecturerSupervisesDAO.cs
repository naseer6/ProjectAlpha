using Microsoft.Data.SqlClient;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturerSupervisesDAO : BaseDao
    {
        public void Insert(int lecturerId, int activityId)
        {
            string query = "INSERT INTO [Lecturer_Supervises] (LecturerId, ActivityId) VALUES (@lecturerId, @activityId)";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@lecturerId", lecturerId),
                new SqlParameter("@activityId", activityId)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void Delete(int lecturerId, int activityId)
        {
            string query = "DELETE FROM [Lecturer_Supervises] WHERE LecturerId = @lecturerId AND ActivityId = @activityId";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@lecturerId", lecturerId),
                new SqlParameter("@activityId", activityId)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
