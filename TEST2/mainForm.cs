using System.Windows.Forms;

namespace TEST2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            StateForm stateform = new StateForm();
            stateform.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            connectionForm connectionForm = new connectionForm();
            connectionForm.Show();
        }

      
        

        private void mainForm_Load(object sender, System.EventArgs e)
        {
            mainForm mainForm = new mainForm();
        }


        

        private void Close_button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, System.EventArgs e)
        {

        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(button5, e.Location);
            }
        }

        private void техподдержкаToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            tex_podd tex_Podd = new tex_podd();
            tex_Podd.Show();
        }
    }
}
