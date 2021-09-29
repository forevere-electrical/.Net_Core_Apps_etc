using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPro
{
    public class Selector
    {
        public DoubleChromoSphere Balls { get; set; }
        //Red balls pool
        public List<string> RedBallList { get; set; }
        
        //Blue balls pool
        public List<string> BlueBallList { get; set; }

        // Selected numbers or balls
        public List<DoubleChromoSphere> SelectedBalls { get; set; } = new List<DoubleChromoSphere>();

        private Random random = new Random();

        public Selector(List<string> redBalls, List<string> blueBalls)
        {
            this.RedBallList = redBalls;
            this.BlueBallList = blueBalls;           
        }
        /// <summary>
        /// generate Count number of redball numbers
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<string> CreateRedNum(int count=6)
        {
            List<string> numList = new List<string>();
            while (true)
            {
                if (numList.Count == count) break;
                string num = RedBallList[random.Next(this.RedBallList.Count)];
                if (numList.Contains(num)) continue;
                else numList.Add(num);
            }
            return numList;
        }

        /// <summary>
        /// generate Count number of blue ball numbers
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<string> CreateBlueNum(int count=1)
        {
            List<string> numList = new List<string>();
            while (true)
            {
                if (numList.Count == count) break;
                string num = BlueBallList[random.Next(this.BlueBallList.Count)];
                if (numList.Contains(num)) continue;
                else numList.Add(num);
            }
            return numList;
        }

       
    }
}
