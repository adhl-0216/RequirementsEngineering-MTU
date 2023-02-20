namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmManageGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageGames));
            this.btnScheduleGames = new System.Windows.Forms.Button();
            this.btnLogGameRes = new System.Windows.Forms.Button();
            this.btnRescheduleGame = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScheduleGames
            // 
            this.btnScheduleGames.BackColor = System.Drawing.Color.Firebrick;
            this.btnScheduleGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScheduleGames.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScheduleGames.Location = new System.Drawing.Point(17, 10);
            this.btnScheduleGames.Name = "btnScheduleGames";
            this.btnScheduleGames.Size = new System.Drawing.Size(239, 77);
            this.btnScheduleGames.TabIndex = 0;
            this.btnScheduleGames.Text = "Schedule Games";
            this.btnScheduleGames.UseVisualStyleBackColor = false;
            this.btnScheduleGames.Click += new System.EventHandler(this.btnScheduleGames_Click);
            // 
            // btnLogGameRes
            // 
            this.btnLogGameRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogGameRes.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogGameRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogGameRes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogGameRes.Location = new System.Drawing.Point(261, 93);
            this.btnLogGameRes.Name = "btnLogGameRes";
            this.btnLogGameRes.Size = new System.Drawing.Size(239, 77);
            this.btnLogGameRes.TabIndex = 1;
            this.btnLogGameRes.Text = "Log Game Result";
            this.btnLogGameRes.UseVisualStyleBackColor = false;
            this.btnLogGameRes.Click += new System.EventHandler(this.btnLogGameRes_Click);
            // 
            // btnRescheduleGame
            // 
            this.btnRescheduleGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRescheduleGame.BackColor = System.Drawing.Color.Firebrick;
            this.btnRescheduleGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRescheduleGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRescheduleGame.Location = new System.Drawing.Point(261, 10);
            this.btnRescheduleGame.Name = "btnRescheduleGame";
            this.btnRescheduleGame.Size = new System.Drawing.Size(239, 77);
            this.btnRescheduleGame.TabIndex = 2;
            this.btnRescheduleGame.Text = "Reschedule Game";
            this.btnRescheduleGame.UseVisualStyleBackColor = false;
            this.btnRescheduleGame.Click += new System.EventHandler(this.btnRescheduleGame_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelGame.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelGame.Location = new System.Drawing.Point(17, 93);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(239, 77);
            this.btnCancelGame.TabIndex = 3;
            this.btnCancelGame.Text = "Cancel Game";
            this.btnCancelGame.UseVisualStyleBackColor = false;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // frmManageGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NBAFantasyLeagueSeasonSchedulerSYS.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 180);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnRescheduleGame);
            this.Controls.Add(this.btnLogGameRes);
            this.Controls.Add(this.btnScheduleGames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManageGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageGames_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScheduleGames;
        private System.Windows.Forms.Button btnLogGameRes;
        private System.Windows.Forms.Button btnRescheduleGame;
        private System.Windows.Forms.Button btnCancelGame;
    }
}