using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cric_buzz
{
    public class player
    {
        public string name;
        public string shrit;
        public string average;
        public string ranking;
        public string total_runs;
        public string match_played;
        public string total_wickets;
        public player()
        {

        }
        public void add_player(a1 obj)
        {
            string tmp;
            tmp = obj.textBox1.Text;
            //ob.button1_Click(null,null);
            obj.button14.Hide();
            obj.label1.Text = "Player Number";
            obj.label2.Text = "Shirt Number";
            obj.label3.Text = "Average Score";
            obj.label4.Text = "Ranking";
            obj.label5.Text = "Total Runs";
            obj.label6.Text = "Matches Played";
            obj.label7.Text = "Total Wickets";
            obj.button4.Show();
            obj.button9.Show();
            obj.button8.Hide();
            obj.button1.Hide();
            obj.button2.Hide();
            obj.button3.Hide();
            //button5.Hide();
            obj.button6.Hide();
            obj.button7.Hide();
            obj.label1.Show();
            obj.label2.Show();
            obj.label3.Show();
            obj.label4.Show();
            obj.label5.Show();
            obj.label6.Show();
            obj.label7.Show();
            obj.textBox1.Show();
            obj.textBox2.Show();
            obj.textBox3.Show();
            obj.textBox4.Show();
            obj.textBox5.Show();
            obj.textBox6.Show();
            obj.textBox7.Show();
        }
        public void remove_player(a1 obj)
        {       
            obj.button14.Hide();
            obj.label1.Text = "Enter Player Name";
            obj.button5.Show();
            obj.button4.Show();
            obj.button9.Show();
            obj.button8.Hide();
            obj.button1.Hide();
            obj.button2.Hide();
            obj.button3.Hide();
            obj.button4.Hide();
            obj.button6.Hide();
            obj.button7.Hide();
            obj.label1.Show();
            obj.textBox1.Show();
        }
        public void update_player(a1 obj)
        {
            obj.button14.Hide();
            obj.label1.Text = "Enter Player Name";
            obj.button15.Show();
            obj.button5.Hide();
            obj.button4.Hide();
            obj.button9.Show();
            obj.button8.Hide();
            obj.button1.Hide();
            obj.button2.Hide();
            obj.button3.Hide();
            obj.button4.Hide();
            obj.button6.Hide();
            obj.button7.Hide();
            obj.label1.Show();
            obj.textBox1.Show();
        }
        public void searcch_player(search_player obj)
        {
            obj.Show();
        }
        public void print_all_player(all_player ob)
        {
            ob.Show();
        }

    }
}