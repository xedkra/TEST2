namespace TEST2
{
    partial class Vxod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vxod));
            panel1 = new System.Windows.Forms.Panel();
            buttonLogin = new System.Windows.Forms.Button();
            pass = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            login = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            Close_button1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(login);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(580, 692);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            buttonLogin.Location = new System.Drawing.Point(172, 554);
            buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(240, 66);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pass
            // 
            pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            pass.Location = new System.Drawing.Point(172, 399);
            pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pass.Name = "pass";
            pass.Size = new System.Drawing.Size(327, 40);
            pass.TabIndex = 4;
            pass.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2849796_lock_security_multimedia_close_protection_icon__4_;
            pictureBox2.Location = new System.Drawing.Point(84, 385);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(48, 48);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            login.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            login.Location = new System.Drawing.Point(172, 288);
            login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            login.Multiline = true;
            login.Name = "login";
            login.Size = new System.Drawing.Size(327, 44);
            login.TabIndex = 2;
            login.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1564534_customer_man_user_account_profile_icon__1_1;
            pictureBox1.Location = new System.Drawing.Point(84, 274);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(48, 48);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            panel2.Controls.Add(Close_button1);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(580, 151);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // Close_button1
            // 
            Close_button1.AutoSize = true;
            Close_button1.BackColor = System.Drawing.SystemColors.ControlDark;
            Close_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            Close_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            Close_button1.Location = new System.Drawing.Point(560, 0);
            Close_button1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Close_button1.Name = "Close_button1";
            Close_button1.Size = new System.Drawing.Size(18, 17);
            Close_button1.TabIndex = 7;
            Close_button1.Text = "X";
            Close_button1.Click += Close_button1_Click;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(137, 32);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(336, 89);
            label1.TabIndex = 0;
            label1.Text = "ВХОД";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            label1.MouseMove += label1_MouseMove;
            // 
            // Vxod
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(580, 692);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Vxod";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Vxod";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close_button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonLogin;
    }
}