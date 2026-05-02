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
//    public partial class Customer_Management_Screen : Form
//    {
//        public Customer_Management_Screen()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void Customer_Management_Screen_Load(object sender, EventArgs e)
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
    public partial class Customer_Management_Screen : Form
    {
        int CustomerID;

        public Customer_Management_Screen()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ===== LOAD DATA =====
        private void LoadCustomers()
        {
            DBConnection.con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", DBConnection.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvCustomers.DataSource = dt;

            DBConnection.con.Close();
        }

        // ===== FORM LOAD =====
        private void Customer_Management_Screen_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // ===== GRID CLICK =====
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CustomerID = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells[0].Value);

                txtCustomerName.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCNIC.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        // ===== ADD =====
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            SqlCommand cmd = new SqlCommand("AddCustomer", DBConnection.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text);

            cmd.ExecuteNonQuery();
            DBConnection.con.Close();

            MessageBox.Show("Customer Added");
            LoadCustomers();
        }

        // ===== UPDATE =====
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateCustomer", DBConnection.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@CNIC", txtCNIC.Text);

            cmd.ExecuteNonQuery();
            DBConnection.con.Close();

            MessageBox.Show("Customer Updated");
            LoadCustomers();
        }

        // ===== DELETE =====
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DBConnection.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteCustomer", DBConnection.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

            cmd.ExecuteNonQuery();
            DBConnection.con.Close();

            MessageBox.Show("Customer Deleted");
            LoadCustomers();
        }

        // ===== CLEAR =====
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtCNIC.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
            f.Show();
        }
    }
}