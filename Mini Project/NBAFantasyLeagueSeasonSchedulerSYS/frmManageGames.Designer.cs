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
            this.btnScheduleGames.Location = new System.Drawing.Point(26, 15);
            this.btnScheduleGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScheduleGames.Name = "btnScheduleGames";
            this.btnScheduleGames.Size = new System.Drawing.Size(358, 118);
            this.btnScheduleGames.TabIndex = 0;
            this.btnScheduleGames.Text = "Schedule Games";
            this.btnScheduleGames.UseVisualStyleBackColor = true;
            this.btnScheduleGames.Click += new System.EventHandler(this.btnScheduleGames_Click);
            // 
            // btnLogGameRes
            // 
            this.btnLogGameRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogGameRes.Location = new System.Drawing.Point(392, 143);
            this.btnLogGameRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogGameRes.Name = "btnLogGameRes";
            this.btnLogGameRes.Size = new System.Drawing.Size(358, 118);
            this.btnLogGameRes.TabIndex = 1;
            this.btnLogGameRes.Text = "Log Game Result";
            this.btnLogGameRes.UseVisualStyleBackColor = true;
            this.btnLogGameRes.Click += new System.EventHandler(this.btnLogGameRes_Click);
            // 
            // btnRescheduleGame
            // 
            this.btnRescheduleGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRescheduleGame.Location = new System.Drawing.Point(392, 15);
            this.btnRescheduleGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRescheduleGame.Name = "btnRescheduleGame";
            this.btnRescheduleGame.Size = new System.Drawing.Size(358, 118);
            this.btnRescheduleGame.TabIndex = 2;
            this.btnRescheduleGame.Text = "Reschedule Game";
            this.btnRescheduleGame.UseVisualStyleBackColor = true;
            this.btnRescheduleGame.Click += new System.EventHandler(this.btnRescheduleGame_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelGame.Location = new System.Drawing.Point(26, 143);
            this.btnCancelGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(358, 118);
            this.btnCancelGame.TabIndex = 3;
            this.btnCancelGame.Text = "Cancel Game";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // frmManageGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 277);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnRescheduleGame);
            this.Controls.Add(this.btnLogGameRes);
            this.Controls.Add(this.btnScheduleGames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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