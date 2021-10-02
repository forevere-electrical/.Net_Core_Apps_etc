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
        //private int redBallsCount, blueBallsCount = 0;
        private Dictionary<string, Label> redBallLabels = new Dictionary<string, Label>();
        private Dictionary<string, Label> blueBallLabels = new Dictionary<string, Label>();
        //Create Selector instant:
        public Selector mySelector;
        private List<string> redBalls = new List<string>();
        private List<string> blueBalls = new List<string>();

        public LotteryPro()
        {
            InitializeComponent();
            initRedPanel();
            initBluePanel();
            
            mySelector = new Selector(this.redBalls, this.blueBalls);
            //  mySelector.SelectedBalls= DoubleChromoSphere()
            this.redBalls = this.blueBalls = null;
        }

        #region initiate red and blue panel
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
   
                lbl.Name = "lblRedNum" + i;
                lbl.Tag = "0";  // 0 for gray, 1 for Red, 2 for Blue
                lbl.Size = new System.Drawing.Size(45, 45);
                lbl.Text = i < 10 ? "0" + i : i.ToString();
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //add the above generated label to red panel
                this.pnlRed.Controls.Add(lbl);
                // add the click event of this click to group click event. 
                lbl.Click += new EventHandler(ball_Click);
                redBallLabels.Add(lbl.Text, lbl);
                redBalls.Add(lbl.Text);
            }            
        }
    
        
        /// <summary>
        /// dynamically place 33 balls inside left panel, 11 balls a row,
        /// totoal 3 rows. 
        /// </summary>
        private void initBluePanel()
        {
            for (int i = 1; i <= 16; i++)
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
                lbl.Click += new EventHandler(ball_Click);
                blueBallLabels.Add(lbl.Text, lbl);
                blueBalls.Add(lbl.Text);
            }

        }
        #endregion

        #region select and deselect event handler
        public void ball_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender; //transfer the object to Label class.
            setBallColor(lbl);
            ShowRedCount();
            ShowBlueCount();
        }

        public void setBallColor(Label lbl)
        {

            //check the flag for label: 0 for gray, 1 for red, 2 for blue
            // if label color was gray, then check which color group it belongs
            // if belongs to red balls group, then make such changes as follows
            switch (lbl.Tag.ToString())
            {
                case "0": //Balls was not selected, then after selected, make the following changes:                    
                    lbl.ForeColor = Color.White;    //change numbers color in balls to white
                    if (lbl.Name.Contains("Red"))   //if balls from red panel
                    {
                        lbl.Tag = "1";              // set flag of balls' color to 1, means red color balls
                        lbl.Image = Image.FromFile("images/red.png");   //show red balls which was selected
                        redBalls.Add(lbl.Text);
                    }
                    else    //balls from blue panel
                    {
                        lbl.Tag = "2";
                        blueBalls.Add(lbl.Text);
                        lbl.Image = Image.FromFile("images/blue.png");
                    }
                    break;
                case "1": //Balls already selected and color is red
                    redBalls.Remove(lbl.Text);
                    resetColor(lbl);
                    break;
                case "2": //Balls already selected and color is blue
                    blueBalls.Remove(lbl.Text);
                    resetColor(lbl);
                    break;
                default:
                    break;
            }
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

        #endregion


        #region response to button click events on UI
        private void btnRandomRed_Click(object sender, EventArgs e)
        {
            clearRed();
            int count = Convert.ToInt32(this.numRedBalls.Value);
            this.redBalls = createBalls(1, count);
            ShowRedCount();
            
        }
        /// <summary>
        /// generate count number of numbers (balls), color as defined by colorCode
        /// </summary>
        /// <param name="colorCode">1 is red, 2 is blue</param>
        /// <param name="count">the number of balls to be generated</param>
        private List<string> createBalls(int colorCode, int count)
        {
            List<string> numList = new List<string>();
            switch (colorCode)
            {
                case 1:
                    numList = mySelector.CreateRedNum(count);
                    for (int i = 0; i < count; i++)
                    {
                        Label lbl = redBallLabels[numList[i]];
                        setBallColor(lbl);
                    }
                    break;
                case 2:
                    numList = mySelector.CreateBlueNum(count);
                    for (int i = 0; i < count; i++)
                    {
                        Label lbl = blueBallLabels[numList[i]];
                        setBallColor(lbl);
                    }
                    break;
                default:
                    break;
            }
            return numList;
        }

        private void btnClearRed_Click(object sender, EventArgs e)
        {
            clearRed();
            ShowRedCount();
        }

        private void btnRandomBlue_Click(object sender, EventArgs e)
        {
            clearBlue();
            int count = Convert.ToInt32(this.numBlueBalls.Value);
            this.blueBalls = createBalls(2, count);
            ShowBlueCount();
        }

        private void btnBlueClear_Click(object sender, EventArgs e)
        {
            clearBlue();
            ShowBlueCount();
        }
        #endregion
        #region general methods to clear red or blue color set back to gray.

        /// <summary>
        /// after deselected the color will be reset to gray color.
        /// </summary>
        /// <param name="lbl">Label to reset the color</param>
        public void resetColor(Label lbl)
        {
            lbl.Image = Image.FromFile("images/gray.png");
            lbl.ForeColor = Color.Black;
            lbl.Tag = "0";
        }

        private void clearRed()
        {
            foreach (Label item in this.redBallLabels.Values)
            {
                if (item.Tag.ToString() == "1") resetColor(item);
            }
            this.redBalls = null;
        }

        private void clearBlue()
        {
            foreach (Label item in this.blueBallLabels.Values)
            {
                if (item.Tag.ToString() == "2") resetColor(item);
            }
            this.blueBalls = null;
        }
        #endregion

        #region Show red or blue balls' count
        private void ShowRedCount()
        {
            int redCount = 0;
         
            foreach (var item in redBallLabels.Values)
            {
                if (item.Tag.ToString() == "1") redCount++;
            }
            this.lblRedBallCount.Text = redCount.ToString();
            this.lblStatus2.Text = (Convert.ToInt32(this.lblRedBallCount.Text) > 1) ? "red balls, and " : "red ball, and ";

        }

        private void ShowBlueCount()
        {
            int blueCount = 0;
            
            foreach (var item in blueBallLabels.Values)
            {
                if (item.Tag.ToString() == "2") blueCount++;
            }
            this.lblBlueBallCount.Text = blueCount.ToString();
            this.lblStatus3.Text = (Convert.ToInt32(this.lblBlueBallCount.Text) > 1) ? "balls" : "ball";
            
        }
        #endregion
        /// <summary>
        /// Add selected balls to DataGridView for confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /* List<string> redNum = new List<string>();
             List<string> blueNum = new List<string>();
             // add red balls numbers to list
             foreach(var item in this.redBallLabels.Values)
             {
                 if (item.Tag.ToString().Equals("1")) redNum.Add(item.Text);
             }
             // add blue balls' numbers to list
             foreach(var item in this.blueBallLabels.Values)
             {
                 if (item.Tag.ToString().Equals("2")) blueNum.Add(item.Text);
             }*/
            // put redball numbers and blueball numbers into constructor to get price info etc.
            //mySelector.SelectedBalls.Add(new DoubleChromoSphere(redNum, blueNum));
            confirmToDGV();

        }

        private void confirmToDGV()
        {
            if(this.redBalls.Count<6 || this.blueBalls.Count<1)
            {
                MessageBox.Show("Please select at least 6 red balls and at least 1 blue ball!");
                return;
            }
            mySelector.SelectedBalls.Add(new DoubleChromoSphere(this.redBalls, this.blueBalls));
            //show results
            this.dgvList.DataSource = null;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.DataSource = mySelector.SelectedBalls;
            this.dgvList.ClearSelection();
            //reset status information and selections
            clearBlue();
            clearRed();
            this.lblRedBallCount.Text = this.lblBlueBallCount.Text = "0";
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            mySelector.SelectedBalls.Clear();
            this.dgvList.DataSource = null;
        }

        private void btnAuto1Draw_Click(object sender, EventArgs e)
        {
            this.redBalls = createBalls(1, 6);
            this.blueBalls = createBalls(2, 1);
            confirmToDGV();
        }

        private void btnAutoGen_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.numAutoGen.Value);
            for (var i=0; i < num; i++)
            {
                this.redBalls = createBalls(1, 6);
                this.blueBalls = createBalls(2, 1);
                confirmToDGV();
            }
        }
    }
}
