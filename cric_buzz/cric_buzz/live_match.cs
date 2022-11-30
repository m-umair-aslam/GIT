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
    public partial class live_match : Form
    {
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public live_match(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            p1 ob = new p1(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
