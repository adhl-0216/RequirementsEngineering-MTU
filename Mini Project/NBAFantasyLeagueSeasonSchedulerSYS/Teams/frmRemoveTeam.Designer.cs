
namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmRemoveTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveTeam));
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgTeamDetails = new System.Windows.Forms.DataGridView();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asstCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeCourt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeamDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(119, 6);
            this.cboSelectTeam.MaxDropDownItems = 10;
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(538, 21);
            this.cboSelectTeam.TabIndex = 0;
            this.cboSelectTeam.SelectedIndexChanged += new System.EventHandler(this.cboSelectTeam_SelectedIndexChanged);
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(6, 9);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(67, 13);
            this.lblSelectTeam.TabIndex = 1;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 26);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Remove Team";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgTeamDetails);
            this.panel1.Controls.Add(this.cboSelectTeam);
            this.panel1.Controls.Add(this.lblSelectTeam);
            this.panel1.Location = new System.Drawing.Point(18, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(668, 306);
            this.panel1.TabIndex = 19;
            // 
            // dtgTeamDetails
            // 
            this.dtgTeamDetails.AllowUserToAddRows = false;
            this.dtgTeamDetails.AllowUserToDeleteRows = false;
            this.dtgTeamDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTeamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeamDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName,
            this.manager,
            this.headCoach,
            this.asstCoach,
            this.homeCourt});
            this.dtgTeamDetails.Location = new System.Drawing.Point(9, 31);
            this.dtgTeamDetails.Name = "dtgTeamDetails";
            this.dtgTeamDetails.ReadOnly = true;
            this.dtgTeamDetails.RowHeadersWidth = 62;
            this.dtgTeamDetails.Size = new System.Drawing.Size(648, 264);
            this.dtgTeamDetails.TabIndex = 2;
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveTeam.Location = new System.Drawing.Point(308, 384);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(75, 32);
            this.btnRemoveTeam.TabIndex = 20;
            this.btnRemoveTeam.Text = "REMOVE";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // teamID
            // 
            this.teamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamID.HeaderText = "ID";
            this.teamID.MinimumWidth = 8;
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.Width = 43;
            // 
            // teamName
            // 
            this.teamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teamName.HeaderText = "NAME";
            this.teamName.MinimumWidth = 8;
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            this.teamName.Width = 63;
            // 
            // manager
            // 
            this.manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.manager.HeaderText = "MANAGER";
            this.manager.MinimumWidth = 8;
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Width = 86;
            // 
            // headCoach
            // 
            this.headCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.headCoach.HeaderText = "HEAD COACH";
            this.headCoach.MinimumWidth = 8;
            this.headCoach.Name = "headCoach";
            this.headCoach.ReadOnly = true;
            this.headCoach.Width = 102;
            // 
            // asstCoach
            // 
            this.asstCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.asstCoach.HeaderText = "ASSISTANT COACH";
            this.asstCoach.MinimumWidth = 8;
            this.asstCoach.Name = "asstCoach";
            this.asstCoach.ReadOnly = true;
            this.asstCoach.Width = 121;
            // 
            // homeCourt
            // 
            this.homeCourt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.homeCourt.HeaderText = "HOME COURT";
            this.homeCourt.MinimumWidth = 8;
            this.homeCourt.Name = "homeCourt";
            this.homeCourt.ReadOnly = true;
            // 
            // frmRemoveTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 428);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRemoveTeam";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Teams] - [Remove Team]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveTeam_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveTeam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeamDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.DataGridView dtgTeamDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn headCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn asstCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeCourt;
    }
}