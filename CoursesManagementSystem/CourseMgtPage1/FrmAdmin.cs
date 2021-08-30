using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMgtPage1
{
    public partial class FrmCover : Form
    {
        public FrmCover()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Window Move by left mouse button draging

        private Point mouseOff; //position of mouse moving
        private bool leftFlag; //a flag if leftbutton clicked
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); // get the value of current position
                leftFlag = true; // when left button clicked, set flag to true
            }
        }

        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y); //set position after moving
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag) leftFlag = false;
        }
        #endregion

    }
}
