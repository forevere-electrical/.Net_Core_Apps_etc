
namespace CourseMgtPage1
{
    partial class FrmAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCourse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.lblAddCourse = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblAdded = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.gpbCourseInfo = new System.Windows.Forms.GroupBox();
            this.lblBar = new System.Windows.Forms.Label();
            this.ckbAutoClear = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtClassHours = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCourseContent = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(567, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaveToDB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.Image")));
            this.btnSaveToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToDB.Location = new System.Drawing.Point(461, 4);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSaveToDB.Size = new System.Drawing.Size(100, 50);
            this.btnSaveToDB.TabIndex = 6;
            this.btnSaveToDB.Text = "Add to DB";
            this.btnSaveToDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            // 
            // lblAddCourse
            // 
            this.lblAddCourse.AutoSize = true;
            this.lblAddCourse.Location = new System.Drawing.Point(44, 21);
            this.lblAddCourse.Name = "lblAddCourse";
            this.lblAddCourse.Size = new System.Drawing.Size(82, 17);
            this.lblAddCourse.TabIndex = 5;
            this.lblAddCourse.Text = "Add Course";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(2, 21);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(45, 17);
            this.lblPage.TabIndex = 4;
            this.lblPage.Text = "Page:";
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Location = new System.Drawing.Point(159, 21);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(109, 17);
            this.lblAdded.TabIndex = 4;
            this.lblAdded.Text = "Courses Added:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(274, 21);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 17);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            // 
            // gpbCourseInfo
            // 
            this.gpbCourseInfo.Controls.Add(this.txtCredit);
            this.gpbCourseInfo.Controls.Add(this.txtClassHours);
            this.gpbCourseInfo.Controls.Add(this.txtCourseContent);
            this.gpbCourseInfo.Controls.Add(this.txtCourseName);
            this.gpbCourseInfo.Controls.Add(this.cbbCategory);
            this.gpbCourseInfo.Controls.Add(this.ckbAutoClear);
            this.gpbCourseInfo.Controls.Add(this.label5);
            this.gpbCourseInfo.Controls.Add(this.label4);
            this.gpbCourseInfo.Controls.Add(this.label3);
            this.gpbCourseInfo.Controls.Add(this.label2);
            this.gpbCourseInfo.Controls.Add(this.label1);
            this.gpbCourseInfo.Location = new System.Drawing.Point(5, 60);
            this.gpbCourseInfo.Name = "gpbCourseInfo";
            this.gpbCourseInfo.Size = new System.Drawing.Size(662, 95);
            this.gpbCourseInfo.TabIndex = 8;
            this.gpbCourseInfo.TabStop = false;
            this.gpbCourseInfo.Text = "[Course Infomation]";
            // 
            // lblBar
            // 
            this.lblBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBar.Location = new System.Drawing.Point(0, 55);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(690, 1);
            this.lblBar.TabIndex = 4;
            // 
            // ckbAutoClear
            // 
            this.ckbAutoClear.AutoSize = true;
            this.ckbAutoClear.Location = new System.Drawing.Point(145, -1);
            this.ckbAutoClear.Name = "ckbAutoClear";
            this.ckbAutoClear.Size = new System.Drawing.Size(209, 21);
            this.ckbAutoClear.TabIndex = 0;
            this.ckbAutoClear.Text = "Auto Clear Text After Adding";
            this.ckbAutoClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course Credit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course Category:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(515, 59);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbbCategory.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(111, 30);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(84, 22);
            this.txtCourseName.TabIndex = 6;
            // 
            // txtClassHours
            // 
            this.txtClassHours.Location = new System.Drawing.Point(306, 30);
            this.txtClassHours.Name = "txtClassHours";
            this.txtClassHours.Size = new System.Drawing.Size(56, 22);
            this.txtClassHours.TabIndex = 6;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(515, 30);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(121, 22);
            this.txtCredit.TabIndex = 6;
          
            // 
            // txtCourseContent
            // 
            this.txtCourseContent.Location = new System.Drawing.Point(145, 59);
            this.txtCourseContent.Name = "txtCourseContent";
            this.txtCourseContent.Size = new System.Drawing.Size(217, 22);
            this.txtCourseContent.TabIndex = 6;
           
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(5, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(662, 250);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Course Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Course Hours";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Course Credit";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Course Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Course Category";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 143;
            // 
            // FrmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(672, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbCourseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.lblAddCourse);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.lblPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCourse";
            this.Text = "FrmAddCourse";
            this.gpbCourseInfo.ResumeLayout(false);
            this.gpbCourseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Label lblAddCourse;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox gpbCourseInfo;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtClassHours;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.CheckBox ckbAutoClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.TextBox txtCourseContent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}