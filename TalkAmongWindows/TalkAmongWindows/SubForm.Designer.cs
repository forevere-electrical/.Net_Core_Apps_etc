
namespace TalkAmongWindows
{
    partial class subForm
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
            this.lblSubTop = new System.Windows.Forms.Label();
            this.txtMessageSent = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMsgBroadcasted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSubTop
            // 
            this.lblSubTop.AutoSize = true;
            this.lblSubTop.Location = new System.Drawing.Point(13, 9);
            this.lblSubTop.Name = "lblSubTop";
            this.lblSubTop.Size = new System.Drawing.Size(136, 17);
            this.lblSubTop.TabIndex = 0;
            this.lblSubTop.Text = "Message to be sent:";
            // 
            // txtMessageSent
            // 
            this.txtMessageSent.Location = new System.Drawing.Point(16, 45);
            this.txtMessageSent.Multiline = true;
            this.txtMessageSent.Name = "txtMessageSent";
            this.txtMessageSent.Size = new System.Drawing.Size(336, 103);
            this.txtMessageSent.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(107, 168);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(122, 41);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMsgBroadcasted
            // 
            this.txtMsgBroadcasted.Location = new System.Drawing.Point(16, 239);
            this.txtMsgBroadcasted.Multiline = true;
            this.txtMsgBroadcasted.Name = "txtMsgBroadcasted";
            this.txtMsgBroadcasted.Size = new System.Drawing.Size(336, 71);
            this.txtMsgBroadcasted.TabIndex = 3;
            // 
            // subForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 322);
            this.Controls.Add(this.txtMsgBroadcasted);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessageSent);
            this.Controls.Add(this.lblSubTop);
            this.Name = "subForm";
            this.Text = "SubForm: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTop;
        private System.Windows.Forms.TextBox txtMessageSent;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMsgBroadcasted;
    }
}