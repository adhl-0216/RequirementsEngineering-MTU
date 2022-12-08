
namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    partial class frmGenerateTeamProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateTeamProfile));
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.pnlTeamDetails = new System.Windows.Forms.Panel();
            this.pnlTeamID = new System.Windows.Forms.Panel();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.pnlTeamName = new System.Windows.Forms.Panel();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pnlHeadCoach = new System.Windows.Forms.Panel();
            this.txtHeadCoach = new System.Windows.Forms.TextBox();
            this.lblHeadCoach = new System.Windows.Forms.Label();
            this.pnlAsstCoach = new System.Windows.Forms.Panel();
            this.txtAsstCoach = new System.Windows.Forms.TextBox();
            this.lblAsstCoach = new System.Windows.Forms.Label();
            this.pnlGM = new System.Windows.Forms.Panel();
            this.txtGM = new System.Windows.Forms.TextBox();
            this.lblGM = new System.Windows.Forms.Label();
            this.pnlHomeCourt = new System.Windows.Forms.Panel();
            this.txtHomeCourt = new System.Windows.Forms.TextBox();
            this.lblHomeCourt = new System.Windows.Forms.Label();
            this.dtgGames = new System.Windows.Forms.DataGridView();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTeamWins = new System.Windows.Forms.Label();
            this.pnlTeamDetails.SuspendLayout();
            this.pnlTeamID.SuspendLayout();
            this.pnlTeamName.SuspendLayout();
            this.pnlHeadCoach.SuspendLayout();
            this.pnlAsstCoach.SuspendLayout();
            this.pnlGM.SuspendLayout();
            this.pnlHomeCourt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTeams
            // 
            this.cboTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(18, 12);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(862, 28);
            this.cboTeams.TabIndex = 0;
            this.cboTeams.SelectedValueChanged += new System.EventHandler(this.cboTeams_SelectedValueChanged);
            // 
            // pnlTeamDetails
            // 
            this.pnlTeamDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeamDetails.Controls.Add(this.pnlTeamID);
            this.pnlTeamDetails.Controls.Add(this.pnlTeamName);
            this.pnlTeamDetails.Controls.Add(this.pnlHeadCoach);
            this.pnlTeamDetails.Controls.Add(this.pnlAsstCoach);
            this.pnlTeamDetails.Controls.Add(this.pnlGM);
            this.pnlTeamDetails.Controls.Add(this.pnlHomeCourt);
            this.pnlTeamDetails.Location = new System.Drawing.Point(19, 48);
            this.pnlTeamDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeamDetails.Name = "pnlTeamDetails";
            this.pnlTeamDetails.Padding = new System.Windows.Forms.Padding(6);
            this.pnlTeamDetails.Size = new System.Drawing.Size(861, 241);
            this.pnlTeamDetails.TabIndex = 4;
            // 
            // pnlTeamID
            // 
            this.pnlTeamID.Controls.Add(this.txtTeamID);
            this.pnlTeamID.Controls.Add(this.lblTeamID);
            this.pnlTeamID.Location = new System.Drawing.Point(10, 10);
            this.pnlTeamID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeamID.Name = "pnlTeamID";
            this.pnlTeamID.Padding = new System.Windows.Forms.Padding(6);
            this.pnlTeamID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTeamID.Size = new System.Drawing.Size(417, 42);
            this.pnlTeamID.TabIndex = 2;
            // 
            // txtTeamID
            // 
            this.txtTeamID.Enabled = false;
            this.txtTeamID.HideSelection = false;
            this.txtTeamID.Location = new System.Drawing.Point(147, 9);
            this.txtTeamID.Multiline = true;
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.ReadOnly = true;
            this.txtTeamID.Size = new System.Drawing.Size(261, 26);
            this.txtTeamID.TabIndex = 4;
            this.txtTeamID.TabStop = false;
            // 
            // lblTeamID
            // 
            this.lblTeamID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Location = new System.Drawing.Point(6, 6);
            this.lblTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(70, 20);
            this.lblTeamID.TabIndex = 1;
            this.lblTeamID.Text = "Team ID";
            this.lblTeamID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTeamName
            // 
            this.pnlTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeamName.Controls.Add(this.txtTeamName);
            this.pnlTeamName.Controls.Add(this.lblTeamName);
            this.pnlTeamName.Location = new System.Drawing.Point(434, 10);
            this.pnlTeamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeamName.Name = "pnlTeamName";
            this.pnlTeamName.Padding = new System.Windows.Forms.Padding(6);
            this.pnlTeamName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTeamName.Size = new System.Drawing.Size(417, 42);
            this.pnlTeamName.TabIndex = 0;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Enabled = false;
            this.txtTeamName.HideSelection = false;
            this.txtTeamName.Location = new System.Drawing.Point(147, 9);
            this.txtTeamName.Multiline = true;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.ReadOnly = true;
            this.txtTeamName.Size = new System.Drawing.Size(261, 26);
            this.txtTeamName.TabIndex = 5;
            this.txtTeamName.TabStop = false;
            // 
            // lblTeamName
            // 
            this.lblTeamName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(6, 6);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(95, 20);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeadCoach
            // 
            this.pnlHeadCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeadCoach.Controls.Add(this.txtHeadCoach);
            this.pnlHeadCoach.Controls.Add(this.lblHeadCoach);
            this.pnlHeadCoach.Location = new System.Drawing.Point(434, 62);
            this.pnlHeadCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeadCoach.Name = "pnlHeadCoach";
            this.pnlHeadCoach.Padding = new System.Windows.Forms.Padding(6);
            this.pnlHeadCoach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHeadCoach.Size = new System.Drawing.Size(417, 42);
            this.pnlHeadCoach.TabIndex = 2;
            // 
            // txtHeadCoach
            // 
            this.txtHeadCoach.Enabled = false;
            this.txtHeadCoach.HideSelection = false;
            this.txtHeadCoach.Location = new System.Drawing.Point(147, 6);
            this.txtHeadCoach.Multiline = true;
            this.txtHeadCoach.Name = "txtHeadCoach";
            this.txtHeadCoach.ReadOnly = true;
            this.txtHeadCoach.Size = new System.Drawing.Size(261, 26);
            this.txtHeadCoach.TabIndex = 6;
            this.txtHeadCoach.TabStop = false;
            // 
            // lblHeadCoach
            // 
            this.lblHeadCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeadCoach.AutoSize = true;
            this.lblHeadCoach.Location = new System.Drawing.Point(6, 6);
            this.lblHeadCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadCoach.Name = "lblHeadCoach";
            this.lblHeadCoach.Size = new System.Drawing.Size(98, 20);
            this.lblHeadCoach.TabIndex = 1;
            this.lblHeadCoach.Text = "Head Coach";
            this.lblHeadCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAsstCoach
            // 
            this.pnlAsstCoach.Controls.Add(this.txtAsstCoach);
            this.pnlAsstCoach.Controls.Add(this.lblAsstCoach);
            this.pnlAsstCoach.Location = new System.Drawing.Point(10, 114);
            this.pnlAsstCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAsstCoach.Name = "pnlAsstCoach";
            this.pnlAsstCoach.Padding = new System.Windows.Forms.Padding(6);
            this.pnlAsstCoach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlAsstCoach.Size = new System.Drawing.Size(417, 42);
            this.pnlAsstCoach.TabIndex = 3;
            // 
            // txtAsstCoach
            // 
            this.txtAsstCoach.Enabled = false;
            this.txtAsstCoach.HideSelection = false;
            this.txtAsstCoach.Location = new System.Drawing.Point(147, 6);
            this.txtAsstCoach.Multiline = true;
            this.txtAsstCoach.Name = "txtAsstCoach";
            this.txtAsstCoach.ReadOnly = true;
            this.txtAsstCoach.Size = new System.Drawing.Size(261, 26);
            this.txtAsstCoach.TabIndex = 3;
            this.txtAsstCoach.TabStop = false;
            // 
            // lblAsstCoach
            // 
            this.lblAsstCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAsstCoach.AutoSize = true;
            this.lblAsstCoach.Location = new System.Drawing.Point(6, 6);
            this.lblAsstCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsstCoach.Name = "lblAsstCoach";
            this.lblAsstCoach.Size = new System.Drawing.Size(125, 20);
            this.lblAsstCoach.TabIndex = 1;
            this.lblAsstCoach.Text = "Assistant Coach";
            this.lblAsstCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGM
            // 
            this.pnlGM.Controls.Add(this.txtGM);
            this.pnlGM.Controls.Add(this.lblGM);
            this.pnlGM.Location = new System.Drawing.Point(10, 62);
            this.pnlGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGM.Name = "pnlGM";
            this.pnlGM.Padding = new System.Windows.Forms.Padding(6);
            this.pnlGM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGM.Size = new System.Drawing.Size(417, 42);
            this.pnlGM.TabIndex = 1;
            // 
            // txtGM
            // 
            this.txtGM.Enabled = false;
            this.txtGM.HideSelection = false;
            this.txtGM.Location = new System.Drawing.Point(147, 6);
            this.txtGM.Multiline = true;
            this.txtGM.Name = "txtGM";
            this.txtGM.ReadOnly = true;
            this.txtGM.Size = new System.Drawing.Size(261, 26);
            this.txtGM.TabIndex = 2;
            this.txtGM.TabStop = false;
            // 
            // lblGM
            // 
            this.lblGM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGM.AutoSize = true;
            this.lblGM.Location = new System.Drawing.Point(6, 6);
            this.lblGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGM.Name = "lblGM";
            this.lblGM.Size = new System.Drawing.Size(133, 20);
            this.lblGM.TabIndex = 1;
            this.lblGM.Text = "General Manager";
            this.lblGM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHomeCourt
            // 
            this.pnlHomeCourt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHomeCourt.Controls.Add(this.txtHomeCourt);
            this.pnlHomeCourt.Controls.Add(this.lblHomeCourt);
            this.pnlHomeCourt.Location = new System.Drawing.Point(434, 114);
            this.pnlHomeCourt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHomeCourt.Name = "pnlHomeCourt";
            this.pnlHomeCourt.Padding = new System.Windows.Forms.Padding(6);
            this.pnlHomeCourt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHomeCourt.Size = new System.Drawing.Size(417, 116);
            this.pnlHomeCourt.TabIndex = 4;
            // 
            // txtHomeCourt
            // 
            this.txtHomeCourt.Enabled = false;
            this.txtHomeCourt.HideSelection = false;
            this.txtHomeCourt.Location = new System.Drawing.Point(147, 16);
            this.txtHomeCourt.Multiline = true;
            this.txtHomeCourt.Name = "txtHomeCourt";
            this.txtHomeCourt.ReadOnly = true;
            this.txtHomeCourt.Size = new System.Drawing.Size(261, 91);
            this.txtHomeCourt.TabIndex = 7;
            this.txtHomeCourt.TabStop = false;
            // 
            // lblHomeCourt
            // 
            this.lblHomeCourt.AutoSize = true;
            this.lblHomeCourt.Location = new System.Drawing.Point(6, 6);
            this.lblHomeCourt.Margin = new System.Windows.Forms.Padding(6);
            this.lblHomeCourt.Name = "lblHomeCourt";
            this.lblHomeCourt.Padding = new System.Windows.Forms.Padding(6);
            this.lblHomeCourt.Size = new System.Drawing.Size(107, 32);
            this.lblHomeCourt.TabIndex = 1;
            this.lblHomeCourt.Text = "Home Court";
            this.lblHomeCourt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgGames
            // 
            this.dtgGames.AllowUserToAddRows = false;
            this.dtgGames.AllowUserToDeleteRows = false;
            this.dtgGames.AllowUserToResizeColumns = false;
            this.dtgGames.AllowUserToResizeRows = false;
            this.dtgGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGames.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameID,
            this.opponent,
            this.date,
            this.time,
            this.venue,
            this.result});
            this.dtgGames.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgGames.Location = new System.Drawing.Point(19, 374);
            this.dtgGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgGames.Name = "dtgGames";
            this.dtgGames.ReadOnly = true;
            this.dtgGames.RowHeadersVisible = false;
            this.dtgGames.RowHeadersWidth = 62;
            this.dtgGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGames.Size = new System.Drawing.Size(861, 297);
            this.dtgGames.TabIndex = 6;
            // 
            // gameID
            // 
            this.gameID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gameID.HeaderText = "ID";
            this.gameID.MinimumWidth = 8;
            this.gameID.Name = "gameID";
            this.gameID.ReadOnly = true;
            this.gameID.Width = 62;
            // 
            // opponent
            // 
            this.opponent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.opponent.HeaderText = "OPPONENT";
            this.opponent.MinimumWidth = 8;
            this.opponent.Name = "opponent";
            this.opponent.ReadOnly = true;
            this.opponent.Width = 131;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date.HeaderText = "DATE";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 88;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.time.HeaderText = "TIME";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 83;
            // 
            // venue
            // 
            this.venue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.venue.HeaderText = "VENUE";
            this.venue.MinimumWidth = 8;
            this.venue.Name = "venue";
            this.venue.ReadOnly = true;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.result.HeaderText = "RESULT";
            this.result.MinimumWidth = 8;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 109;
            // 
            // lblTeamWins
            // 
            this.lblTeamWins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTeamWins.AutoSize = true;
            this.lblTeamWins.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamWins.Location = new System.Drawing.Point(361, 301);
            this.lblTeamWins.Name = "lblTeamWins";
            this.lblTeamWins.Size = new System.Drawing.Size(206, 64);
            this.lblTeamWins.TabIndex = 5;
            this.lblTeamWins.Text = "(27-27)";
            this.lblTeamWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGenerateTeamProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.ClientSize = new System.Drawing.Size(924, 374);
            this.Controls.Add(this.pnlTeamDetails);
            this.Controls.Add(this.dtgGames);
            this.Controls.Add(this.lblTeamWins);
            this.Controls.Add(this.cboTeams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerateTeamProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Admin] - [Team Profiles]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerateTeamProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmGenerateTeamProfile_Load);
            this.pnlTeamDetails.ResumeLayout(false);
            this.pnlTeamID.ResumeLayout(false);
            this.pnlTeamID.PerformLayout();
            this.pnlTeamName.ResumeLayout(false);
            this.pnlTeamName.PerformLayout();
            this.pnlHeadCoach.ResumeLayout(false);
            this.pnlHeadCoach.PerformLayout();
            this.pnlAsstCoach.ResumeLayout(false);
            this.pnlAsstCoach.PerformLayout();
            this.pnlGM.ResumeLayout(false);
            this.pnlGM.PerformLayout();
            this.pnlHomeCourt.ResumeLayout(false);
            this.pnlHomeCourt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Panel pnlTeamDetails;
        private System.Windows.Forms.Panel pnlTeamID;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Panel pnlTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Panel pnlHeadCoach;
        private System.Windows.Forms.TextBox txtHeadCoach;
        private System.Windows.Forms.Label lblHeadCoach;
        private System.Windows.Forms.Panel pnlAsstCoach;
        private System.Windows.Forms.TextBox txtAsstCoach;
        private System.Windows.Forms.Label lblAsstCoach;
        private System.Windows.Forms.Panel pnlGM;
        private System.Windows.Forms.TextBox txtGM;
        private System.Windows.Forms.Label lblGM;
        private System.Windows.Forms.Panel pnlHomeCourt;
        private System.Windows.Forms.TextBox txtHomeCourt;
        private System.Windows.Forms.Label lblHomeCourt;
        private System.Windows.Forms.DataGridView dtgGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.Label lblTeamWins;
    }
}