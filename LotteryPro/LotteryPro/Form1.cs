using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPro
{
    public partial class LotteryPro : Form
    {
        private int redBallsCount, blueBallsCount = 0;
        public LotteryPro()
        {
            InitializeComponent();
            initRedPanel();
            initBluePanel();
        }

        private void LotteryPro_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Close the window after "X" was clicked on the top right corner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// dynamically place 33 balls inside left panel, 11 balls a row,
        /// totoal 3 rows. 
        /// </summary>
        private void initRedPanel()
        {
            for(int i=1; i <= 33; i++)
            {
                Label lbl = new Label();
                lbl.Cursor = System.Windows.Forms.Cursors.Hand;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl.Image = Image.FromFile("Images/gray.png");//global::LotteryPro.Properties.Resources.gray;
                lbl.Location = new System.Drawing.Point(3+50*(i<12?i-1:(i<23?i%12:i%23)), 10+46*((int)((i-1)/11)));
                lbl.Name = "lblNum" + i;
                lbl.Tag = "0";  // 0 for gray, 1 for Red, 2 for Blue
                lbl.Size = new System.Drawing.Size(45, 45);
                lbl.Text = i < 10 ? "0" + i : i.ToString();
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //add the above generated label to red panel
                this.pnlRed.Controls.Add(lbl);
                // add the click event of this click to group click event. 
                lbl.Click += new EventHandler(lblRed_Click);
            }
            
        }
        /// <summary>
        /// Red ball was clicked, set Ball color to Red, clicked again, 
        /// Color changed back to gray. Selection and deselection.
        /// </summary>
        /// <param name="sender">the object that produced the click event on.</param>
        /// <param name="e"></param>
        public void lblRed_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender; //transfer the object to Label class.
            if (lbl.Tag.ToString() == "0")
            {
                lbl.Image = Image.FromFile("images/red.png");
                lbl.ForeColor = Color.White;
                lbl.Tag = "1";
                this.redBallsCount += 1;
            }
            else
            {
                lbl.Image = Image.FromFile("images/gray.png");
                lbl.ForeColor = Color.Black;
                lbl.Tag = "0";
                this.redBallsCount -= 1;
            }
            this.lblStatus.Text = $"You picked {this.redBallsCount} Red Balls, {this.blueBallsCount} Blue Balls, Total {this.redBallsCount + this.blueBallsCount} Balls";
        }
        public void lblBlue_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender; //transfer the object to Label class.
            if (lbl.Tag.ToString() == "0")
            {
                lbl.Image = Image.FromFile("images/Blue.png");
                lbl.ForeColor = Color.White;
                lbl.Tag = "2";
                this.blueBallsCount += 1;

            }
            else
            {
                lbl.Image = Image.FromFile("images/gray.png");
                lbl.ForeColor = Color.Black;
                lbl.Tag = "0";
                this.blueBallsCount -= 1;
            }
            this.lblStatus.Text = $"You picked {this.redBallsCount} Red Balls, {this.blueBallsCount} Blue Balls, Total {this.redBallsCount + this.blueBallsCount} Balls";
        }
        /// <summary>
        /// dynamically place 33 balls inside left panel, 11 balls a row,
        /// totoal 3 rows. 
        /// </summary>
        private void initBluePanel()
        {
            for (int i = 1; i <= 18; i++)
            {
                Label lbl = new Label();
                lbl.Cursor = System.Windows.Forms.Cursors.Hand;
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl.Image = Image.FromFile("Images/gray.png");//global::LotteryPro.Properties.Resources.gray;
                lbl.Location = new System.Drawing.Point(3 + 50 * (i < 7 ? i - 1 : (i < 13 ? i % 7 : i % 13)), 10 + 46 * ((int)((i - 1) / 6)));
                lbl.Name = "lblBlueNum" + i;
                lbl.Tag = "0";  // 0 for gray, 1 for Red, 2 for Blue
                lbl.Size = new System.Drawing.Size(45, 45);
                lbl.Text = i < 10 ? "0" + i : i.ToString();
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //add the above generated label to red panel
                this.pnlBlue.Controls.Add(lbl);
                // add the click event of this click to group click event. 
                lbl.Click += new EventHandler(lblBlue_Click);
            }

        }
    }
}
