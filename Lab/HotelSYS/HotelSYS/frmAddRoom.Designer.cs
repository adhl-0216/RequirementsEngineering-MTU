
namespace HotelSYS
{
    partial class frmAddRoom
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
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.grpRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.cboRoomType);
            this.grpRoom.Controls.Add(this.lblRoomType);
            this.grpRoom.Controls.Add(this.txtRoomNo);
            this.grpRoom.Controls.Add(this.lblRoomNo);
            this.grpRoom.Location = new System.Drawing.Point(59, 44);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Size = new System.Drawing.Size(394, 212);
            this.grpRoom.TabIndex = 0;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Enter Room Details";
            this.grpRoom.Enter += new System.EventHandler(this.grpRoom_Enter);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(28, 38);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(75, 13);
            this.lblRoomNo.TabIndex = 0;
            this.lblRoomNo.Text = "Room Number";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(109, 35);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNo.TabIndex = 1;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(28, 69);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(62, 13);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Room Type";
            // 
            // cboRoomType
            // 
            this.cboRoomType.AllowDrop = true;
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(109, 69);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(121, 21);
            this.cboRoomType.Sorted = true;
            this.cboRoomType.TabIndex = 3;
            // 
            // frmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 319);
            this.Controls.Add(this.grpRoom);
            this.Name = "frmAddRoom";
            this.Text = "Hotel Del Luna - [Add Room]";
            this.Load += new System.EventHandler(this.frmAddRoom_Load);
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ComboBox cboRoomType;
    }
}