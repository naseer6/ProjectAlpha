using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Change_Lecturer : Form
    {
        private Teacher _teacher = null;
        public Change_Lecturer(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;
        }

        private void Change_Lecturer_Load(object sender, EventArgs e)
        {

            if (_teacher != null)
            {
                textBoxFirstName.Text = _teacher.FirstName;
                textBoxLastName.Text = _teacher.LastName;
                textBoxTelNumber.Text = _teacher.TelephoneNumber.ToString();
                textBoxAge.Text = _teacher.Age.ToString();
            }
            else
            {
                MessageBox.Show("Teacher object is null.");
               
                this.Close();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _teacher.FirstName = textBoxFirstName.Text;
                _teacher.LastName = textBoxLastName.Text;
                int telNumber = int.Parse(textBoxTelNumber.Text);
                int age = int.Parse(textBoxAge.Text);
                if (age > 0)
                {
                    _teacher.Age = age;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Value");
                    DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
