using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class StudentParticipatesDAO : BaseDao
    {
        public void Insert(int studentId, int activityId)
        {
            string query = "INSERT INTO [Student_Participate] (StudentId, ActivityId) VALUES (@studentId, @activityId)";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@studentId", studentId),
                new SqlParameter("@activityId", activityId)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void Delete(int studentId, int activityId)
        {
            string query = "DELETE FROM [Student_Participate] WHERE StudentId = @studentId AND ActivityId = @activityId";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@studentId", studentId),
                new SqlParameter("@activityId", activityId)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }

}

