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
    public partial class Activity_Part : Form
    {
        private StudentService studentsService = new StudentService();
        private ActivityService activityService = new ActivityService();
        private StudentParticipateService studentParticipateService = new StudentParticipateService();
        private List<Student> activeStudents = null;
        private List<Student> nonActiveStudents = null;
        private List<Activity> activities = null;
        private Activity selectedActivity = null;

        public Activity_Part()
        {
            InitializeComponent();
        }

        public class ComboBoxItemP
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void UpdateAndShowLists()
        {
            activeStudents = studentsService.GetByActivityId(selectedActivity.Id);
            nonActiveStudents = studentsService.GetNonAssignedStudents(selectedActivity.Id);
            ShowStudentsList(listViewActiveStudents, activeStudents);
            ShowStudentsList(listViewNonActiveStudents, nonActiveStudents);
        }

        private void ShowStudentsList(ListView listView, List<Student> students)
        {
            if (students.Count > 0)
            {
                listView.Items.Clear();
                foreach (Student student in students)
                {
                    ListViewItem li = new ListViewItem(student.Id.ToString());
                    li.SubItems.Add(student.FirstName + " " + student.LastName);
                    li.SubItems.Add(student.Tel.ToString());
                    li.SubItems.Add(student.Class.ToString());
                    li.Tag = student;
                    listView.Items.Add(li);
                }
            }
            else
            {
                listView.Items.Clear();
            }
        }

        private void Activity_Part_Load(object sender, EventArgs e)
        {
            activities = activityService.GetActivities();
            foreach (Activity activity in activities)
            {
                comboBoxActivityP.Items.Add(new ComboBoxItemP { Text = $"{activity.Name} {activity.StartDate.ToShortDateString()}", Value = activity });
            }
        }

        private void comboBoxActivityP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItemP SelectedItem = (ComboBoxItemP)comboBoxActivityP.SelectedItem;
            selectedActivity = (Activity)SelectedItem.Value;
            UpdateAndShowLists();
        }

        private void toolStripButtonPRem_Click(object sender, EventArgs e)
        {
            if (selectedActivity != null)
            {
                if (listViewActiveStudents.SelectedItems.Count == 1)
                {
                    Student student = (Student)listViewActiveStudents.SelectedItems[0].Tag;
                    if (MessageBox.Show($"Are you sure you want to delete {student.FirstName} {student.LastName} from participants?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        studentParticipateService.Delete(student.Id, selectedActivity.Id);
                        UpdateAndShowLists();
                    }
                }
            }
        }

        private void toolStripButtonPAdd_Click(object sender, EventArgs e)
        {
            if (selectedActivity != null)
            {
                if (listViewNonActiveStudents.SelectedItems.Count == 1)
                {
                    Student student = (Student)listViewNonActiveStudents.SelectedItems[0].Tag;
                    studentParticipateService.Insert(student.Id, selectedActivity.Id);
                    UpdateAndShowLists();
                }
            }
        }
    }
}
