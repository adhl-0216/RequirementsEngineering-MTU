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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTeamStandings));
            this.dtgStandings = new System.Windows.Forms.DataGridView();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamLoses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsPerGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opponentPointsPerGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStandings)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStandings
            // 
            this.dtgStandings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamName,
            this.teamWins,
            this.teamLoses,
            this.winRate,
            this.homeRecord,
            this.awayRecord,
            this.pointsPerGame,
            this.opponentPointsPerGame});
            this.dtgStandings.Location = new System.Drawing.Point(12, 45);
            this.dtgStandings.Name = "dtgStandings";
            this.dtgStandings.RowHeadersVisible = false;
            this.dtgStandings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStandings.Size = new System.Drawing.Size(803, 385);
            this.dtgStandings.TabIndex = 0;
            // 
            // teamName
            // 
            this.teamName.HeaderText = "TEAM";
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            // 
            // teamWins
            // 
            this.teamWins.HeaderText = "WINS";
            this.teamWins.Name = "teamWins";
            this.teamWins.ReadOnly = true;
            // 
            // teamLoses
            // 
            this.teamLoses.HeaderText = "LOSES";
            this.teamLoses.Name = "teamLoses";
            // 
            // winRate
            // 
            this.winRate.HeaderText = "PCT";
            this.winRate.Name = "winRate";
            // 
            // homeRecord
            // 
            this.homeRecord.HeaderText = "HOME";
            this.homeRecord.Name = "homeRecord";
            // 
            // awayRecord
            // 
            this.awayRecord.HeaderText = "AWAY";
            this.awayRecord.Name = "awayRecord";
            // 
            // pointsPerGame
            // 
            this.pointsPerGame.HeaderText = "PPG";
            this.pointsPerGame.Name = "pointsPerGame";
            // 
            // opponentPointsPerGame
            // 
            this.opponentPointsPerGame.HeaderText = "OPPG";
            this.opponentPointsPerGame.Name = "opponentPointsPerGame";
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
            // frmViewTeamStandings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBAFantasyLeagueSeasonSchedulerSYS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(827, 442);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtgStandings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewTeamStandings";
            this.Text = "NBA Fantasy League Season Scheduler - [Admin] - [Team Standings]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewTeamStandings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStandings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStandings;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamLoses;
        private System.Windows.Forms.DataGridViewTextBoxColumn winRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsPerGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn opponentPointsPerGame;
        private System.Windows.Forms.Label lblTitle;
    }
}