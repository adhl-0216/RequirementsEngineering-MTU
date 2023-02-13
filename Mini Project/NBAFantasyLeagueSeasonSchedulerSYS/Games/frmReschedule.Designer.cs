﻿
namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    partial class frmReschedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReschedule));
            this.dtgGames = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGameDetails = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.lblGameID = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).BeginInit();
            this.grpGameDetails.SuspendLayout();
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
            this.dtgGames.Size = new System.Drawing.Size(767, 553);
            this.dtgGames.TabIndex = 1;
            this.dtgGames.SelectionChanged += new System.EventHandler(this.dtgGames_SelectionChanged);
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
            // grpGameDetails
            // 
            this.grpGameDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGameDetails.Controls.Add(this.btnSelect);
            this.grpGameDetails.Controls.Add(this.dtpTime);
            this.grpGameDetails.Controls.Add(this.btnReschedule);
            this.grpGameDetails.Controls.Add(this.lblGameID);
            this.grpGameDetails.Controls.Add(this.txtVenue);
            this.grpGameDetails.Controls.Add(this.lblVenue);
            this.grpGameDetails.Controls.Add(this.lblTime);
            this.grpGameDetails.Controls.Add(this.dtpDate);
            this.grpGameDetails.Controls.Add(this.lblDate);
            this.grpGameDetails.Location = new System.Drawing.Point(9, 568);
            this.grpGameDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpGameDetails.Name = "grpGameDetails";
            this.grpGameDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpGameDetails.Size = new System.Drawing.Size(767, 196);
            this.grpGameDetails.TabIndex = 12;
            this.grpGameDetails.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSelect.Location = new System.Drawing.Point(421, 10);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(73, 23);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(359, 62);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(135, 20);
            this.dtpTime.TabIndex = 19;
            this.dtpTime.Value = new System.DateTime(2022, 12, 7, 13, 52, 54, 0);
            // 
            // btnReschedule
            // 
            this.btnReschedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnReschedule.Location = new System.Drawing.Point(291, 140);
            this.btnReschedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(203, 49);
            this.btnReschedule.TabIndex = 18;
            this.btnReschedule.Text = "RESCHEDULE";
            this.btnReschedule.UseVisualStyleBackColor = true;
            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);
            // 
            // lblGameID
            // 
            this.lblGameID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGameID.AutoSize = true;
            this.lblGameID.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGameID.Location = new System.Drawing.Point(291, 10);
            this.lblGameID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(73, 23);
            this.lblGameID.TabIndex = 17;
            this.lblGameID.Text = "Game ID";
            this.lblGameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVenue
            // 
            this.txtVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVenue.Enabled = false;
            this.txtVenue.Location = new System.Drawing.Point(359, 84);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenue.Multiline = true;
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(135, 53);
            this.txtVenue.TabIndex = 16;
            // 
            // lblVenue
            // 
            this.lblVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(291, 84);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(38, 13);
            this.lblVenue.TabIndex = 15;
            this.lblVenue.Text = "Venue";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(291, 62);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(359, 42);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(135, 20);
            this.dtpDate.TabIndex = 13;
            this.dtpDate.Value = new System.DateTime(2022, 12, 7, 13, 52, 54, 0);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(291, 42);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.dtgGames);
            this.Controls.Add(this.grpGameDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReschedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games] - [Reschedule Game]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReschedule_FormClosing);
            this.Load += new System.EventHandler(this.frmReschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).EndInit();
            this.grpGameDetails.ResumeLayout(false);
            this.grpGameDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGames;
        private System.Windows.Forms.GroupBox grpGameDetails;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn away;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
    }
}