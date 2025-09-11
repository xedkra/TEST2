using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TEST2
{
    public partial class State_Form_obslyga3 : Form
    {
        private class ClickableArea
        {
            public int Start { get; set; }
            public int Length { get; set; }
            public Action Action { get; set; }
            public string Text { get; set; }
        }

        private List<ClickableArea> clickableAreas = new List<ClickableArea>();

        public State_Form_obslyga3()
        {
            InitializeComponent();
            InitializeRichTextBox();
            richTextBox1.Visible = false;

        }

        private void InitializeRichTextBox()
        {
            richTextBox1.DetectUrls = false;
            richTextBox1.ReadOnly = true;
            richTextBox1.Cursor = Cursors.Arrow;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.BackColor = SystemColors.ButtonHighlight;
            richTextBox1.Select(0, richTextBox1.TextLength);
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Select(0, 0);
            richTextBox1.MouseClick += richTextBox1_MouseClick;
            richTextBox1.MouseLeave += richTextBox1_MouseLeave;

            // Очищаем и добавляем текст меню
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Microsoft Sans", 11, FontStyle.Regular);

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

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Close_button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void button7_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Просто показываем RichTextBox
                richTextBox1.Visible = true;
                richTextBox1.BringToFront();
                richTextBox1.Focus();
            }
        }

        private void richTextBox1_MouseLeave_1(object sender, EventArgs e)
        {
           richTextBox1.Visible=false;
        }
    }
}
