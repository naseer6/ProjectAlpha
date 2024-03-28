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
using static System.Windows.Forms.LinkLabel;

namespace SomerenUI
{
    public partial class Add_Teacher : Form
    {
        private Teacher teacher = null;
        public Add_Teacher(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
        }

        private void Add_Teacher_Load(object sender, EventArgs e)
        {
           

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                teacher.FirstName = textBoxFirstName.Text;
                teacher.LastName = textBoxLastName.Text; ;
                int telephoneNumber = int.Parse(textBoxTelNumber.Text);
                int age = int.Parse(textBoxAge.Text);
                if (age > 0)
                {
                    teacher.Age = age;
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
