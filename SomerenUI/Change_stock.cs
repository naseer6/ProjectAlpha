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
    public partial class Change_stock : Form
    {
        private Drink _drink = null;
        public Change_stock(Drink drink)
        {
            InitializeComponent();
            _drink = drink;
        }

        private void Change_stock_Load(object sender, EventArgs e)
        {
            textBoxStock.Text = _drink.Stock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _drink.Stock = int.Parse(textBoxStock.Text);
                if(_drink.Stock < 0)
                {
                    MessageBox.Show("invalid value");
                    DialogResult = DialogResult.No;
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
