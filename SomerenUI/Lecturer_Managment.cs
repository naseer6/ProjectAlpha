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
    public partial class Lecturer_Managment : Form
    {
        private List<Teacher> teachers = new List<Teacher>();
       
        public Lecturer_Managment()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Teacher teacher = new Teacher();


            Add_Teacher add_Teacher = new Add_Teacher(teacher);
            if (add_Teacher.ShowDialog() == DialogResult.OK)
            {
                teachers.Add(teacher);
            }
            DisplayLecturers(teachers);
        }

        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Teacher> GetTeachers()
        {
            TeachersService teacherService = new TeachersService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }



        private void DisplayLecturers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewTeachers_.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.Id.ToString());
                li.SubItems.Add(teacher.FirstName + " " + teacher.LastName);
                li.SubItems.Add(teacher.TelephoneNumber.ToString());
                li.SubItems.Add(teacher.Age.ToString());
                li.Tag = teacher;
                listViewTeachers_.Items.Add(li);
            }
        }

        private void Lecturer_Managment_Load(object sender, EventArgs e)
        {
            try
            {
                // get and display all teachers
                teachers = GetTeachers();
                DisplayLecturers(teachers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + ex.Message);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listViewTeachers_.SelectedItems.Count == 1)
            {
                Teacher teacher = (Teacher)listViewTeachers_.SelectedItems[0].Tag;
                Change_Lecturer changeLecturer = new Change_Lecturer(teacher);
                if (changeLecturer.ShowDialog() == DialogResult.OK)
                {
                    int index = teachers.FindIndex(d => d.Id == teacher.Id);
                    if (index != -1)
                    {
                        teachers[index] = teacher;
                    }
                    DisplayLecturers(teachers);
                }
            }
            else
            {
                MessageBox.Show("Select one item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewTeachers_.SelectedItems.Count == 1)
            {
                Teacher teacher = (Teacher)listViewTeachers_.SelectedItems[0].Tag;
                int index = teachers.FindIndex(d => d.Id == teacher.Id);
                if (index != -1)
                {
                    teachers.RemoveAt(index);
                }
                DisplayLecturers(teachers);
            }
            else
            {
                MessageBox.Show("Select one item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
