using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class LecturerSupervisesService
    {
        private LecturerSupervisesDAO lecturerSupervisesdb;

        public LecturerSupervisesService()
        {
            lecturerSupervisesdb = new LecturerSupervisesDAO();
        }
        public void Insert(int lecturerId, int activityId)
        {
            lecturerSupervisesdb.Insert(lecturerId, activityId);
        }
        public void Delete(int lecturerId, int activityId)
        {
            lecturerSupervisesdb.Delete(lecturerId, activityId);
        }
    }
}
