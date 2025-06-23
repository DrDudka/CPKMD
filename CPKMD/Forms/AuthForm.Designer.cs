namespace CPKMD
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new MaskedTextBox();
            label6 = new Label();
            buttonAuth = new Button();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(buttonAuth);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 488);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(146, 81);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(154, 64);
            label1.TabIndex = 14;
            label1.Text = "ГБОУДПОРО\r\n\"ЦПК\"";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(63, 81);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(70, 285);
            txtPassword.Margin = new Padding(0);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 33);
            txtPassword.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.DarkTurquoise;
            label6.Font = new Font("Times New Roman", 14F);
            label6.Location = new Point(146, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 12;
            label6.Text = "Авторизация";
            // 
            // buttonAuth
            // 
            buttonAuth.Anchor = AnchorStyles.None;
            buttonAuth.BackColor = Color.DarkTurquoise;
            buttonAuth.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAuth.Location = new Point(107, 341);
            buttonAuth.Margin = new Padding(0);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(191, 50);
            buttonAuth.TabIndex = 2;
            buttonAuth.Text = "Войти";
            buttonAuth.UseVisualStyleBackColor = false;
            buttonAuth.Click += buttonAuth_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtUsername.Location = new Point(70, 207);
            txtUsername.Margin = new Padding(0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 33);
            txtUsername.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(64, 256);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 1;
            label5.Text = "Пароль";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(64, 178);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 0;
            label4.Text = "Логин";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkTurquoise;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(384, 47);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 488);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox txtPassword;
        private Label label6;
        private Button buttonAuth;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
    }
}
