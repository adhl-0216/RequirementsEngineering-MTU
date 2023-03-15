namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    partial class frmViewTeamStandings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTeamStandings));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvStandings = new System.Windows.Forms.DataGridView();
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamLoses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsPerGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentPointsPerGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "STANDINGS";
            // 
            // dgvStandings
            // 
            this.dgvStandings.AllowUserToAddRows = false;
            this.dgvStandings.AllowUserToDeleteRows = false;
            this.dgvStandings.AllowUserToResizeColumns = false;
            this.dgvStandings.AllowUserToResizeRows = false;
            this.dgvStandings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStandings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStandings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStandings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStandings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamWins,
            this.teamLoses,
            this.winRate,
            this.homeRecord,
            this.awayRecord,
            this.pointsPerGame,
            this.opponentPointsPerGame});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStandings.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStandings.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStandings.Location = new System.Drawing.Point(15, 40);
            this.dgvStandings.MultiSelect = false;
            this.dgvStandings.Name = "dgvStandings";
            this.dgvStandings.ReadOnly = true;
            this.dgvStandings.RowHeadersVisible = false;
            this.dgvStandings.RowHeadersWidth = 62;
            this.dgvStandings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandings.Size = new System.Drawing.Size(489, 250);
            this.dgvStandings.TabIndex = 2;
            // 
            // teamID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.teamID.DefaultCellStyle = dataGridViewCellStyle2;
            this.teamID.HeaderText = "TEAM";
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            this.teamID.Width = 62;
            // 
            // teamWins
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.teamWins.DefaultCellStyle = dataGridViewCellStyle3;
            this.teamWins.HeaderText = "WINS";
            this.teamWins.Name = "teamWins";
            this.teamWins.ReadOnly = true;
            this.teamWins.Width = 61;
            // 
            // teamLoses
            // 
            this.teamLoses.HeaderText = "LOSES";
            this.teamLoses.Name = "teamLoses";
            this.teamLoses.ReadOnly = true;
            this.teamLoses.Width = 67;
            // 
            // winRate
            // 
            this.winRate.HeaderText = "PCT";
            this.winRate.Name = "winRate";
            this.winRate.ReadOnly = true;
            this.winRate.Width = 53;
            // 
            // homeRecord
            // 
            this.homeRecord.HeaderText = "HOME";
            this.homeRecord.Name = "homeRecord";
            this.homeRecord.ReadOnly = true;
            this.homeRecord.Width = 64;
            // 
            // awayRecord
            // 
            this.awayRecord.HeaderText = "AWAY";
            this.awayRecord.Name = "awayRecord";
            this.awayRecord.ReadOnly = true;
            this.awayRecord.Width = 64;
            // 
            // pointsPerGame
            // 
            this.pointsPerGame.HeaderText = "PPG";
            this.pointsPerGame.Name = "pointsPerGame";
            this.pointsPerGame.ReadOnly = true;
            this.pointsPerGame.Width = 54;
            // 
            // opponentPointsPerGame
            // 
            this.opponentPointsPerGame.HeaderText = "OPPG";
            this.opponentPointsPerGame.Name = "opponentPointsPerGame";
            this.opponentPointsPerGame.ReadOnly = true;
            this.opponentPointsPerGame.Width = 62;
            // 
            // frmViewTeamStandings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBAFantasyLeagueSeasonSchedulerSYS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(518, 301);
            this.Controls.Add(this.dgvStandings);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewTeamStandings";
            this.Text = "NBA Fantasy League Season Scheduler - [Admin] - [Team Standings]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewTeamStandings_FormClosing);
            this.Load += new System.EventHandler(this.frmViewTeamStandings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvStandings;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamLoses;
        private System.Windows.Forms.DataGridViewTextBoxColumn winRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsPerGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentPointsPerGame;
    }
}