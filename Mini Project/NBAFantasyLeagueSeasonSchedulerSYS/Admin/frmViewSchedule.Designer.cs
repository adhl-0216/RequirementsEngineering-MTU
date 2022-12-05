
namespace NBAFantasyLeagueSeasonSchedulerSYS.Admin
{
    partial class frmViewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSchedule));
            this.SuspendLayout();
            // 
            // frmViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmViewSchedule";
            this.Text = "NBA Fantasy League Season Scheduler - [Admin] - [View Schedule]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewSchedule_FormClosing);
            this.Load += new System.EventHandler(this.frmViewSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}