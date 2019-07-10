using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckRacingGame
{
    public class Bettor
    {
        //Variable initialization
        public int Amounts; 
        public int Trucks;
        public Gambler Punter; 

        public string Description()//This is for updating the descriptions
        {
            string description = "";
            description = this.Punter.ClientName + " bets " + this.Amounts + " dollars on Truck #" + Trucks;
            return description;
        }

        public int PayOut(int winPerson)//This function is for updating payout
        {
            if (Trucks == winPerson)
            {
                return this.Amounts;
            }
            else
            {
                return -this.Amounts;
            }
        }
    }
}
