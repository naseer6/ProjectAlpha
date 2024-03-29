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
    public partial class ManageStudents : Form
    {
        private List<Student> students = new List<Student>();
        private StudentService studentService = new StudentService();
        public ManageStudents()
        {

            InitializeComponent();

        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            try
            {

                students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception eventArgs)
            {
                MessageBox.Show("Something went wrong while loading the students: " + eventArgs.Message);
            }
        }







        private List<Student> GetStudents()
        {

            List<Student> students = studentService.GetStudents();
            return students;
        }
        private void DisplayStudents(List<Student> students)
        {

            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {

                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.SubItems.Add(student.FirstName);
                li.SubItems.Add(student.LastName);
                li.SubItems.Add(student.Tel);
                li.SubItems.Add(student.Class);
                li.Tag = student;
                listViewStudents.Items.Add(li);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddNewStudent addNewStudent = new AddNewStudent();
            if (addNewStudent.ShowDialog() == DialogResult.OK)
            {
                Student newStudent = addNewStudent.GetNewStudent();
                try
                {
                    studentService.AddStudent(newStudent);

                    students = GetStudents();
                    DisplayStudents(students);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                Student selectedStudent = (Student)listViewStudents.SelectedItems[0].Tag;
                UpdateStudent updateStudent = new UpdateStudent(selectedStudent);
                if (updateStudent.ShowDialog() == DialogResult.OK)
                {
                    Student updatedStudent = updateStudent.GetUpdatedStudent();
                    try
                    {
                        studentService.UpdateStudent(updatedStudent);

                        students = GetStudents();
                        DisplayStudents(students);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select one student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {

                Student selectedStudent = (Student)listViewStudents.SelectedItems[0].Tag;


                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    StudentService studentService = new StudentService();
                    var success = studentService.DeleteStudent(selectedStudent.Id);

                    if (success)
                    {
                        students = GetStudents();
                        DisplayStudents(students);


                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select one student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
