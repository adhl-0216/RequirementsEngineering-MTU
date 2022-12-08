
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSchedule.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSchedule.Location = new System.Drawing.Point(466, 463);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(270, 77);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "SCHEDULE";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // dtgTeamDetails
            // 
            this.dtgTeamDetails.AllowUserToAddRows = false;
            this.dtgTeamDetails.AllowUserToDeleteRows = false;
            this.dtgTeamDetails.AllowUserToResizeColumns = false;
            this.dtgTeamDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgTeamDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTeamDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTeamDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgTeamDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgTeamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeamDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName,
            this.manager,
            this.headCoach,
            this.asstCoach,
            this.homeCourt});
            this.dtgTeamDetails.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgTeamDetails.Location = new System.Drawing.Point(13, 14);
            this.dtgTeamDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgTeamDetails.Name = "dtgTeamDetails";
            this.dtgTeamDetails.ReadOnly = true;
            this.dtgTeamDetails.RowHeadersVisible = false;
            this.dtgTeamDetails.RowHeadersWidth = 62;
            this.dtgTeamDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTeamDetails.Size = new System.Drawing.Size(1174, 439);
            this.dtgTeamDetails.TabIndex = 3;
            // 
            // teamID
            // 
            this.teamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamID.HeaderText = "ID";
            this.teamID.MinimumWidth = 8;
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.Width = 62;
            // 
            // teamName
            // 
            this.teamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamName.HeaderText = "NAME";
            this.teamName.MinimumWidth = 8;
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            this.teamName.Width = 91;
            // 
            // manager
            // 
            this.manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.manager.HeaderText = "MANAGER";
            this.manager.MinimumWidth = 8;
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Width = 127;
            // 
            // headCoach
            // 
            this.headCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.headCoach.HeaderText = "HEAD COACH";
            this.headCoach.MinimumWidth = 8;
            this.headCoach.Name = "headCoach";
            this.headCoach.ReadOnly = true;
            this.headCoach.Width = 140;
            // 
            // asstCoach
            // 
            this.asstCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.asstCoach.HeaderText = "ASSISTANT COACH";
            this.asstCoach.MinimumWidth = 8;
            this.asstCoach.Name = "asstCoach";
            this.asstCoach.ReadOnly = true;
            this.asstCoach.Width = 179;
            // 
            // homeCourt
            // 
            this.homeCourt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.homeCourt.HeaderText = "HOME COURT";
            this.homeCourt.MinimumWidth = 8;
            this.homeCourt.Name = "homeCourt";
            this.homeCourt.ReadOnly = true;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.dtgTeamDetails);
            this.Controls.Add(this.btnSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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