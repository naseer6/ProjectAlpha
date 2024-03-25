using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SomerenDAL
{
    public class OrderDAO : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT Student_ID, Drink_ID, Date, Quantity FROM [Orders]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();

                // Check for DBNull values before casting
                order.Student_ID = dr["Student_ID"] != DBNull.Value ? (int)dr["Student_ID"] : 0;
                order.Drink_ID = dr["Drink_ID"] != DBNull.Value ? (int)dr["Drink_ID"] : 0;
                order.Date = dr["Date"] != DBNull.Value ? (DateTime)dr["Date"] : DateTime.MinValue;
                order.Quantity = dr["Quantity"] != DBNull.Value ? (int)dr["Quantity"] : 0;

                orders.Add(order);
            }

            return orders;
        }

        public void InsertOrder(Order order)
        {
            string orderQuery = "INSERT INTO [Orders] (Student_ID, Drink_ID, Date, Quantity) VALUES (@Student_ID, @Drink_ID, @Date, @Quantity)";

            string drinkQuery = "UPDATE [Drink] SET Stock = Stock - @Quantity WHERE ID = @Drink_ID";

            SqlParameter[] orderParameters =
            {
        new SqlParameter("@Student_ID", order.Student_ID),
        new SqlParameter("@Drink_ID", order.Drink_ID),
        new SqlParameter("@Date", order.Date),
        new SqlParameter("@Quantity", order.Quantity)
    };

            SqlParameter[] drinkParameters =
            {
        new SqlParameter("@Quantity", order.Quantity),
        new SqlParameter("@Drink_ID", order.Drink_ID)
    };

            ExecuteEditQuery(orderQuery, orderParameters);
            ExecuteEditQuery(drinkQuery, drinkParameters);
        }


        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT o.Student_ID, o.Drink_ID, o.Date, o.Quantity, d.Price " +
                           "FROM [Orders] o " +
                           "INNER JOIN [Drink] d ON o.Drink_ID = d.Id " +
                           "WHERE o.Date >= @StartDate AND o.Date <= @EndDate";

            SqlParameter[] sqlParameters =
            {
        new SqlParameter("@StartDate", startDate),
        new SqlParameter("@EndDate", endDate)
    };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable);
        }




    }
}
