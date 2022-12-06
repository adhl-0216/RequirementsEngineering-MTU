
namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    partial class frmCancelGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelGames));
            this.dtgGames = new System.Windows.Forms.DataGridView();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGames
            // 
            this.dtgGames.AllowUserToAddRows = false;
            this.dtgGames.AllowUserToDeleteRows = false;
            this.dtgGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameID,
            this.home,
            this.away,
            this.date,
            this.time,
            this.venue});
            this.dtgGames.Location = new System.Drawing.Point(12, 12);
            this.dtgGames.Name = "dtgGames";
            this.dtgGames.ReadOnly = true;
            this.dtgGames.Size = new System.Drawing.Size(738, 229);
            this.dtgGames.TabIndex = 0;
            // 
            // gameID
            // 
            this.gameID.HeaderText = "ID";
            this.gameID.Name = "gameID";
            this.gameID.ReadOnly = true;
            // 
            // home
            // 
            this.home.HeaderText = "HOME TEAM";
            this.home.Name = "home";
            this.home.ReadOnly = true;
            // 
            // away
            // 
            this.away.HeaderText = "AWAY TEAM";
            this.away.Name = "away";
            this.away.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // venue
            // 
            this.venue.HeaderText = "VENUE";
            this.venue.Name = "venue";
            this.venue.ReadOnly = true;
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelGame.Location = new System.Drawing.Point(317, 383);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(128, 30);
            this.btnCancelGame.TabIndex = 1;
            this.btnCancelGame.Text = "CANCEL GAME";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(12, 272);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(738, 105);
            this.txtReason.TabIndex = 2;
            // 
            // lblReason
            // 
            this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 256);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(154, 13);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Reason for Game Cancellation:";
            // 
            // frmCancelGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 425);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.dtgGames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCancelGames";
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games] -[Cancel Game]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCancelGames_FormClosing);
            this.Load += new System.EventHandler(this.frmCancelGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGames;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn away;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
    }
}