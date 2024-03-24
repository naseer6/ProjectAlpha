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

        public int GetTotalDrinksSold(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = orderdb.GetOrdersByDateRange(startDate, endDate);
            return orders.Sum(o => o.Quantity);
        }

        public decimal GetTurnover(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = orderdb.GetOrdersByDateRange(startDate, endDate);

            // Filter out orders with null Drink property
            orders = orders.Where(o => o.Drink != null).ToList();

            decimal turnover = orders.Sum(o => o.Quantity * o.Drink.Price);
            return turnover;
        }

        public int GetNumberOfCustomers(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = orderdb.GetOrdersByDateRange(startDate, endDate);
            int numberOfCustomers = orders.Select(o => o.Student_ID).Distinct().Count();
            return numberOfCustomers;
        }

    }
}
