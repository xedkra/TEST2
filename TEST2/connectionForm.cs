using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST2
{
    public partial class connectionForm : Form
    {
        public connectionForm()
        {
            InitializeComponent();
        }

        private void connectionForm_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StateForm stateform = new StateForm();
            stateform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            tex_podd user_Data = new tex_podd();
            user_Data.Show();
        }

        private void Close_button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(button5, e.Location);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void техподдержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tex_podd tex_Podd = new tex_podd();
            tex_Podd.Show();
        }

        private void техподдержкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            tex_podd tex_Podd = new tex_podd();
            tex_Podd.Show();
        }
    }
}
