
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
            this.lblTop = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRedBalls = new System.Windows.Forms.Label();
            this.lblRedTips = new System.Windows.Forms.Label();
            this.lblBlueBalls = new System.Windows.Forms.Label();
            this.lblBlueTips = new System.Windows.Forms.Label();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlBlue = new System.Windows.Forms.Panel();
            this.cbbRed = new System.Windows.Forms.ComboBox();
            this.btnRandomRed = new System.Windows.Forms.Button();
            this.btnClearRed = new System.Windows.Forms.Button();
            this.cbbBlue = new System.Windows.Forms.ComboBox();
            this.btnRandomBlue = new System.Windows.Forms.Button();
            this.btnBlueClear = new System.Windows.Forms.Button();
            this.lblBar1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
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
            // cbbRed
            // 
            this.cbbRed.DisplayMember = "6";
            this.cbbRed.FormattingEnabled = true;
            this.cbbRed.Location = new System.Drawing.Point(136, 314);
            this.cbbRed.Name = "cbbRed";
            this.cbbRed.Size = new System.Drawing.Size(121, 24);
            this.cbbRed.TabIndex = 1;
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
            // 
            // btnClearRed
            // 
            this.btnClearRed.Location = new System.Drawing.Point(362, 314);
            this.btnClearRed.Name = "btnClearRed";
            this.btnClearRed.Size = new System.Drawing.Size(75, 23);
            this.btnClearRed.TabIndex = 3;
            this.btnClearRed.Text = "Clear";
            this.btnClearRed.UseVisualStyleBackColor = true;
            // 
            // cbbBlue
            // 
            this.cbbBlue.DisplayMember = "6";
            this.cbbBlue.FormattingEnabled = true;
            this.cbbBlue.Location = new System.Drawing.Point(609, 314);
            this.cbbBlue.Name = "cbbBlue";
            this.cbbBlue.Size = new System.Drawing.Size(121, 24);
            this.cbbBlue.TabIndex = 1;
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
            // 
            // btnBlueClear
            // 
            this.btnBlueClear.Location = new System.Drawing.Point(835, 314);
            this.btnBlueClear.Name = "btnBlueClear";
            this.btnBlueClear.Size = new System.Drawing.Size(75, 23);
            this.btnBlueClear.TabIndex = 3;
            this.btnBlueClear.Text = "Clear";
            this.btnBlueClear.UseVisualStyleBackColor = true;
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
            this.lblStatus.Size = new System.Drawing.Size(342, 32);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LotteryPro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(976, 624);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBar1);
            this.Controls.Add(this.btnBlueClear);
            this.Controls.Add(this.btnRandomBlue);
            this.Controls.Add(this.btnClearRed);
            this.Controls.Add(this.cbbBlue);
            this.Controls.Add(this.btnRandomRed);
            this.Controls.Add(this.cbbRed);
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
            this.Load += new System.EventHandler(this.LotteryPro_Load);
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
        private System.Windows.Forms.ComboBox cbbRed;
        private System.Windows.Forms.Button btnRandomRed;
        private System.Windows.Forms.Button btnClearRed;
        private System.Windows.Forms.ComboBox cbbBlue;
        private System.Windows.Forms.Button btnRandomBlue;
        private System.Windows.Forms.Button btnBlueClear;
        private System.Windows.Forms.Label lblBar1;
        private System.Windows.Forms.Label lblStatus;
    }
}

