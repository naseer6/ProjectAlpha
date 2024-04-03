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
    public partial class UpdateStudent : Form
    {

        private Student updatedStudent;

        public UpdateStudent(Student student)
        {
            InitializeComponent();
            updatedStudent = student;
            firstName.Text = student.FirstName;
            lastName.Text = student.LastName;
            telNumber.Text = student.Tel;
            class1.Text = student.Class;
        }

        public Student GetUpdatedStudent()
        {
            updatedStudent.FirstName = firstName.Text;
            updatedStudent.LastName = lastName.Text;
            updatedStudent.Tel = telNumber.Text;
            updatedStudent.Class = class1.Text;
            return updatedStudent;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
