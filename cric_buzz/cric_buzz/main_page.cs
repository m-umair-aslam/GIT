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
    public partial class main_page : Form
    {
        public SoundPlayer so;
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public main_page(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
            so = new SoundPlayer("s.wav");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void main_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            so.Play();
            admin_login ob = new admin_login(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            so.Play();
            login ob = new login(cp_array, ct_array, cm_array);
            ob.Show();
            this.Hide();

        }
    }
}
