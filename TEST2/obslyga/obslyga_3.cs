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
    public partial class obslyga_3 : Form
    {
        public obslyga_3()
        {
            InitializeComponent();
            richTextBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            State_Form_obslyga3 state_Form_Obslyga3 = new State_Form_obslyga3();
            state_Form_Obslyga3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connection_Form_Obslyga3 connection_Form_Obslyga3 = new Connection_Form_Obslyga3();
            connection_Form_Obslyga3.Show();
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Просто показываем RichTextBox
                richTextBox1.Visible = true;
                richTextBox1.BringToFront();
                richTextBox1.Focus();
            }
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}
