//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Car_Rental_System
//{
//    public partial class Reports_Screen : Form
//    {
//        public Reports_Screen()
//        {
//            InitializeComponent();
//        }

//        private void Reports_Screen_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Reports_Screen : Form
    {
        public Reports_Screen()
        {
            InitializeComponent();
        }

        private void Reports_Screen_Load(object sender, EventArgs e)
        {

        }

        // ===== ALL CARS =====
        private void btnAllCars_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cars", DBConnection.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReports.DataSource = dt;

            DBConnection.con.Close();
        }

        // ===== ALL BOOKINGS =====
        private void btnAllBookings_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            string query = @"SELECT b.BookingID, c.CustomerName, car.CarName,
                             b.BookingDate, b.ReturnDate, b.Status
                             FROM Bookings b
                             JOIN Customers c ON b.CustomerID = c.CustomerID
                             JOIN Cars car ON b.CarID = car.CarID";

            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReports.DataSource = dt;

            DBConnection.con.Close();
        }

        // ===== AVAILABLE CARS =====
        private void btnAvailableCars_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Cars WHERE Status='Available'",
                DBConnection.con
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReports.DataSource = dt;

            DBConnection.con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
            f.Show();
            this.Hide();
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}