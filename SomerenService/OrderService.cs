using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDAO orderdb;

        public OrderService()
        {
            orderdb = new OrderDAO();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }
        public void InsertOrder(Order order)
        {
            orderdb.InsertOrder(order);
        }
       
    }
}
