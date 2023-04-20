
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
            this.grpGameResult = new System.Windows.Forms.GroupBox();
            this.grpWinner = new System.Windows.Forms.GroupBox();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
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
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.date,
            this.gameID,
            this.home,
            this.away,
            this.time,
            this.venue});
            this.dtgGames.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgGames.Location = new System.Drawing.Point(9, 9);
            this.dtgGames.MultiSelect = false;
            this.dtgGames.Name = "dtgGames";
            this.dtgGames.ReadOnly = true;
            this.dtgGames.RowHeadersVisible = false;
            this.dtgGames.RowHeadersWidth = 62;
            this.dtgGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGames.Size = new System.Drawing.Size(783, 247);
            this.dtgGames.TabIndex = 2;
            this.dtgGames.SelectionChanged += new System.EventHandler(this.dtgGames_SelectionChanged);
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
            this.grpGameResult.Location = new System.Drawing.Point(8, 261);
            this.grpGameResult.Margin = new System.Windows.Forms.Padding(2);
            this.grpGameResult.Name = "grpGameResult";
            this.grpGameResult.Padding = new System.Windows.Forms.Padding(2);
            this.grpGameResult.Size = new System.Drawing.Size(784, 202);
            this.grpGameResult.TabIndex = 31;
            this.grpGameResult.TabStop = false;
            // 
            // grpWinner
            // 
            this.grpWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpWinner.Controls.Add(this.lblAway);
            this.grpWinner.Controls.Add(this.lblHome);
            this.grpWinner.Location = new System.Drawing.Point(297, 34);
            this.grpWinner.Margin = new System.Windows.Forms.Padding(2);
            this.grpWinner.Name = "grpWinner";
            this.grpWinner.Padding = new System.Windows.Forms.Padding(2);
            this.grpWinner.Size = new System.Drawing.Size(192, 33);
            this.grpWinner.TabIndex = 43;
            this.grpWinner.TabStop = false;
            this.grpWinner.Text = "WINNER";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Location = new System.Drawing.Point(123, 15);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(39, 13);
            this.lblAway.TabIndex = 1;
            this.lblAway.Text = "AWAY";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(30, 15);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(39, 13);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "HOME";
            // 
            // txtAwayTRB
            // 
            this.txtAwayTRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAwayTRB.Enabled = false;
            this.txtAwayTRB.Location = new System.Drawing.Point(421, 94);
            this.txtAwayTRB.Margin = new System.Windows.Forms.Padding(2);
            this.txtAwayTRB.Name = "txtAwayTRB";
            this.txtAwayTRB.Size = new System.Drawing.Size(68, 20);
            this.txtAwayTRB.TabIndex = 5;
            // 
            // txtAwayAST
            // 
            this.txtAwayAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAwayAST.Enabled = false;
            this.txtAwayAST.Location = new System.Drawing.Point(421, 118);
            this.txtAwayAST.Margin = new System.Windows.Forms.Padding(2);
            this.txtAwayAST.Name = "txtAwayAST";
            this.txtAwayAST.Size = new System.Drawing.Size(68, 20);
            this.txtAwayAST.TabIndex = 6;
            // 
            // txtAwayPTS
            // 
            this.txtAwayPTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAwayPTS.Enabled = false;
            this.txtAwayPTS.Location = new System.Drawing.Point(421, 71);
            this.txtAwayPTS.Margin = new System.Windows.Forms.Padding(2);
            this.txtAwayPTS.Name = "txtAwayPTS";
            this.txtAwayPTS.Size = new System.Drawing.Size(68, 20);
            this.txtAwayPTS.TabIndex = 4;
            this.txtAwayPTS.Leave += new System.EventHandler(this.txtPTS_Leave);
            // 
            // txtHomeTRB
            // 
            this.txtHomeTRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHomeTRB.Enabled = false;
            this.txtHomeTRB.Location = new System.Drawing.Point(297, 94);
            this.txtHomeTRB.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomeTRB.Name = "txtHomeTRB";
            this.txtHomeTRB.Size = new System.Drawing.Size(68, 20);
            this.txtHomeTRB.TabIndex = 2;
            // 
            // txtHomeAST
            // 
            this.txtHomeAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHomeAST.Enabled = false;
            this.txtHomeAST.Location = new System.Drawing.Point(297, 118);
            this.txtHomeAST.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomeAST.Name = "txtHomeAST";
            this.txtHomeAST.Size = new System.Drawing.Size(68, 20);
            this.txtHomeAST.TabIndex = 3;
            // 
            // txtHomePTS
            // 
            this.txtHomePTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHomePTS.Enabled = false;
            this.txtHomePTS.Location = new System.Drawing.Point(297, 71);
            this.txtHomePTS.Margin = new System.Windows.Forms.Padding(2);
            this.txtHomePTS.Name = "txtHomePTS";
            this.txtHomePTS.Size = new System.Drawing.Size(68, 20);
            this.txtHomePTS.TabIndex = 1;
            this.txtHomePTS.Leave += new System.EventHandler(this.txtPTS_Leave);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSelect.Location = new System.Drawing.Point(411, 4);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 31);
            this.btnSelect.TabIndex = 36;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(295, 142);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(197, 55);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGameID
            // 
            this.lblGameID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGameID.AutoSize = true;
            this.lblGameID.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGameID.Location = new System.Drawing.Point(291, 5);
            this.lblGameID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(73, 23);
            this.lblGameID.TabIndex = 34;
            this.lblGameID.Text = "Game ID";
            this.lblGameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAST
            // 
            this.lblAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAST.AutoSize = true;
            this.lblAST.Location = new System.Drawing.Point(379, 118);
            this.lblAST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAST.Name = "lblAST";
            this.lblAST.Size = new System.Drawing.Size(28, 13);
            this.lblAST.TabIndex = 33;
            this.lblAST.Text = "AST";
            this.lblAST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTRB
            // 
            this.lblTRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTRB.AutoSize = true;
            this.lblTRB.Location = new System.Drawing.Point(379, 96);
            this.lblTRB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTRB.Name = "lblTRB";
            this.lblTRB.Size = new System.Drawing.Size(29, 13);
            this.lblTRB.TabIndex = 32;
            this.lblTRB.Text = "TRB";
            this.lblTRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPTS
            // 
            this.lblPTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPTS.AutoSize = true;
            this.lblPTS.Location = new System.Drawing.Point(379, 75);
            this.lblPTS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTS.Name = "lblPTS";
            this.lblPTS.Size = new System.Drawing.Size(28, 13);
            this.lblPTS.TabIndex = 31;
            this.lblPTS.Text = "PTS";
            this.lblPTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date.HeaderText = "DATE";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 61;
            // 
            // gameID
            // 
            this.gameID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gameID.HeaderText = "ID";
            this.gameID.MinimumWidth = 8;
            this.gameID.Name = "gameID";
            this.gameID.ReadOnly = true;
            this.gameID.Width = 43;
            // 
            // home
            // 
            this.home.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.home.HeaderText = "HOME TEAM";
            this.home.MinimumWidth = 8;
            this.home.Name = "home";
            this.home.ReadOnly = true;
            this.home.Width = 97;
            // 
            // away
            // 
            this.away.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.away.HeaderText = "AWAY TEAM";
            this.away.MinimumWidth = 8;
            this.away.Name = "away";
            this.away.ReadOnly = true;
            this.away.Width = 97;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.time.HeaderText = "TIME";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 58;
            // 
            // venue
            // 
            this.venue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.venue.HeaderText = "VENUE";
            this.venue.MinimumWidth = 8;
            this.venue.Name = "venue";
            this.venue.ReadOnly = true;
            // 
            // frmLogGameResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.dtgGames);
            this.Controls.Add(this.grpGameResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.GroupBox grpGameResult;
        private System.Windows.Forms.GroupBox grpWinner;
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
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn away;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
    }
}