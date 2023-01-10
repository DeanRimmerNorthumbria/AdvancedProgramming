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
            this.selectActivity = new System.Windows.Forms.Button();
            this.what = new System.Windows.Forms.Button();
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
            this.who.Location = new System.Drawing.Point(152, 401);
            this.who.Name = "who";
            this.who.Size = new System.Drawing.Size(75, 23);
            this.who.TabIndex = 1;
            this.who.Text = "who";
            this.who.UseVisualStyleBackColor = true;
            this.who.Click += new System.EventHandler(this.who_Click);
            // 
            // selectActivity
            // 
            this.selectActivity.Location = new System.Drawing.Point(38, 355);
            this.selectActivity.Name = "selectActivity";
            this.selectActivity.Size = new System.Drawing.Size(83, 23);
            this.selectActivity.TabIndex = 2;
            this.selectActivity.Text = "Select Activity";
            this.selectActivity.UseVisualStyleBackColor = true;
            this.selectActivity.Click += new System.EventHandler(this.selectActivity_Click);
            // 
            // what
            // 
            this.what.Location = new System.Drawing.Point(152, 355);
            this.what.Name = "what";
            this.what.Size = new System.Drawing.Size(75, 23);
            this.what.TabIndex = 3;
            this.what.Text = "what";
            this.what.UseVisualStyleBackColor = true;
            this.what.Click += new System.EventHandler(this.what_Click);
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.what);
            this.Controls.Add(this.selectActivity);
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
        private System.Windows.Forms.Button selectActivity;
        private System.Windows.Forms.Button what;
    }
}