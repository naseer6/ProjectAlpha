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
        public Add_Teacher()
        {
            InitializeComponent();

        }

        public Teacher GetNewTeacher()
        {
            int newTeacherId = GetNextTeacherId();


            Teacher newTeacher = new Teacher
            {
                Id = newTeacherId,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                TelephoneNumber = int.Parse(textBoxTelNumber.Text),
                Age = int.Parse(textBoxAge.Text),
            };

            return newTeacher;
        }
        TeachersService teachersService = new TeachersService();
        private int GetNextTeacherId()
        {


            List<int> existingIds = teachersService.GetTeachersIds();


            if (existingIds.Count == 0)
            {
                return 1;
            }


            int maxId = existingIds.Max();
            return maxId + 1;
        }



        private void Add_Teacher_Load(object sender, EventArgs e)
        {


        }

       

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
