namespace day_away_planner.Views
{
    partial class NewBooking
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
            this.selectClient = new System.Windows.Forms.Button();
            this.who = new System.Windows.Forms.Button();
            this.modifyClient = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectClient
            // 
            this.selectClient.Location = new System.Drawing.Point(38, 402);
            this.selectClient.Name = "selectClient";
            this.selectClient.Size = new System.Drawing.Size(75, 23);
            this.selectClient.TabIndex = 0;
            this.selectClient.Text = "Select Client";
            this.selectClient.UseVisualStyleBackColor = true;
            this.selectClient.Click += new System.EventHandler(this.selectClient_Click);
            // 
            // who
            // 
            this.who.Location = new System.Drawing.Point(328, 402);
            this.who.Name = "who";
            this.who.Size = new System.Drawing.Size(75, 23);
            this.who.TabIndex = 1;
            this.who.Text = "who";
            this.who.UseVisualStyleBackColor = true;
            this.who.Click += new System.EventHandler(this.who_Click);
            // 
            // modifyClient
            // 
            this.modifyClient.Location = new System.Drawing.Point(119, 402);
            this.modifyClient.Name = "modifyClient";
            this.modifyClient.Size = new System.Drawing.Size(122, 23);
            this.modifyClient.TabIndex = 2;
            this.modifyClient.Text = "Modify Existing Client";
            this.modifyClient.UseVisualStyleBackColor = true;
            this.modifyClient.Click += new System.EventHandler(this.modifyClient_Click);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(247, 402);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(75, 23);
            this.newClient.TabIndex = 3;
            this.newClient.Text = "New Client";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.modifyClient);
            this.Controls.Add(this.who);
            this.Controls.Add(this.selectClient);
            this.Name = "NewBooking";
            this.Text = "NewBooking";
            this.Load += new System.EventHandler(this.NewBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectClient;
        private System.Windows.Forms.Button who;
        private System.Windows.Forms.Button modifyClient;
        private System.Windows.Forms.Button newClient;
    }
}