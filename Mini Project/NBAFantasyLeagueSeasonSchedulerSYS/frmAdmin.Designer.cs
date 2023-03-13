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
            this.btnTeamStandings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewSchedule.BackColor = System.Drawing.Color.Firebrick;
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewSchedule.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewSchedule.Location = new System.Drawing.Point(10, 9);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(220, 131);
            this.btnViewSchedule.TabIndex = 0;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = false;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnTeamProfs
            // 
            this.btnTeamProfs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTeamProfs.BackColor = System.Drawing.Color.Firebrick;
            this.btnTeamProfs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeamProfs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeamProfs.Location = new System.Drawing.Point(235, 9);
            this.btnTeamProfs.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeamProfs.Name = "btnTeamProfs";
            this.btnTeamProfs.Size = new System.Drawing.Size(220, 131);
            this.btnTeamProfs.TabIndex = 1;
            this.btnTeamProfs.Text = "Team Profiles";
            this.btnTeamProfs.UseVisualStyleBackColor = false;
            this.btnTeamProfs.Click += new System.EventHandler(this.btnTeamProfs_Click);
            // 
            // btnTeamStandings
            // 
            this.btnTeamStandings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTeamStandings.BackColor = System.Drawing.Color.Firebrick;
            this.btnTeamStandings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeamStandings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeamStandings.Location = new System.Drawing.Point(460, 8);
            this.btnTeamStandings.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeamStandings.Name = "btnTeamStandings";
            this.btnTeamStandings.Size = new System.Drawing.Size(220, 131);
            this.btnTeamStandings.TabIndex = 2;
            this.btnTeamStandings.Text = "Team Standings";
            this.btnTeamStandings.UseVisualStyleBackColor = false;
            this.btnTeamStandings.Click += new System.EventHandler(this.btnTeamStandings_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBAFantasyLeagueSeasonSchedulerSYS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 149);
            this.Controls.Add(this.btnTeamStandings);
            this.Controls.Add(this.btnTeamProfs);
            this.Controls.Add(this.btnViewSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Admin]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Button btnTeamProfs;
        private System.Windows.Forms.Button btnTeamStandings;
    }
}