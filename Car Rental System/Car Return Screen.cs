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
//    public partial class Car_Return_Screen : Form
//    {
//        public Car_Return_Screen()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void Car_Return_Screen_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace Car_Rental_System
//{
//    public partial class Car_Return_Screen : Form
//    {
//        public Car_Return_Screen()
//        {
//            InitializeComponent();
//        }

//        // ===== FORM LOAD =====
//        private void Car_Return_Screen_Load(object sender, EventArgs e)
//        {
//            LoadBookings();
//            LoadReturnHistory();
//        }

//        // ===== LOAD BOOKINGS =====
//        void LoadBookings()
//        {
//            DBConnection.con.Open();

//            SqlDataAdapter da = new SqlDataAdapter(
//                "SELECT BookingID FROM Bookings WHERE Status='Booked'",
//                DBConnection.con
//            );

//            DataTable dt = new DataTable();
//            da.Fill(dt);

//            cmbBooking.DataSource = dt;
//            cmbBooking.DisplayMember = "BookingID";
//            cmbBooking.ValueMember = "BookingID";

//            DBConnection.con.Close();
//        }

//        // ===== LOAD RETURN HISTORY (FIXED QUERY) =====
//        void LoadReturnHistory()
//        {
//            DBConnection.con.Open();

//            SqlDataAdapter da = new SqlDataAdapter(@"
//                SELECT 
//                    r.ReturnID,
//                    b.BookingID,
//                    c.CustomerName,
//                    car.CarName,
//                    b.BookingDate,
//                    b.ReturnDate,
//                    r.ActualReturnDate
//                FROM Returns r
//                INNER JOIN Bookings b ON r.BookingID = b.BookingID
//                INNER JOIN Customers c ON b.CustomerID = c.CustomerID
//                INNER JOIN Cars car ON b.CarID = car.CarID
//            ", DBConnection.con);

//            DataTable dt = new DataTable();
//            da.Fill(dt);

//            dgvReturnHistory.DataSource = dt;

//            DBConnection.con.Close();
//        }

//        // ===== RETURN CAR =====
//        private void btnReturnCar_Click(object sender, EventArgs e)
//        {
//            DBConnection.con.Open();

//            SqlCommand cmd = new SqlCommand("ReturnCar", DBConnection.con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.AddWithValue("@BookingID", cmbBooking.SelectedValue);

//            cmd.ExecuteNonQuery();

//            DBConnection.con.Close();

//            MessageBox.Show("Car Returned Successfully");

//            LoadBookings();
//            LoadReturnHistory();
//        }

//        // ===== VIEW HISTORY =====
//        private void btnViewHistory_Click(object sender, EventArgs e)
//        {
//            LoadReturnHistory();
//        }

//        // ===== SAFE EVENTS =====
//        private void label1_Click(object sender, EventArgs e) { }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
//            f.Show();
//        }
//    }
//}
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
//    public partial class Car_Return_Screen : Form
//    {
//        public Car_Return_Screen()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void Car_Return_Screen_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;

//namespace Car_Rental_System
//{
//    public partial class Car_Return_Screen : Form
//    {
//        public Car_Return_Screen()
//        {
//            InitializeComponent();
//        }

//        // ===== FORM LOAD =====
//        private void Car_Return_Screen_Load(object sender, EventArgs e)
//        {
//            LoadBookings();
//            LoadReturnHistory();
//        }

//        // ===== LOAD BOOKINGS =====
//        void LoadBookings()
//        {
//            DBConnection.con.Open();

//            SqlDataAdapter da = new SqlDataAdapter(
//                "SELECT BookingID FROM Bookings WHERE Status='Booked'",
//                DBConnection.con
//            );

//            DataTable dt = new DataTable();
//            da.Fill(dt);

//            cmbBooking.DataSource = dt;
//            cmbBooking.DisplayMember = "BookingID";
//            cmbBooking.ValueMember = "BookingID";

