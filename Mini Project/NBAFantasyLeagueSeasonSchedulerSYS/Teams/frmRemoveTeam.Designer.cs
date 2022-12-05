
namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmRemoveTeam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveTeam));
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.dataTeams = new System.Windows.Forms.DataGridView();
            this.teamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teams_File = new NBAFantasyLeagueSeasonSchedulerSYS.Teams_File();
            this.teamsFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teams_File)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(107, 6);
            this.cboSelectTeam.MaxDropDownItems = 10;
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(411, 21);
            this.cboSelectTeam.TabIndex = 0;
            this.cboSelectTeam.SelectedIndexChanged += new System.EventHandler(this.cboSelectTeam_SelectedIndexChanged);
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(6, 9);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(67, 13);
            this.lblSelectTeam.TabIndex = 1;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 26);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Remove Team";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataTeams);
            this.panel1.Controls.Add(this.cboSelectTeam);
            this.panel1.Controls.Add(this.lblSelectTeam);
            this.panel1.Location = new System.Drawing.Point(18, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(533, 275);
            this.panel1.TabIndex = 19;
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveTeam.Location = new System.Drawing.Point(240, 353);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(75, 32);
            this.btnRemoveTeam.TabIndex = 20;
            this.btnRemoveTeam.Text = "REMOVE";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // dataTeams
            // 
            this.dataTeams.AllowUserToAddRows = false;
            this.dataTeams.AllowUserToDeleteRows = false;
            this.dataTeams.AutoGenerateColumns = false;
            this.dataTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamID,
            this.teamName,
            this.hCoach,
            this.home});
            this.dataTeams.DataSource = this.teamsFileBindingSource;
            this.dataTeams.Location = new System.Drawing.Point(9, 33);
            this.dataTeams.Name = "dataTeams";
            this.dataTeams.ReadOnly = true;
            this.dataTeams.Size = new System.Drawing.Size(509, 231);
            this.dataTeams.TabIndex = 2;
            // 
            // teamID
            // 
            this.teamID.HeaderText = "ID";
            this.teamID.Name = "teamID";
            this.teamID.ReadOnly = true;
            // 
            // teamName
            // 
            this.teamName.HeaderText = "NAME";
            this.teamName.Name = "teamName";
            this.teamName.ReadOnly = true;
            // 
            // hCoach
            // 
            this.hCoach.HeaderText = "HEAD COACH";
            this.hCoach.Name = "hCoach";
            this.hCoach.ReadOnly = true;
            // 
            // home
            // 
            this.home.HeaderText = "HOME COURT";
            this.home.Name = "home";
            this.home.ReadOnly = true;
            // 
            // teams_File
            // 
            this.teams_File.DataSetName = "Teams_File";
            this.teams_File.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsFileBindingSource
            // 
            this.teamsFileBindingSource.DataSource = this.teams_File;
            this.teamsFileBindingSource.Position = 0;
            // 
            // frmRemoveTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 397);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveTeam";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Teams] - [Remove Team]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRemoveTeam_FormClosing);
            this.Load += new System.EventHandler(this.frmRemoveTeam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teams_File)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsFileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.DataGridView dataTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.BindingSource teamsFileBindingSource;
        private Teams_File teams_File;
    }
}