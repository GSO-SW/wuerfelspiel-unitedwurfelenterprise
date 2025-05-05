using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class FrmWuerfelspiel : Form
    {
        public FrmWuerfelspiel()
        {
            InitializeComponent();
        }

        private void FrmWuerfelspiel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_play_Click(object sender, EventArgs e)
        {

            GameForm game = new GameForm();
            game.Show();
            this.Hide();
        }

 
    
        private void btn_1Ps_Click(object sender, EventArgs e)
        {

        }

        private void btn_2Ps_Click(object sender, EventArgs e)
        {

        }

        private void btn_3Ps_Click(object sender, EventArgs e)
        {

        }

        private void btn_4Ps_Click(object sender, EventArgs e)
        {

        }

        private void btn_5Ps_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 

    
}


