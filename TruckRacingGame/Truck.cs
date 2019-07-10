using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRacingGame
{
    public class Truck
    {
        public int TruckBeginingPosition; // this is for that position where our track is started
        public int TruckTrackLength; //This variable for the length of the track
        public PictureBox TruckPictureBox; //Instance of picture box
        public Random RandomNumber; //This is instance of random class
        public int Locat; //My Location on the track


        public void TrucksStartingPosition()//This is for reseting the trucks on their position
        {
            Locat = 0;
            TruckPictureBox.Top = TruckBeginingPosition;
        }
        public bool TruckRace()//For the running of random numbers
        {
            Locat += RandomNumber.Next(1, 5);//changing the random numbers
            TruckPictureBox.Top = Locat;//this is for top location where our truck starts the race
            if (TruckPictureBox.Top >= TruckTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
