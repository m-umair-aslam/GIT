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
    public partial class match_search : Form
    {
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public match_search(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
        }
       public  string store,store2,store3;

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            p1 ob = new p1(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        int t = 0;
        string dstore;
        private void match_search_Load(object sender, EventArgs e)
        {
           for (int i=0;i<20;i++)
            {
                if (cm_array[i].Match_type == store|| cm_array[i].Match_type == store2 || cm_array[i].Match_type == store3 )
                {
                    dstore += "\n\n";
                    dstore += "_______________________";
                    dstore += "\n\n";
                    dstore += "Match # ";
                    t++;
                    dstore += t;
                    dstore += "\n\n";
                    dstore += "Team # 1 : ";
                    dstore += cm_array[i].Team1;
                    dstore += "\nTeam # 2 : ";
                    dstore += cm_array[i].Team2;
                    dstore += "\nVenue : ";
                    dstore += cm_array[i].Venue;
                    dstore += "\nDate : ";
                    dstore += cm_array[i].Date;
                    dstore += "\nMatch Status : ";
                    dstore += cm_array[i].Match_status;
                    dstore += "\nUmpire  : ";
                    dstore += cm_array[i].Umpires;
                    dstore += "\nMatches Type : ";
                    dstore += cm_array[i].Match_type;
                }
            }
            label1.Text = dstore;
        }
    }
}
