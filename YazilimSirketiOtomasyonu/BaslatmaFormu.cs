﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace YazilimSirketiOtomasyonu
{
    public partial class BaslatmaFormu : Form
    {
        
        public BaslatmaFormu()
        {
            InitializeComponent();
            BaglantiDB baglantiDB = new BaglantiDB();
            baglantiDB.BaglantiOpen();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\alizade.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if(!islem)
            {
                this.Opacity += 0.009;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.009;
                if(this.Opacity == 0) {
                    this.Hide();
                    AnaSayfa gtr = new AnaSayfa();
                    gtr.Show();
                    timer1.Enabled = false;
                    
                }
               
            }
        }
    }
}
