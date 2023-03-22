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
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTEAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWINS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLOSES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAWAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOPPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colRank,
            this.colTEAM,
            this.colWINS,
            this.colLOSES,
            this.colPCT,
            this.colHOME,
            this.colAWAY,
            this.colPPG,
            this.colOPPG});
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
            this.dgvStandings.Size = new System.Drawing.Size(552, 250);
            this.dgvStandings.TabIndex = 2;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "RANK";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.Width = 62;
            // 
            // colTEAM
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTEAM.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTEAM.HeaderText = "TEAM";
            this.colTEAM.Name = "colTEAM";
            this.colTEAM.ReadOnly = true;
            this.colTEAM.Width = 62;
            // 
            // colWINS
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colWINS.DefaultCellStyle = dataGridViewCellStyle3;
            this.colWINS.HeaderText = "WINS";
            this.colWINS.Name = "colWINS";
            this.colWINS.ReadOnly = true;
            this.colWINS.Width = 61;
            // 
            // colLOSES
            // 
            this.colLOSES.HeaderText = "LOSES";
            this.colLOSES.Name = "colLOSES";
            this.colLOSES.ReadOnly = true;
            this.colLOSES.Width = 67;
            // 
            // colPCT
            // 
            this.colPCT.HeaderText = "PCT";
            this.colPCT.Name = "colPCT";
            this.colPCT.ReadOnly = true;
            this.colPCT.Width = 53;
            // 
            // colHOME
            // 
            this.colHOME.HeaderText = "HOME";
            this.colHOME.Name = "colHOME";
            this.colHOME.ReadOnly = true;
            this.colHOME.Width = 64;
            // 
            // colAWAY
            // 
            this.colAWAY.HeaderText = "AWAY";
            this.colAWAY.Name = "colAWAY";
            this.colAWAY.ReadOnly = true;
            this.colAWAY.Width = 64;
            // 
            // colPPG
            // 
            this.colPPG.HeaderText = "PPG";
            this.colPPG.Name = "colPPG";
            this.colPPG.ReadOnly = true;
            this.colPPG.Width = 54;
            // 
            // colOPPG
            // 
            this.colOPPG.HeaderText = "OPPG";
            this.colOPPG.Name = "colOPPG";
            this.colOPPG.ReadOnly = true;
            this.colOPPG.Width = 62;
            // 
            // frmViewTeamStandings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBAFantasyLeagueSeasonSchedulerSYS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(581, 301);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTEAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWINS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLOSES;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAWAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOPPG;
    }
}