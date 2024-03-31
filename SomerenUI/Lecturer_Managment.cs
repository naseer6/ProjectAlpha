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
        TeachersService teacherService = new TeachersService();
        public Lecturer_Managment()
        {
            InitializeComponent();
        }


        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Teacher> GetTeachers()
        {

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





        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            Add_Teacher addNewTeacher = new Add_Teacher(teacher);
            if (addNewTeacher.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    teacherService.AddTeacher(teacher);
                    teachers = GetTeachers();
                    DisplayLecturers(teachers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonChange_Click_1(object sender, EventArgs e)
        {
            if (listViewTeachers_.SelectedItems.Count == 1)
            {
                Teacher selectedTeacher = (Teacher)listViewTeachers_.SelectedItems[0].Tag;
                Change_Lecturer updateTeacher = new Change_Lecturer(selectedTeacher);
                if (updateTeacher.ShowDialog() == DialogResult.OK)
                {
                    Teacher updatedTeacher = updateTeacher.GetUpdatedTeacher();
                    try
                    {
                        teacherService.UpdateTeacher(updatedTeacher);

                        teachers = GetTeachers();
                        DisplayLecturers(teachers);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select one student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewTeachers_.SelectedItems.Count == 1)
            {

                Teacher selectedTeacher = (Teacher)listViewTeachers_.SelectedItems[0].Tag;


                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    TeachersService teacherService = new TeachersService();
                    var success = teacherService.DeleteTeacher(selectedTeacher.Id);

                    if (success)
                    {
                        teachers = GetTeachers();
                        DisplayLecturers(teachers);


                    }
                    else
                    {
                        MessageBox.Show("Failed to delete teacher. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select one teacher to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
