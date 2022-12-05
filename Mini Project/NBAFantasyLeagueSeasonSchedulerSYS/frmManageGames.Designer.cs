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
            this.btnScheduleGames = new System.Windows.Forms.Button();
            this.btnLogGameRes = new System.Windows.Forms.Button();
            this.btnRescheduleGame = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScheduleGames
            // 
            this.btnScheduleGames.Location = new System.Drawing.Point(181, 114);
            this.btnScheduleGames.Name = "btnScheduleGames";
            this.btnScheduleGames.Size = new System.Drawing.Size(131, 51);
            this.btnScheduleGames.TabIndex = 0;
            this.btnScheduleGames.Text = "Schedule Games";
            this.btnScheduleGames.UseVisualStyleBackColor = true;
            this.btnScheduleGames.Click += new System.EventHandler(this.btnScheduleGames_Click);
            // 
            // btnLogGameRes
            // 
            this.btnLogGameRes.Location = new System.Drawing.Point(349, 195);
            this.btnLogGameRes.Name = "btnLogGameRes";
            this.btnLogGameRes.Size = new System.Drawing.Size(131, 51);
            this.btnLogGameRes.TabIndex = 1;
            this.btnLogGameRes.Text = "Log Game Result";
            this.btnLogGameRes.UseVisualStyleBackColor = true;
            this.btnLogGameRes.Click += new System.EventHandler(this.btnLogGameRes_Click);
            // 
            // btnRescheduleGame
            // 
            this.btnRescheduleGame.Location = new System.Drawing.Point(349, 114);
            this.btnRescheduleGame.Name = "btnRescheduleGame";
            this.btnRescheduleGame.Size = new System.Drawing.Size(131, 51);
            this.btnRescheduleGame.TabIndex = 2;
            this.btnRescheduleGame.Text = "Reschedule Game";
            this.btnRescheduleGame.UseVisualStyleBackColor = true;
            this.btnRescheduleGame.Click += new System.EventHandler(this.btnRescheduleGame_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Location = new System.Drawing.Point(181, 195);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(131, 51);
            this.btnCancelGame.TabIndex = 3;
            this.btnCancelGame.Text = "Cancel Game";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // frmManageGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnRescheduleGame);
            this.Controls.Add(this.btnLogGameRes);
            this.Controls.Add(this.btnScheduleGames);
            this.Name = "frmManageGames";
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