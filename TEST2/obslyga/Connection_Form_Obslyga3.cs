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
    public partial class Connection_Form_Obslyga3 : Form
    {
        //ПРОФИЛЬ
        private class ClickableArea
        {
            public int Start { get; set; }
            public int Length { get; set; }
            public Action Action { get; set; }
            public string Text { get; set; }
        }

        private List<ClickableArea> clickableAreas = new List<ClickableArea>();

        public Connection_Form_Obslyga3()
        {
            InitializeComponent();
            InitializeConnectionTab();
            InitializeRichTextBox();
            richTextBox1.Visible = false;
        }
        private void InitializeRichTextBox()
        {
            richTextBox1.DetectUrls = false;
            richTextBox1.ReadOnly = true;
            richTextBox1.Cursor = Cursors.Arrow;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.MouseClick += richTextBox1_MouseClick;
            richTextBox1.MouseLeave += richTextBox1_MouseLeave;

            // Очищаем и добавляем текст меню
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            // Добавляем кликабельные области (БЕЗ ЦВЕТА)
            AddClickableArea("Главная",
                 () =>
                 {
                     this.Hide();

                     // Создаем и показываем главную форму
                     obslyga_3 obslyga_3 = new obslyga_3();
                     obslyga_3.Show();
                 });

            AddClickableArea("Имя/Фамилия",
                () => ShowForm(new ProfileForm()));

            AddClickableArea("Тех.Поддержка",
                () => ShowForm(new tex_podd()));

            AddClickableArea("Выход из аккаунта",
                () => Logout());
        }

        private void AddClickableArea(string text, Action action)
        {
            int start = richTextBox1.TextLength;

            richTextBox1.AppendText(text + "\n");
            int length = text.Length;

            // Форматируем текст (без изменения цвета)
            richTextBox1.Select(start, length);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.SelectionBackColor = Color.Transparent;

            clickableAreas.Add(new ClickableArea
            {
                Start = start,
                Length = length,
                Action = action,
                Text = text
            });

            richTextBox1.Select(0, 0);
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int charIndex = richTextBox1.GetCharIndexFromPosition(e.Location);

            // Сбрасываем все выделения
            richTextBox1.Select(0, richTextBox1.TextLength);
            richTextBox1.SelectionBackColor = Color.Transparent;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.Select(0, 0);

            // Проверяем наведение на кликабельные области
            foreach (var area in clickableAreas)
            {
                if (charIndex >= area.Start && charIndex < area.Start + area.Length)
                {
                    richTextBox1.Cursor = Cursors.Hand;

                    // Подсвечиваем только нужную область
                    richTextBox1.Select(area.Start, area.Length);
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
                    richTextBox1.SelectionBackColor = SystemColors.ControlLight;
                    break;
                }
                else
                {
                    richTextBox1.Cursor = Cursors.Default;
                }
            }

            richTextBox1.Select(0, 0);
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            // При уходе мыши сбрасываем все выделения
            richTextBox1.Select(0, richTextBox1.TextLength);
            richTextBox1.SelectionBackColor = Color.Transparent;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            richTextBox1.Select(0, 0);
            richTextBox1.Cursor = Cursors.Default;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int charIndex = richTextBox1.GetCharIndexFromPosition(e.Location);

            foreach (var area in clickableAreas)
            {
                if (charIndex >= area.Start && charIndex < area.Start + area.Length)
                {
                    // Визуальная обратная связь
                    richTextBox1.Select(area.Start, area.Length);
                    richTextBox1.SelectionBackColor = Color.LightBlue;
                    richTextBox1.Refresh();

                    // Действие
                    area.Action.Invoke();

                    // Сбрасываем выделение
                    System.Threading.Thread.Sleep(150);
                    richTextBox1.Select(0, 0);
                    return;
                }
            }
        }

        private void ShowForm(Form form)
        {
            form.Show();
            form.Focus();
        }

        private void Logout()
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?",
                "Выход из аккаунта",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Выход выполнен успешно!", "Выход",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            // Просто показываем RichTextBox
            richTextBox1.Visible = true;
            richTextBox1.BringToFront();
            richTextBox1.Focus();
        }
        //ПРОФИЛЬ КОНЧИЛСЯ


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            State_Form_obslyga3 state_Form_Obslyga3 = new State_Form_obslyga3();
            state_Form_Obslyga3.Show();
            this.Hide();
        }

        private void richTextBox1_MouseLeave_1(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
        //ЛИСT СОТРУДНИКОВ
        private void InitializeConnectionTab()
        {
            // Создаем вкладку
            TabPage connectionTab = new TabPage("Связь");
            tabControl1.TabPages.Add(connectionTab);

            // Создаем разделитель
            SplitContainer splitContainer = new SplitContainer();
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Orientation = Orientation.Horizontal;

            // Верхняя панель - сотрудники на объекте
            GroupBox onSiteGroup = new GroupBox();
            onSiteGroup.Text = "Сотрудники на объекте сегодня";
            onSiteGroup.Dock = DockStyle.Fill;

            ListView onSiteListView = new ListView();
            onSiteListView.View = View.Details;
            onSiteListView.Dock = DockStyle.Fill;
            onSiteListView.Columns.AddRange(new ColumnHeader[] {
            new ColumnHeader() { Text = "ФИО", Width = 150 },
            new ColumnHeader() { Text = "Должность", Width = 120 },
            new ColumnHeader() { Text = "Телефон", Width = 110 }
        });

            // Нижняя панель - доступные сотрудники
            GroupBox availableGroup = new GroupBox();
            availableGroup.Text = "Доступные сотрудники обслуживающей компании";
            availableGroup.Dock = DockStyle.Fill;

            ListView availableListView = new ListView();
            availableListView.View = View.Details;
            availableListView.Dock = DockStyle.Fill;
            availableListView.Columns.AddRange(new ColumnHeader[] {
            new ColumnHeader() { Text = "ФИО", Width = 150 },
            new ColumnHeader() { Text = "Должность", Width = 120 },
            new ColumnHeader() { Text = "Телефон", Width = 110 },
            new ColumnHeader() { Text = "Статус", Width = 80 }
        });

            // Добавляем элементы
            onSiteGroup.Controls.Add(onSiteListView);
            availableGroup.Controls.Add(availableListView);

            splitContainer.Panel1.Controls.Add(onSiteGroup);
            splitContainer.Panel2.Controls.Add(availableGroup);

            connectionTab.Controls.Add(splitContainer);

            // Загрузка данных
            LoadEmployeesData(onSiteListView, availableListView);
        }

        private void LoadEmployeesData(ListView onSiteList, ListView availableList)
        {
            // Пример данных - сотрудники на объекте
            onSiteList.Items.AddRange(new ListViewItem[] {
            new ListViewItem(new string[] { "Иванов И.И.", "Инженер", "+7-999-123-45-67" }),
            new ListViewItem(new string[] { "Петров П.П.", "Техник", "+7-999-765-43-21" })
        });

            // Пример данных - доступные сотрудники
            availableList.Items.AddRange(new ListViewItem[] {
            new ListViewItem(new string[] { "Сидоров С.С.", "Менеджер", "+7-999-111-22-33", "Доступен" }),
            new ListViewItem(new string[] { "Кузнецов К.К.", "Специалист", "+7-999-444-55-66", "Занят" })
        });
        }
        //ЛИСТ СОТРУДНИКОВ КОНЧИЛСЯ
    }
}

