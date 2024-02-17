using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSirketiOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
       
             
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
          
            //efe
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;


            pictureBox1.Parent = pictureBox3;
            pictureBox1.BackColor = Color.Transparent;

            pictureBox2.Parent = pictureBox3;
            pictureBox2.BackColor = Color.Transparent;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
