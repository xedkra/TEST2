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
using Microsoft.EntityFrameworkCore;
using TEST2.Models;



namespace TEST2
{
    public partial class Vxod : Form
    {
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
            // хуйня пустая пусть будет
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
            using (var context = new AppDbContext())
            {
                try
                {
                    var user = context.Users
                        .Include(u => u.LoginPassword)
                        .FirstOrDefault(u => u.LoginPassword.login == login &&
                                             u.LoginPassword.password == password);

                    return user?.Id ?? -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при аутентификации: {ex.Message}");
                    return -1;
                }
            }
        }

        private (string userInfo, int accessLevel) GetUserInfo(int userId)
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    var user = context.Users
                        .Include(u => u.AccessLevel)
                            .ThenInclude(al => al.JobTitle)
                                .ThenInclude(jt => jt.Organization)
                        .FirstOrDefault(u => u.Id == userId);

                    if (user != null)
                    {
                        string info = $"ID: {user.Id}\n" +
                                      $"Имя: {user.Firstname}\n" +
                                      $"Фамилия: {user.Lastname}\n" +
                                      $"Номер: {user.Number}\n" +
                                      $"Организация: {user.AccessLevel.JobTitle.Organization.Organizations}\n" +
                                      $"Должность: {user.AccessLevel.JobTitle.JobTitles}\n" +
                                      $"Уровень доступа: {user.AccessLevel.LVL}";

                        return (info, user.AccessLevel.LVL);
                    }
                    else
                    {
                        return (null, -1);
                    }
                }
                catch (Exception)
                {
                    return (null, -1);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Метод для обработки события Paint второй панели
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Обработчик клика по label1
        }

        // Добавляем остальные методы, которые могли быть в Designer.cs
        private void login_TextChanged(object sender, EventArgs e)
        {
            // Обработчик изменения текста в поле login
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            // Обработчик изменения текста в поле pass
        }

        private void Vxod_Load(object sender, EventArgs e)
        {
            // Обработчик загрузки формы
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Обработчик клика по label2
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Обработчик клика по label3
        }
    }
}