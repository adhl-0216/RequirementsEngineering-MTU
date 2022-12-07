
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
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblGameID = new System.Windows.Forms.Label();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).BeginInit();
            this.SuspendLayout();
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
            this.dtgGames.TabIndex = 1;
            this.dtgGames.DoubleClick += new System.EventHandler(this.dtgGames_DoubleClick);
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
            this.venue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.venue.HeaderText = "VENUE";
            this.venue.MinimumWidth = 8;
            this.venue.Name = "venue";
            this.venue.ReadOnly = true;
            this.venue.Width = 101;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(448, 463);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(554, 463);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.Value = new System.DateTime(2022, 12, 7, 13, 52, 54, 0);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(448, 495);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(448, 529);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(56, 20);
            this.lblVenue.TabIndex = 6;
            this.lblVenue.Text = "Venue";
            this.lblVenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVenue
            // 
            this.txtVenue.Enabled = false;
            this.txtVenue.Location = new System.Drawing.Point(554, 529);
            this.txtVenue.Multiline = true;
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(200, 79);
            this.txtVenue.TabIndex = 7;
            // 
            // lblGameID
            // 
            this.lblGameID.AutoSize = true;
            this.lblGameID.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblGameID.Location = new System.Drawing.Point(446, 409);
            this.lblGameID.Name = "lblGameID";
            this.lblGameID.Size = new System.Drawing.Size(108, 33);
            this.lblGameID.TabIndex = 8;
            this.lblGameID.Text = "Game ID";
            this.lblGameID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReschedule
            // 
            this.btnReschedule.Location = new System.Drawing.Point(452, 614);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(302, 75);
            this.btnReschedule.TabIndex = 9;
            this.btnReschedule.Text = "RESCHEDULE";
            this.btnReschedule.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(554, 495);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(200, 26);
            this.dtpTime.TabIndex = 10;
            this.dtpTime.Value = new System.DateTime(2022, 12, 7, 13, 52, 54, 0);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(633, 409);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(121, 33);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmReschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnReschedule);
            this.Controls.Add(this.lblGameID);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtgGames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReschedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games] - [Reschedule Game]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReschedule_FormClosing);
            this.Load += new System.EventHandler(this.frmReschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn away;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label lblGameID;
        private System.Windows.Forms.Button btnReschedule;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnSelect;
    }
}