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

namespace SomerenUI
{
    public partial class Add_Drink : Form
    {
        private Drink drink = null;
        public Add_Drink(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        private void Add_Drink_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                drink.Name = textBoxName.Text;
                drink.Price = decimal.Parse(textBoxPrice.Text);
                drink.Type = comboBoxType.Text;

                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
