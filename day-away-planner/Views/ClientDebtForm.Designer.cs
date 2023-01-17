
namespace day_away_planner.Views
{
    partial class ClientDebtForm
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
            this.Client_Date = new System.Windows.Forms.Label();
            this.Client_Booked_date = new System.Windows.Forms.TextBox();
            this.Client_Debt = new System.Windows.Forms.TextBox();
            this.Clt_debt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Client_Date
            // 
            this.Client_Date.AutoSize = true;
            this.Client_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_Date.Location = new System.Drawing.Point(50, 43);
            this.Client_Date.Name = "Client_Date";
            this.Client_Date.Size = new System.Drawing.Size(154, 20);
            this.Client_Date.TabIndex = 0;
            this.Client_Date.Text = "Client Booked Date";
            // 
            // Client_Booked_date
            // 
            this.Client_Booked_date.Location = new System.Drawing.Point(231, 43);
            this.Client_Booked_date.Multiline = true;
            this.Client_Booked_date.Name = "Client_Booked_date";
            this.Client_Booked_date.ReadOnly = true;
            this.Client_Booked_date.Size = new System.Drawing.Size(114, 27);
            this.Client_Booked_date.TabIndex = 1;
            // 
            // Client_Debt
            // 
            this.Client_Debt.Location = new System.Drawing.Point(231, 96);
            this.Client_Debt.Multiline = true;
            this.Client_Debt.Name = "Client_Debt";
            this.Client_Debt.ReadOnly = true;
            this.Client_Debt.Size = new System.Drawing.Size(114, 28);
            this.Client_Debt.TabIndex = 2;
            // 
            // Clt_debt
            // 
            this.Clt_debt.AutoSize = true;
            this.Clt_debt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clt_debt.Location = new System.Drawing.Point(51, 96);
            this.Clt_debt.Name = "Clt_debt";
            this.Clt_debt.Size = new System.Drawing.Size(93, 20);
            this.Clt_debt.TabIndex = 3;
            this.Clt_debt.Text = "Client Debt";
            // 
            // ClientDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clt_debt);
            this.Controls.Add(this.Client_Debt);
            this.Controls.Add(this.Client_Booked_date);
            this.Controls.Add(this.Client_Date);
            this.Name = "ClientDebtForm";
            this.Text = "ClientDebtForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Client_Date;
        private System.Windows.Forms.TextBox Client_Booked_date;
        private System.Windows.Forms.TextBox Client_Debt;
        private System.Windows.Forms.Label Clt_debt;
    }
}