
namespace WindowTalk
{
    partial class FrmMain
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
            this.btnCreateChild = new System.Windows.Forms.Button();
            this.btnClearMsg = new System.Windows.Forms.Button();
            this.lblMsgRv = new System.Windows.Forms.Label();
            this.txtMsgRv = new System.Windows.Forms.TextBox();
            this.btnCloseChild = new System.Windows.Forms.Button();
            this.btnLinkEv = new System.Windows.Forms.Button();
            this.btnRemoveEv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateChild
            // 
            this.btnCreateChild.Location = new System.Drawing.Point(279, 27);
            this.btnCreateChild.Name = "btnCreateChild";
            this.btnCreateChild.Size = new System.Drawing.Size(75, 39);
            this.btnCreateChild.TabIndex = 0;
            this.btnCreateChild.Text = "Create Child Windows";
            this.btnCreateChild.UseVisualStyleBackColor = true;
            this.btnCreateChild.Click += new System.EventHandler(this.btnCreateChild_Click);
            // 
            // btnClearMsg
            // 
            this.btnClearMsg.Location = new System.Drawing.Point(279, 84);
            this.btnClearMsg.Name = "btnClearMsg";
            this.btnClearMsg.Size = new System.Drawing.Size(75, 39);
            this.btnClearMsg.TabIndex = 1;
            this.btnClearMsg.Text = "Clear Message";
            this.btnClearMsg.UseVisualStyleBackColor = true;
            this.btnClearMsg.Click += new System.EventHandler(this.btnClearMsg_Click);
            // 
            // lblMsgRv
            // 
            this.lblMsgRv.AutoSize = true;
            this.lblMsgRv.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsgRv.Location = new System.Drawing.Point(30, 27);
            this.lblMsgRv.Name = "lblMsgRv";
            this.lblMsgRv.Size = new System.Drawing.Size(124, 19);
            this.lblMsgRv.TabIndex = 2;
            this.lblMsgRv.Text = "Message Received:";
            // 
            // txtMsgRv
            // 
            this.txtMsgRv.Location = new System.Drawing.Point(34, 54);
            this.txtMsgRv.Multiline = true;
            this.txtMsgRv.Name = "txtMsgRv";
            this.txtMsgRv.Size = new System.Drawing.Size(219, 128);
            this.txtMsgRv.TabIndex = 3;
            // 
            // btnCloseChild
            // 
            this.btnCloseChild.Location = new System.Drawing.Point(279, 141);
            this.btnCloseChild.Name = "btnCloseChild";
            this.btnCloseChild.Size = new System.Drawing.Size(75, 40);
            this.btnCloseChild.TabIndex = 1;
            this.btnCloseChild.Text = "Close Child Windows";
            this.btnCloseChild.UseVisualStyleBackColor = true;
            this.btnCloseChild.Click += new System.EventHandler(this.btnCloseChild_Click);
            // 
            // btnLinkEv
            // 
            this.btnLinkEv.Location = new System.Drawing.Point(34, 208);
            this.btnLinkEv.Name = "btnLinkEv";
            this.btnLinkEv.Size = new System.Drawing.Size(118, 32);
            this.btnLinkEv.TabIndex = 1;
            this.btnLinkEv.Text = "Link Event";
            this.btnLinkEv.UseVisualStyleBackColor = true;
            this.btnLinkEv.Click += new System.EventHandler(this.btnLinkEv_Click);
            // 
            // btnRemoveEv
            // 
            this.btnRemoveEv.Location = new System.Drawing.Point(169, 208);
            this.btnRemoveEv.Name = "btnRemoveEv";
            this.btnRemoveEv.Size = new System.Drawing.Size(131, 32);
            this.btnRemoveEv.TabIndex = 1;
            this.btnRemoveEv.Text = "Remove Event";
            this.btnRemoveEv.UseVisualStyleBackColor = true;
            this.btnRemoveEv.Click += new System.EventHandler(this.btnRemoveEv_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtMsgRv);
            this.Controls.Add(this.lblMsgRv);
            this.Controls.Add(this.btnRemoveEv);
            this.Controls.Add(this.btnLinkEv);
            this.Controls.Add(this.btnCloseChild);
            this.Controls.Add(this.btnClearMsg);
            this.Controls.Add(this.btnCreateChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateChild;
        private System.Windows.Forms.Button btnClearMsg;
        private System.Windows.Forms.Label lblMsgRv;
        private System.Windows.Forms.TextBox txtMsgRv;
        private System.Windows.Forms.Button btnCloseChild;
        private System.Windows.Forms.Button btnLinkEv;
        private System.Windows.Forms.Button btnRemoveEv;
    }
}

