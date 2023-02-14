
namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    partial class frmViewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSchedule));
            this.dtgScheduledGames = new System.Windows.Forms.DataGridView();
            this.dtgCancelledGames = new System.Windows.Forms.DataGridView();
            this.lblScheduledGames = new System.Windows.Forms.Label();
            this.lblCancelledGames = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgScheduledGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCancelledGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgScheduledGames
            // 
            this.dtgScheduledGames.AllowUserToAddRows = false;
            this.dtgScheduledGames.AllowUserToDeleteRows = false;
            this.dtgScheduledGames.AllowUserToResizeColumns = false;
            this.dtgScheduledGames.AllowUserToResizeRows = false;
            this.dtgScheduledGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgScheduledGames.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgScheduledGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgScheduledGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgScheduledGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.gameID,
            this.home,
            this.away,
            this.time,
            this.venue});
            this.dtgScheduledGames.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgScheduledGames.Location = new System.Drawing.Point(9, 23);
            this.dtgScheduledGames.MultiSelect = false;
            this.dtgScheduledGames.Name = "dtgScheduledGames";
            this.dtgScheduledGames.ReadOnly = true;
            this.dtgScheduledGames.RowHeadersVisible = false;
            this.dtgScheduledGames.RowHeadersWidth = 62;
            this.dtgScheduledGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgScheduledGames.Size = new System.Drawing.Size(767, 400);
            this.dtgScheduledGames.TabIndex = 2;
            // 
            // dtgCancelledGames
            // 
            this.dtgCancelledGames.AllowUserToAddRows = false;
            this.dtgCancelledGames.AllowUserToDeleteRows = false;
            this.dtgCancelledGames.AllowUserToResizeColumns = false;
            this.dtgCancelledGames.AllowUserToResizeRows = false;
            this.dtgCancelledGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCancelledGames.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgCancelledGames.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgCancelledGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCancelledGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.reason});
            this.dtgCancelledGames.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCancelledGames.Location = new System.Drawing.Point(9, 449);
            this.dtgCancelledGames.MultiSelect = false;
            this.dtgCancelledGames.Name = "dtgCancelledGames";
            this.dtgCancelledGames.ReadOnly = true;
            this.dtgCancelledGames.RowHeadersVisible = false;
            this.dtgCancelledGames.RowHeadersWidth = 62;
            this.dtgCancelledGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCancelledGames.Size = new System.Drawing.Size(767, 300);
            this.dtgCancelledGames.TabIndex = 3;
            // 
            // lblScheduledGames
            // 
            this.lblScheduledGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduledGames.AutoSize = true;
            this.lblScheduledGames.Location = new System.Drawing.Point(6, 7);
            this.lblScheduledGames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScheduledGames.Name = "lblScheduledGames";
            this.lblScheduledGames.Size = new System.Drawing.Size(94, 13);
            this.lblScheduledGames.TabIndex = 4;
            this.lblScheduledGames.Text = "Scheduled Games";
            // 
            // lblCancelledGames
            // 
            this.lblCancelledGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancelledGames.AutoSize = true;
            this.lblCancelledGames.Location = new System.Drawing.Point(6, 433);
            this.lblCancelledGames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancelledGames.Name = "lblCancelledGames";
            this.lblCancelledGames.Size = new System.Drawing.Size(90, 13);
            this.lblCancelledGames.TabIndex = 5;
            this.lblCancelledGames.Text = "Cancelled Games";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "HOME TEAM";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "AWAY TEAM";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 97;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "TIME";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "VENUE";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 69;
            // 
            // reason
            // 
            this.reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reason.HeaderText = "REASON";
            this.reason.MinimumWidth = 8;
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            // 
            // frmViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lblCancelledGames);
            this.Controls.Add(this.lblScheduledGames);
            this.Controls.Add(this.dtgCancelledGames);
            this.Controls.Add(this.dtgScheduledGames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmViewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Admin] - [View Schedule]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewSchedule_FormClosing);
            this.Load += new System.EventHandler(this.frmViewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgScheduledGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCancelledGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgScheduledGames;
        private System.Windows.Forms.DataGridView dtgCancelledGames;
        private System.Windows.Forms.Label lblScheduledGames;
        private System.Windows.Forms.Label lblCancelledGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn away;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
    }
}