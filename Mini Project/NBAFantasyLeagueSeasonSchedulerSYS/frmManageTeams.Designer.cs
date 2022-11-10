namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmManageTeams
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
            this.grpTeamDetails = new System.Windows.Forms.GroupBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.pboBanner = new System.Windows.Forms.PictureBox();
            this.grpTeamDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTeamDetails
            // 
            this.grpTeamDetails.Controls.Add(this.btnAddTeam);
            this.grpTeamDetails.Controls.Add(this.btnRemoveTeam);
            this.grpTeamDetails.Controls.Add(this.btnUpdateTeam);
            this.grpTeamDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpTeamDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTeamDetails.Location = new System.Drawing.Point(12, 143);
            this.grpTeamDetails.Margin = new System.Windows.Forms.Padding(8);
            this.grpTeamDetails.Name = "grpTeamDetails";
            this.grpTeamDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpTeamDetails.Size = new System.Drawing.Size(600, 126);
            this.grpTeamDetails.TabIndex = 4;
            this.grpTeamDetails.TabStop = false;
            this.grpTeamDetails.Text = "Team Details";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(6, 16);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(190, 100);
            this.btnAddTeam.TabIndex = 4;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(404, 16);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(190, 100);
            this.btnRemoveTeam.TabIndex = 7;
            this.btnRemoveTeam.Text = "Remove Team";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Location = new System.Drawing.Point(205, 16);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(190, 100);
            this.btnUpdateTeam.TabIndex = 6;
            this.btnUpdateTeam.Text = "Update Team";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // pboBanner
            // 
            this.pboBanner.BackgroundImage = global::NBAFantasyLeagueSeasonSchedulerSYS.Properties.Resources._1500x500;
            this.pboBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboBanner.Location = new System.Drawing.Point(12, 12);
            this.pboBanner.Name = "pboBanner";
            this.pboBanner.Size = new System.Drawing.Size(600, 128);
            this.pboBanner.TabIndex = 5;
            this.pboBanner.TabStop = false;
            // 
            // frmManageTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.pboBanner);
            this.Controls.Add(this.grpTeamDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmManageTeams";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Teams]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageTeams_FormClosing);
            this.Load += new System.EventHandler(this.frmManageTeams_Load);
            this.grpTeamDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeamDetails;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.PictureBox pboBanner;
    }
}