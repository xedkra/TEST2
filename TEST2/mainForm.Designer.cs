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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_button1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.имяФамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техподдержкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.Close_button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 554);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Close_button1
            // 
            this.Close_button1.AutoSize = true;
            this.Close_button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Close_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_button1.Location = new System.Drawing.Point(1047, 0);
            this.Close_button1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close_button1.Name = "Close_button1";
            this.Close_button1.Size = new System.Drawing.Size(18, 17);
            this.Close_button1.TabIndex = 5;
            this.Close_button1.Text = "X";
            this.Close_button1.Click += new System.EventHandler(this.Close_button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(533, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "Связь и заявки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(533, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Состояние объекта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.Image = global::TEST2.Properties.Resources._1564534_customer_man_user_account_profile_icon__1_1;
            this.button5.Location = new System.Drawing.Point(983, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 84);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имяФамилияToolStripMenuItem,
            this.техподдержкаToolStripMenuItem,
            this.выходИзАккаунтаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 76);
            // 
            // имяФамилияToolStripMenuItem
            // 
            this.имяФамилияToolStripMenuItem.Name = "имяФамилияToolStripMenuItem";
            this.имяФамилияToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.имяФамилияToolStripMenuItem.Text = "Имя фамилия";
            // 
            // техподдержкаToolStripMenuItem
            // 
            this.техподдержкаToolStripMenuItem.Name = "техподдержкаToolStripMenuItem";
            this.техподдержкаToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.техподдержкаToolStripMenuItem.Text = "Тех.поддержка";
            this.техподдержкаToolStripMenuItem.Click += new System.EventHandler(this.техподдержкаToolStripMenuItem_Click);
            // 
            // выходИзАккаунтаToolStripMenuItem
            // 
            this.выходИзАккаунтаToolStripMenuItem.Name = "выходИзАккаунтаToolStripMenuItem";
            this.выходИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.выходИзАккаунтаToolStripMenuItem.Text = "Выход из аккаунта";
            this.выходИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.выходToolStipMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

