using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT Id, Name, Type, Price, Stock FROM [Drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateDrink(Drink drink)
        {
            string query = "UPDATE [Drink] SET Name = @Name, Type = @Type, Price = @Price, Stock = @Stock WHERE Id = @Id";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Name", drink.Name),
                new SqlParameter("@Type", drink.Type),
                new SqlParameter("@Price", drink.Price),
                new SqlParameter("@Stock", drink.Stock),
                new SqlParameter("@Id", drink.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateStock(int amount, int id)
        {
            string query = "UPDATE [Drink] SET Stock = @Stock WHERE Id = @Id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Stock", amount),
                new SqlParameter("Id", id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void InsertDrink(Drink drink)
        {
            string query = "INSERT INTO [Drink] (Id, Name, Type, Price, Stock) VALUES (@Id, @Name, @Type, @Price, @Stock)";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Id", drink.Id),
                new SqlParameter("@Name", drink.Name),
                new SqlParameter("@Type", drink.Type),
                new SqlParameter("@Price", drink.Price),
                new SqlParameter("@Stock", drink.Stock)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteDrink(int DrinkId)
        {
            string query = "DELETE FROM [Drink] WHERE Id = @Id";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Id", DrinkId)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Id = (int)dr["Id"],
                    Name = dr["Name"].ToString(),
                    Type = dr["Type"].ToString(),
                    Price = (decimal)dr["Price"],
                    Stock = (int)dr["Stock"]
                };

                drinks.Add(drink);
            }

            return drinks;
        }


        public List<Drink> GetDrinksByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT d.Id, d.Name, d.Type, d.Price, d.Stock " +
                           "FROM [Drink] d " +
                           "INNER JOIN [Orders] o ON d.Id = o.Drink_ID " +
                           "WHERE o.Date >= @StartDate AND o.Date <= @EndDate";

            SqlParameter[] sqlParameters =
            {
        new SqlParameter("@StartDate", startDate),
        new SqlParameter("@EndDate", endDate)
    };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable);
        }

        public Drink GetDrinkById(int drinkId)
        {
            string query = "SELECT Id, Name, Type, Price, Stock FROM [Drink] WHERE Id = @Id";
            SqlParameter[] sqlParameters =
            {
        new SqlParameter("@Id", drinkId)
    };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable).FirstOrDefault(); 
        }



    }
}

