
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.Check_Debt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clt_Booked_Date
            // 
            this.Clt_Booked_Date.AutoSize = true;
            this.Clt_Booked_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clt_Booked_Date.Location = new System.Drawing.Point(55, 57);
            this.Clt_Booked_Date.Name = "Clt_Booked_Date";
            this.Clt_Booked_Date.Size = new System.Drawing.Size(154, 20);
            this.Clt_Booked_Date.TabIndex = 0;
            this.Clt_Booked_Date.Text = "Client Booked Date";
            // 
            // Client_Booked_Date
            // 
            this.Client_Booked_Date.Location = new System.Drawing.Point(228, 48);
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
            this.Clt_debt.Location = new System.Drawing.Point(55, 126);
            this.Clt_debt.Name = "Clt_debt";
            this.Clt_debt.Size = new System.Drawing.Size(97, 20);
            this.Clt_debt.TabIndex = 2;
            this.Clt_debt.Text = "Client_Debt";
            // 
            // Client_Debt
            // 
            this.Client_Debt.Location = new System.Drawing.Point(228, 126);
            this.Client_Debt.Multiline = true;
            this.Client_Debt.Name = "Client_Debt";
            this.Client_Debt.ReadOnly = true;
            this.Client_Debt.Size = new System.Drawing.Size(150, 29);
            this.Client_Debt.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(509, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(506, 25);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(108, 20);
            this.Date.TabIndex = 5;
            this.Date.Text = "Today\'s Date";
            // 
            // Check_Debt
            // 
            this.Check_Debt.Location = new System.Drawing.Point(544, 126);
            this.Check_Debt.Name = "Check_Debt";
            this.Check_Debt.Size = new System.Drawing.Size(121, 37);
            this.Check_Debt.TabIndex = 6;
            this.Check_Debt.Text = "CheckDebt";
            this.Check_Debt.UseVisualStyleBackColor = true;
            this.Check_Debt.Click += new System.EventHandler(this.Check_Debt_Click);
            // 
            // ClientDebtCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check_Debt);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button Check_Debt;
    }
}