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
    public partial class admin_login : Form
    {
        public SoundPlayer so;
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public admin_login(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
            so = new SoundPlayer("s.wav");
        }

        private void admin_login_Load(object sender, EventArgs e)
        {
           
        }
        string ad_id,ad_pass;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ad_pass = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            so.Play();
            if(ad_id=="admin"&&ad_pass=="000")
            {
                a1 ob = new a1(cp_array, ct_array, cm_array);
                ob.Show();
                this.Hide();

            }
            else
            {                
             MessageBox.Show(" wrong password");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            so.Play();
            main_page ob = new main_page(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad_id = textBox1.Text;
            
        }
    }
}
