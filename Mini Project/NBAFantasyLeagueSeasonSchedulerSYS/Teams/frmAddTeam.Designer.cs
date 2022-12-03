namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmAddTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTeam));
            this.pnlTeamName = new System.Windows.Forms.Panel();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.pnlHeadCoach = new System.Windows.Forms.Panel();
            this.lblHeadCoach = new System.Windows.Forms.Label();
            this.txtHeadCoach = new System.Windows.Forms.TextBox();
            this.pnlAsstCoach = new System.Windows.Forms.Panel();
            this.lblAsstCoach = new System.Windows.Forms.Label();
            this.txtAsstCoach = new System.Windows.Forms.TextBox();
            this.pnlHomeCourt = new System.Windows.Forms.Panel();
            this.lblHomeCourt = new System.Windows.Forms.Label();
            this.txtHomeCourt = new System.Windows.Forms.TextBox();
            this.pnlGM = new System.Windows.Forms.Panel();
            this.lblGM = new System.Windows.Forms.Label();
            this.txtGM = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTeamName.SuspendLayout();
            this.pnlHeadCoach.SuspendLayout();
            this.pnlAsstCoach.SuspendLayout();
            this.pnlHomeCourt.SuspendLayout();
            this.pnlGM.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTeamName
            // 
            this.pnlTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTeamName.Controls.Add(this.lblTeamName);
            this.pnlTeamName.Controls.Add(this.txtTeamName);
            this.pnlTeamName.Location = new System.Drawing.Point(10, 11);
            this.pnlTeamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeamName.Name = "pnlTeamName";
            this.pnlTeamName.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTeamName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTeamName.Size = new System.Drawing.Size(417, 42);
            this.pnlTeamName.TabIndex = 9;
            // 
            // lblTeamName
            // 
            this.lblTeamName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(6, 6);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(95, 20);
            this.lblTeamName.TabIndex = 3;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTeamName.Location = new System.Drawing.Point(175, 6);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(236, 26);
            this.txtTeamName.TabIndex = 1;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // pnlHeadCoach
            // 
            this.pnlHeadCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeadCoach.Controls.Add(this.lblHeadCoach);
            this.pnlHeadCoach.Controls.Add(this.txtHeadCoach);
            this.pnlHeadCoach.Location = new System.Drawing.Point(10, 115);
            this.pnlHeadCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeadCoach.Name = "pnlHeadCoach";
            this.pnlHeadCoach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlHeadCoach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHeadCoach.Size = new System.Drawing.Size(417, 42);
            this.pnlHeadCoach.TabIndex = 10;
            // 
            // lblHeadCoach
            // 
            this.lblHeadCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeadCoach.AutoSize = true;
            this.lblHeadCoach.Location = new System.Drawing.Point(6, 6);
            this.lblHeadCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadCoach.Name = "lblHeadCoach";
            this.lblHeadCoach.Size = new System.Drawing.Size(98, 20);
            this.lblHeadCoach.TabIndex = 3;
            this.lblHeadCoach.Text = "Head Coach";
            this.lblHeadCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHeadCoach
            // 
            this.txtHeadCoach.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtHeadCoach.Location = new System.Drawing.Point(175, 6);
            this.txtHeadCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeadCoach.Name = "txtHeadCoach";
            this.txtHeadCoach.Size = new System.Drawing.Size(236, 26);
            this.txtHeadCoach.TabIndex = 3;
            // 
            // pnlAsstCoach
            // 
            this.pnlAsstCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAsstCoach.Controls.Add(this.lblAsstCoach);
            this.pnlAsstCoach.Controls.Add(this.txtAsstCoach);
            this.pnlAsstCoach.Location = new System.Drawing.Point(10, 168);
            this.pnlAsstCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAsstCoach.Name = "pnlAsstCoach";
            this.pnlAsstCoach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlAsstCoach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlAsstCoach.Size = new System.Drawing.Size(417, 42);
            this.pnlAsstCoach.TabIndex = 10;
            // 
            // lblAsstCoach
            // 
            this.lblAsstCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAsstCoach.AutoSize = true;
            this.lblAsstCoach.Location = new System.Drawing.Point(6, 6);
            this.lblAsstCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsstCoach.Name = "lblAsstCoach";
            this.lblAsstCoach.Size = new System.Drawing.Size(125, 20);
            this.lblAsstCoach.TabIndex = 3;
            this.lblAsstCoach.Text = "Assistant Coach";
            this.lblAsstCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAsstCoach
            // 
            this.txtAsstCoach.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtAsstCoach.Location = new System.Drawing.Point(175, 6);
            this.txtAsstCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsstCoach.Name = "txtAsstCoach";
            this.txtAsstCoach.Size = new System.Drawing.Size(236, 26);
            this.txtAsstCoach.TabIndex = 4;
            // 
            // pnlHomeCourt
            // 
            this.pnlHomeCourt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHomeCourt.Controls.Add(this.lblHomeCourt);
            this.pnlHomeCourt.Controls.Add(this.txtHomeCourt);
            this.pnlHomeCourt.Location = new System.Drawing.Point(10, 220);
            this.pnlHomeCourt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHomeCourt.Name = "pnlHomeCourt";
            this.pnlHomeCourt.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlHomeCourt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHomeCourt.Size = new System.Drawing.Size(417, 212);
            this.pnlHomeCourt.TabIndex = 10;
            // 
            // lblHomeCourt
            // 
            this.lblHomeCourt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHomeCourt.AutoSize = true;
            this.lblHomeCourt.Location = new System.Drawing.Point(6, 6);
            this.lblHomeCourt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblHomeCourt.Name = "lblHomeCourt";
            this.lblHomeCourt.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblHomeCourt.Size = new System.Drawing.Size(107, 32);
            this.lblHomeCourt.TabIndex = 3;
            this.lblHomeCourt.Text = "Home Court";
            this.lblHomeCourt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHomeCourt.Click += new System.EventHandler(this.lblHomeCourt_Click);
            // 
            // txtHomeCourt
            // 
            this.txtHomeCourt.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtHomeCourt.Location = new System.Drawing.Point(175, 6);
            this.txtHomeCourt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHomeCourt.Multiline = true;
            this.txtHomeCourt.Name = "txtHomeCourt";
            this.txtHomeCourt.Size = new System.Drawing.Size(236, 200);
            this.txtHomeCourt.TabIndex = 5;
            // 
            // pnlGM
            // 
            this.pnlGM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGM.Controls.Add(this.lblGM);
            this.pnlGM.Controls.Add(this.txtGM);
            this.pnlGM.Location = new System.Drawing.Point(10, 63);
            this.pnlGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGM.Name = "pnlGM";
            this.pnlGM.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlGM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGM.Size = new System.Drawing.Size(417, 42);
            this.pnlGM.TabIndex = 10;
            // 
            // lblGM
            // 
            this.lblGM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGM.AutoSize = true;
            this.lblGM.Location = new System.Drawing.Point(6, 6);
            this.lblGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGM.Name = "lblGM";
            this.lblGM.Size = new System.Drawing.Size(133, 20);
            this.lblGM.TabIndex = 3;
            this.lblGM.Text = "General Manager";
            this.lblGM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGM
            // 
            this.txtGM.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtGM.Location = new System.Drawing.Point(175, 6);
            this.txtGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGM.Name = "txtGM";
            this.txtGM.Size = new System.Drawing.Size(236, 26);
            this.txtGM.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 38);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Team Details";
            // 
            // pnlInputs
            // 
            this.pnlInputs.Controls.Add(this.pnlTeamName);
            this.pnlInputs.Controls.Add(this.pnlHeadCoach);
            this.pnlInputs.Controls.Add(this.pnlAsstCoach);
            this.pnlInputs.Controls.Add(this.pnlGM);
            this.pnlInputs.Controls.Add(this.pnlHomeCourt);
            this.pnlInputs.Location = new System.Drawing.Point(18, 78);
            this.pnlInputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlInputs.Size = new System.Drawing.Size(438, 443);
            this.pnlInputs.TabIndex = 12;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddTeam.Location = new System.Drawing.Point(340, 557);
            this.btnAddTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(196, 58);
            this.btnAddTeam.TabIndex = 7;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(472, 211);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lblInstructions.Size = new System.Drawing.Size(374, 144);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // frmAddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 634);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Teams] - [Add Team]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddTeam_FormClosing);
            this.Load += new System.EventHandler(this.frmAddTeam_Load);
            this.pnlTeamName.ResumeLayout(false);
            this.pnlTeamName.PerformLayout();
            this.pnlHeadCoach.ResumeLayout(false);
            this.pnlHeadCoach.PerformLayout();
            this.pnlAsstCoach.ResumeLayout(false);
            this.pnlAsstCoach.PerformLayout();
            this.pnlHomeCourt.ResumeLayout(false);
            this.pnlHomeCourt.PerformLayout();
            this.pnlGM.ResumeLayout(false);
            this.pnlGM.PerformLayout();
            this.pnlInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Panel pnlHeadCoach;
        private System.Windows.Forms.Label lblHeadCoach;
        private System.Windows.Forms.TextBox txtHeadCoach;
        private System.Windows.Forms.Panel pnlAsstCoach;
        private System.Windows.Forms.Label lblAsstCoach;
        private System.Windows.Forms.TextBox txtAsstCoach;
        private System.Windows.Forms.Panel pnlHomeCourt;
        private System.Windows.Forms.Label lblHomeCourt;
        private System.Windows.Forms.TextBox txtHomeCourt;
        private System.Windows.Forms.Panel pnlGM;
        private System.Windows.Forms.Label lblGM;
        private System.Windows.Forms.TextBox txtGM;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}