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
            this.teamRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStandings)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStandings
            // 
            this.dtgStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamName,
            this.teamRecord});
            this.dtgStandings.Location = new System.Drawing.Point(39, 35);
            this.dtgStandings.Name = "dtgStandings";
            this.dtgStandings.RowHeadersVisible = false;
            this.dtgStandings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStandings.Size = new System.Drawing.Size(336, 162);
            this.dtgStandings.TabIndex = 0;
            // 
            // teamName
            // 
            this.teamName.HeaderText = "TEAM";
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            // 
            // teamRecord
            // 
            this.teamRecord.HeaderText = "RECORD";
            this.teamRecord.Name = "teamRecord";
            this.teamRecord.ReadOnly = true;
            // 
            // frmViewTeamStandings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgStandings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewTeamStandings";
            this.Text = "NBA Fantasy League Season Scheduler - [Admin] - [Team Standings]";
            ((System.ComponentModel.ISupportInitialize)(this.dtgStandings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStandings;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamRecord;
    }
}