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

            
            orders = orders.Where(o => o.Drink_ID != 0).ToList();

            decimal turnover = 0;

            
            var drinkdb = new DrinkDao();

            foreach (var order in orders)
            {
               
                Drink drink = drinkdb.GetDrinkById(order.Drink_ID);
                if (drink != null)
                {
                    
                    turnover += order.Quantity * drink.Price;
                }
            }

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

