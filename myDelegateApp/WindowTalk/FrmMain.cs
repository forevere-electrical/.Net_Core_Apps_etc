using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTalk
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // to save child windows
        private List<Form> frmList = new List<Form>();


        /// <summary>
        /// Declare delegate method
        /// </summary>
        /// <param name="msg">Message to be passed to child window</param>
        /// <param name="childName">Name of child window</param>
        public delegate void PassMsgDelegate(string msg, string childName);


        private void ReceiveMsg(string msg, string childName)
        {
            this.txtMsgRv.Text += $"Message from: {childName}: {msg}\r\n";
        }

        #region Program the button click methods for main window

        // create multiple child windows
        private void btnCreateChild_Click(object sender, EventArgs e)
        {
            //create only one child window for now
            FrmChild child = new FrmChild();
            child.Show();

            //add current child window into the formlist.
            frmList.Add(child);
        }

        //Clear messages already received
        private void btnClearMsg_Click(object sender, EventArgs e)
        {
            this.txtMsgRv.Clear();
        }

        // close all child window(s)  
        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            foreach(var item in frmList)
            {
                item.Close();
            }
        }

        #endregion

        #region button events link and remove link
        private void btnRemoveEv_Click(object sender, EventArgs e)
        {
            foreach(FrmChild item in frmList)
            {
                item.passMsgEvent -= this.ReceiveMsg;
            }
        }

        private void btnLinkEv_Click(object sender, EventArgs e)
        {
            foreach(FrmChild item in frmList)
            {
                item.passMsgEvent += this.ReceiveMsg;
            }
        }


        #endregion
    }
}
