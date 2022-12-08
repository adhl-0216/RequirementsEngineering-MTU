
namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    partial class frmLogGameResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogGameResults));
            this.dtgGames = new System.Windows.Forms.DataGridView();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGameResult = new System.Windows.Forms.GroupBox();
            this.grpWinner = new System.Windows.Forms.GroupBox();
            this.rdHome = new System.Windows.Forms.RadioButton();
            this.rdAway = new System.Windows.Forms.RadioButton();
            this.txtAwayTRB = new System.Windows.Forms.TextBox();
            this.txtAwayAST = new System.Windows.Forms.TextBox();
            this.txtAwayPTS = new System.Windows.Forms.TextBox();
            this.txtHomeTRB = new System.Windows.Forms.TextBox();
            this.txtHomeAST = new System.Windows.Forms.TextBox();
            this.txtHomePTS = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGameID = new System.Windows.Forms.Label();
            this.lblAST = new System.Windows.Forms.Label();
            this.lblTRB = new System.Windows.Forms.Label();
            this.lblPTS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).BeginInit();
            this.grpGameResult.SuspendLayout();
            this.grpWinner.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgGames
            // 
            this.dtgGames.AllowUserToAddRows = false;
            this.dtgGames.AllowUserToDeleteRows = false;
            this.dtgGames.AllowUserToResizeColumns = false;
            this.dtgGames.AllowUserToResizeRows = false;
            this.dtgGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGames.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameID,
            this.home,
            this.away,
            this.date,
            this.time,
            this.venue});
            this.dtgGames.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgGames.Location = new System.Drawing.Point(13, 14);
            this.dtgGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgGames.MultiSelect = false;
            this.dtgGames.Name = "dtgGames";
            this.dtgGames.ReadOnly = true;
            this.dtgGames.RowHeadersVisible = false;
            this.dtgGames.RowHeadersWidth = 62;
            this.dtgGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGames.Size = new System.Drawing.Size(1174, 376);
            this.dtgGames.TabIndex = 2;
            this.dtgGames.SelectionChanged += new System.EventHandler(this.dtgGames_SelectionChanged);
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
            // home
            // 
            this.home.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.home.HeaderText = "HOME TEAM";
            this.home.MinimumWidth = 8;
            this.home.Name = "home";
            this.home.ReadOnly = true;
            this.home.Width = 141;
            // 
            // away
            // 
            this.away.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.away.HeaderText = "AWAY TEAM";
            this.away.MinimumWidth = 8;
            this.away.Name = "away";
            this.away.ReadOnly = true;
            this.away.Width = 141;
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
            // grpGameResult
            // 
            this.grpGameResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGameResult.Controls.Add(this.grpWinner);
            this.grpGameResult.Controls.Add(this.txtAwayTRB);
            this.grpGameResult.Controls.Add(this.txtAwayAST);
            this.grpGameResult.Controls.Add(this.txtAwayPTS);
            this.grpGameResult.Controls.Add(this.txtHomeTRB);
            this.grpGameResult.Controls.Add(this.txtHomeAST);
            this.grpGameResult.Controls.Add(this.txtHomePTS);
            this.grpGameResult.Controls.Add(this.btnSelect);
            this.grpGameResult.Controls.Add(this.btnConfirm);
            this.grpGameResult.Controls.Add(this.lblGameID);
            this.grpGameResult.Controls.Add(this.lblAST);
            this.grpGameResult.Controls.Add(this.lblTRB);
            this.grpGameResult.Controls.Add(this.lblPTS);
            this.grpGameResult.Location = new System.Drawing.Point(12, 398);
            this.grpGameResult.Name = "grpGameResult";
            this.grpGameResult.Size = new System.Drawing.Size(1176, 296);
            this.grpGameResult.TabIndex = 31;
            this.grpGameResult.TabStop = false;
            // 
            // grpWinner
            // 
            this.grpWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpWinner.Controls.Add(this.rdHome);
            this.grpWinner.Controls.Add(this.rdAway);
            this.grpWinner.Enabled = false;
            this.grpWinner.Location = new System.Drawing.Point(443, 47);
            this.grpWinner.Name = "grpWinner";
            this.grpWinner.Size = new System.Drawing.Size(288, 56);
            this.grpWinner.TabIndex = 43;
            this.grpWinner.TabStop = false;
            this.grpWinner.Text = "WINNER";
            // 
            // rdHome
            // 
            this.rdHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdHome.AutoSize = true;
            this.rdHome.Location = new System.Drawing.Point(6, 26);
            this.rdHome.Name = "rdHome";
            this.rdHome.Size = new System.Drawing.Size(82, 24);
            this.rdHome.TabIndex = 27;
            this.rdHome.TabStop = true;
            this.rdHome.Tag = "H";
            this.rdHome.Text = "HOME";
            this.rdHome.UseVisualStyleBackColor = true;
            // 
            // rdAway
            // 
            this.rdAway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAway.AutoSize = true;
            this.rdAway.Location = new System.Drawing.Point(200, 26);
            this.rdAway.Name = "rdAway";
            this.rdAway.Size = new System.Drawing.Size(82, 24);
            this.rdAway.TabIndex = 28;
            this.rdAway.TabStop = true;
            this.rdAway.Tag = "A";
            this.rdAway.Text = "AWAY";
            this.rdAway.UseVisualStyleBackColor = true;
            // 
            // txtAwayTRB
            // 
            this.txtAwayTRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAwayTRB.Enabled = false;
            this.txtAwayTRB.Location = new System.Drawing.Point(632, 144);
            this.txtAwayTRB.Name = "txtAwayTRB";
            this.txtAwayTRB.Size = new System.Drawing.Size(100, 26);
            this.txtAwayTRB.TabIndex = 42;
            // 
            // txtAwayAST
            // 
            this.txtAwayAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAwayAST.Enabled = false;
            this.txtAwayAST.Location = new System.Drawing.Point(632, 181);
            this.txtAwayAST.Name = "txtAwayAST";
            this.txtAwayAST.Size = new System.Drawing.Size(100, 26);
            this.txtAwayAST.TabIndex = 41;
            // 
            // txtAwayPTS
            // 
            this.txtAwayPTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAwayPTS.Enabled = false;
            this.txtAwayPTS.Location = new System.Drawing.Point(632, 109);
            this.txtAwayPTS.Name = "txtAwayPTS";
            this.txtAwayPTS.Size = new System.Drawing.Size(100, 26);
            this.txtAwayPTS.TabIndex = 40;
            // 
            // txtHomeTRB
            // 
            this.txtHomeTRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHomeTRB.Enabled = false;
            this.txtHomeTRB.Location = new System.Drawing.Point(445, 144);
            this.txtHomeTRB.Name = "txtHomeTRB";
            this.txtHomeTRB.Size = new System.Drawing.Size(100, 26);
            this.txtHomeTRB.TabIndex = 39;
            // 
            // txtHomeAST
            // 
            this.txtHomeAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHomeAST.Enabled = false;
            this.txtHomeAST.Location = new System.Drawing.Point(445, 181);
            this.txtHomeAST.Name = "txtHomeAST";
            this.txtHomeAST.Size = new System.Drawing.Size(100, 26);
            this.txtHomeAST.TabIndex = 38;
            // 
            // txtHomePTS
            // 
            this.txtHomePTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHomePTS.Enabled = false;
            this.txtHomePTS.Location = new System.Drawing.Point(445, 109);
            this.txtHomePTS.Name = "txtHomePTS";
            this.txtHomePTS.Size = new System.Drawing.Size(100, 26);
            this.txtHomePTS.TabIndex = 37;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSelect.Location = new System.Drawing.Point(618, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(121, 33);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(437, 213);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(302, 75);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblGameID
            // 
            this.lblGameID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGameID.AutoSize = true;
            this.lblGameID.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGameID.Location = new System.Drawing.Point(437, 8);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(108, 33);
            this.lblGameID.TabIndex = 34;
            this.lblGameID.Text = "Game ID";
            this.lblGameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAST
            // 
            this.lblAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAST.AutoSize = true;
            this.lblAST.Location = new System.Drawing.Point(568, 181);
            this.lblAST.Name = "lblAST";
            this.lblAST.Size = new System.Drawing.Size(40, 20);
            this.lblAST.TabIndex = 33;
            this.lblAST.Text = "AST";
            this.lblAST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTRB
            // 
            this.lblTRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTRB.AutoSize = true;
            this.lblTRB.Location = new System.Drawing.Point(568, 147);
            this.lblTRB.Name = "lblTRB";
            this.lblTRB.Size = new System.Drawing.Size(41, 20);
            this.lblTRB.TabIndex = 32;
            this.lblTRB.Text = "TRB";
            this.lblTRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPTS
            // 
            this.lblPTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPTS.AutoSize = true;
            this.lblPTS.Location = new System.Drawing.Point(569, 115);
            this.lblPTS.Name = "lblPTS";
            this.lblPTS.Size = new System.Drawing.Size(39, 20);
            this.lblPTS.TabIndex = 31;
            this.lblPTS.Text = "PTS";
            this.lblPTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogGameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dtgGames);
            this.Controls.Add(this.grpGameResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogGameResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games] - [Log Game Result]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogGameResults_FormClosing);
            this.Load += new System.EventHandler(this.frmLogGameResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).EndInit();
            this.grpGameResult.ResumeLayout(false);
            this.grpGameResult.PerformLayout();
            this.grpWinner.ResumeLayout(false);
            this.grpWinner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn away;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.GroupBox grpGameResult;
        private System.Windows.Forms.GroupBox grpWinner;
        private System.Windows.Forms.RadioButton rdHome;
        private System.Windows.Forms.RadioButton rdAway;
        private System.Windows.Forms.TextBox txtAwayTRB;
        private System.Windows.Forms.TextBox txtAwayAST;
        private System.Windows.Forms.TextBox txtAwayPTS;
        private System.Windows.Forms.TextBox txtHomeTRB;
        private System.Windows.Forms.TextBox txtHomeAST;
        private System.Windows.Forms.TextBox txtHomePTS;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Label lblAST;
        private System.Windows.Forms.Label lblTRB;
        private System.Windows.Forms.Label lblPTS;
    }
}