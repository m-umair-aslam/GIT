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
    public partial class login : Form
    {
        public SoundPlayer so;
        player[] cp_array;
        team[] ct_array;
        match[] cm_array;
        public login(player[] pp_array, team[] pt_array, match[] pm_array)
        {
            cp_array = pp_array;
            ct_array = pt_array;
            cm_array = pm_array;
            InitializeComponent();
            so = new SoundPlayer("s.wav");
        }
        string id, pass;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            so.Play();
            p1 ob = new p1(cp_array,ct_array,cm_array);
            if ("umair" == id&& pass == "123")
            {
                ob.Show();
                this.Hide();

            }
            else
            {
                
              MessageBox.Show("wrong ");  
            }
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            so.Play();
            main_page ob = new main_page(cp_array,ct_array,cm_array);
            ob.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = textBox1.Text;
        }
    }
}
