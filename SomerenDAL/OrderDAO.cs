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
                Order order = new Order()
                {

                    Student_ID = (int)dr["Student_ID"],
                    Drink_ID = (int)dr["Drink_ID"],
                    Date = (DateTime)dr["Date"],
                    Quantity = (int)dr["Quantity"]
                };
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

    }
}
