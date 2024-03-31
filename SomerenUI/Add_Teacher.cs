using SomerenModel;
using SomerenService;
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
        private void buttonAdd_Click_1(object sender, EventArgs e) {

            try
            {
                teacher.FirstName = textBoxFirstName.Text;
                teacher.LastName = textBoxLastName.Text;
                teacher.TelephoneNumber = int.Parse(textBoxTelNumber.Text);
                teacher.Age = int.Parse(textBoxAge.Text);
                DialogResult = DialogResult.OK;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
