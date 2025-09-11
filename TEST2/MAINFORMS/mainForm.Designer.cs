namespace TEST2
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            Close_button1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            имяФамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            техподдержкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выходИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(934, 519);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(Close_button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(934, 519);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
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
            Close_button1.TabIndex = 5;
            Close_button1.Text = "X";
            Close_button1.Click += Close_button1_Click;
            // 
            // button2
            // 
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            button2.Location = new System.Drawing.Point(466, 0);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(396, 79);
            button2.TabIndex = 1;
            button2.Text = "Связь и заявки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(466, 79);
            button1.TabIndex = 0;
            button1.Text = "Состояние объекта";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.MenuBar;
            button5.ContextMenuStrip = contextMenuStrip1;
            button5.Image = Properties.Resources._1564534_customer_man_user_account_profile_icon__1_1;
            button5.Location = new System.Drawing.Point(860, 0);
            button5.Margin = new System.Windows.Forms.Padding(4);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(74, 79);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseUp += button5_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { имяФамилияToolStripMenuItem, техподдержкаToolStripMenuItem, выходИзАккаунтаToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(176, 70);
            // 
            // имяФамилияToolStripMenuItem
            // 
            имяФамилияToolStripMenuItem.Name = "имяФамилияToolStripMenuItem";
            имяФамилияToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            имяФамилияToolStripMenuItem.Text = "Имя фамилия";
            имяФамилияToolStripMenuItem.Click += имяФамилияToolStripMenuItem_Click;
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
            выходИзАккаунтаToolStripMenuItem.Click += выходToolStipMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            richTextBox1.Location = new System.Drawing.Point(815, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(119, 71);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Главная\nИмя/Фамилия\nТех.Поддержка\nВыход из аккаунта";
            richTextBox1.Visible = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 519);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "mainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mainform";
            Load += mainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close_button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem имяФамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem техподдержкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

