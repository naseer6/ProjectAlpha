using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq;
using System;
using System.Globalization;
using System.Threading;

namespace SomerenUI
{

    public partial class SomerenUI : Form
    {

        public SomerenUI()
        {
            InitializeComponent();
        }
        //checking

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlRooms.Hide();
            pnlVAT.Hide();
            // show dashboard
            pnlDashboard.Show();
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels

            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlRooms.Hide();
            pnlVAT.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private void ShowTeachersPanel()
        {
            // hide all other panels

            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlRooms.Hide();
            pnlVAT.Hide();


            // show teachers
            pnlTeachers.Show();

            try
            {
                // get and display all teachers
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }

        private void ShowActivitiesPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRevenue.Hide();
            pnlRooms.Hide();
            pnlVAT.Hide();

            // show activities
            pnlActivities.Show();

            try
            {
                // get and display all students
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }


        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlRevenue.Hide();
            pnlActivities.Hide();
            pnlVAT.Hide();


            // show Rooms
            pnlRooms.Show();

            try
            {
                // get and display all students
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }


        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }
        private List<Teacher> GetTeachers()
        {
            TeachersService teacherService = new TeachersService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                // Create a new ListViewItem and add student attributes to it
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.SubItems.Add(student.FirstName + " " + student.LastName);
                li.SubItems.Add(student.Tel);
                li.SubItems.Add(student.Class);
                listViewStudents.Items.Add(li);
            }
        }
        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewTeachers.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.Id.ToString());
                li.SubItems.Add(teacher.FirstName + " " + teacher.LastName);
                li.SubItems.Add(teacher.TelephoneNumber.ToString());
                li.SubItems.Add(teacher.Age.ToString());
                listViewTeachers.Items.Add(li);
            }
        }

        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            listViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.Id.ToString());
                li.SubItems.Add(activity.Name);
                li.SubItems.Add(activity.StartDate.ToString());
                li.SubItems.Add(activity.EndDate.ToString());
                listViewActivities.Items.Add(li);
            }
        }

        private void ShowRevenuePanel()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Show();
            pnlRooms.Hide();
            pnlVAT.Hide();
        }


        private void ShowVATPanel()
        {
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlRooms.Hide();
            pnlVAT.Show();
        }


        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.Id.ToString());
                li.SubItems.Add(room.Number.ToString());
                li.SubItems.Add(room.Capacity.ToString());
                li.SubItems.Add(room.Type.ToString());
                li.Tag = room;   // link room object to listview item
                listViewRooms.Items.Add(li);
            }
        }





        private void SomerenUI_Load(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }
        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (endDate < startDate || endDate > DateTime.Today)
            {
                MessageBox.Show("Please select a valid date period.");
                return;
            }


        }



        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        


        




        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void barManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bar_Managment bar_Managment = new Bar_Managment();
            bar_Managment.Show();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();

        }

        private void vATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVATPanel();
        }


    }
}