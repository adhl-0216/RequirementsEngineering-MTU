﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTeamsToolStripMenuItem,
            this.manageGamesToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1401, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMainMenu";
            // 
            // manageTeamsToolStripMenuItem
            // 
            this.manageTeamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.updateTeamToolStripMenuItem,
            this.removeTeamToolStripMenuItem});
            this.manageTeamsToolStripMenuItem.Name = "manageTeamsToolStripMenuItem";
            this.manageTeamsToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.manageTeamsToolStripMenuItem.Text = "Manage Teams";
            this.manageTeamsToolStripMenuItem.Click += new System.EventHandler(this.manageTeamsToolStripMenuItem_Click);
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // updateTeamToolStripMenuItem
            // 
            this.updateTeamToolStripMenuItem.Name = "updateTeamToolStripMenuItem";
            this.updateTeamToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.updateTeamToolStripMenuItem.Text = "Update Team";
            this.updateTeamToolStripMenuItem.Click += new System.EventHandler(this.updateTeamToolStripMenuItem_Click);
            // 
            // removeTeamToolStripMenuItem
            // 
            this.removeTeamToolStripMenuItem.Name = "removeTeamToolStripMenuItem";
            this.removeTeamToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
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
            this.manageGamesToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.manageGamesToolStripMenuItem.Text = "Manage Games";
            this.manageGamesToolStripMenuItem.Click += new System.EventHandler(this.manageGamesToolStripMenuItem_Click);
            // 
            // scheduleGamesToolStripMenuItem
            // 
            this.scheduleGamesToolStripMenuItem.Name = "scheduleGamesToolStripMenuItem";
            this.scheduleGamesToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.scheduleGamesToolStripMenuItem.Text = "Schedule Games";
            // 
            // rescheduleGamesToolStripMenuItem
            // 
            this.rescheduleGamesToolStripMenuItem.Name = "rescheduleGamesToolStripMenuItem";
            this.rescheduleGamesToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.rescheduleGamesToolStripMenuItem.Text = "Reschedule Game";
            // 
            // cancelGameToolStripMenuItem
            // 
            this.cancelGameToolStripMenuItem.Name = "cancelGameToolStripMenuItem";
            this.cancelGameToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.cancelGameToolStripMenuItem.Text = "Cancel Games";
            // 
            // logGameResultsToolStripMenuItem
            // 
            this.logGameResultsToolStripMenuItem.Name = "logGameResultsToolStripMenuItem";
            this.logGameResultsToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.logGameResultsToolStripMenuItem.Text = "Log Game Results";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScheduleToolStripMenuItem,
            this.generateTeamProfilesToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            // 
            // generateTeamProfilesToolStripMenuItem
            // 
            this.generateTeamProfilesToolStripMenuItem.Name = "generateTeamProfilesToolStripMenuItem";
            this.generateTeamProfilesToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.generateTeamProfilesToolStripMenuItem.Text = "Generate Team Profiles";
            this.generateTeamProfilesToolStripMenuItem.Click += new System.EventHandler(this.generateTeamProfilesToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1401, 809);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Fantasy League Season Scheduler - [Main Menu]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

