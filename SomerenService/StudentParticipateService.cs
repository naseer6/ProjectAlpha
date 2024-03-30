using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class StudentParticipateService
    {
        private StudentParticipatesDAO studentParticipatesdb;

        public StudentParticipateService()
        {
            studentParticipatesdb = new StudentParticipatesDAO();
        }
        public void Insert(int studentId, int activityId)
        {
            studentParticipatesdb.Insert(studentId, activityId);
        }
        public void Delete(int studentId, int activityId)
        {
            studentParticipatesdb.Delete(studentId, activityId);
        }
    }
}
