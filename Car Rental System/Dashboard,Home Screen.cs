using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Dashboard_Home_Screen : Form
    {
        public Dashboard_Home_Screen()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports_Screen f = new Reports_Screen();
            f.Show();
        }

        private void Dashboard_Home_Screen_Load(object sender, EventArgs e)
        {

        }

        private void btnCarManagement_Click(object sender, EventArgs e)
        {
            Car_Management_Screen f = new Car_Management_Screen();
            f.Show();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            Customer_Management_Screen f = new Customer_Management_Screen();
            f.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking_Screen f = new Booking_Screen();
            f.Show();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            Car_Return_Screen f = new Car_Return_Screen();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
    }
}
