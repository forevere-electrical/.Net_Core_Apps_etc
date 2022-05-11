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
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }

        // declare a delegate method variable
        public event FrmMain.PassMsgDelegate passMsgEvent;

        /// <summary>
        /// Send message to Main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            //check if delegate variable is linked to relative method
            if (passMsgEvent == null)
            {
                MessageBox.Show("Please link delegate method first!", "Friendly alert");
                return;
            }

            //activate delegate event
            passMsgEvent(this.txtSend.Text, this.Text);
        }
    }
}
