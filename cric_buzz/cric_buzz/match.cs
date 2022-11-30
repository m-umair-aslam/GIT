using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cric_buzz
{
    public class match
    {
        public string Team1;
        public string Team2;
        public string Date;
        public string Venue;
        public string Match_type;
        public string Umpires;
        public string Match_status;
        public void shedule_match(a1 ob)
        {
            ob.button14.Hide();
            ob.button12.Show();
            ob.label1.Text = "Team 1";
            ob.label2.Text = "Team 2";
            ob.label3.Text = "date";
            ob.label4.Text = "venue";
            ob.label5.Text = "Match Type";
            ob.label6.Text = "Empire";
            ob.label7.Text = "Match Status";
            ob.button4.Hide();
            ob.button9.Show();
            ob.button8.Hide();
            ob.button1.Hide();
            ob.button2.Hide();
            ob.button3.Hide();
            //button5.Hide();
            ob.button6.Hide();
            ob.button7.Hide();
            ob.label1.Show();
            ob.label2.Show();
            ob.label3.Show();
            ob.label4.Show();
            ob.label5.Show();
            ob.label6.Show();
            ob.label7.Show();
            ob.textBox1.Show();
            ob.textBox2.Show();
            ob.textBox3.Show();
            ob.textBox4.Show();
            ob.textBox5.Show();
            ob.textBox6.Show();
            ob.textBox7.Show();
        }
        public void search_odi_match(match_search ob)
        {
            ob.store = "ODI";
            ob.store2 = "odi";
            ob.store3 = "Odi";
            ob.Show();
        }
        public void search_T20_match(match_search ob)
        {
            ob.store = "T20";
            ob.store2 = "t20";
            ob.store3 = "t20";
            ob.Show();
        }
        public void search_Test_match(match_search ob)
        {
            ob.store = "TEST";
            ob.store2 = "test";
            ob.store3 = "Test";
            ob.Show();
        }
    }
    
}
