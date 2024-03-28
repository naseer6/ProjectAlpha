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

        private DrinkService drinkService = new DrinkService();
        private OrderService orderService;

        public SomerenUI()
        {
            InitializeComponent();
            orderService = new OrderService();
        }
        //checking


        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlOrder.Hide();
            pnlDashboard.Show();

        }
        private void ShowStudentsPanel()
        {
            // hide all other panels

            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlOrder.Hide();
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
            pnlOrder.Hide();

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
            pnlOrder.Hide();
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

        private List<Drink> GetDrinks()
        {

            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinks(List<Drink> drinks)
        {
            listViewDrinksOrder.Items.Clear();
            foreach (Drink drink in drinks)
            {
                ListViewItem listViewItem = new ListViewItem(drink.Id.ToString());
                listViewItem.SubItems.Add(drink.Name);
                listViewItem.SubItems.Add(drink.Type);
                listViewItem.SubItems.Add(drink.Price.ToString("F2"));
                listViewItem.SubItems.Add(drink.Stock.ToString());
                if (drink.Stock >= 10)
                {
                    listViewItem.SubItems.Add("Stock sufficient");
                }
                else if (drink.Stock == 0)
                {
                    listViewItem.SubItems.Add("No stock");
                }
                else
                {
                    listViewItem.SubItems.Add("Stock nearly depleted");
                }

                listViewDrinksOrder.Items.Add(listViewItem);
            }
        }

        private void ShowOrderDrinksPanel()
        {
            // hide all other panels

            pnlDashboard.Hide();
            pnlTeachers.Hide();
            pnlActivities.Hide();
            pnlRevenue.Hide();
            pnlStudents.Hide();
            pnlOrder.Hide();
            pnlOrder.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudentsOrder(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }

            List<Drink> drinks = GetDrinks();
            DisplayDrinks(drinks);
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

        private void DisplayStudentsOrder(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudentsOrder.Items.Clear();

            foreach (Student student in students)
            {
                // Create a new ListViewItem and add student attributes to it
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.SubItems.Add(student.FirstName + " " + student.LastName);
                li.SubItems.Add(student.Tel);
                li.SubItems.Add(student.Class);
                listViewStudentsOrder.Items.Add(li);
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
            pnlOrder.Hide();
            pnlRevenue.Show();

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


            int totalDrinksSold = orderService.GetTotalDrinksSold(startDate, endDate);
            decimal turnover = orderService.GetTurnover(startDate, endDate);
            int numberOfCustomers = orderService.GetNumberOfCustomers(startDate, endDate);


            lblTotalSales.Text = $"{totalDrinksSold}";
            lblTurnover.Text = $"{turnover:F2}";
            lblNumCustomers.Text = $"{numberOfCustomers}";


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

        private void toolStripMenuItemOrder_Click(object sender, EventArgs e)
        {
            ShowOrderDrinksPanel();
        }

        private void barManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bar_Managment bar_Managment = new Bar_Managment();
            bar_Managment.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {


        }


        private void CalculateAmount()
        {

            if (int.TryParse(txtOrder.Text, out int quantity) && quantity >= 0)
            {
                if (listViewDrinksOrder.SelectedItems.Count > 0 &&
                    listViewDrinksOrder.SelectedItems[0].SubItems.Count > 0)
                {
                    if (decimal.TryParse(listViewDrinksOrder.SelectedItems[0].SubItems[3].Text, out decimal pricePerItem))
                    {
                        decimal amount = quantity * pricePerItem;
                        lblResult.Text = amount.ToString("0.00");
                    }
                    else
                    {
                        lblResult.Text = "Invalid price per item";
                    }

                }
                else
                {
                    lblResult.Text = "No item selected";
                }
            }
            else
            {
                lblResult.Text = "Invalid quantity";
            }
        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowOrderDrinksPanel();
        }

        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer_Supervises lecturer_Supervises = new Lecturer_Supervises();
            lecturer_Supervises.ShowDialog();
        }

        private void txtOrder_TextChanged_1(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            OrderService orderDAO = new OrderService();
            if (listViewStudentsOrder.SelectedItems.Count == 1 && listViewDrinksOrder.SelectedItems.Count == 1)
            {
                Order order1 = new Order();

                order1.Quantity = int.Parse(txtOrder.Text);
                order1.Student_ID = int.Parse(listViewStudentsOrder.SelectedItems[0].SubItems[0].Text);
                order1.Drink_ID = int.Parse(listViewDrinksOrder.SelectedItems[0].SubItems[0].Text);
                order1.Date = DateTime.Now;
                orderDAO.InsertOrder(order1);



                MessageBox.Show("Order placed successfully!");

                if (int.TryParse(txtOrder.Text, out int quantity) && quantity >= 0)
                {
                    if (listViewDrinksOrder.SelectedItems.Count > 0 &&
                        listViewDrinksOrder.SelectedItems[0].SubItems.Count > 0)
                    {


                        if (int.TryParse(listViewDrinksOrder.SelectedItems[0].SubItems[4].Text, out int stockQuantity))
                        {
                            if (stockQuantity >= quantity)
                            {

                                stockQuantity -= quantity;


                                listViewDrinksOrder.SelectedItems[0].SubItems[4].Text = stockQuantity.ToString();


                                txtOrder.Text = string.Empty;
                                lblResult.Text = string.Empty;




                            }
                            else
                            {
                                lblResult.Text = "Not enough stock";
                            }
                        }
                        else
                        {
                            lblResult.Text = "Invalid stock quantity";
                        }
                    }
                    else
                    {
                        lblResult.Text = "No item selected";
                    }
                }
                else
                {
                    lblResult.Text = "Invalid quantity";
                }

            }

            else
            {
                MessageBox.Show("Please select a student and a drink.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            


        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            

        }

        
            

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudents manageStudent = new ManageStudents();
            manageStudent.ShowDialog();
        }
    }
}