namespace RPS
{
    partial class RPS
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
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lblopponent = new System.Windows.Forms.Label();
            this.radrock = new System.Windows.Forms.RadioButton();
            this.radpaper = new System.Windows.Forms.RadioButton();
            this.radscissors = new System.Windows.Forms.RadioButton();
            this.grpplayerschoice = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.grpplayerschoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::RPS.Properties.Resources.GettyImages_871479424_f599f96e1c03466880bfc5be20aeb201;
            this.imgOpponent.Location = new System.Drawing.Point(394, 0);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(410, 212);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 0;
            this.imgOpponent.TabStop = false;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::RPS.Properties.Resources.GettyImages_871479424_f599f96e1c03466880bfc5be20aeb201;
            this.imgPlayer.Location = new System.Drawing.Point(1, 0);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(395, 212);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 1;
            this.imgPlayer.TabStop = false;
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer.Location = new System.Drawing.Point(134, 215);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(81, 29);
            this.lblplayer.TabIndex = 2;
            this.lblplayer.Text = "Player";
            // 
            // lblopponent
            // 
            this.lblopponent.AutoSize = true;
            this.lblopponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopponent.Location = new System.Drawing.Point(546, 215);
            this.lblopponent.Name = "lblopponent";
            this.lblopponent.Size = new System.Drawing.Size(120, 29);
            this.lblopponent.TabIndex = 3;
            this.lblopponent.Text = "Opponent";
            // 
            // radrock
            // 
            this.radrock.AutoSize = true;
            this.radrock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radrock.Location = new System.Drawing.Point(23, 28);
            this.radrock.Name = "radrock";
            this.radrock.Size = new System.Drawing.Size(64, 24);
            this.radrock.TabIndex = 4;
            this.radrock.TabStop = true;
            this.radrock.Text = "Rock";
            this.radrock.UseVisualStyleBackColor = true;
            this.radrock.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radpaper
            // 
            this.radpaper.AutoSize = true;
            this.radpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radpaper.Location = new System.Drawing.Point(23, 56);
            this.radpaper.Name = "radpaper";
            this.radpaper.Size = new System.Drawing.Size(69, 24);
            this.radpaper.TabIndex = 5;
            this.radpaper.TabStop = true;
            this.radpaper.Text = "Paper";
            this.radpaper.UseVisualStyleBackColor = true;
            this.radpaper.CheckedChanged += new System.EventHandler(this.radpaper_CheckedChanged);
            // 
            // radscissors
            // 
            this.radscissors.AutoSize = true;
            this.radscissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radscissors.Location = new System.Drawing.Point(23, 86);
            this.radscissors.Name = "radscissors";
            this.radscissors.Size = new System.Drawing.Size(87, 24);
            this.radscissors.TabIndex = 6;
            this.radscissors.TabStop = true;
            this.radscissors.Text = "Scissors";
            this.radscissors.UseVisualStyleBackColor = true;
            this.radscissors.CheckedChanged += new System.EventHandler(this.radscissors_CheckedChanged);
            // 
            // grpplayerschoice
            // 
            this.grpplayerschoice.Controls.Add(this.radrock);
            this.grpplayerschoice.Controls.Add(this.radpaper);
            this.grpplayerschoice.Controls.Add(this.radscissors);
            this.grpplayerschoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpplayerschoice.Location = new System.Drawing.Point(76, 260);
            this.grpplayerschoice.Name = "grpplayerschoice";
            this.grpplayerschoice.Size = new System.Drawing.Size(200, 116);
            this.grpplayerschoice.TabIndex = 10;
            this.grpplayerschoice.TabStop = false;
            this.grpplayerschoice.Text = "Players Choice";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(498, 260);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(231, 96);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "Play Round";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(281, 397);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 25);
            this.lblMsg.TabIndex = 12;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.Location = new System.Drawing.Point(282, 260);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(75, 18);
            this.lblW.TabIndex = 13;
            this.lblW.Text = "Total wins";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(301, 288);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(16, 18);
            this.lblWins.TabIndex = 14;
            this.lblWins.Text = "0";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoses.Location = new System.Drawing.Point(375, 288);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(16, 18);
            this.lblLoses.TabIndex = 15;
            this.lblLoses.Text = "0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(455, 288);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(16, 18);
            this.lblTies.TabIndex = 16;
            this.lblTies.Text = "0";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.Location = new System.Drawing.Point(355, 260);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(81, 18);
            this.lblL.TabIndex = 17;
            this.lblL.Text = "Total loses";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(433, 260);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(68, 18);
            this.lblT.TabIndex = 18;
            this.lblT.Text = "Total ties";
            // 
            // tmrShoot
            // 
            this.tmrShoot.Interval = 5000;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Interval = 5000;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpplayerschoice);
            this.Controls.Add(this.lblopponent);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.imgOpponent);
            this.Name = "RPS";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.RPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.grpplayerschoice.ResumeLayout(false);
            this.grpplayerschoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lblopponent;
        private System.Windows.Forms.RadioButton radrock;
        private System.Windows.Forms.RadioButton radpaper;
        private System.Windows.Forms.RadioButton radscissors;
        private System.Windows.Forms.GroupBox grpplayerschoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Timer tmrPlayer;
    }
}

