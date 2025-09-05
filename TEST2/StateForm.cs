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
    public partial class StateForm : Form
    {
        public StateForm()
        {
            InitializeComponent();
        }

        private void StateForm_Load(object sender, EventArgs e)
        {

        }

   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            connectionForm connectionForm = new connectionForm();
            connectionForm.Show();
        }


        private void Close_button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(button7, e.Location);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void техподдержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tex_podd tex_Podd = new tex_podd();
            tex_Podd.Show();
        }
    }
}
