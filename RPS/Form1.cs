using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class RPS : Form
    {
        Random generator = new Random();
        int win = 0;
        int lose = 0;
        int tie = 0;
        public RPS()
        
        {
            InitializeComponent();
        }

        private void RPS_Load(object sender, EventArgs e)
        { 

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
        }
        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            //1 = rock 2 = paper 3 = scissors
            int random = generator.Next(1, 4);
            if (random == 1)
                imgOpponent.Image = Properties.Resources._860_main_magnesite;
            else if (random == 2)
                imgOpponent.Image = Properties.Resources._916kVZ5rmgL;
            else if (random == 3)
                imgOpponent.Image = Properties.Resources.Standard_scissors;
            if (radrock.Checked && random == 3)
                lblMsg.Text = ("Congratulations you are the winner");
            else if (radrock.Checked && random == 2)
                lblMsg.Text = ("Opps you are the loser");
            else if (radrock.Checked && random == 1)
                lblMsg.Text = ("Wow you got a tie");
            else if (radpaper.Checked && random == 3)
                lblMsg.Text = ("Opps you are the loser");
            else if (radpaper.Checked && random == 2)
                lblMsg.Text = ("Wow you got a tie");
            else if (radpaper.Checked && random == 1)
                lblMsg.Text = ("Congratulations you are the winner");
            else if (radscissors.Checked && random == 3)
                lblMsg.Text = ("Wow you got a tie");
            else if (radscissors.Checked && random == 2)
                lblMsg.Text = ("Congratulations you are the winner");
            else if (radscissors.Checked && random == 1)
                lblMsg.Text = ("Opps you are the loser");
            if (radrock.Checked && random == 1 || radpaper.Checked && random == 2 || radscissors.Checked && random == 3)
                tie = tie + 1;
            else if (radrock.Checked && random == 2 || radpaper.Checked && random == 3 || radscissors.Checked && random == 1)
                lose = lose + 1;
            else if (radrock.Checked && random == 3 || radpaper.Checked && random == 1 || radscissors.Checked && random == 2)
                win = win + 1;
            lblTies.Text = Convert.ToString(tie);
            lblLoses.Text = Convert.ToString(lose);
            lblWins.Text = Convert.ToString(win);
            radrock.Checked = false;
            radpaper.Checked = false;
            radscissors.Checked = false;
            tmrShoot.Enabled = true;
            tmrPlayer.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources._860_main_magnesite;
        }

        private void radpaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources._916kVZ5rmgL;
        }

        private void radscissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Standard_scissors;
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            imgOpponent.Image = Properties.Resources.GettyImages_871479424_f599f96e1c03466880bfc5be20aeb201;            
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.GettyImages_871479424_f599f96e1c03466880bfc5be20aeb201;
        }
    }
}
