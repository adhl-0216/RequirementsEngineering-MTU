
namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmUpdateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateTeam));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.pnlNewName = new System.Windows.Forms.Panel();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.pnlTeamName = new System.Windows.Forms.Panel();
            this.cboTeamName = new System.Windows.Forms.ComboBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pnlHeadCoach = new System.Windows.Forms.Panel();
            this.lblHeadCoach = new System.Windows.Forms.Label();
            this.txtHeadCoach = new System.Windows.Forms.TextBox();
            this.pnlAsstCoach = new System.Windows.Forms.Panel();
            this.lblAsstCoach = new System.Windows.Forms.Label();
            this.txtAsstCoach = new System.Windows.Forms.TextBox();
            this.pnlGM = new System.Windows.Forms.Panel();
            this.lblGM = new System.Windows.Forms.Label();
            this.txtGM = new System.Windows.Forms.TextBox();
            this.pnlHomeCourt = new System.Windows.Forms.Panel();
            this.lblHomeCourt = new System.Windows.Forms.Label();
            this.txtHomeCourt = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTeamID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnlInputs.SuspendLayout();
            this.pnlNewName.SuspendLayout();
            this.pnlTeamName.SuspendLayout();
            this.pnlHeadCoach.SuspendLayout();
            this.pnlAsstCoach.SuspendLayout();
            this.pnlGM.SuspendLayout();
            this.pnlHomeCourt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(472, 237);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.lblInstructions.Size = new System.Drawing.Size(374, 144);
            this.lblInstructions.TabIndex = 19;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateTeam.Location = new System.Drawing.Point(340, 609);
            this.btnUpdateTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(196, 58);
            this.btnUpdateTeam.TabIndex = 1;
            this.btnUpdateTeam.Text = "Update Team";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // pnlInputs
            // 
            this.pnlInputs.Controls.Add(this.pnlNewName);
            this.pnlInputs.Controls.Add(this.pnlTeamName);
            this.pnlInputs.Controls.Add(this.pnlHeadCoach);
            this.pnlInputs.Controls.Add(this.pnlAsstCoach);
            this.pnlInputs.Controls.Add(this.pnlGM);
            this.pnlInputs.Controls.Add(this.pnlHomeCourt);
            this.pnlInputs.Location = new System.Drawing.Point(18, 78);
            this.pnlInputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlInputs.Size = new System.Drawing.Size(438, 522);
            this.pnlInputs.TabIndex = 0;
            // 
            // pnlNewName
            // 
            this.pnlNewName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNewName.Controls.Add(this.lblNewName);
            this.pnlNewName.Controls.Add(this.txtNewName);
            this.pnlNewName.Location = new System.Drawing.Point(10, 65);
            this.pnlNewName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNewName.Name = "pnlNewName";
            this.pnlNewName.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlNewName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlNewName.Size = new System.Drawing.Size(417, 42);
            this.pnlNewName.TabIndex = 1;
            // 
            // lblNewName
            // 
            this.lblNewName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(6, 6);
            this.lblNewName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(130, 20);
            this.lblNewName.TabIndex = 1;
            this.lblNewName.Text = "New Team Name";
            this.lblNewName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewName
            // 
            this.txtNewName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtNewName.Enabled = false;
            this.txtNewName.Location = new System.Drawing.Point(175, 6);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewName.Multiline = true;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(236, 30);
            this.txtNewName.TabIndex = 0;
            // 
            // pnlTeamName
            // 
            this.pnlTeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTeamName.Controls.Add(this.cboTeamName);
            this.pnlTeamName.Controls.Add(this.lblTeamName);
            this.pnlTeamName.Location = new System.Drawing.Point(10, 15);
            this.pnlTeamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTeamName.Name = "pnlTeamName";
            this.pnlTeamName.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTeamName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTeamName.Size = new System.Drawing.Size(417, 42);
            this.pnlTeamName.TabIndex = 0;
            // 
            // cboTeamName
            // 
            this.cboTeamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeamName.FormattingEnabled = true;
            this.cboTeamName.Location = new System.Drawing.Point(172, 5);
            this.cboTeamName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTeamName.MaxDropDownItems = 10;
            this.cboTeamName.Name = "cboTeamName";
            this.cboTeamName.Size = new System.Drawing.Size(236, 28);
            this.cboTeamName.TabIndex = 0;
            this.cboTeamName.SelectedIndexChanged += new System.EventHandler(this.cboTeamName_SelectedIndexChanged);
            // 
            // lblTeamName
            // 
            this.lblTeamName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(6, 6);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(95, 20);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeadCoach
            // 
            this.pnlHeadCoach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeadCoach.Controls.Add(this.lblHeadCoach);
            this.pnlHeadCoach.Controls.Add(this.txtHeadCoach);
            this.pnlHeadCoach.Location = new System.Drawing.Point(10, 163);
            this.pnlHeadCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeadCoach.Name = "pnlHeadCoach";
            this.pnlHeadCoach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlHeadCoach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHeadCoach.Size = new System.Drawing.Size(417, 42);
            this.pnlHeadCoach.TabIndex = 3;
            // 
            // lblHeadCoach
            // 
            this.lblHeadCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeadCoach.AutoSize = true;
            this.lblHeadCoach.Location = new System.Drawing.Point(6, 6);
            this.lblHeadCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadCoach.Name = "lblHeadCoach";
            this.lblHeadCoach.Size = new System.Drawing.Size(98, 20);
            this.lblHeadCoach.TabIndex = 1;
            this.lblHeadCoach.Text = "Head Coach";
            this.lblHeadCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHeadCoach
            // 
            this.txtHeadCoach.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtHeadCoach.Enabled = false;
            this.txtHeadCoach.Location = new System.Drawing.Point(175, 6);
            this.txtHeadCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeadCoach.Name = "txtHeadCoach";
            this.txtHeadCoach.Size = new System.Drawing.Size(236, 26);
            this.txtHeadCoach.TabIndex = 0;
            // 
            // pnlAsstCoach
            // 
            this.pnlAsstCoach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAsstCoach.Controls.Add(this.lblAsstCoach);
            this.pnlAsstCoach.Controls.Add(this.txtAsstCoach);
            this.pnlAsstCoach.Location = new System.Drawing.Point(10, 212);
            this.pnlAsstCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAsstCoach.Name = "pnlAsstCoach";
            this.pnlAsstCoach.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlAsstCoach.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlAsstCoach.Size = new System.Drawing.Size(417, 42);
            this.pnlAsstCoach.TabIndex = 4;
            // 
            // lblAsstCoach
            // 
            this.lblAsstCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAsstCoach.AutoSize = true;
            this.lblAsstCoach.Location = new System.Drawing.Point(6, 6);
            this.lblAsstCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsstCoach.Name = "lblAsstCoach";
            this.lblAsstCoach.Size = new System.Drawing.Size(125, 20);
            this.lblAsstCoach.TabIndex = 1;
            this.lblAsstCoach.Text = "Assistant Coach";
            this.lblAsstCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAsstCoach
            // 
            this.txtAsstCoach.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtAsstCoach.Enabled = false;
            this.txtAsstCoach.Location = new System.Drawing.Point(175, 6);
            this.txtAsstCoach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsstCoach.Name = "txtAsstCoach";
            this.txtAsstCoach.Size = new System.Drawing.Size(236, 26);
            this.txtAsstCoach.TabIndex = 0;
            // 
            // pnlGM
            // 
            this.pnlGM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGM.Controls.Add(this.lblGM);
            this.pnlGM.Controls.Add(this.txtGM);
            this.pnlGM.Location = new System.Drawing.Point(10, 114);
            this.pnlGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGM.Name = "pnlGM";
            this.pnlGM.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlGM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlGM.Size = new System.Drawing.Size(417, 42);
            this.pnlGM.TabIndex = 2;
            // 
            // lblGM
            // 
            this.lblGM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGM.AutoSize = true;
            this.lblGM.Location = new System.Drawing.Point(6, 6);
            this.lblGM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGM.Name = "lblGM";
            this.lblGM.Size = new System.Drawing.Size(133, 20);
            this.lblGM.TabIndex = 1;
            this.lblGM.Text = "General Manager";
            this.lblGM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGM
            // 
            this.txtGM.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtGM.Enabled = false;
            this.txtGM.Location = new System.Drawing.Point(175, 6);
            this.txtGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGM.Name = "txtGM";
            this.txtGM.Size = new System.Drawing.Size(236, 26);
            this.txtGM.TabIndex = 0;
            // 
            // pnlHomeCourt
            // 
            this.pnlHomeCourt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHomeCourt.Controls.Add(this.lblHomeCourt);
            this.pnlHomeCourt.Controls.Add(this.txtHomeCourt);
            this.pnlHomeCourt.Location = new System.Drawing.Point(10, 262);
            this.pnlHomeCourt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHomeCourt.Name = "pnlHomeCourt";
            this.pnlHomeCourt.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlHomeCourt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlHomeCourt.Size = new System.Drawing.Size(417, 212);
            this.pnlHomeCourt.TabIndex = 5;
            // 
            // lblHomeCourt
            // 
            this.lblHomeCourt.AutoSize = true;
            this.lblHomeCourt.Location = new System.Drawing.Point(6, 6);
            this.lblHomeCourt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblHomeCourt.Name = "lblHomeCourt";
            this.lblHomeCourt.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblHomeCourt.Size = new System.Drawing.Size(107, 32);
            this.lblHomeCourt.TabIndex = 1;
            this.lblHomeCourt.Text = "Home Court";
            this.lblHomeCourt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHomeCourt
            // 
            this.txtHomeCourt.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtHomeCourt.Enabled = false;
            this.txtHomeCourt.Location = new System.Drawing.Point(175, 6);
            this.txtHomeCourt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHomeCourt.Multiline = true;
            this.txtHomeCourt.Name = "txtHomeCourt";
            this.txtHomeCourt.Size = new System.Drawing.Size(236, 200);
            this.txtHomeCourt.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 38);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Team Details";
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.ForeColor = System.Drawing.Color.Red;
            this.lblTeamID.Location = new System.Drawing.Point(477, 94);
            this.lblTeamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(0, 20);
            this.lblTeamID.TabIndex = 20;
            // 
            // frmUpdateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 686);
            this.Controls.Add(this.lblTeamID);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnUpdateTeam);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Teams] - [Update Team]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateTeam_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnlInputs.ResumeLayout(false);
            this.pnlNewName.ResumeLayout(false);
            this.pnlNewName.PerformLayout();
            this.pnlTeamName.ResumeLayout(false);
            this.pnlTeamName.PerformLayout();
            this.pnlHeadCoach.ResumeLayout(false);
            this.pnlHeadCoach.PerformLayout();
            this.pnlAsstCoach.ResumeLayout(false);
            this.pnlAsstCoach.PerformLayout();
            this.pnlGM.ResumeLayout(false);
            this.pnlGM.PerformLayout();
            this.pnlHomeCourt.ResumeLayout(false);
            this.pnlHomeCourt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Panel pnlTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Panel pnlHeadCoach;
        private System.Windows.Forms.Label lblHeadCoach;
        private System.Windows.Forms.TextBox txtHeadCoach;
        private System.Windows.Forms.Panel pnlAsstCoach;
        private System.Windows.Forms.Label lblAsstCoach;
        private System.Windows.Forms.TextBox txtAsstCoach;
        private System.Windows.Forms.Panel pnlGM;
        private System.Windows.Forms.Label lblGM;
        private System.Windows.Forms.TextBox txtGM;
        private System.Windows.Forms.Panel pnlHomeCourt;
        private System.Windows.Forms.Label lblHomeCourt;
        private System.Windows.Forms.TextBox txtHomeCourt;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboTeamName;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Panel pnlNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewName;
    }
}