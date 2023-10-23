using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGameSummitive
{
    public partial class Form1 : Form
    {
        int page;
        int brawler = 0;
        int keenmind = 0;
        int hunter = 0;
        int r;
        SoundPlayer player = new SoundPlayer(Properties.Resources.The_Caretaker___It_s_just_a_burning_memory__2016_);
        public Form1()
        {
            InitializeComponent();
            page = -1;
            option1Button.Text = "Start";
            Random random = new Random();
            r = random.Next(1, 11);
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (option1Button.Text == "Start")
            {
            }
            else if (page == -1)
            {
                hunter++;
                page = 0;
            }
            else if (page == 0)
                page = 1;
            else if (page == 1)
                page = 4;
            else if (page == 2)
            {
                outputLabel.Text = "Well um i guess game over???";
                pictureOutput.Image = Properties.Resources.Shadowfell2;
                Refresh();
                Thread.Sleep(1000);
                page = 35;

            }
            else if (page == 3 && r <= 6)
                page = 8;
            else if (page == 3 && r >= 7)
                page = 5;
            else if (page == 4)
                page = 9;
            else if (page == 5)
            {
                outputLabel.Text = "The torch shines bright the area seems to purify you get out safely";
                pictureOutput.Image = Properties.Resources.Shadowfell2;
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 6)
                page = 17;
            else if (page == 7)
                page = 10;
            else if (page == 8)
                page = 16;
            else if (page == 9)
            {
                outputLabel.Text = "The murky water seems to draw you in and pulls you under the water and you drown";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 10)
            {
                outputLabel.Text = "you try to kill the dragon with no success and die";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 11)
                page = 18;
            else if (page == 12)
            {
                outputLabel.Text = "You jump up but because of the weaker gravity you go to high and a dragon eats you";
                pictureOutput.Image = Properties.Resources.shadowfelldragon1;
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 13)
            {
                outputLabel.Text = "You get plenty of food this place isn't so bad you start a new life here";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 14)
            {
                outputLabel.Text = "Child leads you out of this place";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 15)
                page = 20;
            else if (page == 16)
                page = 20;
            else if (page == 17)
            {
                outputLabel.Text = "You are a murderer you got out but were sentenced to life in prison";
                Refresh();
                Thread.Sleep(2000);
                page = 35;
            }
            else if (page == 18)
            {
                outputLabel.Text = "you take it's eyes and it shows you the exit";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 19)
            {
                outputLabel.Text = "You go back and your torch light grows again but you become trapped here";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 20)
            {
                outputLabel.Text = "You wander for many hours before you finally escape.";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 35 || page == 36)
            {
                page = -1;
            }
            
        
    
            switch(page) {
                case -1:
                    outputLabel.Text = "Choose a skill";
                    option1Button.Text = "Brawler";
                    option2Button.Text = "Keenmind";
                    option3Button.Text = "Hunter";
                    brawler = 0;
                    keenmind = 0;
                    hunter = 0;
                    player.Play();
                    break;
                case 0:
                    outputLabel.Text = "You wake up in a shadowy forest. Do you try and locate yourself?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "Yes (Keen mind is needed)";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 1:
                    outputLabel.Text = "You are in a shadowy forest with no indication of how you go here. Which way do you go?";
                    option1Button.Text = "East";
                    option2Button.Text = "West";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 3:
                    outputLabel.Text = "you are in the shadow fell and dimension of misery and despair but luckily you locate your torch. Light the torch?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 4:
                    outputLabel.Text = "you see a pit of water but the water is very murky. Take a dip?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Lake;
                    break;
                case 6:
                    outputLabel.Text = "Probably a good idea at a second glance you see dead animals in the water.";
                    Refresh();
                    Thread.Sleep(1500);
                    outputLabel.Text = "You notice a small humanoid approaching the water. What do you";
                    option1Button.Text = "Push the child in the water";
                    option2Button.Text = "Talk to the child";
                    option3Button.Text = "Take dead animals out of the water (Hunter)";
                    pictureOutput.Image = Properties.Resources.Lake;
                    break;
                case 7:
                    outputLabel.Text = "You see a small shadowy dragon but it hasn't seen you yet. Fight the dragon?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "Tackle it instead";
                    pictureOutput.Image = Properties.Resources.shadowfelldragon1;
                    break;
                case 8:
                    outputLabel.Text = "The torch in very dim but with it's light you feel safer and with your keen knowledge you realize gravity is weak here";
                    option1Button.Text = "Walk";
                    option2Button.Text = "Jump";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 11:
                    outputLabel.Text = "You kill the dragon. Do you want to loot it?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfelldragon1;
                    break;
                case 15:
                    outputLabel.Text = "You sneak away safely. Now which way do you go?";
                    option1Button.Text = "South";
                    option2Button.Text = "East";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell3;
                    break;
                case 16:
                    outputLabel.Text = "Boring but ok you walk around with your torch light as a guide. Your torch light begins to grow dimmer.";
                    option1Button.Text = "Go foreward";
                    option2Button.Text = "Go back";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell3;
                    break;
                case 35:
                    outputLabel.Text = "You lost would you like to try again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell4;
                    break;
                case 36:
                    outputLabel.Text = "You won but there are different way to win. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell4;
                    break;
            }
            
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            
            if (page == -1)
            {
                keenmind++;
                page = 0;
            }
            else if (page == 0)
                page = 2;
            else if (page == 1)
                page = 7;
            else if (page == 2)
            {
                outputLabel.Text = "Well um i guess game over???";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 3)
                page = 1;
            else if (page == 4)
                page = 6;
            else if (page == 5)
            {
                outputLabel.Text = "The torch shines bright the area seems to purify you get out safely";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 6)
                page = 14;
            else if (page == 7)
                page = 15;
            else if (page == 8)
                page = 12;
            else if (page == 9)
            {
                outputLabel.Text = "The murky water seems to draw you in and pulls you under the water and you drown";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 10)
            {
                outputLabel.Text = "you try to kill the dragon with no success and die";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 11)
                page = 7;
            else if (page == 12)
            {
                outputLabel.Text = "You jump up but because of the weaker gravity you go to high and a dragon eats you";
                pictureOutput.Image = Properties.Resources.shadowfelldragon1;
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 13)
            {
                outputLabel.Text = "You get plenty of food this place isn't so bad you start a new life here";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 14)
            {
                outputLabel.Text = "Child leads you out of this place";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 15)
                page = 7;
            else if (page == 16)
                page = 19;
            else if (page == 17)
            {
                outputLabel.Text = "You are a murderer you got out but were sentenced to life in prison";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 18)
            {
                outputLabel.Text = "you take it's eyes and it shows you the exit";
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 19)
            {
                outputLabel.Text = "You go back and your torch light grows again but you become trapped here";
                Refresh();
                Thread.Sleep(1000);
                page = 35;
            }
            else if (page == 20)
            {
                outputLabel.Text = "You wander for many hours before you finally escape.";
                pictureOutput.Image = Properties.Resources.shadowfell4;
                Refresh();
                Thread.Sleep(1000);
                page = 36;
            }
            else if (page == 35 || page == 36)
            {
                Close();
            }
            switch (page)
            {
                case -1:
                    outputLabel.Text = "Choose a skill";
                    option1Button.Text = "Brawler";
                    option2Button.Text = "Keenmind";
                    option3Button.Text = "Hunter";
                    brawler = 0;
                    keenmind = 0;
                    hunter = 0;
                    break;
                case 0:
                    outputLabel.Text = "You wake up in a shadowy forest. Do you try and locate yourself?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "Yes (Keen mind is needed)";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 1:
                    outputLabel.Text = "You are in a shadowy forest with no indication of how you go here. Which way do you go?";
                    option1Button.Text = "East";
                    option2Button.Text = "West";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 3:
                    outputLabel.Text = "you are in the shadow fell and dimension of misery and despair but luckily you locate your torch. Light the torch?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 4:
                    outputLabel.Text = "you see a pit of water but the water is very murky. Take a dip?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Lake;
                    break;
                case 6:
                    outputLabel.Text = "Probably a good idea at a second glance you see dead animals in the water.";
                    Refresh();
                    Thread.Sleep(1500);
                    outputLabel.Text = "You notice a small humanoid approaching the water. What do you";
                    option1Button.Text = "Push the child in the water";
                    option2Button.Text = "Talk to the child";
                    option3Button.Text = "Take dead animals out of the water (Hunter)";
                    pictureOutput.Image = Properties.Resources.Lake;
                    break;
                case 7:
                    outputLabel.Text = "You see a small shadowy dragon but it hasn't seen you yet. Fight the dragon?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "Tackle it instead";
                    pictureOutput.Image = Properties.Resources.shadowfelldragon1;
                    break;
                case 8:
                    outputLabel.Text = "The torch in very dim but with it's light you feel safer and with your keen knowledge you realize gravity is weak here";
                    option1Button.Text = "Walk";
                    option2Button.Text = "Jump";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.Shadowfell2;
                    break;
                case 11:
                    outputLabel.Text = "You kill the dragon. Do you want to loot it?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfelldragon1;
                    break;
                case 15:
                    outputLabel.Text = "You sneak away safely. Now which way do you go?";
                    option1Button.Text = "South";
                    option2Button.Text = "East";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell3;
                    break;
                case 16:
                    outputLabel.Text = "Boring but ok you walk around with your torch light as a guide. Your torch light begins to grow dimmer.";
                    option1Button.Text = "Go foreward";
                    option2Button.Text = "Go back";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell3;
                    break;
                case 35:
                    outputLabel.Text = "You lost would you like to try again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell4;
                    break;
                case 36:
                    outputLabel.Text = "You won but there are different way to win. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    pictureOutput.Image = Properties.Resources.shadowfell4;
                    break;
            }

        }
        private void option3Button_Click(object sender, EventArgs e)
        {

            if (page == -1)
            {
                hunter++;
                page = 0;
            }
            else if (page == 0 && keenmind == 1)
            {
                page = 3;
            }
           
            else if (page == 0)
            {
                outputLabel.Text = "Your mind isn't keen enough for this option";
            }
            else if (page == 7 && brawler == 1)
            {
                outputLabel.Text = "You kill the dragon";
                Refresh();
                Thread.Sleep(1500);
                page = 11;
            }
            else if (page == 7)
            {
                outputLabel.Text = "You need some real brawling experince for this option";
            }
            else if (page == 6 && hunter == 1)
            {
                outputLabel.Text = "You get plenty of food this place isn't so bad you start a new life here";
                Refresh();
                Thread.Sleep(1500);
                page = 36;
            }
            else if (page == 6)
            {
                outputLabel.Text = "You don't have the hunting skills required for this";
            }
            switch (page)
            {
                case -1:
                    outputLabel.Text = "Choose a skill";
                    option1Button.Text = "Brawler";
                    option2Button.Text = "Keenmind";
                    option3Button.Text = "Hunter";
                    brawler = 0;
                    keenmind = 0;
                    hunter = 0;
                    break;
                case 0:
                    outputLabel.Text = "You wake up in a shadowy forest. Do you try and locate yourself?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "Yes (Keen mind is needed)";
                    break;
                case 1:
                    outputLabel.Text = "You are in a shadowy forest with no indication of how you go here. Which way do you go?";
                    option1Button.Text = "East";
                    option2Button.Text = "West";
                    option3Button.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "you are in the shadow fell and dimension of misery and despair but luckily you locate your torch. Light the torch?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "you see a pit of water but the water is very murky. Take a dip?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "Probably a good idea at a second glance you see dead animals in the water.";
                    Refresh();
                    Thread.Sleep(1500);
                    outputLabel.Text = "You notice a small humanoid approaching the water. What do you";
                    option1Button.Text = "Push the child in the water";
                    option2Button.Text = "Talk to the child";
                    option3Button.Text = "Take dead animals out of the water (Hunter)";
                    break;
                case 7:
                    outputLabel.Text = "You see a small shadowy dragon but it hasn't seen you yet. Fight the dragon?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "Tackle it instead";
                    break;
                case 8:
                    outputLabel.Text = "The torch in very dim but with it's light you feel safer and with your keen knowledge you realize gravity is weak here";
                    option1Button.Text = "Walk";
                    option2Button.Text = "Jump";
                    option3Button.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You kill the dragon. Do you want to loot it?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You sneak away safely. Now which way do you go?";
                    option1Button.Text = "South";
                    option2Button.Text = "East";
                    option3Button.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "Boring but ok you walk around with your torch light as a guide. Your torch light begins to grow dimmer.";
                    option1Button.Text = "Go foreward";
                    option2Button.Text = "Go back";
                    option3Button.Text = "";
                    break;
                case 35:
                    outputLabel.Text = "You lost would you like to try again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    break;
                case 36:
                    outputLabel.Text = "You won but there are different way to win. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    }

