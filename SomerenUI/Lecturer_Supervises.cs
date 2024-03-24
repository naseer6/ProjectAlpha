using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Lecturer_Supervises : Form
    {
        private TeachersService teachersService = new TeachersService();
        private ActivityService activityService = new ActivityService();
        private LecturerSupervisesService lecturerSupervisesService = new LecturerSupervisesService();
        private List<Teacher> activeTeachers = null;
        private List<Teacher> nonActiveTeachers = null;
        private List<Activity> activities = null;
        private Activity selectedActivity = null;

        public Lecturer_Supervises()
        {
            InitializeComponent();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void Lecturer_Supervises_Load(object sender, EventArgs e)
        {
            activities = activityService.GetActivities();
            foreach (Activity activity in activities)
            {
                comboBoxActivities.Items.Add(new ComboBoxItem { Text = $"{activity.Name} {activity.StartDate.ToShortDateString()}", Value = activity });
            }
        }

        private void comboBoxActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem SelectedItem = (ComboBoxItem)comboBoxActivities.SelectedItem;
            selectedActivity = (Activity)SelectedItem.Value;
            UpdateAndShowLists();
        }

        private void UpdateAndShowLists()
        {
            activeTeachers = teachersService.GetByActivityId(selectedActivity.Id);
            nonActiveTeachers = teachersService.GetNonAssignedLecturers(selectedActivity.Id);
            ShowTeachersList(listViewActiveSupervisors, activeTeachers);
            ShowTeachersList(listViewNonActiveLecturers, nonActiveTeachers);
        }

        private void ShowTeachersList(ListView listView, List<Teacher> teachers)
        {
            if (teachers.Count > 0)
            {
                listView.Items.Clear();
                foreach (Teacher teacher in teachers)
                {
                    ListViewItem li = new ListViewItem(teacher.Id.ToString());
                    li.SubItems.Add(teacher.FirstName + " " + teacher.LastName);
                    li.SubItems.Add(teacher.TelephoneNumber.ToString());
                    li.SubItems.Add(teacher.Age.ToString());
                    li.Tag = teacher;
                    listView.Items.Add(li);
                }
            }
            else
            {
                listView.Items.Clear();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            if (selectedActivity != null)
            {
                if (listViewActiveSupervisors.SelectedItems.Count == 1)
                {
                    Teacher teacher = (Teacher)listViewActiveSupervisors.SelectedItems[0].Tag;
                    if (MessageBox.Show($"Are you sure you want to delete {teacher.FirstName} {teacher.LastName} from Supervisors?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lecturerSupervisesService.Delete(teacher.Id, selectedActivity.Id);
                        UpdateAndShowLists();
                    }
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (selectedActivity != null)
            {
                if (listViewNonActiveLecturers.SelectedItems.Count == 1)
                {
                    Teacher teacher = (Teacher)listViewNonActiveLecturers.SelectedItems[0].Tag;
                    lecturerSupervisesService.Insert(teacher.Id, selectedActivity.Id);
                    UpdateAndShowLists();
                }
            }
        }
    }
}
