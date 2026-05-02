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
//    public partial class Booking_Screen : Form
//    {
//        public Booking_Screen()
//        {
//            InitializeComponent();
//        }

//        private void label3_Click(object sender, EventArgs e)
//        {

//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void Booking_Screen_Load(object sender, EventArgs e)
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
    public partial class Booking_Screen : Form
    {
        public Booking_Screen()
        {
            InitializeComponent();
        }

        // ===== FORM LOAD =====
        private void Booking_Screen_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCars();
            LoadBookings();
        }

        // ===== LOAD CUSTOMERS =====
        void LoadCustomers()
        {
            DBConnection.con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, CustomerName FROM Customers", DBConnection.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCustomer.DataSource = dt;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";

            DBConnection.con.Close();
        }

        // ===== LOAD AVAILABLE CARS =====
        void LoadCars()
        {
            DBConnection.con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT CarID, CarName FROM Cars WHERE Status='Available'", DBConnection.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbCar.DataSource = dt;
            cmbCar.DisplayMember = "CarName";
            cmbCar.ValueMember = "CarID";

            DBConnection.con.Close();
        }

        // ===== LOAD BOOKINGS =====
        void LoadBookings()
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

            dgvBookings.DataSource = dt;

            DBConnection.con.Close();
        }

        // ===== BOOK CAR =====
        private void btnBookCar_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            SqlCommand cmd = new SqlCommand("BookCar", DBConnection.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", cmbCustomer.SelectedValue);
            cmd.Parameters.AddWithValue("@CarID", cmbCar.SelectedValue);
            cmd.Parameters.AddWithValue("@BookingDate", dtpBooking.Value);
            cmd.Parameters.AddWithValue("@ReturnDate", dtpReturn.Value);

            cmd.ExecuteNonQuery();

            DBConnection.con.Close();

            MessageBox.Show("Car Booked Successfully");

            LoadBookings();
            LoadCars(); // refresh available cars
        }

        // ===== VIEW BOOKINGS =====
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        // ===== OPTIONAL LABEL EVENTS (EMPTY SAFE) =====
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
            f.Show();
        }
    }
}