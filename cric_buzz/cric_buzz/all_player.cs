using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cric_buzz
{
    public partial class all_player : Form
    {
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        string store;
        public all_player(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            /////// player display /////////
            for (int i = 0; i < 20; i++)
            {
                if (cp_array[i].name != null)
                {
                    store += "\n\n";
                    store += "_______________________";
                    store += "\n\n";
                    store += "Player # ";
                    int t = i;
                    t++;
                    store += t;
                    store += "\n\n";
                    store += "Name : ";
                    store += cp_array[i].name;
                    store += "\nShirt : ";
                    store += cp_array[i].shrit;
                    store += "\nRanking : ";
                    store += cp_array[i].ranking;
                    store += "\nAverage : ";
                    store += cp_array[i].average;
                    store += "\nTotal Wickets : ";
                    store += cp_array[i].total_wickets;
                    store += "\nTotal Runs : ";
                    store += cp_array[i].total_runs;
                    store += "\nMatches Played : ";
                    store += cp_array[i].match_played;
                }
            }       
            InitializeComponent();
            label4.Text = store;

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void all_player_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 ob = new p1(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();
            button1.Hide();
        }
    }
    
}
