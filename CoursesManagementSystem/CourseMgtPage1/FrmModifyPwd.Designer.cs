
namespace CourseMgtPage1
{
    partial class FrmModifyPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifyPwd));
            this.gpbChangePwd = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.txtConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.gpbChangePwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbChangePwd
            // 
            this.gpbChangePwd.Controls.Add(this.btnClose);
            this.gpbChangePwd.Controls.Add(this.btnSaveToDB);
            this.gpbChangePwd.Controls.Add(this.txtConfirmNewPwd);
            this.gpbChangePwd.Controls.Add(this.lblConfirmNewPwd);
            this.gpbChangePwd.Controls.Add(this.txtNewPwd);
            this.gpbChangePwd.Controls.Add(this.lblNewPwd);
            this.gpbChangePwd.Controls.Add(this.txtOldPwd);
            this.gpbChangePwd.Controls.Add(this.lblOldPwd);
            this.gpbChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbChangePwd.Location = new System.Drawing.Point(170, 135);
            this.gpbChangePwd.Name = "gpbChangePwd";
            this.gpbChangePwd.Size = new System.Drawing.Size(350, 200);
            this.gpbChangePwd.TabIndex = 0;
            this.gpbChangePwd.TabStop = false;
            this.gpbChangePwd.Text = "[User Change Password]";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(183, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.Location = new System.Drawing.Point(64, 149);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(98, 34);
            this.btnSaveToDB.TabIndex = 3;
            this.btnSaveToDB.Text = "Submit";
            this.btnSaveToDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // txtConfirmNewPwd
            // 
            this.txtConfirmNewPwd.Location = new System.Drawing.Point(143, 118);
            this.txtConfirmNewPwd.Name = "txtConfirmNewPwd";
            this.txtConfirmNewPwd.PasswordChar = '-';
            this.txtConfirmNewPwd.Size = new System.Drawing.Size(167, 22);
            this.txtConfirmNewPwd.TabIndex = 2;
            // 
            // lblConfirmNewPwd
            // 
            this.lblConfirmNewPwd.AutoSize = true;
            this.lblConfirmNewPwd.Location = new System.Drawing.Point(12, 121);
            this.lblConfirmNewPwd.Name = "lblConfirmNewPwd";
            this.lblConfirmNewPwd.Size = new System.Drawing.Size(125, 17);
            this.lblConfirmNewPwd.TabIndex = 0;
            this.lblConfirmNewPwd.Text = "Confirm Password:";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(143, 78);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(167, 22);
            this.txtNewPwd.TabIndex = 1;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(33, 81);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(104, 17);
            this.lblNewPwd.TabIndex = 0;
            this.lblNewPwd.Text = "New Password:";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(143, 39);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(167, 22);
            this.txtOldPwd.TabIndex = 0;
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(38, 42);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(99, 17);
            this.lblOldPwd.TabIndex = 0;
            this.lblOldPwd.Text = "Old Password:";
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.gpbChangePwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModifyPwd";
            this.Text = "FrmChangePwd";
            this.gpbChangePwd.ResumeLayout(false);
            this.gpbChangePwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbChangePwd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.TextBox txtConfirmNewPwd;
        private System.Windows.Forms.Label lblConfirmNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label lblOldPwd;
    }
}