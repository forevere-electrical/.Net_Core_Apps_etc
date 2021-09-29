
namespace LotteryPro
{
    partial class LotteryPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotteryPro));
            this.lblTop = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRedBalls = new System.Windows.Forms.Label();
            this.lblRedTips = new System.Windows.Forms.Label();
            this.lblBlueBalls = new System.Windows.Forms.Label();
            this.lblBlueTips = new System.Windows.Forms.Label();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlBlue = new System.Windows.Forms.Panel();
            this.btnRandomRed = new System.Windows.Forms.Button();
            this.btnClearRed = new System.Windows.Forms.Button();
            this.btnRandomBlue = new System.Windows.Forms.Button();
            this.btnBlueClear = new System.Windows.Forms.Button();
            this.lblBar1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAuto1Draw = new System.Windows.Forms.Button();
            this.btnAutoGen = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnConfirmPay = new System.Windows.Forms.Button();
            this.numAutoGen = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numRedBalls = new System.Windows.Forms.NumericUpDown();
            this.numBlueBalls = new System.Windows.Forms.NumericUpDown();
            this.lblRedBallCount = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblBlueBallCount = new System.Windows.Forms.Label();
            this.lblStatus3 = new System.Windows.Forms.Label();
            this.BallType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedBlueBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedBalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueBalls)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.DarkRed;
            this.lblTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(976, 30);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "LotteryPro Technologies Co. Ltd. [www.feeel.ca]     Dual Color Lottery Ball Selec" +
    "tor    by Ken Zhang SKYPE: zhangkun_mr";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(946, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRedBalls
            // 
            this.lblRedBalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedBalls.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRedBalls.Location = new System.Drawing.Point(131, 60);
            this.lblRedBalls.Name = "lblRedBalls";
            this.lblRedBalls.Size = new System.Drawing.Size(154, 34);
            this.lblRedBalls.TabIndex = 2;
            this.lblRedBalls.Text = "RED BALLS";
            // 
            // lblRedTips
            // 
            this.lblRedTips.Location = new System.Drawing.Point(291, 55);
            this.lblRedTips.Name = "lblRedTips";
            this.lblRedTips.Size = new System.Drawing.Size(110, 41);
            this.lblRedTips.TabIndex = 2;
            this.lblRedTips.Text = "Please select at least 6 red balls";
            // 
            // lblBlueBalls
            // 
            this.lblBlueBalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueBalls.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueBalls.Location = new System.Drawing.Point(604, 60);
            this.lblBlueBalls.Name = "lblBlueBalls";
            this.lblBlueBalls.Size = new System.Drawing.Size(167, 34);
            this.lblBlueBalls.TabIndex = 2;
            this.lblBlueBalls.Text = "BLUE BALLS";
            // 
            // lblBlueTips
            // 
            this.lblBlueTips.Location = new System.Drawing.Point(769, 52);
            this.lblBlueTips.Name = "lblBlueTips";
            this.lblBlueTips.Size = new System.Drawing.Size(141, 42);
            this.lblBlueTips.TabIndex = 2;
            this.lblBlueTips.Text = "Please select at least 1 blue balls";
            // 
            // pnlRed
            // 
            this.pnlRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRed.Location = new System.Drawing.Point(22, 97);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(551, 159);
            this.pnlRed.TabIndex = 3;
            // 
            // pnlBlue
            // 
            this.pnlBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlue.Location = new System.Drawing.Point(593, 97);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(317, 159);
            this.pnlBlue.TabIndex = 3;
            // 
            // btnRandomRed
            // 
            this.btnRandomRed.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRandomRed.FlatAppearance.BorderSize = 0;
            this.btnRandomRed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomRed.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRandomRed.Location = new System.Drawing.Point(272, 314);
            this.btnRandomRed.Name = "btnRandomRed";
            this.btnRandomRed.Size = new System.Drawing.Size(75, 23);
            this.btnRandomRed.TabIndex = 2;
            this.btnRandomRed.Text = "Random";
            this.btnRandomRed.UseVisualStyleBackColor = false;
            this.btnRandomRed.Click += new System.EventHandler(this.btnRandomRed_Click);
            // 
            // btnClearRed
            // 
            this.btnClearRed.Location = new System.Drawing.Point(362, 314);
            this.btnClearRed.Name = "btnClearRed";
            this.btnClearRed.Size = new System.Drawing.Size(75, 23);
            this.btnClearRed.TabIndex = 3;
            this.btnClearRed.Text = "Clear";
            this.btnClearRed.UseVisualStyleBackColor = true;
            this.btnClearRed.Click += new System.EventHandler(this.btnClearRed_Click);
            // 
            // btnRandomBlue
            // 
            this.btnRandomBlue.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRandomBlue.FlatAppearance.BorderSize = 0;
            this.btnRandomBlue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnRandomBlue.Location = new System.Drawing.Point(745, 314);
            this.btnRandomBlue.Name = "btnRandomBlue";
            this.btnRandomBlue.Size = new System.Drawing.Size(75, 23);
            this.btnRandomBlue.TabIndex = 2;
            this.btnRandomBlue.Text = "Random";
            this.btnRandomBlue.UseVisualStyleBackColor = false;
            this.btnRandomBlue.Click += new System.EventHandler(this.btnRandomBlue_Click);
            // 
            // btnBlueClear
            // 
            this.btnBlueClear.Location = new System.Drawing.Point(835, 314);
            this.btnBlueClear.Name = "btnBlueClear";
            this.btnBlueClear.Size = new System.Drawing.Size(75, 23);
            this.btnBlueClear.TabIndex = 3;
            this.btnBlueClear.Text = "Clear";
            this.btnBlueClear.UseVisualStyleBackColor = true;
            this.btnBlueClear.Click += new System.EventHandler(this.btnBlueClear_Click);
            // 
            // lblBar1
            // 
            this.lblBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBar1.Location = new System.Drawing.Point(38, 375);
            this.lblBar1.Name = "lblBar1";
            this.lblBar1.Size = new System.Drawing.Size(900, 1);
            this.lblBar1.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(301, 359);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 32);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "You picked ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BallType,
            this.RedBlueBalls,
            this.Price});
            this.dgvList.Location = new System.Drawing.Point(22, 446);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(551, 166);
            this.dgvList.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(272, 408);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAuto1Draw
            // 
            this.btnAuto1Draw.Location = new System.Drawing.Point(609, 446);
            this.btnAuto1Draw.Name = "btnAuto1Draw";
            this.btnAuto1Draw.Size = new System.Drawing.Size(148, 36);
            this.btnAuto1Draw.TabIndex = 8;
            this.btnAuto1Draw.Text = "Auto 1 Draw";
            this.btnAuto1Draw.UseVisualStyleBackColor = true;
            this.btnAuto1Draw.Click += new System.EventHandler(this.btnAuto1Draw_Click);
            // 
            // btnAutoGen
            // 
            this.btnAutoGen.Location = new System.Drawing.Point(682, 488);
            this.btnAutoGen.Name = "btnAutoGen";
            this.btnAutoGen.Size = new System.Drawing.Size(75, 34);
            this.btnAutoGen.TabIndex = 8;
            this.btnAutoGen.Text = "AutoGen";
            this.btnAutoGen.UseVisualStyleBackColor = true;
            this.btnAutoGen.Click += new System.EventHandler(this.btnAutoGen_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(609, 539);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(148, 37);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnConfirmPay
            // 
            this.btnConfirmPay.Location = new System.Drawing.Point(609, 582);
            this.btnConfirmPay.Name = "btnConfirmPay";
            this.btnConfirmPay.Size = new System.Drawing.Size(148, 30);
            this.btnConfirmPay.TabIndex = 8;
            this.btnConfirmPay.Text = "Confirm Payment";
            this.btnConfirmPay.UseVisualStyleBackColor = true;
            // 
            // numAutoGen
            // 
            this.numAutoGen.Location = new System.Drawing.Point(609, 495);
            this.numAutoGen.Name = "numAutoGen";
            this.numAutoGen.Size = new System.Drawing.Size(67, 22);
            this.numAutoGen.TabIndex = 9;
            this.numAutoGen.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // numRedBalls
            // 
            this.numRedBalls.Location = new System.Drawing.Point(176, 315);
            this.numRedBalls.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRedBalls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRedBalls.Name = "numRedBalls";
            this.numRedBalls.Size = new System.Drawing.Size(80, 22);
            this.numRedBalls.TabIndex = 11;
            this.numRedBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRedBalls.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numBlueBalls
            // 
            this.numBlueBalls.Location = new System.Drawing.Point(639, 314);
            this.numBlueBalls.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numBlueBalls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBlueBalls.Name = "numBlueBalls";
            this.numBlueBalls.Size = new System.Drawing.Size(80, 22);
            this.numBlueBalls.TabIndex = 11;
            this.numBlueBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBlueBalls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRedBallCount
            // 
            this.lblRedBallCount.ForeColor = System.Drawing.Color.Red;
            this.lblRedBallCount.Location = new System.Drawing.Point(389, 359);
            this.lblRedBallCount.Name = "lblRedBallCount";
            this.lblRedBallCount.Size = new System.Drawing.Size(48, 32);
            this.lblRedBallCount.TabIndex = 5;
            this.lblRedBallCount.Text = "0";
            this.lblRedBallCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus2
            // 
            this.lblStatus2.Location = new System.Drawing.Point(427, 359);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(100, 32);
            this.lblStatus2.TabIndex = 5;
            this.lblStatus2.Text = "red ball, and ";
            this.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlueBallCount
            // 
            this.lblBlueBallCount.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueBallCount.Location = new System.Drawing.Point(519, 359);
            this.lblBlueBallCount.Name = "lblBlueBallCount";
            this.lblBlueBallCount.Size = new System.Drawing.Size(54, 32);
            this.lblBlueBallCount.TabIndex = 5;
            this.lblBlueBallCount.Text = "0";
            this.lblBlueBallCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus3
            // 
            this.lblStatus3.Location = new System.Drawing.Point(550, 359);
            this.lblStatus3.Name = "lblStatus3";
            this.lblStatus3.Size = new System.Drawing.Size(73, 32);
            this.lblStatus3.TabIndex = 5;
            this.lblStatus3.Text = "ball";
            this.lblStatus3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BallType
            // 
            this.BallType.DataPropertyName = "BallType";
            this.BallType.HeaderText = "BallType";
            this.BallType.MinimumWidth = 6;
            this.BallType.Name = "BallType";
            this.BallType.ReadOnly = true;
            this.BallType.Width = 92;
            // 
            // RedBlueBalls
            // 
            this.RedBlueBalls.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RedBlueBalls.DataPropertyName = "BallsShow";
            this.RedBlueBalls.HeaderText = "Selected Red and Blue Balls";
            this.RedBlueBalls.MinimumWidth = 6;
            this.RedBlueBalls.Name = "RedBlueBalls";
            this.RedBlueBalls.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "PriceShow";
            this.Price.HeaderText = "SubTotal";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 94;
            // 
            // LotteryPro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(976, 624);
            this.Controls.Add(this.numBlueBalls);
            this.Controls.Add(this.numRedBalls);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numAutoGen);
            this.Controls.Add(this.btnConfirmPay);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAutoGen);
            this.Controls.Add(this.btnAuto1Draw);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lblStatus3);
            this.Controls.Add(this.lblBlueBallCount);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblRedBallCount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBar1);
            this.Controls.Add(this.btnBlueClear);
            this.Controls.Add(this.btnRandomBlue);
            this.Controls.Add(this.btnClearRed);
            this.Controls.Add(this.btnRandomRed);
            this.Controls.Add(this.pnlBlue);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.lblBlueTips);
            this.Controls.Add(this.lblRedTips);
            this.Controls.Add(this.lblBlueBalls);
            this.Controls.Add(this.lblRedBalls);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LotteryPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LotteryPro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedBalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueBalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRedBalls;
        private System.Windows.Forms.Label lblRedTips;
        private System.Windows.Forms.Label lblBlueBalls;
        private System.Windows.Forms.Label lblBlueTips;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlBlue;
        private System.Windows.Forms.Button btnRandomRed;
        private System.Windows.Forms.Button btnClearRed;
        private System.Windows.Forms.Button btnRandomBlue;
        private System.Windows.Forms.Button btnBlueClear;
        private System.Windows.Forms.Label lblBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAuto1Draw;
        private System.Windows.Forms.Button btnAutoGen;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnConfirmPay;
        private System.Windows.Forms.NumericUpDown numAutoGen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numRedBalls;
        private System.Windows.Forms.NumericUpDown numBlueBalls;
        private System.Windows.Forms.Label lblRedBallCount;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblBlueBallCount;
        private System.Windows.Forms.Label lblStatus3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BallType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedBlueBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

