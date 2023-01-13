
namespace day_away_planner.Views
{
    partial class ClientDebtCheck
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
            this.Clt_Booked_Date = new System.Windows.Forms.Label();
            this.Client_Booked_Date = new System.Windows.Forms.TextBox();
            this.Clt_debt = new System.Windows.Forms.Label();
            this.Client_Debt = new System.Windows.Forms.TextBox();
            this.Check_Debt = new System.Windows.Forms.Button();
            this.Clt_name = new System.Windows.Forms.Label();
            this.Client_Name = new System.Windows.Forms.TextBox();
            this.Clt_company = new System.Windows.Forms.Label();
            this.Client_Company = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clt_Booked_Date
            // 
            this.Clt_Booked_Date.AutoSize = true;
            this.Clt_Booked_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clt_Booked_Date.Location = new System.Drawing.Point(12, 190);
            this.Clt_Booked_Date.Name = "Clt_Booked_Date";
            this.Clt_Booked_Date.Size = new System.Drawing.Size(154, 20);
            this.Clt_Booked_Date.TabIndex = 0;
            this.Clt_Booked_Date.Text = "Client Booked Date";
            // 
            // Client_Booked_Date
            // 
            this.Client_Booked_Date.Location = new System.Drawing.Point(228, 173);
            this.Client_Booked_Date.Multiline = true;
            this.Client_Booked_Date.Name = "Client_Booked_Date";
            this.Client_Booked_Date.ReadOnly = true;
            this.Client_Booked_Date.Size = new System.Drawing.Size(187, 48);
            this.Client_Booked_Date.TabIndex = 1;
            // 
            // Clt_debt
            // 
            this.Clt_debt.AutoSize = true;
            this.Clt_debt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clt_debt.Location = new System.Drawing.Point(52, 260);
            this.Clt_debt.Name = "Clt_debt";
            this.Clt_debt.Size = new System.Drawing.Size(97, 20);
            this.Clt_debt.TabIndex = 2;
            this.Clt_debt.Text = "Client_Debt";
            // 
            // Client_Debt
            // 
            this.Client_Debt.Location = new System.Drawing.Point(228, 260);
            this.Client_Debt.Multiline = true;
            this.Client_Debt.Name = "Client_Debt";
            this.Client_Debt.ReadOnly = true;
            this.Client_Debt.Size = new System.Drawing.Size(150, 29);
            this.Client_Debt.TabIndex = 3;
            // 
            // Check_Debt
            // 
            this.Check_Debt.Location = new System.Drawing.Point(171, 338);
            this.Check_Debt.Name = "Check_Debt";
            this.Check_Debt.Size = new System.Drawing.Size(138, 54);
            this.Check_Debt.TabIndex = 6;
            this.Check_Debt.Text = "CheckDebt";
            this.Check_Debt.UseVisualStyleBackColor = true;
            this.Check_Debt.Click += new System.EventHandler(this.Check_Debt_Click);
            // 
            // Clt_name
            // 
            this.Clt_name.AutoSize = true;
            this.Clt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clt_name.Location = new System.Drawing.Point(52, 103);
            this.Clt_name.Name = "Clt_name";
            this.Clt_name.Size = new System.Drawing.Size(101, 20);
            this.Clt_name.TabIndex = 7;
            this.Clt_name.Text = "Client Name";
            // 
            // Client_Name
            // 
            this.Client_Name.Location = new System.Drawing.Point(228, 103);
            this.Client_Name.Multiline = true;
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.ReadOnly = true;
            this.Client_Name.Size = new System.Drawing.Size(187, 31);
            this.Client_Name.TabIndex = 8;
            // 
            // Clt_company
            // 
            this.Clt_company.AutoSize = true;
            this.Clt_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clt_company.Location = new System.Drawing.Point(52, 42);
            this.Clt_company.Name = "Clt_company";
            this.Clt_company.Size = new System.Drawing.Size(127, 20);
            this.Clt_company.TabIndex = 9;
            this.Clt_company.Text = "Client Company";
            // 
            // Client_Company
            // 
            this.Client_Company.Location = new System.Drawing.Point(228, 42);
            this.Client_Company.Multiline = true;
            this.Client_Company.Name = "Client_Company";
            this.Client_Company.ReadOnly = true;
            this.Client_Company.Size = new System.Drawing.Size(187, 31);
            this.Client_Company.TabIndex = 10;
            // 
            // ClientDebtCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.Client_Company);
            this.Controls.Add(this.Clt_company);
            this.Controls.Add(this.Client_Name);
            this.Controls.Add(this.Clt_name);
            this.Controls.Add(this.Check_Debt);
            this.Controls.Add(this.Client_Debt);
            this.Controls.Add(this.Clt_debt);
            this.Controls.Add(this.Client_Booked_Date);
            this.Controls.Add(this.Clt_Booked_Date);
            this.Name = "ClientDebtCheck";
            this.Text = "ClientDebtCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clt_Booked_Date;
        private System.Windows.Forms.Label Clt_debt;
        public System.Windows.Forms.TextBox Client_Booked_Date;
        public System.Windows.Forms.TextBox Client_Debt;
        private System.Windows.Forms.Button Check_Debt;
        private System.Windows.Forms.Label Clt_name;
        public System.Windows.Forms.TextBox Client_Name;
        private System.Windows.Forms.Label Clt_company;
        public System.Windows.Forms.TextBox Client_Company;
    }
}