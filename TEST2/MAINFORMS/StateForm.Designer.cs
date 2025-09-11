namespace TEST2
{
    partial class StateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateForm));
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            listBox1 = new System.Windows.Forms.ListBox();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            Close_button1 = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            выборПросмотраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            button7 = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            имяФамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            техподдержкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выходИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Close_button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(button7);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(933, 519);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel4.Location = new System.Drawing.Point(168, 134);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(765, 385);
            panel4.TabIndex = 12;
            panel4.Paint += panel4_Paint;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "123", "12", "3", "123", "123", "123", "123", "123", "12", "3", "123", "12", "312", "312", "3", "123" });
            listBox1.Location = new System.Drawing.Point(0, 172);
            listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(164, 319);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(0, 134);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(164, 38);
            panel3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label2.Location = new System.Drawing.Point(0, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 20);
            label2.TabIndex = 0;
            label2.Text = "Список датчиков";
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = System.Drawing.SystemColors.Control;
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            button4.Location = new System.Drawing.Point(362, 76);
            button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(572, 59);
            button4.TabIndex = 8;
            button4.Text = "Ошибки и неисправности(0)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(0, 76);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(362, 59);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(48, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(210, 24);
            label1.TabIndex = 0;
            label1.Text = "НАЗВАНИЕ ОБЪЕКТА";
            label1.Click += label1_Click;
            // 
            // Close_button1
            // 
            Close_button1.AutoSize = true;
            Close_button1.BackColor = System.Drawing.SystemColors.ControlDark;
            Close_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            Close_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            Close_button1.Location = new System.Drawing.Point(916, 0);
            Close_button1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Close_button1.Name = "Close_button1";
            Close_button1.Size = new System.Drawing.Size(15, 13);
            Close_button1.TabIndex = 6;
            Close_button1.Text = "X";
            Close_button1.Click += Close_button1_Click;
            // 
            // button5
            // 
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            button5.Location = new System.Drawing.Point(467, 0);
            button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(396, 78);
            button5.TabIndex = 2;
            button5.Text = "Связь и заявки";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = System.Windows.Forms.Cursors.No;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(467, 78);
            button1.TabIndex = 1;
            button1.Text = "Состояние объекта";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { выборПросмотраToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 495);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(933, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // выборПросмотраToolStripMenuItem
            // 
            выборПросмотраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { проектToolStripMenuItem, списокToolStripMenuItem });
            выборПросмотраToolStripMenuItem.Name = "выборПросмотраToolStripMenuItem";
            выборПросмотраToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            выборПросмотраToolStripMenuItem.Text = "Выбор просмотра";
            // 
            // проектToolStripMenuItem
            // 
            проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            проектToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            проектToolStripMenuItem.Text = "Проект";
            // 
            // списокToolStripMenuItem
            // 
            списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            списокToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            списокToolStripMenuItem.Text = "Список";
            списокToolStripMenuItem.Click += списокToolStripMenuItem_Click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.MenuBar;
            button7.ContextMenuStrip = contextMenuStrip1;
            button7.Image = Properties.Resources._1564534_customer_man_user_account_profile_icon__1_1;
            button7.Location = new System.Drawing.Point(860, 0);
            button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(74, 78);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            button7.MouseUp += button7_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { имяФамилияToolStripMenuItem, техподдержкаToolStripMenuItem, выходИзАккаунтаToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(176, 70);
            // 
            // имяФамилияToolStripMenuItem
            // 
            имяФамилияToolStripMenuItem.Name = "имяФамилияToolStripMenuItem";
            имяФамилияToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            имяФамилияToolStripMenuItem.Text = "Имя фамилия";
            // 
            // техподдержкаToolStripMenuItem
            // 
            техподдержкаToolStripMenuItem.Name = "техподдержкаToolStripMenuItem";
            техподдержкаToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            техподдержкаToolStripMenuItem.Text = "Тех.поддержка";
            техподдержкаToolStripMenuItem.Click += техподдержкаToolStripMenuItem_Click;
            // 
            // выходИзАккаунтаToolStripMenuItem
            // 
            выходИзАккаунтаToolStripMenuItem.Name = "выходИзАккаунтаToolStripMenuItem";
            выходИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            выходИзАккаунтаToolStripMenuItem.Text = "Выход из аккаунта";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            richTextBox1.Location = new System.Drawing.Point(815, 76);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(119, 71);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "Главная\nИмя/Фамилия\nТех.Поддержка\nВыход из аккаунта";
            richTextBox1.Visible = false;
            // 
            // StateForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "StateForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "StateForm_spisok";
            Load += StateForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Close_button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборПросмотраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem имяФамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техподдержкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}