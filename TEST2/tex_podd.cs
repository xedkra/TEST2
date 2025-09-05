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
    public partial class tex_podd : Form
    {
        public tex_podd()
        {
            InitializeComponent();
        }

        private void user_data_Load(object sender, EventArgs e)
        {

        }

   
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StateForm stateform = new StateForm();
            stateform.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            connectionForm connectionForm = new connectionForm();
            connectionForm.Show();
        }

        private void Close_button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

 

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(button5, e.Location );
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
