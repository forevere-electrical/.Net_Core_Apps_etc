
namespace CourseMgtPage1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoginClient = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnTeacherManagement = new System.Windows.Forms.Button();
            this.btnCourseManagement = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.mclCalendar = new System.Windows.Forms.MonthCalendar();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(63)))), ((int)(((byte)(133)))));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblLoginClient);
            this.pnlTop.Controls.Add(this.lblWebsite);
            this.pnlTop.Controls.Add(this.lblSystem);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 66);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(63)))), ((int)(((byte)(133)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(211)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(895, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "⨉";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoginClient
            // 
            this.lblLoginClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoginClient.Image = ((System.Drawing.Image)(resources.GetObject("lblLoginClient.Image")));
            this.lblLoginClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLoginClient.Location = new System.Drawing.Point(770, 31);
            this.lblLoginClient.Name = "lblLoginClient";
            this.lblLoginClient.Size = new System.Drawing.Size(100, 23);
            this.lblLoginClient.TabIndex = 2;
            this.lblLoginClient.Text = "User";
           
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWebsite.Location = new System.Drawing.Point(537, 32);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(105, 17);
            this.lblWebsite.TabIndex = 1;
            this.lblWebsite.Text = "web: js.feeel.ca";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSystem.Location = new System.Drawing.Point(23, 18);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(487, 32);
            this.lblSystem.TabIndex = 0;
            this.lblSystem.Text = "ABC COURSE MANAGEMENT SYSTEM";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.pnlLeft.Controls.Add(this.btnChangePwd);
            this.pnlLeft.Controls.Add(this.btnTeacherManagement);
            this.pnlLeft.Controls.Add(this.btnCourseManagement);
            this.pnlLeft.Controls.Add(this.btnAddCourse);
            this.pnlLeft.Controls.Add(this.mclCalendar);
            this.pnlLeft.Location = new System.Drawing.Point(8, 72);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(208, 469);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePwd.FlatAppearance.BorderSize = 0;
            this.btnChangePwd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangePwd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnChangePwd.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePwd.Image")));
            this.btnChangePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePwd.Location = new System.Drawing.Point(8, 394);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(192, 32);
            this.btnChangePwd.TabIndex = 4;
            this.btnChangePwd.Text = "Change Password";
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = false;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnTeacherManagement
            // 
            this.btnTeacherManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTeacherManagement.FlatAppearance.BorderSize = 0;
            this.btnTeacherManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTeacherManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTeacherManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManagement.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTeacherManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacherManagement.Image")));
            this.btnTeacherManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManagement.Location = new System.Drawing.Point(9, 310);
            this.btnTeacherManagement.Name = "btnTeacherManagement";
            this.btnTeacherManagement.Size = new System.Drawing.Size(191, 32);
            this.btnTeacherManagement.TabIndex = 3;
            this.btnTeacherManagement.Text = "Teacher Management";
            this.btnTeacherManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacherManagement.UseVisualStyleBackColor = false;
            // 
            // btnCourseManagement
            // 
            this.btnCourseManagement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCourseManagement.FlatAppearance.BorderSize = 0;
            this.btnCourseManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCourseManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCourseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourseManagement.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCourseManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseManagement.Image")));
            this.btnCourseManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourseManagement.Location = new System.Drawing.Point(9, 272);
            this.btnCourseManagement.Name = "btnCourseManagement";
            this.btnCourseManagement.Size = new System.Drawing.Size(191, 32);
            this.btnCourseManagement.TabIndex = 2;
            this.btnCourseManagement.Text = "Course Management ";
            this.btnCourseManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourseManagement.UseVisualStyleBackColor = false;
            this.btnCourseManagement.Click += new System.EventHandler(this.btnCourseManagement_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(9, 234);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(191, 32);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Adding Course Info";
            this.btnAddCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // mclCalendar
            // 
            this.mclCalendar.Location = new System.Drawing.Point(-43, 0);
            this.mclCalendar.Name = "mclCalendar";
            this.mclCalendar.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.pnlRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRight.BackgroundImage")));
            this.pnlRight.Location = new System.Drawing.Point(224, 72);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(690, 470);
            this.pnlRight.TabIndex = 4;
            this.pnlRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.pnlRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.pnlRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(184)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "MainWindow";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Button btnTeacherManagement;
        private System.Windows.Forms.Button btnCourseManagement;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.MonthCalendar mclCalendar;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblLoginClient;
        private System.Windows.Forms.Button btnClose;
    }
}