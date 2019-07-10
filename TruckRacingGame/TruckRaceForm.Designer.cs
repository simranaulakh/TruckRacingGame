namespace TruckRacingGame
{
    partial class TruckRaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.raceButton = new System.Windows.Forms.Button();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownForBet = new System.Windows.Forms.NumericUpDown();
            this.btnBets = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sandeepBetLabel = new System.Windows.Forms.Label();
            this.rajinderBetLabel = new System.Windows.Forms.Label();
            this.simranBetLabel = new System.Windows.Forms.Label();
            this.radioButtonSandeep = new System.Windows.Forms.RadioButton();
            this.radioButtonRajinder = new System.Windows.Forms.RadioButton();
            this.radioButtonSimran = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.RaceTimer = new System.Windows.Forms.Timer(this.components);
            this.truck4 = new System.Windows.Forms.PictureBox();
            this.truck3 = new System.Windows.Forms.PictureBox();
            this.truck2 = new System.Windows.Forms.PictureBox();
            this.truck1 = new System.Windows.Forms.PictureBox();
            this.truckTrack = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // bettingParlor
            // 
            this.bettingParlor.BackColor = System.Drawing.Color.MistyRose;
            this.bettingParlor.Controls.Add(this.btnReset);
            this.bettingParlor.Controls.Add(this.raceButton);
            this.bettingParlor.Controls.Add(this.numericUpDownNumber);
            this.bettingParlor.Controls.Add(this.label3);
            this.bettingParlor.Controls.Add(this.numericUpDownForBet);
            this.bettingParlor.Controls.Add(this.btnBets);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.sandeepBetLabel);
            this.bettingParlor.Controls.Add(this.rajinderBetLabel);
            this.bettingParlor.Controls.Add(this.simranBetLabel);
            this.bettingParlor.Controls.Add(this.radioButtonSandeep);
            this.bettingParlor.Controls.Add(this.radioButtonRajinder);
            this.bettingParlor.Controls.Add(this.radioButtonSimran);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Location = new System.Drawing.Point(336, 297);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(411, 276);
            this.bettingParlor.TabIndex = 5;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Place";
            // 
            // raceButton
            // 
            this.raceButton.BackColor = System.Drawing.Color.Black;
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.raceButton.Location = new System.Drawing.Point(39, 221);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(193, 49);
            this.raceButton.TabIndex = 22;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = false;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(286, 170);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownNumber.TabIndex = 21;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "bets on truck number";
            // 
            // numericUpDownForBet
            // 
            this.numericUpDownForBet.Location = new System.Drawing.Point(117, 172);
            this.numericUpDownForBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownForBet.Name = "numericUpDownForBet";
            this.numericUpDownForBet.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownForBet.TabIndex = 19;
            this.numericUpDownForBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBets
            // 
            this.btnBets.BackColor = System.Drawing.Color.Red;
            this.btnBets.Location = new System.Drawing.Point(39, 170);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(68, 31);
            this.btnBets.TabIndex = 18;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = false;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bets";
            // 
            // sandeepBetLabel
            // 
            this.sandeepBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sandeepBetLabel.Location = new System.Drawing.Point(163, 126);
            this.sandeepBetLabel.Name = "sandeepBetLabel";
            this.sandeepBetLabel.Size = new System.Drawing.Size(197, 17);
            this.sandeepBetLabel.TabIndex = 15;
            this.sandeepBetLabel.Text = "SandeepBetLabel";
            // 
            // rajinderBetLabel
            // 
            this.rajinderBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rajinderBetLabel.Location = new System.Drawing.Point(163, 93);
            this.rajinderBetLabel.Name = "rajinderBetLabel";
            this.rajinderBetLabel.Size = new System.Drawing.Size(197, 17);
            this.rajinderBetLabel.TabIndex = 14;
            this.rajinderBetLabel.Text = "RajinderBetLabel";
            // 
            // simranBetLabel
            // 
            this.simranBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.simranBetLabel.Location = new System.Drawing.Point(163, 62);
            this.simranBetLabel.Name = "simranBetLabel";
            this.simranBetLabel.Size = new System.Drawing.Size(197, 17);
            this.simranBetLabel.TabIndex = 13;
            this.simranBetLabel.Text = "SimranBetLabel";
            // 
            // radioButtonSandeep
            // 
            this.radioButtonSandeep.AutoSize = true;
            this.radioButtonSandeep.Location = new System.Drawing.Point(31, 126);
            this.radioButtonSandeep.Name = "radioButtonSandeep";
            this.radioButtonSandeep.Size = new System.Drawing.Size(122, 17);
            this.radioButtonSandeep.TabIndex = 3;
            this.radioButtonSandeep.TabStop = true;
            this.radioButtonSandeep.Text = "radioButtonSandeep";
            this.radioButtonSandeep.UseVisualStyleBackColor = true;
            // 
            // radioButtonRajinder
            // 
            this.radioButtonRajinder.AutoSize = true;
            this.radioButtonRajinder.Location = new System.Drawing.Point(31, 93);
            this.radioButtonRajinder.Name = "radioButtonRajinder";
            this.radioButtonRajinder.Size = new System.Drawing.Size(118, 17);
            this.radioButtonRajinder.TabIndex = 2;
            this.radioButtonRajinder.TabStop = true;
            this.radioButtonRajinder.Text = "radioButtonRajinder";
            this.radioButtonRajinder.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimran
            // 
            this.radioButtonSimran.AutoSize = true;
            this.radioButtonSimran.Location = new System.Drawing.Point(31, 61);
            this.radioButtonSimran.Name = "radioButtonSimran";
            this.radioButtonSimran.Size = new System.Drawing.Size(111, 17);
            this.radioButtonSimran.TabIndex = 1;
            this.radioButtonSimran.TabStop = true;
            this.radioButtonSimran.Text = "radioButtonSimran";
            this.radioButtonSimran.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(28, 32);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(83, 16);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet";
            // 
            // RaceTimer
            // 
            this.RaceTimer.Tick += new System.EventHandler(this.RaceTimer_Tick);
            // 
            // truck4
            // 
            this.truck4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck4.Image = global::TruckRacingGame.Properties.Resources.t441;
            this.truck4.Location = new System.Drawing.Point(210, 12);
            this.truck4.Name = "truck4";
            this.truck4.Size = new System.Drawing.Size(23, 76);
            this.truck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck4.TabIndex = 4;
            this.truck4.TabStop = false;
            // 
            // truck3
            // 
            this.truck3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck3.Image = global::TruckRacingGame.Properties.Resources.t331;
            this.truck3.Location = new System.Drawing.Point(172, 12);
            this.truck3.Name = "truck3";
            this.truck3.Size = new System.Drawing.Size(23, 76);
            this.truck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck3.TabIndex = 3;
            this.truck3.TabStop = false;
            // 
            // truck2
            // 
            this.truck2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck2.Image = global::TruckRacingGame.Properties.Resources.t221;
            this.truck2.Location = new System.Drawing.Point(133, 12);
            this.truck2.Name = "truck2";
            this.truck2.Size = new System.Drawing.Size(23, 76);
            this.truck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck2.TabIndex = 2;
            this.truck2.TabStop = false;
            // 
            // truck1
            // 
            this.truck1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.truck1.Image = global::TruckRacingGame.Properties.Resources.t111;
            this.truck1.Location = new System.Drawing.Point(93, 12);
            this.truck1.Name = "truck1";
            this.truck1.Size = new System.Drawing.Size(23, 76);
            this.truck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truck1.TabIndex = 1;
            this.truck1.TabStop = false;
            // 
            // truckTrack
            // 
            this.truckTrack.Image = global::TruckRacingGame.Properties.Resources.track331;
            this.truckTrack.Location = new System.Drawing.Point(0, 0);
            this.truckTrack.Name = "truckTrack";
            this.truckTrack.Size = new System.Drawing.Size(320, 585);
            this.truckTrack.TabIndex = 0;
            this.truckTrack.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(253, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 49);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TruckRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 585);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.truck4);
            this.Controls.Add(this.truck3);
            this.Controls.Add(this.truck2);
            this.Controls.Add(this.truck1);
            this.Controls.Add(this.truckTrack);
            this.Name = "TruckRaceForm";
            this.Text = "TruckRaceForm";
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox truckTrack;
        private System.Windows.Forms.PictureBox truck1;
        private System.Windows.Forms.PictureBox truck2;
        private System.Windows.Forms.PictureBox truck3;
        private System.Windows.Forms.PictureBox truck4;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton radioButtonSandeep;
        private System.Windows.Forms.RadioButton radioButtonRajinder;
        private System.Windows.Forms.RadioButton radioButtonSimran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sandeepBetLabel;
        private System.Windows.Forms.Label rajinderBetLabel;
        private System.Windows.Forms.Label simranBetLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownForBet;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer RaceTimer;
        private System.Windows.Forms.Button btnReset;
    }
}