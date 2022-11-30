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
    public partial class search_player : Form
    {
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public search_player(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
        }
        
        private void add_player_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        string tmp;

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                tmp = tmp + cp_array[i].name;
                tmp = tmp + "\n";
                tmp = tmp + cp_array[i].total_wickets;
                tmp = tmp + "\n";
            }
            label1.Text = tmp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p1 obj = new p1(cp_array, ct_array, cm_array);
            obj.Show();
            this.Hide();
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        string ser, store;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /////// player search /////////
            ser = textBox1.Text;
            bool cht = true;
            for (int i = 0; i < 20; i++)
            {
                if (cp_array[i].name == ser)
                 {
                    store = "Name : ";
                    store +=cp_array[i].name;
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
                    cht = false;
                }
            }
            label2.Text = store ;
            if (cht == true)
                MessageBox.Show("Player does not exist");
           else
                MessageBox.Show("done");
        }
    }
}
