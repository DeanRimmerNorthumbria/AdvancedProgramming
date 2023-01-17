
namespace day_away_planner.Views
{
    partial class Clientbookingdetails
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
            this.Clnt_Name = new System.Windows.Forms.Label();
            this.Cmp_Name = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Clnt_booking_details = new System.Windows.Forms.Label();
            this.clientNewbooking = new System.Windows.Forms.Button();
            this.Client_Department = new System.Windows.Forms.TextBox();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.Client_Name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clnt_Name
            // 
            this.Clnt_Name.AutoSize = true;
            this.Clnt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clnt_Name.Location = new System.Drawing.Point(34, 54);
            this.Clnt_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clnt_Name.Name = "Clnt_Name";
            this.Clnt_Name.Size = new System.Drawing.Size(80, 17);
            this.Clnt_Name.TabIndex = 0;
            this.Clnt_Name.Text = "ClientName";
            // 
            // Cmp_Name
            // 
            this.Cmp_Name.AutoSize = true;
            this.Cmp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmp_Name.Location = new System.Drawing.Point(34, 116);
            this.Cmp_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cmp_Name.Name = "Cmp_Name";
            this.Cmp_Name.Size = new System.Drawing.Size(104, 17);
            this.Cmp_Name.TabIndex = 2;
            this.Cmp_Name.Text = "CompanyName";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(34, 178);
            this.Department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(82, 17);
            this.Department.TabIndex = 3;
            this.Department.Text = "Department";
            // 
            // Clnt_booking_details
            // 
            this.Clnt_booking_details.AutoSize = true;
            this.Clnt_booking_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clnt_booking_details.Location = new System.Drawing.Point(400, 18);
            this.Clnt_booking_details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clnt_booking_details.Name = "Clnt_booking_details";
            this.Clnt_booking_details.Size = new System.Drawing.Size(167, 17);
            this.Clnt_booking_details.TabIndex = 9;
            this.Clnt_booking_details.Text = "Client Booking Details";
            // 
            // clientNewbooking
            // 
            this.clientNewbooking.Enabled = false;
            this.clientNewbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNewbooking.Location = new System.Drawing.Point(710, 377);
            this.clientNewbooking.Margin = new System.Windows.Forms.Padding(2);
            this.clientNewbooking.Name = "clientNewbooking";
            this.clientNewbooking.Size = new System.Drawing.Size(135, 32);
            this.clientNewbooking.TabIndex = 14;
            this.clientNewbooking.Text = "Create New Booking";
            this.clientNewbooking.UseVisualStyleBackColor = true;
            this.clientNewbooking.Click += new System.EventHandler(this.clientNewbooking_Click);
            // 
            // Client_Department
            // 
            this.Client_Department.Location = new System.Drawing.Point(161, 178);
            this.Client_Department.Margin = new System.Windows.Forms.Padding(2);
            this.Client_Department.Multiline = true;
            this.Client_Department.Name = "Client_Department";
            this.Client_Department.Size = new System.Drawing.Size(209, 24);
            this.Client_Department.TabIndex = 6;
            // 
            // Company_Name
            // 
            this.Company_Name.Location = new System.Drawing.Point(161, 116);
            this.Company_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Company_Name.Multiline = true;
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(209, 24);
            this.Company_Name.TabIndex = 7;
            // 
            // Client_Name
            // 
            this.Client_Name.Location = new System.Drawing.Point(161, 54);
            this.Client_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Client_Name.Multiline = true;
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.Size = new System.Drawing.Size(209, 23);
            this.Client_Name.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 303);
            this.dataGridView1.TabIndex = 15;
            // 
            // Clientbookingdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clientNewbooking);
            this.Controls.Add(this.Clnt_booking_details);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.Client_Department);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Cmp_Name);
            this.Controls.Add(this.Client_Name);
            this.Controls.Add(this.Clnt_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientbookingdetails";
            this.Text = "Clientbookingdetails";
            this.Load += new System.EventHandler(this.Clientbookingdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clnt_Name;
        private System.Windows.Forms.Label Cmp_Name;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Clnt_booking_details;
        private System.Windows.Forms.Button clientNewbooking;
        public System.Windows.Forms.TextBox Client_Department;
        public System.Windows.Forms.TextBox Company_Name;
        public System.Windows.Forms.TextBox Client_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}