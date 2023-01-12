
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
            this.Cmp_Email = new System.Windows.Forms.Label();
            this.Company_Bookings = new System.Windows.Forms.TextBox();
            this.Clnt_booking_details = new System.Windows.Forms.Label();
            this.Client_Address = new System.Windows.Forms.TextBox();
            this.Clnt_Address = new System.Windows.Forms.Label();
            this.clientNewbooking = new System.Windows.Forms.Button();
            this.Company_Email = new System.Windows.Forms.TextBox();
            this.Client_Department = new System.Windows.Forms.TextBox();
            this.Company_Name = new System.Windows.Forms.TextBox();
            this.Client_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clnt_Name
            // 
            this.Clnt_Name.AutoSize = true;
            this.Clnt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clnt_Name.Location = new System.Drawing.Point(45, 66);
            this.Clnt_Name.Name = "Clnt_Name";
            this.Clnt_Name.Size = new System.Drawing.Size(96, 20);
            this.Clnt_Name.TabIndex = 0;
            this.Clnt_Name.Text = "ClientName";
            // 
            // Cmp_Name
            // 
            this.Cmp_Name.AutoSize = true;
            this.Cmp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmp_Name.Location = new System.Drawing.Point(45, 112);
            this.Cmp_Name.Name = "Cmp_Name";
            this.Cmp_Name.Size = new System.Drawing.Size(123, 20);
            this.Cmp_Name.TabIndex = 2;
            this.Cmp_Name.Text = "CompanyName";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(46, 163);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(97, 20);
            this.Department.TabIndex = 3;
            this.Department.Text = "Department";
            // 
            // Cmp_Email
            // 
            this.Cmp_Email.AutoSize = true;
            this.Cmp_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmp_Email.Location = new System.Drawing.Point(46, 215);
            this.Cmp_Email.Name = "Cmp_Email";
            this.Cmp_Email.Size = new System.Drawing.Size(51, 20);
            this.Cmp_Email.TabIndex = 4;
            this.Cmp_Email.Text = "Email";
            // 
            // Company_Bookings
            // 
            this.Company_Bookings.Location = new System.Drawing.Point(632, 66);
            this.Company_Bookings.Multiline = true;
            this.Company_Bookings.Name = "Company_Bookings";
            this.Company_Bookings.Size = new System.Drawing.Size(493, 359);
            this.Company_Bookings.TabIndex = 8;
            // 
            // Clnt_booking_details
            // 
            this.Clnt_booking_details.AutoSize = true;
            this.Clnt_booking_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clnt_booking_details.Location = new System.Drawing.Point(628, 22);
            this.Clnt_booking_details.Name = "Clnt_booking_details";
            this.Clnt_booking_details.Size = new System.Drawing.Size(197, 20);
            this.Clnt_booking_details.TabIndex = 9;
            this.Clnt_booking_details.Text = "Client Booking Details";
            // 
            // Client_Address
            // 
            this.Client_Address.Location = new System.Drawing.Point(215, 289);
            this.Client_Address.Multiline = true;
            this.Client_Address.Name = "Client_Address";
            this.Client_Address.Size = new System.Drawing.Size(277, 136);
            this.Client_Address.TabIndex = 12;
            // 
            // Clnt_Address
            // 
            this.Clnt_Address.AutoSize = true;
            this.Clnt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clnt_Address.Location = new System.Drawing.Point(47, 289);
            this.Clnt_Address.Name = "Clnt_Address";
            this.Clnt_Address.Size = new System.Drawing.Size(71, 20);
            this.Clnt_Address.TabIndex = 13;
            this.Clnt_Address.Text = "Address";
            // 
            // clientNewbooking
            // 
            this.clientNewbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNewbooking.Location = new System.Drawing.Point(895, 486);
            this.clientNewbooking.Name = "clientNewbooking";
            this.clientNewbooking.Size = new System.Drawing.Size(172, 34);
            this.clientNewbooking.TabIndex = 14;
            this.clientNewbooking.Text = "Create New Booking";
            this.clientNewbooking.UseVisualStyleBackColor = true;
            this.clientNewbooking.Click += new System.EventHandler(this.clientNewbooking_Click);
            // 
            // Company_Email
            // 
            this.Company_Email.Location = new System.Drawing.Point(215, 213);
            this.Company_Email.Multiline = true;
            this.Company_Email.Name = "Company_Email";
            this.Company_Email.Size = new System.Drawing.Size(277, 28);
            this.Company_Email.TabIndex = 5;
            // 
            // Client_Department
            // 
            this.Client_Department.Location = new System.Drawing.Point(215, 163);
            this.Client_Department.Multiline = true;
            this.Client_Department.Name = "Client_Department";
            this.Client_Department.Size = new System.Drawing.Size(277, 29);
            this.Client_Department.TabIndex = 6;
            // 
            // Company_Name
            // 
            this.Company_Name.Location = new System.Drawing.Point(215, 112);
            this.Company_Name.Multiline = true;
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Size = new System.Drawing.Size(277, 28);
            this.Company_Name.TabIndex = 7;
            // 
            // Client_Name
            // 
            this.Client_Name.Location = new System.Drawing.Point(215, 66);
            this.Client_Name.Multiline = true;
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.Size = new System.Drawing.Size(277, 27);
            this.Client_Name.TabIndex = 1;
            // 
            // Clientbookingdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 563);
            this.Controls.Add(this.clientNewbooking);
            this.Controls.Add(this.Clnt_Address);
            this.Controls.Add(this.Client_Address);
            this.Controls.Add(this.Clnt_booking_details);
            this.Controls.Add(this.Company_Bookings);
            this.Controls.Add(this.Company_Name);
            this.Controls.Add(this.Client_Department);
            this.Controls.Add(this.Company_Email);
            this.Controls.Add(this.Cmp_Email);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Cmp_Name);
            this.Controls.Add(this.Client_Name);
            this.Controls.Add(this.Clnt_Name);
            this.Name = "Clientbookingdetails";
            this.Text = "Clientbookingdetails";
            this.Load += new System.EventHandler(this.Clientbookingdetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clnt_Name;
        private System.Windows.Forms.Label Cmp_Name;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Cmp_Email;
        private System.Windows.Forms.Label Clnt_booking_details;
        private System.Windows.Forms.Label Clnt_Address;
        private System.Windows.Forms.Button clientNewbooking;
        public System.Windows.Forms.TextBox Company_Bookings;
        public System.Windows.Forms.TextBox Client_Address;
        public System.Windows.Forms.TextBox Company_Email;
        public System.Windows.Forms.TextBox Client_Department;
        public System.Windows.Forms.TextBox Company_Name;
        public System.Windows.Forms.TextBox Client_Name;
    }
}