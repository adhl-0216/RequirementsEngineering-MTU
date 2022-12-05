namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnTeamProfs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(165, 144);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(131, 37);
            this.btnViewSchedule.TabIndex = 0;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnTeamProfs
            // 
            this.btnTeamProfs.Location = new System.Drawing.Point(358, 144);
            this.btnTeamProfs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTeamProfs.Name = "btnTeamProfs";
            this.btnTeamProfs.Size = new System.Drawing.Size(131, 37);
            this.btnTeamProfs.TabIndex = 1;
            this.btnTeamProfs.Text = "Team Profiles";
            this.btnTeamProfs.UseVisualStyleBackColor = true;
            this.btnTeamProfs.Click += new System.EventHandler(this.btnTeamProfs_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeamProfs);
            this.Controls.Add(this.btnViewSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.Text = "NBA Fantasy League Season Scheduler - [Admin]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Button btnTeamProfs;
    }
}