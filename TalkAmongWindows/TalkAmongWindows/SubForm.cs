using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkAmongWindows
{
    //[2] step 1: declare delegate method
    public delegate void delegateBroadcastMsg(string msg);
    public partial class subForm : Form
    {
        // step3: create delegate viariable, so that it can be called in current subform window
        public delegatePassMsg passMsg;

        public subForm()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // step 5: use the delegate method
            passMsg(this.txtMessageSent.Text, this.Text);
        }
        //[2] step2: method to receive broadcast message
        public void Receiver(string msg)
        {
            this.txtMsgBroadcasted.Text = msg;
        }

       
    }
}
