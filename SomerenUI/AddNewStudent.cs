using SomerenModel;
using SomerenService;
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


        public Student GetNewStudent()
        {
            int newStudentId = GetNextStudentId();


            Student newStudent = new Student
            {
                Id = newStudentId,
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Tel = telNumber.Text,
                Class = class1.Text
            };

            return newStudent;
        }
        StudentService studentService = new StudentService();
        private int GetNextStudentId()
        {
            List<int> existingIds = studentService.GetStudentIds();

            if (existingIds.Count == 0)
            {
                return 1;
            }

            int maxId = existingIds.Max();
            return maxId + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
