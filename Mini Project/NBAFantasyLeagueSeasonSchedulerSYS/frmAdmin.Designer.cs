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
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnTeamProfs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(247, 222);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(197, 57);
            this.btnViewSchedule.TabIndex = 0;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnTeamProfs
            // 
            this.btnTeamProfs.Location = new System.Drawing.Point(537, 222);
            this.btnTeamProfs.Name = "btnTeamProfs";
            this.btnTeamProfs.Size = new System.Drawing.Size(197, 57);
            this.btnTeamProfs.TabIndex = 1;
            this.btnTeamProfs.Text = "Team Profiles";
            this.btnTeamProfs.UseVisualStyleBackColor = true;
            this.btnTeamProfs.Click += new System.EventHandler(this.btnTeamProfs_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnTeamProfs);
            this.Controls.Add(this.btnViewSchedule);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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