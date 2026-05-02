using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Car_Management_Screen : Form
    {
        int CarID = 0;

        public Car_Management_Screen()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void Car_Management_Screen_Load(object sender, EventArgs e)
        {
            LoadCars();

            // ComboBox FIX
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Booked");
        }

        // ================= LOAD GRID =================
        void LoadCars()
        {
            try
            {
                if (DBConnection.con.State == ConnectionState.Open)
                    DBConnection.con.Close();

                DBConnection.con.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT CarID, CarName, Model, RentPerDay, Status FROM Cars",
                    DBConnection.con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCars.DataSource = dt;

                DBConnection.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= GRID CLICK =================
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];

                CarID = Convert.ToInt32(row.Cells[0].Value);
                txtCarName.Text = row.Cells[1].Value.ToString();
                txtModel.Text = row.Cells[2].Value.ToString();
                txtRent.Text = row.Cells[3].Value.ToString();
                cmbStatus.Text = row.Cells[4].Value.ToString();
            }
        }

        // ================= VALIDATION =================
        bool ValidateFields()
        {
            if (txtCarName.Text == "" || txtModel.Text == "" || txtRent.Text == "" || cmbStatus.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return false;
            }

            if (!decimal.TryParse(txtRent.Text, out _))
            {
                MessageBox.Show("Rent must be numeric");
                return false;
            }

            return true;
        }

        // ================= ADD =================
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
            if (!ValidateFields()) return;

            try
            {
                DBConnection.con.Open();

                SqlCommand cmd = new SqlCommand("AddCar", DBConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CarName", txtCarName.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Rent", Convert.ToDecimal(txtRent.Text));
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                cmd.ExecuteNonQuery();

                DBConnection.con.Close();

                MessageBox.Show("Car Added Successfully");

                LoadCars();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= UPDATE =================
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (CarID == 0)
            {
                MessageBox.Show("Select a car first");
                return;
            }

            if (!ValidateFields()) return;

            try
            {
                DBConnection.con.Open();

                SqlCommand cmd = new SqlCommand("UpdateCar", DBConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CarID", CarID);
                cmd.Parameters.AddWithValue("@CarName", txtCarName.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Rent", Convert.ToDecimal(txtRent.Text));
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                cmd.ExecuteNonQuery();

                DBConnection.con.Close();

                MessageBox.Show("Car Updated Successfully");

                LoadCars();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= DELETE =================
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (CarID == 0)
            {
                MessageBox.Show("Select a car first");
                return;
            }

            try
            {
                DBConnection.con.Open();

                SqlCommand cmd = new SqlCommand("DeleteCar", DBConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CarID", CarID);

                cmd.ExecuteNonQuery();

                DBConnection.con.Close();

                MessageBox.Show("Car Deleted Successfully");

                LoadCars();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= CLEAR =================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtCarName.Clear();
            txtModel.Clear();
            txtRent.Clear();
            cmbStatus.SelectedIndex = -1;
            CarID = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard_Home_Screen f = new Dashboard_Home_Screen();
            f.Show();
        }
    }
}