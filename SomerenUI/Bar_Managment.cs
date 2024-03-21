using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class Bar_Managment : Form
    {
        private List<Drink> drinks = null;
        private DrinkService drinkService = new DrinkService();
        public Bar_Managment()
        {
            InitializeComponent();
        }
        private List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }
        private void DisplayDrinks(List<Drink> drinks)
        {
            listViewDrinks.Items.Clear();
            foreach (Drink drink in drinks)
            {
                ListViewItem listViewItem = new ListViewItem(drink.Id.ToString());
                listViewItem.SubItems.Add(drink.Name);
                listViewItem.SubItems.Add(drink.Type);
                listViewItem.SubItems.Add(drink.Price.ToString("F2"));
                listViewItem.SubItems.Add(drink.Stock.ToString());
                if(drink.Stock >= 10)
                {
                    listViewItem.SubItems.Add("Stock sufficient");
                }
                else if(drink.Stock == 0)
                {
                    listViewItem.SubItems.Add("No stock");
                }
                else
                {
                    listViewItem.SubItems.Add("Stock nearly depleted");
                }
                listViewItem.Tag = drink;

                listViewDrinks.Items.Add(listViewItem);
            }
        }
        private void Bar_Managment_Load(object sender, EventArgs e)
        {
           
            drinks = GetDrinks();
            DisplayDrinks(drinks);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count == 1)
            {
                Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                Edit_Drink edit_Drink = new Edit_Drink(drink);

                if (edit_Drink.ShowDialog() == DialogResult.OK)
                {
                    int index = drinks.FindIndex(d => d.Id == drink.Id);
                    if (index != -1)
                    {
                        drinks[index] = drink;
                    }
                    DisplayDrinks(drinks);
                }

            }
            else
            {
                MessageBox.Show("Select one item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonStock_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count == 1)
            {
                Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                Change_stock change_Stock = new Change_stock(drink);
                if (change_Stock.ShowDialog() == DialogResult.OK)
                {
                    int index = drinks.FindIndex(d => d.Id == drink.Id);
                    if (index != -1)
                    {
                        drinks[index] = drink;
                    }
                    DisplayDrinks(drinks);
                }
            }
            else
            {
                MessageBox.Show("Select one item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count == 1)
            {
                Drink drink = (Drink)listViewDrinks.SelectedItems[0].Tag;
                int index = drinks.FindIndex(d => d.Id == drink.Id);
                if (index != -1)
                {
                    drinks.RemoveAt(index);
                }
                DisplayDrinks(drinks);
            }
            else
            {
                MessageBox.Show("Select one item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            drink.Id = drinks.Count + 1;
            drink.Stock = 0;
            Add_Drink add_Drink = new Add_Drink(drink);
            if (add_Drink.ShowDialog() == DialogResult.OK)
            {
                drinks.Add(drink);
            }
            DisplayDrinks(drinks);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            List<Drink> drinksdb = GetDrinks();
            foreach(Drink drink in drinks)
            {
                Drink correspondingDrink = drinksdb.FirstOrDefault(d => d.Id == drink.Id);
                if (correspondingDrink != null)
                {
                    if( correspondingDrink.Name != drink.Name ||
                        correspondingDrink.Type != drink.Type ||
                        correspondingDrink.Price != drink.Price ||
                        correspondingDrink.Stock != drink.Stock)
                    {
                        drinkService.UpdateDrink(drink);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    drinkService.InsertDrink(drink);
                }
            }
            foreach (Drink drinkDb in drinksdb)
            {
                if (!drinks.Any(d => d.Id == drinkDb.Id))
                {
                    drinkService.DeleteDrink(drinkDb.Id);
                }
            }
            this.Close();
        }
    }
}
