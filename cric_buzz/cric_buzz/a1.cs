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
using System.Media;
namespace cric_buzz
{
    
    public partial class a1 : Form
    {
        public  SoundPlayer so;
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public int count = 0;
        int tcount = 0;
        int tpcount = 0;
        int mcount = 0;
        public a1(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
            so = new SoundPlayer("s.wav");
            //////////////////////// reading from file ///////////////////////
            String path = Environment.CurrentDirectory + "/" + "player.txt";
            //using (StreamReader file = new StreamReader(path))
            //{
            //    string ln;
            //    int i = 0;
            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        cp_array[i].name = ln;
            //        ln = file.ReadLine();
            //        cp_array[i].shrit = ln;
            //        ln = file.ReadLine();
            //        cp_array[i].total_runs = ln;
            //        ln = file.ReadLine();
            //        cp_array[i].total_wickets = ln;
            //        ln = file.ReadLine();
            //        cp_array[i].ranking = ln;
            //        ln = file.ReadLine();
            //        cp_array[i].average = ln;
            //        ln = file.ReadLine();
            //        cp_array[i].match_played = ln;
            //        i++;
            //       count = i;
            //    }
            //    file.Close();
            //}
              path = Environment.CurrentDirectory + "/" + "team.txt";
            using (StreamReader fil = new StreamReader(path))
            {
                string ln;
                int x = 0;
                while ((ln = fil.ReadLine()) != null)
                {
                    ct_array[x].team_name=ln;
                    ln = fil.ReadLine();
                    ct_array[x].Team_Captain = ln;
                    ln = fil.ReadLine();
                    ct_array[x].Team_Coach = ln;
                    ln = fil.ReadLine();
                    ct_array[x].Total_matches_lost = ln;
                    ln = fil.ReadLine();
                    ct_array[x].Total_matches_won = ln;
                    ln = fil.ReadLine();
                    ct_array[x].ICC_ranking= ln;
                    x++;
                    for (int p = 0; p < 6; p++)
                    {
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].name = ln;
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].shrit = ln;
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].total_runs = ln;
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].total_wickets = ln;
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].ranking = ln;
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].average = ln;
                        ln = fil.ReadLine();
                        ct_array[x].obj[p].match_played = ln;
                    }
                }
                tcount = x;
                fil.Close();
            }
            path = Environment.CurrentDirectory + "/" + "match.txt";    
            using (StreamReader fi = new StreamReader(path))
            {
                string ln;
                int i = 0;
                while ((ln = fi.ReadLine()) != null)
                {
                    cm_array[i].Team1=ln;
                    ln = fi.ReadLine();
                    cm_array[i].Team2 = ln;
                    ln = fi.ReadLine();
                    cm_array[i].Venue = ln;
                    ln = fi.ReadLine();
                    cm_array[i].Date = ln;
                    ln = fi.ReadLine();
                    cm_array[i].Match_type = ln;
                    ln = fi.ReadLine();
                    cm_array[i].Match_status = ln;
                    i++;
                }
                mcount = i;
                fi.Close();
            }
        }
        public void a1_Load(object sender, EventArgs e)
        {
            button15.Hide();
            button16.Hide();
            button13.Hide();
            button5.Hide();
            button12.Hide();
            label8.Hide();
            button11.Hide();
            button10.Hide();
            button4.Hide();
            button9.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
        }
      public void button1_Click(object sender, EventArgs e)
        {
            so.Play();
            button17.Hide();
            cp_array[count].add_player(this);
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            so.Play();
            // Controls.Clear();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text)|| String.IsNullOrEmpty(textBox3.Text)|| String.IsNullOrEmpty(textBox4.Text)|| String.IsNullOrEmpty(textBox5.Text)|| String.IsNullOrEmpty(textBox6.Text)|| String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show(" plz fill all boxes in in apropiate form ");
            }
            else
            {
               
                label8.Text = count.ToString();
                cp_array[count].name = textBox1.Text;
                cp_array[count].shrit = textBox2.Text;
                cp_array[count].average = textBox3.Text;
                cp_array[count].ranking = textBox4.Text;
                cp_array[count].total_runs = textBox5.Text;
                cp_array[count].match_played = textBox6.Text;
                cp_array[count].total_wickets = textBox7.Text;
                /* button7.Hide();
                 l
                 label2.Hide();
                 label3.Hide();
                 label4.Hide();
                 label5.Hide();
                 label6.Hide();
                 label7.Hide();*/
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
               // button16.Text = "";
                label8.Hide();
                MessageBox.Show(" successfullyt saved");
                count++;
            }
        }
        public void label4_Click(object sender, EventArgs e)
        {
        }

        public void button8_Click(object sender, EventArgs e)
        {
            so.Play();
            admin_login ob = new admin_login(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();
        }

        public void button9_Click(object sender, EventArgs e)
        {
            so.Play();
            button17.Show();
            button14.Show();
            button15.Hide();
            button16.Hide();
            button13.Hide();
            button5.Hide();
            label8.Show();
            button12.Hide();
            button11.Hide();
            button10.Hide();
            button4.Hide();
            button9.Hide();
            button8.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            //button5.Show();
            button6.Show();
            button7.Show();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            label8.Hide();
        }

        public void label8_Click(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
            so.Play();
            button17.Hide();
            ct_array[tcount].add_team(this);
            int tmp = tpcount;
            tmp++;
            string t = "player # ";
            label8.Text = t + tmp.ToString();
            //label1.Text = "team";

        }

        public void button10_Click(object sender, EventArgs e)
        {
            so.Play();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show(" plz fill all boxes in in apropiate form ");
            }
            else
            {
                ct_array[tcount].team_name = textBox1.Text;
                ct_array[tcount].ICC_ranking = textBox2.Text;
                ct_array[tcount].Total_matches_won = textBox4.Text;
                ct_array[tcount].Total_matches_lost = textBox3.Text;
                ct_array[tcount].Team_Captain = textBox5.Text;
                ct_array[tcount].Team_Coach = textBox6.Text;
                tpcount = 0;
                tcount++;
                ///////////
               // button10.Hide();
                button7.Hide();
                //label1.Hide();
                //label2.Hide();
                //label3.Hide();
                //label4.Hide();
                //label5.Hide();
                //label6.Hide();
                //label7.Hide();
                //textBox1.Hide();
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                textBox5.Text="";
                textBox6.Text="";
                textBox7.Text="";
                button16.Text="";
                label8.Hide();
                MessageBox.Show("saved");

            }
        }

        public void button11_Click(object sender, EventArgs e)
        {
            so.Play();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show(" plz fill all boxes in in apropiate form ");
            }
            else
            {
                ct_array[tcount].obj[tpcount].name = textBox1.Text;
                ct_array[tcount].obj[tpcount].shrit = textBox2.Text;
                ct_array[tcount].obj[tpcount].average = textBox3.Text;
                ct_array[tcount].obj[tpcount].ranking = textBox4.Text;
                ct_array[tcount].obj[tpcount].total_runs = textBox5.Text;
                ct_array[tcount].obj[tpcount].match_played = textBox6.Text;
                ct_array[tcount].obj[tpcount].total_wickets = textBox7.Text;
                tpcount++;
            }
            if (tpcount > 5)
            {
                label8.Hide();
                label1.Text = "Team Name";
                label2.Text = "ICC ranking";
                label3.Text = "Matches Lost";
                label4.Text = "Matches Won";
                label5.Text = "Captain";
                label6.Text = "Coach";
                label7.Hide();
                textBox7.Hide();
                button11.Hide();
                button10.Show();
            }

            int tmp = tpcount;
            tmp++;
            string t = "player # ";
            label8.Text = t + tmp.ToString();
        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void button12_Click(object sender, EventArgs e)
        {

            search_player ob = new search_player(cp_array, ct_array, cm_array);

            ob.Show();
        }


        public void label9_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            so.Play();
            button17.Hide();
            //////shedule ////////////////
            cm_array[mcount].shedule_match(this);
        }
        public void button12_Click_1(object sender, EventArgs e)
        {
            so.Play();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show(" plz fill all boxes in in apropiate form ");
            }
            else
            {
                cm_array[mcount].Team1 = textBox1.Text;
                cm_array[mcount].Team2 = textBox2.Text;
                cm_array[mcount].Date = textBox3.Text;
                cm_array[mcount].Venue = textBox4.Text;
                cm_array[mcount].Match_type = textBox5.Text;
                cm_array[mcount].Umpires = textBox6.Text;
                cm_array[mcount].Match_status = textBox7.Text;
                button7.Hide();
                //label1.Hide();
                //label2.Hide();
                //label3.Hide();
                //label4.Hide();
                //label5.Hide();
                //label6.Hide();
                //label7.Hide();
                //textBox1.Hide();
                textBox2.Text="";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                button16.Hide();
                label8.Hide();
                //button12.Hide();
                MessageBox.Show(" successfullyt saved");
                mcount++;
            }
        }
        public void button7_Click(object sender, EventArgs e)
        {
            so.Play();
            button17.Hide();
            /////////////////////
            cp_array[count].remove_player(this);
        }
        string tmp;
        public void button5_Click(object sender, EventArgs e)
        {
            so.Play();
            bool ch = true;
            tmp = textBox1.Text;
            for (int i = 0; i < 20; i++)
            {
                if (cp_array[i].name == tmp)
                {
                    button7.Show();
                    cp_array[i].name = "";
                    cp_array[i].ranking = "";
                    cp_array[i].shrit = "";
                    cp_array[i].total_runs = "";
                    cp_array[i].total_wickets = "";
                    cp_array[i].match_played = "";
                    cp_array[i].average = "";
                    ch = false;
                }
            }
            if (ch == true)
            {
                textBox1.Hide();
                label1.Hide();
                button5.Hide();
                MessageBox.Show("user does not exits ");
            }
            else
            {
                button5.Hide();
                textBox1.Hide();
                label1.Hide();
                MessageBox.Show("removed successfully ");
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            so.Play();
            button17.Hide();
            ct_array[tcount].remove_team(this);
        }

        public void button13_Click(object sender, EventArgs e)
        {
            so.Play();
            bool cht = true;
            string tm;
            tm = textBox1.Text;
            for (int i = 0; i < 20; i++)
            {
                if (ct_array[i].team_name == tm)
                {
                    ct_array[i].team_name = "";
                    ct_array[i].Team_Coach = "";
                    ct_array[i].Team_Captain = "";
                    ct_array[i].ICC_ranking = "";
                    ct_array[i].Total_matches_lost = "";
                    ct_array[i].Total_matches_won = "";
                    cht = false;
                }
            }
            if (cht == true)
            {
                textBox1.Hide();
                label1.Hide();
                button13.Hide();
                MessageBox.Show("team does not exist");
            }
            else
            {
                textBox1.Hide();
                label1.Hide();
                button13.Hide();
                MessageBox.Show("removed");
            }
        }

        public void label9_Click_1(object sender, EventArgs e)
        {

        }

        public void label9_Click_2(object sender, EventArgs e)
        {

        }

        public void button14_Click(object sender, EventArgs e)
        {
            //    string tl;
            //    tl = cp_array[0].name;
            //    tl += cp_array[1].name;
            //    label9.Text = tl;
            //}

        }

        public void button14_Click_1(object sender, EventArgs e)
        {
            so.Play();
            button17.Hide();
            cp_array[count].update_player(this);
            //////////////////////////////////
         
        }
        string tp;
        bool chp = true;
        public void button15_Click(object sender, EventArgs e)
        {
            so.Play();
            button15.Hide();
            button16.Show();
            tp = textBox1.Text;
            //    tmp = textBox1.Text;
            for (int i = 0; i < 20; i++)
            {
                if (cp_array[i].name == tp)
                {
                    label8.Text = " Enter info to update ";
                    label8.Show();
                    label1.Text = "Player Name";
                    label2.Text = "Shirt Number";
                    label3.Text = "Average Score";
                    label4.Text = "Ranking";
                    label5.Text = "Total Runs";
                    label6.Text = "Matches Played";
                    label7.Text = "Total Wickets";
                    button7.Show();
                    label1.Show();
                    label2.Show();
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label7.Show();
                    textBox1.Show();
                    textBox2.Show();
                    textBox3.Show();
                    textBox4.Show();
                    textBox5.Show();
                    textBox6.Show();
                    textBox7.Show();
                    chp = false;
                }
            }
            if (chp == true)
            {
                button16.Hide();
                button15.Hide();
                textBox1.Hide();
                label1.Hide();
                MessageBox.Show("user does not exits ");
            }
        }

        public void button16_Click(object sender, EventArgs e)
        {
            so.Play();
            if (chp == true)
            {
                button16.Hide();
                button15.Hide();
                MessageBox.Show("user does not exits ");

            }
            else
            {
                cp_array[count].name = textBox1.Text;
                cp_array[count].shrit = textBox2.Text;
                cp_array[count].average = textBox3.Text;
                cp_array[count].ranking = textBox4.Text;
                cp_array[count].total_runs = textBox5.Text;
                cp_array[count].match_played = textBox6.Text;
                cp_array[count].total_wickets = textBox7.Text;
                button7.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                textBox7.Hide();
                button16.Hide();
                label8.Hide();
                MessageBox.Show("updated successfully ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            so.Play();
            String path = Environment.CurrentDirectory + "/" + "player.txt";
            TextWriter player = File.CreateText(Environment.CurrentDirectory + "/" + "player.txt");
            for (int i = 0; i < 20; i++)
            {
                if (cp_array[i].name != null)
                {
                    player.WriteLine(cp_array[i].name);
                    player.WriteLine(cp_array[i].shrit);
                    player.WriteLine(cp_array[i].total_runs);
                    player.WriteLine(cp_array[i].total_wickets);
                    player.WriteLine(cp_array[i].ranking);
                    player.WriteLine(cp_array[i].average);
                    player.WriteLine(cp_array[i].match_played);
                }
            }
            player.Close();
            path = Environment.CurrentDirectory + "/" + "team.txt";
            TextWriter teem = File.CreateText(Environment.CurrentDirectory + "/" + "team.txt");
            for (int i = 0; i < 20; i++)
            {
                if (ct_array[i].team_name != null)
                {
                    teem.WriteLine(ct_array[i].team_name);
                    teem.WriteLine(ct_array[i].Team_Captain);
                    teem.WriteLine(ct_array[i].Team_Coach);
                    teem.WriteLine(ct_array[i].Total_matches_lost);
                    teem.WriteLine(ct_array[i].Total_matches_won);
                    teem.WriteLine(ct_array[i].ICC_ranking);
                    for (int p = 0; p < 6; p++)
                    {
                        teem.WriteLine(ct_array[i].obj[p].name);
                        teem.WriteLine(ct_array[i].obj[p].shrit);
                        teem.WriteLine(ct_array[i].obj[p].total_runs);
                        teem.WriteLine(ct_array[i].obj[p].total_wickets);
                        teem.WriteLine(ct_array[i].obj[p].ranking);
                        teem.WriteLine(ct_array[i].obj[p].average);
                        teem.WriteLine(ct_array[i].obj[p].match_played);
                    }
                }
            }
            teem.Close();
            path = Environment.CurrentDirectory + "/" + "match.txt";
            TextWriter match = File.CreateText(Environment.CurrentDirectory + "/" + "match.txt");
            for (int i = 0; i < 20; i++)
            {
                if (cm_array[i].Team1 != null)
                {
                    match.WriteLine(cm_array[i].Team1);
                    match.WriteLine(cm_array[i].Team2);
                    match.WriteLine(cm_array[i].Venue);
                    match.WriteLine(cm_array[i].Date);
                    match.WriteLine(cm_array[i].Match_type);
                    match.WriteLine(cm_array[i].Match_status);
                }
            }
            match.Close();
            MessageBox.Show("  :) successfully saved ");
        }
    }
}