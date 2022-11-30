using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cric_buzz
{
    public class team
    {
        public player[] obj = new player[11];
        public string ICC_ranking;
        public string team_name;
        public string Total_matches_won;
        public string Total_matches_lost;
        public string Team_Captain;
        public string Team_Coach;
        public void add_team(a1 obj)
        {
            obj.button14.Hide();
            obj.label1.Text = "Player Number";
            obj.label2.Text = "Shirt Number";
            obj.label3.Text = "Average Score";
            obj.label4.Text = "Ranking";
            obj.label5.Text = "Total Runs";
            obj.label6.Text = "Matches Played";
            obj.label7.Text = "Total Wickets";
            obj.label8.Show();
            obj.button11.Show();
            obj.button10.Hide();
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
        public void remove_team(a1 obj)
        {
            obj.button14.Hide();
            obj.button13.Show();
            obj.label1.Text = "Enter Team Name";
            obj.button5.Hide();
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
        public void search_team(search_team obj)
        {
            obj.Show();
        }
        public void display_all_team(all_team obj)
        {
            obj.Show();
        }

    }
}
