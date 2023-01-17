
namespace HotelSYS
{
    partial class frmConnect
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(105, 48);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(218, 43);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN CONNECTION";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(105, 196);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(218, 43);
            this.btnCLOSE.TabIndex = 1;
            this.btnCLOSE.Text = "CLOSE CONNECTION";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(156, 137);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(117, 13);
            this.lblConnStatus.TabIndex = 3;
            this.lblConnStatus.Text = "Connection is CLOSED";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 287);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnOpen);
            this.Name = "frmConnect";
            this.Text = "Database Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Label lblConnStatus;
    }
}