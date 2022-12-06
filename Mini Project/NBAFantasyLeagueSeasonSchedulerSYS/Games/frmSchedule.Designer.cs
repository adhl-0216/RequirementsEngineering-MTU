
namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.btnSchedule = new System.Windows.Forms.Button();
            this.dtgTeamDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeamDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(273, 321);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 50);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "SCHEDULE";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // dtgTeamDetails
            // 
            this.dtgTeamDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeamDetails.Location = new System.Drawing.Point(60, 13);
            this.dtgTeamDetails.Name = "dtgTeamDetails";
            this.dtgTeamDetails.Size = new System.Drawing.Size(665, 255);
            this.dtgTeamDetails.TabIndex = 1;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgTeamDetails);
            this.Controls.Add(this.btnSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchedule";
            this.Text = "NBA Fantasy League Season Scheduler - [Manage Games] - [Schedule Game]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSchedule_FormClosing);
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeamDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DataGridView dtgTeamDetails;
    }
}