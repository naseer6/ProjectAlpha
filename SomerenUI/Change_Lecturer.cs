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
        private Teacher _teacher;
        public Change_Lecturer(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            textBoxFirstName.Text = teacher.FirstName;
            textBoxLastName.Text = teacher.LastName;
            textBoxTelNumber.Text = teacher.TelephoneNumber.ToString();
            textBoxAge.Text = teacher.Age.ToString();

        }

        public Teacher GetUpdatedTeacher()
        {

            _teacher.FirstName = textBoxFirstName.Text;
            _teacher.LastName = textBoxLastName.Text;
            _teacher.TelephoneNumber = int.Parse(textBoxTelNumber.Text);
            _teacher.Age = int.Parse(textBoxAge.Text);
            return _teacher;
        }

        private void Change_Lecturer_Load(object sender, EventArgs e)
        {



        }

       

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
