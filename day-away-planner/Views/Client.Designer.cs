namespace day_away_planner.Views
{
    partial class Client
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
            this.back = new System.Windows.Forms.Button();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 444);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clientGridView
            // 
            this.clientGridView.AccessibleName = "Clients";
            this.clientGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.clientGridView.AllowUserToAddRows = false;
            this.clientGridView.AllowUserToDeleteRows = false;
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Location = new System.Drawing.Point(12, 76);
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.ReadOnly = true;
            this.clientGridView.RowHeadersWidth = 51;
            this.clientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientGridView.Size = new System.Drawing.Size(676, 334);
            this.clientGridView.TabIndex = 2;
            this.clientGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGridView_RowCellDoubleClick);
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(98, 22);
            this.companyName.Margin = new System.Windows.Forms.Padding(2);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(179, 20);
            this.companyName.TabIndex = 4;
            this.companyName.TextChanged += new System.EventHandler(this.companyName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company Name:";
            // 
            // createNewClient
            // 
            this.createNewClient.Enabled = false;
            this.createNewClient.Location = new System.Drawing.Point(591, 444);
            this.createNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.createNewClient.Name = "createNewClient";
            this.createNewClient.Size = new System.Drawing.Size(97, 23);
            this.createNewClient.TabIndex = 13;
            this.createNewClient.Text = "New Client";
            this.createNewClient.UseVisualStyleBackColor = false;
            this.createNewClient.Click += new System.EventHandler(this.createNewClient_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 493);
            this.Controls.Add(this.createNewClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clientGridView);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView clientGridView;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createNewClient;
    }
}