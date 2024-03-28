using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student GetNewStudent()
            {
                
                Student newStudent = new Student
                {
                    
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Tel = telNumber.Text,
                    Class = class1.Text
                };

                return newStudent;
            }
            MessageBox.Show("Student added successfully!");
        }
    }
}
