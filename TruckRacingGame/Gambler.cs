using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRacingGame
{
    public class Gambler
    {
        //initial variables
        public string ClientName; 
        public Bettor TruckBet; 
        public int Cashes; 
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()//This is for upadating the labels
        {
            MyRadioButton.Text = ClientName + " has " + Cashes + " dollars";
            MyLabel.Text = ClientName + " hasn't place a bet";

            if (Cashes == 0)//Code When bettor has no money to bet then it gets destroy
            {
                MyLabel.Text = String.Format("Destroyed");
                MyLabel.ForeColor = System.Drawing.Color.Red;
                MyRadioButton.Enabled = false;
            }

        }

        public void ClearTheBet()//This function is for clearing the bet
        {
            TruckBet.Amounts = 0;
            TruckBet.Trucks = 0;
            TruckBet.Punter = this;
        }

        public bool PlaceBet(int BetAmount, int TruckToWin)//This function is for placing the bet
        {
            if (Cashes >= BetAmount)
            {
                TruckBet.Amounts = BetAmount;
                TruckBet.Trucks = TruckToWin;
                TruckBet.Punter = this;
                return true;
            }
            else return false;
        }

        public void Collect(int winner)//This function is for collecting the cash
        {
            Cashes += TruckBet.PayOut(winner);
            this.UpdateLabels();
        }
    }
}
