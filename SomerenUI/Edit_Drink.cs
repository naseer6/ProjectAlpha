using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SomerenModel;

namespace SomerenUI
{
    public partial class Edit_Drink : Form
    {
        private Drink _drink = null;
        public Edit_Drink(Drink drink)
        {
            InitializeComponent();
            _drink = drink;
        }

        private void Edit_Drink_Load(object sender, EventArgs e)
        {
            textBoxName.Text = _drink.Name;
            textBoxPrice.Text = _drink.Price.ToString();
            if (_drink.Type == "alcoholic")
            {
                comboBoxType.SelectedItem = comboBoxType.Items[0];
            }
            else if (_drink.Type == "non-alcoholic")
            {
                comboBoxType.SelectedItem = comboBoxType.Items[1];
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _drink.Name = textBoxName.Text;
                _drink.Type = comboBoxType.Text;
                decimal price = decimal.Parse(textBoxPrice.Text);
                if (price > 0)
                {
                    _drink.Price = price;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Value");
                    DialogResult = DialogResult.No;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