//            DBConnection.con.Close();
//        }

//        // ===== LOAD RETURN HISTORY =====
//        void LoadReturnHistory()
//        {
//            DBConnection.con.Open();

//            SqlDataAdapter da = new SqlDataAdapter(
//                "SELECT * FROM Returns",
//                DBConnection.con
//            );

//            DataTable dt = new DataTable();
//            da.Fill(dt);

//            dgvReturnHistory.DataSource = dt;

//            DBConnection.con.Close();
//        }

//        // ===== RETURN CAR =====
//        private void btnReturnCar_Click(object sender, EventArgs e)
//        {
//            DBConnection.con.Open();

//            SqlCommand cmd = new SqlCommand("ReturnCar", DBConnection.con);
//            cmd.CommandType = CommandType.StoredProcedure;

//            cmd.Parameters.AddWithValue("@BookingID", cmbBooking.SelectedValue);

//            cmd.ExecuteNonQuery();

//            DBConnection.con.Close();

//            MessageBox.Show("Car Returned Successfully");

//            LoadBookings();
//            LoadReturnHistory();
//        }

//        // ===== VIEW HISTORY =====
//        private void btnViewHistory_Click(object sender, EventArgs e)
//        {
//            LoadReturnHistory();
//        }

//        // ===== SAFE EMPTY EVENTS =====
//        private void label1_Click(object sender, EventArgs e) { }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
//            f.Show();
//        }
//    }
//}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Car_Return_Screen : Form
    {
        public Car_Return_Screen()
        {
            InitializeComponent();
        }

        // ===== FORM LOAD =====
        private void Car_Return_Screen_Load(object sender, EventArgs e)
        {
            LoadBookings();
            LoadReturnHistory();
        }

        // ===== LOAD BOOKINGS (ONLY ACTIVE BOOKINGS) =====
        void LoadBookings()
        {
            try
            {
                if (DBConnection.con.State == ConnectionState.Open)
                    DBConnection.con.Close();

                DBConnection.con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT BookingID FROM Bookings WHERE Status='Booked'",
                    DBConnection.con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbBooking.DataSource = dt;
                cmbBooking.DisplayMember = "BookingID";
                cmbBooking.ValueMember = "BookingID";

                DBConnection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== LOAD RETURN HISTORY (FIXED WITH LEFT JOIN) =====
        void LoadReturnHistory()
        {
            try
            {
                if (DBConnection.con.State == ConnectionState.Open)
                    DBConnection.con.Close();

                DBConnection.con.Open();

                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        r.ReturnID,
                        ISNULL(b.BookingID, 0) AS BookingID,
                        ISNULL(c.CustomerName, 'Deleted') AS CustomerName,
                        ISNULL(car.CarName, 'Deleted') AS CarName,
                        b.BookingDate,
                        b.ReturnDate,
                        r.ActualReturnDate
                    FROM Returns r
                    LEFT JOIN Bookings b ON r.BookingID = b.BookingID
                    LEFT JOIN Customers c ON b.CustomerID = c.CustomerID
                    LEFT JOIN Cars car ON b.CarID = car.CarID
                ", DBConnection.con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReturnHistory.DataSource = dt;

                DBConnection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== RETURN CAR =====
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (cmbBooking.SelectedValue == null)
            {
                MessageBox.Show("Select a booking first");
                return;
            }

            try
            {
                if (DBConnection.con.State == ConnectionState.Open)
                    DBConnection.con.Close();

                DBConnection.con.Open();

                SqlCommand cmd = new SqlCommand("ReturnCar", DBConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookingID", cmbBooking.SelectedValue);

                cmd.ExecuteNonQuery();

                DBConnection.con.Close();

                MessageBox.Show("Car Returned Successfully");

                LoadBookings();
                LoadReturnHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ===== VIEW HISTORY =====
        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            LoadReturnHistory();
        }

        // ===== BACK BUTTON =====
        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
            f.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e) { }


    }
}
     
