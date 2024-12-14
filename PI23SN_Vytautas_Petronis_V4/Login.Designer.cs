namespace KPS
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Button ButtonLogin;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            TextUsername = new TextBox();
            TextPassword = new TextBox();
            ButtonLogin = new Button();
            PictureLogo = new PictureBox();
            LabelUsername = new Label();
            LabelPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureLogo).BeginInit();
            SuspendLayout();
            // 
            // TextUsername
            // 
            TextUsername.Location = new Point(81, 298);
            TextUsername.Margin = new Padding(2);
            TextUsername.Name = "TextUsername";
            TextUsername.Size = new Size(269, 27);
            TextUsername.TabIndex = 0;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(81, 356);
            TextPassword.Margin = new Padding(2);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '*';
            TextPassword.Size = new Size(269, 27);
            TextPassword.TabIndex = 1;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogin.Location = new Point(81, 400);
            ButtonLogin.Margin = new Padding(2);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(269, 39);
            ButtonLogin.TabIndex = 2;
            ButtonLogin.Text = "Prisijungti";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += btnLogin_Click;
            // 
            // PictureLogo
            // 
            PictureLogo.Image = (Image)resources.GetObject("PictureLogo.Image");
            PictureLogo.Location = new Point(12, 12);
            PictureLogo.Name = "PictureLogo";
            PictureLogo.Size = new Size(413, 203);
            PictureLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureLogo.TabIndex = 6;
            PictureLogo.TabStop = false;
            // 
            // LabelUsername
            // 
            LabelUsername.AutoSize = true;
            LabelUsername.Location = new Point(81, 276);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(174, 20);
            LabelUsername.TabIndex = 8;
            LabelUsername.Text = "Įvesti prisijungimo vardą:";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(81, 334);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(274, 20);
            LabelPassword.TabIndex = 9;
            LabelPassword.Text = "Įvesti prisijungimo pavardę (slaptažodį):";
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(439, 524);
            Controls.Add(LabelUsername);
            Controls.Add(LabelPassword);
            Controls.Add(PictureLogo);
            Controls.Add(TextUsername);
            Controls.Add(TextPassword);
            Controls.Add(ButtonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prisijungimo langas - Komunalinių Paslaugų Sistema";
            ((System.ComponentModel.ISupportInitialize)PictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox PictureLogo;
        private Label LabelUsername;
        private Label LabelPassword;
    }
}
