using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
        public void InsertDrink(Drink drink)
        {
            drinkdb.InsertDrink(drink);
        }
        public void UpdateDrink(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }
        public void UpdateStock(int amount, int id)
        {
            drinkdb.UpdateStock(amount, id);
        }
        public void DeleteDrink(int id)
        {
            drinkdb.DeleteDrink(id);
        }
    }
}
