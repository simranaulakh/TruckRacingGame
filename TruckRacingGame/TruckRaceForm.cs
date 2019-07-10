using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRacingGame
{
    public partial class TruckRaceForm : Form
    {
        Truck[] TruckArray = new Truck[4]; // this is instance of truck class
        Gambler[] PuntersArray = new Gambler[3]; // this is instance of punter class
        Random RandomNumbers = new Random();
        public TruckRaceForm()
        {
            InitializeComponent();
            RaceTrackInitialization();
        }
        private void RaceTrackInitialization()//this is the initialization of race track here i assign the initial values of the variables
        {
            radioButtonSimran.Checked = true;
            minimumBetLabel.Text = "Minimum Bet : " + numericUpDownNumber.Minimum.ToString() + " dollars";//Setting the minimum value of numeric updownnumber
            TruckArray[0] = new Truck()
            {
                TruckPictureBox = truck1,//initialize picture 1 to first array
                TruckBeginingPosition = truck1.Top,//initialize to starting position
                TruckTrackLength = truckTrack.Height - truck1.Height,//initialize track length
                RandomNumber = RandomNumbers//initialize random numbers
            };

            TruckArray[1] = new Truck()//this is for second array of truck class initialization
            {
                TruckPictureBox = truck2,
                TruckBeginingPosition = truck2.Top,
                TruckTrackLength = truckTrack.Height - truck2.Height,
                RandomNumber = RandomNumbers
            };

            TruckArray[2] = new Truck()
            {
                TruckPictureBox = truck3,
                TruckBeginingPosition = truck3.Top,
                TruckTrackLength = truckTrack.Height - truck3.Height,
                RandomNumber = RandomNumbers
            };

            TruckArray[3] = new Truck()
            {
                TruckPictureBox = truck4,
                TruckBeginingPosition = truck4.Top,
                TruckTrackLength = truckTrack.Height - truck4.Height,
                RandomNumber = RandomNumbers
            };

            
            PuntersArray[0] = new Gambler()//This array for the punter class Initialization
            {
                ClientName = "Simran",//Here i define the name of client
                TruckBet = null,//Set the bet null
                Cashes = 70,//set cash 70
                MyRadioButton = radioButtonSimran,//assign radio buuton
                MyLabel = simranBetLabel//assign the labe to punter class
            };

            PuntersArray[1] = new Gambler()
            {
                ClientName = "Rajinder",
                TruckBet = null,
                Cashes = 95,
                MyRadioButton = radioButtonRajinder,
                MyLabel = rajinderBetLabel
            };

            PuntersArray[2] = new Gambler()
            {
                ClientName = "Sandeep",
                TruckBet = null,
                Cashes = 65,
                MyRadioButton = radioButtonSandeep,
                MyLabel = sandeepBetLabel
            };

            for (int i = 0; i <= 2; i++)
            {
                PuntersArray[i].UpdateLabels();
                PuntersArray[i].TruckBet = new Bettor();
            }
        }
        private void btnBets_Click(object sender, EventArgs e)
        {
            if (radioButtonSimran.Checked)//Here bets are placed in this module
            {
                if (PuntersArray[0].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    simranBetLabel.Text = PuntersArray[0].TruckBet.Description();//Here updation of labels from punter class
                }
            }
            else if (radioButtonRajinder.Checked)
            {
                if (PuntersArray[1].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    rajinderBetLabel.Text = PuntersArray[1].TruckBet.Description();
                }
            }
            else if (radioButtonSandeep.Checked)
            {
                if (PuntersArray[2].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    sandeepBetLabel.Text = PuntersArray[2].TruckBet.Description();
                }
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            //reset trucks
            TruckArray[0].TrucksStartingPosition();
            TruckArray[1].TrucksStartingPosition();
            TruckArray[2].TrucksStartingPosition();
            TruckArray[3].TrucksStartingPosition();

            //disable race button till the end of the race
            bettingParlor.Enabled = false;

            //start timer
            RaceTimer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void RaceTimer_Tick(object sender, EventArgs e)//Timer coding
        {
            for (int i = 0; i <= 3; i++)
            {
                if (TruckArray[i].TruckRace())
                {
                    RaceTimer.Stop();
                    bettingParlor.Enabled = true;
                    i++;
                    MessageBox.Show("Truck " + i + " won the race");
                    for (int j = 0; j <= 2; j++)
                    {
                        PuntersArray[j].Collect(i);
                        PuntersArray[j].ClearTheBet();
                    }

                    foreach (Truck Truck in TruckArray)
                    {
                        Truck.TrucksStartingPosition();
                    }
                    break;
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Truck truck in TruckArray)
            {
                truck.TrucksStartingPosition();
            }
            if (simranBetLabel.Text == "Destroyed" && rajinderBetLabel.Text == "Destroyed" && sandeepBetLabel.Text == "Destroyed")
            {
                RaceTrackInitialization();

                PuntersArray[0] = new Gambler()//This array for the punter class Initialization
                {
                    ClientName = "Simran",//Here i define the name of client
                    TruckBet = null,//Set the bet null
                    Cashes = 70,//set cash 70
                    MyRadioButton = radioButtonSimran,//assign radio buuton
                    MyLabel = simranBetLabel//assign the labe to punter class
                };

                PuntersArray[1] = new Gambler()
                {
                    ClientName = "Rajinder",
                    TruckBet = null,
                    Cashes = 95,
                    MyRadioButton = radioButtonRajinder,
                    MyLabel = rajinderBetLabel
                };

                PuntersArray[2] = new Gambler()
                {
                    ClientName = "Sandeep",
                    TruckBet = null,
                    Cashes = 65,
                    MyRadioButton = radioButtonSandeep,
                    MyLabel = sandeepBetLabel
                };

                foreach (Gambler punter in PuntersArray)
                {
                    punter.UpdateLabels();
                }
                simranBetLabel.ForeColor = System.Drawing.Color.Black;
                rajinderBetLabel.ForeColor = System.Drawing.Color.Black;
                sandeepBetLabel.ForeColor = System.Drawing.Color.Black;
                radioButtonSimran.Enabled = true;
                radioButtonRajinder.Enabled = true;
                radioButtonSandeep.Enabled = true;
                numericUpDownForBet.Value = 1;
                numericUpDownNumber.Value = 1;

            }

        }
    }
}
