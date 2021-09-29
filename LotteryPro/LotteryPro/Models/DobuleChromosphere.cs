using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryPro
{
    /// <summary>
    /// class definition for Balls: red balls and blue balls 
    /// </summary>
    public class DoubleChromoSphere
    {
        public List<string> RedBalls { get; set; } 
        public List<string> BlueBalls { get; set; }
        // ball type is single draw or multidraw each select
        public string BallType { get; set; }
        public int Price { get; set; } = 2; // by default price is $2 per draw [single draw price]
        #region constructor
        //Constructor [price=A!/((A-6)! * 6!) * B]       A is redballs' count while B is blueballs' count
        public DoubleChromoSphere(List<string> redBalls, List<string> blueBalls)
        {
            this.RedBalls = redBalls;
            this.BlueBalls = blueBalls;
            //single draw is redballs: 6 max, blueball: 1, otherwise it is multi-draw
            BallType = blueBalls.Count > 1 || redBalls.Count > 6 ? "Double draw" : "Single draw";

            if (BallType=="Double draw")
            {
                Price = (Factorial(redBalls.Count) / (Factorial(redBalls.Count - 6) * Factorial(6))) * blueBalls.Count;
            }
        }
        #endregion
        private int Factorial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        #region Property Expansion
        //Show the selected balls 
        public string BallsShow {
            get
            {
                string nums = "";
                if (RedBalls != null)
                {
                    RedBalls.Sort();
                    nums = string.Join(" ", RedBalls) + " | ";
                }
                
                if(BlueBalls.Count>1)
                {
                    BlueBalls.Sort();
                    return nums += string.Join(" ", BlueBalls) + " | "; 
                }
                               
                else            
                    return nums += " " + BlueBalls[0];            
            }
        }

        public string PriceShow => "$" + Price;
        #endregion
    }
}
