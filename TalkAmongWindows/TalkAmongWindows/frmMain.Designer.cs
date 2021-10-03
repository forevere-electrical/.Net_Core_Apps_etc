
namespace TalkAmongWindows
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
            this.lblTop = new System.Windows.Forms.Label();
            this.txtReceivedMessage = new System.Windows.Forms.TextBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreateSub = new System.Windows.Forms.Button();
            this.btnClearTextBox = new System.Windows.Forms.Button();
            this.btnCloseSub = new System.Windows.Forms.Button();
            this.txtBroadcastMsg = new System.Windows.Forms.TextBox();
            this.btnBroadcastMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(30, 26);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(132, 17);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Message Received:";
            // 
            // txtReceivedMessage
            // 
            this.txtReceivedMessage.Location = new System.Drawing.Point(33, 74);
            this.txtReceivedMessage.Multiline = true;
            this.txtReceivedMessage.Name = "txtReceivedMessage";
            this.txtReceivedMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedMessage.Size = new System.Drawing.Size(301, 134);
            this.txtReceivedMessage.TabIndex = 1;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(33, 238);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(129, 38);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "Link Event";
            this.btnLink.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(212, 238);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(122, 38);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Event";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCreateSub
            // 
            this.btnCreateSub.Location = new System.Drawing.Point(360, 52);
            this.btnCreateSub.Name = "btnCreateSub";
            this.btnCreateSub.Size = new System.Drawing.Size(120, 45);
            this.btnCreateSub.TabIndex = 2;
            this.btnCreateSub.Text = "Create SubForm";
            this.btnCreateSub.UseVisualStyleBackColor = true;
            this.btnCreateSub.Click += new System.EventHandler(this.btnCreateSub_Click);
            // 
            // btnClearTextBox
            // 
            this.btnClearTextBox.Location = new System.Drawing.Point(360, 116);
            this.btnClearTextBox.Name = "btnClearTextBox";
            this.btnClearTextBox.Size = new System.Drawing.Size(120, 49);
            this.btnClearTextBox.TabIndex = 2;
            this.btnClearTextBox.Text = "Clear Box";
            this.btnClearTextBox.UseVisualStyleBackColor = true;
            this.btnClearTextBox.Click += new System.EventHandler(this.btnClearTextBox_Click);
            // 
            // btnCloseSub
            // 
            this.btnCloseSub.Location = new System.Drawing.Point(360, 181);
            this.btnCloseSub.Name = "btnCloseSub";
            this.btnCloseSub.Size = new System.Drawing.Size(120, 47);
            this.btnCloseSub.TabIndex = 2;
            this.btnCloseSub.Text = "Close SubForm";
            this.btnCloseSub.UseVisualStyleBackColor = true;
            this.btnCloseSub.Click += new System.EventHandler(this.btnCloseSub_Click);
            // 
            // txtBroadcastMsg
            // 
            this.txtBroadcastMsg.Location = new System.Drawing.Point(33, 308);
            this.txtBroadcastMsg.Multiline = true;
            this.txtBroadcastMsg.Name = "txtBroadcastMsg";
            this.txtBroadcastMsg.Size = new System.Drawing.Size(301, 65);
            this.txtBroadcastMsg.TabIndex = 3;
            // 
            // btnBroadcastMsg
            // 
            this.btnBroadcastMsg.Location = new System.Drawing.Point(360, 325);
            this.btnBroadcastMsg.Name = "btnBroadcastMsg";
            this.btnBroadcastMsg.Size = new System.Drawing.Size(120, 48);
            this.btnBroadcastMsg.TabIndex = 4;
            this.btnBroadcastMsg.Text = "Broadcast Message";
            this.btnBroadcastMsg.UseVisualStyleBackColor = true;
            this.btnBroadcastMsg.Click += new System.EventHandler(this.btnBroadcastMsg_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.btnBroadcastMsg);
            this.Controls.Add(this.txtBroadcastMsg);
            this.Controls.Add(this.btnCloseSub);
            this.Controls.Add(this.btnClearTextBox);
            this.Controls.Add(this.btnCreateSub);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.txtReceivedMessage);
            this.Controls.Add(this.lblTop);
            this.Name = "frmMain";
            this.Text = "Multi-window Communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox txtReceivedMessage;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreateSub;
        private System.Windows.Forms.Button btnClearTextBox;
        private System.Windows.Forms.Button btnCloseSub;
        private System.Windows.Forms.TextBox txtBroadcastMsg;
        private System.Windows.Forms.Button btnBroadcastMsg;
    }
}

