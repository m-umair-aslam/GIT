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
    public partial class search_team : Form
    {
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public search_team(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
        }
       

        private void search_team_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        string ser,store;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string pstore;

        private void button9_Click(object sender, EventArgs e)
        {
            p1 ob = new p1(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Enter Team Name : ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           ser = textBox1.Text;
            bool cht = true;
            for (int i = 0; i < 20; i++)
            {

                if (ct_array[i].team_name == ser)
                {
                    store = "Team Name : ";
                    store += ct_array[i].team_name;
                    store += "\nTeam Captain : ";
                    store += ct_array[i].Team_Captain;
                    store += "\nTeam Coach : ";
                    store += ct_array[i].Team_Coach;
                    store += "\nICC Ranking : ";
                    store += ct_array[i].ICC_ranking;
                    store += "\nTotal Matches Lost : ";
                    store += ct_array[i].Total_matches_lost;
                    store += "\nTotal Matches Won : ";
                    store += ct_array[i].Total_matches_won;
                    store += "\n  ";
                    store += "";
                    cht = false;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (ct_array[i].team_name == ser)
                {
                    for (int p = 0; p < 11; p++)
                    {
                        pstore += "Player # ";
                        int t = p;
                        t++;
                        pstore += t;
                        pstore += "\n";
                        pstore += "Name : ";
                        pstore += ct_array[i].obj[p].name;
                        pstore += "\nShirt : ";
                        pstore += ct_array[i].obj[p].shrit;
                        pstore += "\nRanking : ";
                        pstore += ct_array[i].obj[p].ranking;
                        pstore += "\nAverage : ";
                        pstore += ct_array[i].obj[p].average;
                        pstore += "\nTotal Wickets : ";
                        pstore += ct_array[i].obj[p].total_wickets;
                        pstore += "\nTotal Runs : ";
                        pstore += ct_array[i].obj[p].total_runs;
                        pstore += "\nMatches Played : ";
                        pstore += ct_array[i].obj[p].match_played;
                        pstore += "\n";
                    }
                }
            }
            label2.Text = pstore;
            label4.Text = store;
            if (cht == true)
                MessageBox.Show("Team does not exist");
            else
                MessageBox.Show("done");
        }
    }
    
}
