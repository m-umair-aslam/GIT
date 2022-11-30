using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace cric_buzz
{
    public partial class p1 : Form
    {
        public SoundPlayer so;
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public p1(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
            so = new SoundPlayer("s.wav");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
        }
        private void p1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            videos ob = new videos(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            news ob = new news(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
        }

        private void searchTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            so.Play();
            login ob = new login(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();
        }

        private void singleSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            search_player ob = new search_player(cp_array, ct_array, cm_array);
            cp_array[0].searcch_player(ob);
            this.Hide();

        }

        private void searchPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            search_team ob = new search_team(cp_array,ct_array,cm_array);
            ct_array[0].search_team(ob);
            this.Hide();
        }

        private void showAllPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            all_player ob = new all_player(cp_array, ct_array, cm_array);
            this.Hide();
            cp_array[0].print_all_player( ob);
        }

        private void showAllTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            all_team ob = new all_team(cp_array, ct_array, cm_array);
            ct_array[0].display_all_team(ob);
            this.Hide();
        }

        private void oDIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            so.Play();
            match_search ob = new match_search(cp_array,ct_array,cm_array);
            this.Hide();
            cm_array[0].search_odi_match(ob);
        }

        private void t20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            so.Play();
            match_search ob = new match_search(cp_array, ct_array, cm_array);
            this.Hide();
            cm_array[0].search_T20_match(ob);
        }

        private void tESTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            so.Play();
            match_search ob = new match_search(cp_array, ct_array, cm_array);
            this.Hide();
            cm_array[0].search_Test_match(ob);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            System.Windows.Forms.Application.Exit();
        }

        private void liveMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            live_match ob = new live_match(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        private void upcomingMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
            upcoming ob = new upcoming(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
        }

        private void sheduledMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            so.Play();
        }
    }
}
