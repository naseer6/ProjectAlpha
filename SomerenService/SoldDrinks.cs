using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class SoldDrinks
    {
        private OrderDAO orderdb;

        public SoldDrinks()
        {
            orderdb = new OrderDAO();
        }

        public (decimal alcoholicTotal, decimal nonAlcoholicTotal) GetTotal(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = orderdb.GetOrdersByDateRange(startDate, endDate);

            decimal alcoholicTurnover = 0;
            decimal nonAlcoholicTurnover = 0;

            var drinkdb = new DrinkDao();

            foreach (var order in orders)
            {
                Drink drink = drinkdb.GetDrinkById(order.Drink_ID);
                if (drink != null)
                {
                    if (drink.Type == "alcoholic")
                    {
                        alcoholicTurnover += order.Quantity * drink.Price * 0.21m;
                    }
                    else if (drink.Type == "non-alcoholic")
                    {
                        nonAlcoholicTurnover += order.Quantity * drink.Price * 0.06m;
                    }
                }
            }

            return (alcoholicTotal: alcoholicTurnover, nonAlcoholicTotal: nonAlcoholicTurnover);
        }
    }
}
