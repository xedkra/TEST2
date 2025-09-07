using System.Windows.Forms;
using TEST2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TEST2
{
    public partial class mainForm : Form
    {
        private User currentUser;

        public mainForm()
        {
            InitializeComponent();
        }

        public mainForm(string login) : this()
        {
            currentUser = GetUserByLogin(login);
            UpdateUserNameMenu();
        }
        private User GetUserByLogin(string login)
        {
            using (var context = new AppDbContext())
            {
                return context.Users
                    .Include(u => u.LoginPassword)
                    .Include(u => u.AccessLevel)
                        .ThenInclude(a => a.JobTitle)
                            .ThenInclude(j => j.Organization)
                    .FirstOrDefault(u => u.LoginPassword.login == login);
            }
        }
        private void UpdateUserNameMenu()
        {
            if (currentUser != null)
            {
                имяФамилияToolStripMenuItem.Text = $"{currentUser.Firstname} {currentUser.Lastname}";
            }
            else
            {
                имяФамилияToolStripMenuItem.Text = "Гость";
            }
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

        private void выходToolStipMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Vxod vxod = new Vxod();
            vxod.Show();
        }

        private void имяФамилияToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
