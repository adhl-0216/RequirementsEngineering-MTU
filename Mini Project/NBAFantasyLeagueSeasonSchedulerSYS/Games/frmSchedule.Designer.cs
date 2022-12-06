
namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dtgTeamDetails = new System.Windows.Forms.DataGridView();
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asstCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeCourt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeamDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(273, 321);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 50);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "SCHEDULE";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dtgTeamDetails
            // 
            this.dtgTeamDetails.AllowUserToAddRows = false;
            this.dtgTeamDetails.AllowUserToDeleteRows = false;
            this.dtgTeamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeamDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName,
            this.manager,
            this.headCoach,
            this.asstCoach,
            this.homeCourt});
            this.dtgTeamDetails.Location = new System.Drawing.Point(72, 51);
            this.dtgTeamDetails.Name = "dtgTeamDetails";
            this.dtgTeamDetails.ReadOnly = true;
            this.dtgTeamDetails.Size = new System.Drawing.Size(644, 264);
            this.dtgTeamDetails.TabIndex = 3;
            // 
            // teamID
            // 
            this.teamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.teamID.HeaderText = "ID";
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.Width = 43;
            // 
            // teamName
            // 
            this.teamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamName.HeaderText = "NAME";
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            // 
            // manager
            // 
            this.manager.HeaderText = "MANAGER";
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            // 
            // headCoach
            // 
            this.headCoach.HeaderText = "HEAD COACH";
            this.headCoach.Name = "headCoach";
            this.headCoach.ReadOnly = true;
            // 
            // asstCoach
            // 
            this.asstCoach.HeaderText = "ASSISTANT COACH";
            this.asstCoach.Name = "asstCoach";
            this.asstCoach.ReadOnly = true;
            // 
            // homeCourt
            // 
            this.homeCourt.HeaderText = "HOME COURT";
            this.homeCourt.Name = "homeCourt";
            this.homeCourt.ReadOnly = true;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgTeamDetails);
            this.Controls.Add(this.btnSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchedule";
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games] - [Schedule Game]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSchedule_FormClosing);
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeamDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DataGridView dtgTeamDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn headCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn asstCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeCourt;
    }
}