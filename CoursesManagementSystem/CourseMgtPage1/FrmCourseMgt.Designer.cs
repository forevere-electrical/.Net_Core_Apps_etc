
namespace CourseMgtPage1
{
    partial class FrmCourseMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseMgt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblCourseMgt = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnChangeCourse = new System.Windows.Forms.Button();
            this.btnDelCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBar = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCourseList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbCourseInfo = new System.Windows.Forms.GroupBox();
            this.lblCourseNo = new System.Windows.Forms.Label();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseName_Modify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaevToDB = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbCategory_Modify = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpbCourseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(13, 19);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(45, 17);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "Page:";
            // 
            // lblCourseMgt
            // 
            this.lblCourseMgt.AutoSize = true;
            this.lblCourseMgt.Location = new System.Drawing.Point(55, 19);
            this.lblCourseMgt.Name = "lblCourseMgt";
            this.lblCourseMgt.Size = new System.Drawing.Size(139, 17);
            this.lblCourseMgt.TabIndex = 1;
            this.lblCourseMgt.Text = "Course Management";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCourse.Location = new System.Drawing.Point(260, 2);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddCourse.Size = new System.Drawing.Size(100, 50);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // btnChangeCourse
            // 
            this.btnChangeCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeCourse.Image")));
            this.btnChangeCourse.Location = new System.Drawing.Point(366, 2);
            this.btnChangeCourse.Name = "btnChangeCourse";
            this.btnChangeCourse.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChangeCourse.Size = new System.Drawing.Size(100, 50);
            this.btnChangeCourse.TabIndex = 1;
            this.btnChangeCourse.Text = "Change Course";
            this.btnChangeCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeCourse.UseVisualStyleBackColor = false;
            // 
            // btnDelCourse
            // 
            this.btnDelCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDelCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnDelCourse.Image")));
            this.btnDelCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelCourse.Location = new System.Drawing.Point(472, 2);
            this.btnDelCourse.Name = "btnDelCourse";
            this.btnDelCourse.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDelCourse.Size = new System.Drawing.Size(100, 50);
            this.btnDelCourse.TabIndex = 2;
            this.btnDelCourse.Text = "Del Course";
            this.btnDelCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelCourse.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(578, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBar
            // 
            this.lblBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBar.Location = new System.Drawing.Point(0, 53);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(690, 1);
            this.lblBar.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 65);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(118, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Course Category:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbbCategory.Location = new System.Drawing.Point(126, 62);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbbCategory.TabIndex = 5;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(263, 65);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(98, 17);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(356, 65);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 22);
            this.txtCourseName.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(462, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Results:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(518, 65);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 17);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(578, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvCourseList
            // 
            this.dgvCourseList.AllowUserToAddRows = false;
            this.dgvCourseList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCourseList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourseList.ColumnHeadersHeight = 30;
            this.dgvCourseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCourseList.EnableHeadersVisualStyles = false;
            this.dgvCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.dgvCourseList.Location = new System.Drawing.Point(15, 92);
            this.dgvCourseList.Name = "dgvCourseList";
            this.dgvCourseList.ReadOnly = true;
            this.dgvCourseList.RowHeadersWidth = 51;
            this.dgvCourseList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCourseList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCourseList.RowTemplate.Height = 24;
            this.dgvCourseList.Size = new System.Drawing.Size(663, 366);
            this.dgvCourseList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gpbCourseInfo);
            this.panel1.Controls.Add(this.lblCourseId);
            this.panel1.Controls.Add(this.lblCourseNo);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaevToDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 178);
            this.panel1.TabIndex = 8;
            // 
            // gpbCourseInfo
            // 
            this.gpbCourseInfo.Controls.Add(this.label5);
            this.gpbCourseInfo.Controls.Add(this.txtDescription);
            this.gpbCourseInfo.Controls.Add(this.label4);
            this.gpbCourseInfo.Controls.Add(this.cbbCategory_Modify);
            this.gpbCourseInfo.Controls.Add(this.txtCredit);
            this.gpbCourseInfo.Controls.Add(this.label3);
            this.gpbCourseInfo.Controls.Add(this.txtCourseHours);
            this.gpbCourseInfo.Controls.Add(this.label2);
            this.gpbCourseInfo.Controls.Add(this.txtCourseName_Modify);
            this.gpbCourseInfo.Controls.Add(this.label1);
            this.gpbCourseInfo.Location = new System.Drawing.Point(16, 55);
            this.gpbCourseInfo.Name = "gpbCourseInfo";
            this.gpbCourseInfo.Size = new System.Drawing.Size(662, 100);
            this.gpbCourseInfo.TabIndex = 0;
            this.gpbCourseInfo.TabStop = false;
            this.gpbCourseInfo.Text = "[Course Info]";
            // 
            // lblCourseNo
            // 
            this.lblCourseNo.AutoSize = true;
            this.lblCourseNo.Location = new System.Drawing.Point(13, 23);
            this.lblCourseNo.Name = "lblCourseNo";
            this.lblCourseNo.Size = new System.Drawing.Size(111, 17);
            this.lblCourseNo.TabIndex = 1;
            this.lblCourseNo.Text = "Course Number:";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(129, 23);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(40, 17);
            this.lblCourseId.TabIndex = 1;
            this.lblCourseId.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name:";
            // 
            // txtCourseName_Modify
            // 
            this.txtCourseName_Modify.Location = new System.Drawing.Point(110, 30);
            this.txtCourseName_Modify.Name = "txtCourseName_Modify";
            this.txtCourseName_Modify.Size = new System.Drawing.Size(100, 22);
            this.txtCourseName_Modify.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Hours:";
            // 
            // txtCourseHours
            // 
            this.txtCourseHours.Location = new System.Drawing.Point(328, 27);
            this.txtCourseHours.Name = "txtCourseHours";
            this.txtCourseHours.Size = new System.Drawing.Size(100, 22);
            this.txtCourseHours.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course Credit:";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(546, 27);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 22);
            this.txtCredit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Course Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 22);
            this.txtDescription.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course Category:";
            // 
            // btnSaevToDB
            // 
            this.btnSaevToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaevToDB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaevToDB.Image = ((System.Drawing.Image)(resources.GetObject("btnSaevToDB.Image")));
            this.btnSaevToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaevToDB.Location = new System.Drawing.Point(461, 6);
            this.btnSaevToDB.Name = "btnSaevToDB";
            this.btnSaevToDB.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSaevToDB.Size = new System.Drawing.Size(100, 50);
            this.btnSaevToDB.TabIndex = 2;
            this.btnSaevToDB.Text = "Submit Change";
            this.btnSaevToDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaevToDB.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(578, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel Change";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cbbCategory_Modify
            // 
            this.cbbCategory_Modify.FormattingEnabled = true;
            this.cbbCategory_Modify.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbbCategory_Modify.Location = new System.Drawing.Point(525, 60);
            this.cbbCategory_Modify.Name = "cbbCategory_Modify";
            this.cbbCategory_Modify.Size = new System.Drawing.Size(121, 24);
            this.cbbCategory_Modify.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Course Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 114;
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
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Teacher";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // FrmCourseMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCourseList);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelCourse);
            this.Controls.Add(this.btnChangeCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCourseMgt);
            this.Controls.Add(this.lblPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCourseMgt";
            this.Text = "Course Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbCourseInfo.ResumeLayout(false);
            this.gpbCourseInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblCourseMgt;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnChangeCourse;
        private System.Windows.Forms.Button btnDelCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCourseList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbCourseInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseName_Modify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaevToDB;
        private System.Windows.Forms.ComboBox cbbCategory_Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}