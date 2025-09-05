using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TEST2
{
    // ваня привет
    public partial class Vxod : Form
    {

        private string connectionString = "server=localhost;userid=root;password=Fgtkmcby2308;database=KPB";

        public Vxod()
        {
            InitializeComponent();
            this.pass.AutoSize = false;
            this.pass.Size = new Size(this.pass.Size.Width, 30);
        }

        private void Close_button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
                
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = login.Text;
            String passUser = pass.Text;

            int userId = AuthenticateUser(loginUser, passUser);
            if (userId == -1)
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var (userInfo, accessLevel) = GetUserInfo(userId);
            if (userInfo != null && accessLevel != -1)
            {
                MessageBox.Show($"Добро пожаловать!\n\n{userInfo}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form formToOpen = null;

                switch (accessLevel)
                {
                    case 1:
                        formToOpen = new mainForm();
                        break;
                    case 2:
                        formToOpen = new director_2();
                        break;
                    case 3:
                        formToOpen = new sisADMIN_3();
                        break;
                    default:
                        MessageBox.Show("Неизвестный уровень доступа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                formToOpen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не удалось получить информацию о пользователе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int AuthenticateUser(string login, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                            SELECT u.id
                            FROM logpas lp
                            JOIN users u ON u.Login_password_ID = lp.id
                            WHERE lp.login=@login AND lp.password=@password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            return Convert.ToInt32(result);
                        else
                            return -1;
                    }
                }
                catch (MySqlException)
                {
                    return -1;
                }
            }
        }
        private (string userInfo, int accessLevel) GetUserInfo(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    u.id AS user_id,
                    u.Firstname,
                    u.Lastname,
                    u.Number,
                    o.Organizations AS organization_name,
                    j.JobTitle AS job_title,
                    l.LVL AS access_level
                FROM 
                    users u
                JOIN 
                    lvl_access l ON u.LvL_ID = l.id
                JOIN 
                    jobtitle j ON l.JobTitle_ID = j.id
                JOIN 
                    organizations o ON j.ORG_ID = o.id
                WHERE 
                    u.id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string info = $"ID: {reader["user_id"]}\n" +
                                              $"Имя: {reader["Firstname"]}\n" +
                                              $"Фамилия: {reader["Lastname"]}\n" +
                                              $"Номер: {reader["Number"]}\n" +
                                              $"Организация: {reader["organization_name"]}\n" +
                                              $"Должность: {reader["job_title"]}\n" +
                                              $"Уровень доступа: {reader["access_level"]}";

                                int lvl = Convert.ToInt32(reader["access_level"]);
                                return (info, lvl);
                            }
                            else
                                return (null, -1);
                        }
                    }
                }
                catch (MySqlException)
                {
                    return (null, -1);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Если ничего делать не нужно, оставьте пустым
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
