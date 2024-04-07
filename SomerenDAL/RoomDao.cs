using SomerenModel;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT Id, Number, Capacity, Type FROM [Rooms]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }



        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Id = (int)dr["Id"],
                    Number = dr["Number"].ToString(),
                    Capacity = (int)dr["Capacity"],
                    Type = dr["Type"].ToString()


                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
