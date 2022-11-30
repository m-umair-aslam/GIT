using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace cric_buzz
{
    public partial class SplashForm : Form
    {
        
        player[] player_array = new player[20];
        team[] team_array = new team[20];
        match[] match_array = new match[20];
        public SplashForm()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                player_array[i] = new player();
                team_array[i] = new team();
                for (int p = 0; p < 11; p++)
                {
                    team_array[i].obj[p] = new player();
                }
                match_array[i] = new match();
            }
            timer1.Start();
            a1 ob = new a1(player_array, team_array, match_array);
          
          //////////////////////////////////////////////////
    }
        int t = 0;
        private void start_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 2;
            if (t > 150)
            {
                main_page ob = new main_page(player_array, team_array, match_array);
                ob.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}