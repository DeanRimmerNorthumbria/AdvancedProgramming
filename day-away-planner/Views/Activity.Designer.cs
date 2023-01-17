
namespace day_away_planner.Views
{
    partial class Activity
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
            this.activityGridView = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activityGridView
            // 
            this.activityGridView.AccessibleName = "Activities";
            this.activityGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.activityGridView.AllowUserToAddRows = false;
            this.activityGridView.AllowUserToDeleteRows = false;
            this.activityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityGridView.Location = new System.Drawing.Point(11, 20);
            this.activityGridView.Margin = new System.Windows.Forms.Padding(2);
            this.activityGridView.Name = "activityGridView";
            this.activityGridView.ReadOnly = true;
            this.activityGridView.RowHeadersWidth = 51;
            this.activityGridView.RowTemplate.Height = 24;
            this.activityGridView.Size = new System.Drawing.Size(465, 346);
            this.activityGridView.TabIndex = 2;
            this.activityGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activityGridView_RowCellDoubleClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(11, 370);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(89, 38);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 432);
            this.Controls.Add(this.back);
            this.Controls.Add(this.activityGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Activity";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView activityGridView;
        private System.Windows.Forms.Button back;
    }
}