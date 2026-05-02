namespace Car_Rental_System
{
    partial class Car_Return_Screen
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBooking = new System.Windows.Forms.ComboBox();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.dgvReturnHistory = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(851, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Return";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Booking : ";
            // 
            // cmbBooking
            // 
            this.cmbBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBooking.FormattingEnabled = true;
            this.cmbBooking.Location = new System.Drawing.Point(432, 240);
            this.cmbBooking.Name = "cmbBooking";
            this.cmbBooking.Size = new System.Drawing.Size(422, 50);
            this.cmbBooking.TabIndex = 2;
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCar.Location = new System.Drawing.Point(939, 232);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(422, 57);
            this.btnReturnCar.TabIndex = 3;
            this.btnReturnCar.Text = "Return Car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHistory.Location = new System.Drawing.Point(1491, 232);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(422, 56);
            this.btnViewHistory.TabIndex = 4;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // dgvReturnHistory
            // 
            this.dgvReturnHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnHistory.Location = new System.Drawing.Point(448, 524);
            this.dgvReturnHistory.Name = "dgvReturnHistory";
            this.dgvReturnHistory.RowHeadersWidth = 82;
            this.dgvReturnHistory.RowTemplate.Height = 33;
            this.dgvReturnHistory.Size = new System.Drawing.Size(1285, 585);
            this.dgvReturnHistory.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Car_Return_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(2034, 1356);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvReturnHistory);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.cmbBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Car_Return_Screen";
            this.Text = "Car_Return_Screen";
            this.Load += new System.EventHandler(this.Car_Return_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBooking;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.DataGridView dgvReturnHistory;
        private System.Windows.Forms.Button button3;
    }
}