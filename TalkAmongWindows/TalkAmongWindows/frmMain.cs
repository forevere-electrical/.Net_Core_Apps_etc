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
    public partial class frmMain : Form
    {
        List<subForm> frmList = new List<subForm>();

        // [2] step 3: create delegate variable
        private delegateBroadcastMsg broadcast;
        public frmMain()
        {
            InitializeComponent();
        }


        // step2: create delegate method, acutally it is to change the text inside textbox.
        private void receiveMsg(string msg, string childName)
        {
            this.txtReceivedMessage.Text += $"{msg} received from {childName}\r\n";
        }
        

        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            for(var i=0; i<3; i++)
            {
                subForm frm = new subForm();
                frm.Name += $"{i+1}";
                frm.Text += $"{i + 1}";
                frm.Show();
                frmList.Add(frm);

                // step 4: link delegate viariable with its delegate method
                frm.passMsg = receiveMsg;

                // [2] step 4: link variable with method 
                broadcast += frm.Receiver;
            }
        }

        private void btnCloseSub_Click(object sender, EventArgs e)
        {
            foreach(var item in frmList)
            {
                item.Close();
            }
        }

        private void btnClearTextBox_Click(object sender, EventArgs e)
        {
            this.txtReceivedMessage.Text = "";
        }

        private void btnBroadcastMsg_Click(object sender, EventArgs e)
        {
            // [2] step 5: use delegate method
            broadcast(txtBroadcastMsg.Text);
        }
    }


    // step1: declare delegate method, so that from subform it can be used
    // to change the text in main form window.
    public delegate void delegatePassMsg(string msg, string childName);
}
