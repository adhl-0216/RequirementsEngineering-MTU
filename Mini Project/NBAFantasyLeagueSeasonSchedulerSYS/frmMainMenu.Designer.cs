
namespace NBAFantasyLeagueSeasonSchedulerSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.manageTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescheduleGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logGameResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTeamProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamStandingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTeamsToolStripMenuItem,
            this.manageGamesToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuMainMenu.Size = new System.Drawing.Size(934, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "mnuMainMenu";
            // 
            // manageTeamsToolStripMenuItem
            // 
            this.manageTeamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.updateTeamToolStripMenuItem,
            this.removeTeamToolStripMenuItem});
            this.manageTeamsToolStripMenuItem.Name = "manageTeamsToolStripMenuItem";
            this.manageTeamsToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.manageTeamsToolStripMenuItem.Text = "Manage Teams";
            this.manageTeamsToolStripMenuItem.Click += new System.EventHandler(this.manageTeamsToolStripMenuItem_Click);
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // updateTeamToolStripMenuItem
            // 
            this.updateTeamToolStripMenuItem.Name = "updateTeamToolStripMenuItem";
            this.updateTeamToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updateTeamToolStripMenuItem.Text = "Update Team";
            this.updateTeamToolStripMenuItem.Click += new System.EventHandler(this.updateTeamToolStripMenuItem_Click);
            // 
            // removeTeamToolStripMenuItem
            // 
            this.removeTeamToolStripMenuItem.Name = "removeTeamToolStripMenuItem";
            this.removeTeamToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.removeTeamToolStripMenuItem.Text = "Remove Team";
            this.removeTeamToolStripMenuItem.Click += new System.EventHandler(this.removeTeamToolStripMenuItem_Click);
            // 
            // manageGamesToolStripMenuItem
            // 
            this.manageGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleGamesToolStripMenuItem,
            this.rescheduleGamesToolStripMenuItem,
            this.cancelGameToolStripMenuItem,
            this.logGameResultsToolStripMenuItem});
            this.manageGamesToolStripMenuItem.Name = "manageGamesToolStripMenuItem";
            this.manageGamesToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.manageGamesToolStripMenuItem.Text = "Manage Games";
            this.manageGamesToolStripMenuItem.Click += new System.EventHandler(this.manageGamesToolStripMenuItem_Click);
            // 
            // scheduleGamesToolStripMenuItem
            // 
            this.scheduleGamesToolStripMenuItem.Name = "scheduleGamesToolStripMenuItem";
            this.scheduleGamesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.scheduleGamesToolStripMenuItem.Text = "Schedule Games";
            this.scheduleGamesToolStripMenuItem.Click += new System.EventHandler(this.scheduleGamesToolStripMenuItem_Click);
            // 
            // rescheduleGamesToolStripMenuItem
            // 
            this.rescheduleGamesToolStripMenuItem.Name = "rescheduleGamesToolStripMenuItem";
            this.rescheduleGamesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.rescheduleGamesToolStripMenuItem.Text = "Reschedule Game";
            this.rescheduleGamesToolStripMenuItem.Click += new System.EventHandler(this.rescheduleGamesToolStripMenuItem_Click);
            // 
            // cancelGameToolStripMenuItem
            // 
            this.cancelGameToolStripMenuItem.Name = "cancelGameToolStripMenuItem";
            this.cancelGameToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cancelGameToolStripMenuItem.Text = "Cancel Games";
            this.cancelGameToolStripMenuItem.Click += new System.EventHandler(this.cancelGameToolStripMenuItem_Click);
            // 
            // logGameResultsToolStripMenuItem
            // 
            this.logGameResultsToolStripMenuItem.Name = "logGameResultsToolStripMenuItem";
            this.logGameResultsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logGameResultsToolStripMenuItem.Text = "Log Game Results";
            this.logGameResultsToolStripMenuItem.Click += new System.EventHandler(this.logGameResultsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScheduleToolStripMenuItem,
            this.generateTeamProfilesToolStripMenuItem,
            this.teamStandingsToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // generateTeamProfilesToolStripMenuItem
            // 
            this.generateTeamProfilesToolStripMenuItem.Name = "generateTeamProfilesToolStripMenuItem";
            this.generateTeamProfilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateTeamProfilesToolStripMenuItem.Text = "Team Profiles";
            this.generateTeamProfilesToolStripMenuItem.Click += new System.EventHandler(this.generateTeamProfilesToolStripMenuItem_Click);
            // 
            // teamStandingsToolStripMenuItem
            // 
            this.teamStandingsToolStripMenuItem.Name = "teamStandingsToolStripMenuItem";
            this.teamStandingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teamStandingsToolStripMenuItem.Text = "Team Standings";
            this.teamStandingsToolStripMenuItem.Click += new System.EventHandler(this.teamStandingsToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 526);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Main Menu]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem manageTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescheduleGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logGameResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTeamProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamStandingsToolStripMenuItem;
    }
}

