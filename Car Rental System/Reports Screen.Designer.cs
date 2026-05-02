namespace Car_Rental_System
{
    partial class Reports_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllCars = new System.Windows.Forms.Button();
            this.btnAllBookings = new System.Windows.Forms.Button();
            this.btnAvailableCars = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(848, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // btnAllCars
            // 
            this.btnAllCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCars.Location = new System.Drawing.Point(50, 241);
            this.btnAllCars.Name = "btnAllCars";
            this.btnAllCars.Size = new System.Drawing.Size(527, 64);
            this.btnAllCars.TabIndex = 1;
            this.btnAllCars.Text = "All Cars";
            this.btnAllCars.UseVisualStyleBackColor = true;
            this.btnAllCars.Click += new System.EventHandler(this.btnAllCars_Click);
            // 
            // btnAllBookings
            // 
            this.btnAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBookings.Location = new System.Drawing.Point(726, 239);
            this.btnAllBookings.Name = "btnAllBookings";
            this.btnAllBookings.Size = new System.Drawing.Size(527, 66);
            this.btnAllBookings.TabIndex = 2;
            this.btnAllBookings.Text = "All Bookings";
            this.btnAllBookings.UseVisualStyleBackColor = true;
            this.btnAllBookings.Click += new System.EventHandler(this.btnAllBookings_Click);
            // 
            // btnAvailableCars
            // 
            this.btnAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableCars.Location = new System.Drawing.Point(1415, 239);
            this.btnAvailableCars.Name = "btnAvailableCars";
            this.btnAvailableCars.Size = new System.Drawing.Size(527, 64);
            this.btnAvailableCars.TabIndex = 3;
            this.btnAvailableCars.Text = "Available Cars";
            this.btnAvailableCars.UseVisualStyleBackColor = true;
            this.btnAvailableCars.Click += new System.EventHandler(this.btnAvailableCars_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(204, 446);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 82;
            this.dgvReports.RowTemplate.Height = 33;
            this.dgvReports.Size = new System.Drawing.Size(1680, 683);
            this.dgvReports.TabIndex = 4;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 54);
            this.button4.TabIndex = 5;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reports_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(2033, 1367);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnAvailableCars);
            this.Controls.Add(this.btnAllBookings);
            this.Controls.Add(this.btnAllCars);
            this.Controls.Add(this.label1);
            this.Name = "Reports_Screen";
            this.Text = "Reports_Screen";
            this.Load += new System.EventHandler(this.Reports_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllCars;
        private System.Windows.Forms.Button btnAllBookings;
        private System.Windows.Forms.Button btnAvailableCars;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button button4;
    }
}