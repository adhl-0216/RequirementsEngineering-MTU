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
            this.btnManagePlayers = new System.Windows.Forms.Button();
            this.grpTeamDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTeamDetails
            // 
            this.grpTeamDetails.Controls.Add(this.btnAddTeam);
            this.grpTeamDetails.Controls.Add(this.btnRemoveTeam);
            this.grpTeamDetails.Controls.Add(this.btnUpdateTeam);
            this.grpTeamDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpTeamDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTeamDetails.Location = new System.Drawing.Point(12, 12);
            this.grpTeamDetails.Margin = new System.Windows.Forms.Padding(5);
            this.grpTeamDetails.Name = "grpTeamDetails";
            this.grpTeamDetails.Padding = new System.Windows.Forms.Padding(5);
            this.grpTeamDetails.Size = new System.Drawing.Size(204, 326);
            this.grpTeamDetails.TabIndex = 4;
            this.grpTeamDetails.TabStop = false;
            this.grpTeamDetails.Text = "Team Details";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(6, 19);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(190, 95);
            this.btnAddTeam.TabIndex = 4;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(6, 221);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(190, 95);
            this.btnRemoveTeam.TabIndex = 7;
            this.btnRemoveTeam.Text = "Remove Team";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Location = new System.Drawing.Point(6, 120);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(190, 95);
            this.btnUpdateTeam.TabIndex = 6;
            this.btnUpdateTeam.Text = "Update Team";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            // 
            // btnManagePlayers
            // 
            this.btnManagePlayers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnManagePlayers.Location = new System.Drawing.Point(261, 12);
            this.btnManagePlayers.Name = "btnManagePlayers";
            this.btnManagePlayers.Size = new System.Drawing.Size(190, 326);
            this.btnManagePlayers.TabIndex = 5;
            this.btnManagePlayers.Text = "Manage Players";
            this.btnManagePlayers.UseVisualStyleBackColor = true;
            // 
            // frmManageTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 350);
            this.Controls.Add(this.grpTeamDetails);
            this.Controls.Add(this.btnManagePlayers);
            this.Name = "frmManageTeams";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Teams]";
            this.grpTeamDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTeamDetails;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnManagePlayers;
    }
}