
namespace HotelSYS
{
    partial class frmUpdateRoomType
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
            this.lblSelectRoomTypes = new System.Windows.Forms.Label();
            this.cboRoomTypes = new System.Windows.Forms.ComboBox();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.grpRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectRoomTypes
            // 
            this.lblSelectRoomTypes.AutoSize = true;
            this.lblSelectRoomTypes.Location = new System.Drawing.Point(40, 47);
            this.lblSelectRoomTypes.Name = "lblSelectRoomTypes";
            this.lblSelectRoomTypes.Size = new System.Drawing.Size(95, 13);
            this.lblSelectRoomTypes.TabIndex = 0;
            this.lblSelectRoomTypes.Text = "Select Room Type";
            // 
            // cboRoomTypes
            // 
            this.cboRoomTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomTypes.FormattingEnabled = true;
            this.cboRoomTypes.Location = new System.Drawing.Point(141, 44);
            this.cboRoomTypes.Name = "cboRoomTypes";
            this.cboRoomTypes.Size = new System.Drawing.Size(160, 21);
            this.cboRoomTypes.Sorted = true;
            this.cboRoomTypes.TabIndex = 1;
            this.cboRoomTypes.SelectedIndexChanged += new System.EventHandler(this.cboRoomTypes_SelectedIndexChanged);
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.btnSubmit);
            this.grpRoomType.Controls.Add(this.txtDesc);
            this.grpRoomType.Controls.Add(this.lblDesc);
            this.grpRoomType.Controls.Add(this.txtRate);
            this.grpRoomType.Controls.Add(this.lblRate);
            this.grpRoomType.Location = new System.Drawing.Point(43, 83);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(393, 230);
            this.grpRoomType.TabIndex = 2;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Update Room Type Details";
            this.grpRoomType.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(149, 186);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(71, 23);
            this.txtDesc.MaxLength = 20;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(228, 20);
            this.txtDesc.TabIndex = 11;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(6, 26);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(71, 49);
            this.txtRate.MaxLength = 7;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(53, 22);
            this.txtRate.TabIndex = 9;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(6, 52);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 8;
            this.lblRate.Text = "Rate";
            // 
            // frmUpdateRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 407);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.cboRoomTypes);
            this.Controls.Add(this.lblSelectRoomTypes);
            this.Name = "frmUpdateRoomType";
            this.Text = "Hotel Del Luna - [Update Room Type]";
            this.Load += new System.EventHandler(this.frmUpdateRoomType_Load);
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectRoomTypes;
        private System.Windows.Forms.ComboBox cboRoomTypes;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnSubmit;
    }
}