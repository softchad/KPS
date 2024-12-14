namespace KPS
{
    partial class Manager
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox ComboChooseServiceToUpdatePrice;
        private System.Windows.Forms.TextBox TextUpdatedServicePrice;
        private System.Windows.Forms.Button ButtonUpdatePriceForService;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label LabelAssignedHome;
        private System.Windows.Forms.Label LabelChooseService;
        private System.Windows.Forms.Label LabelTypeServicePriceUpdate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            ComboChooseServiceToUpdatePrice = new ComboBox();
            TextUpdatedServicePrice = new TextBox();
            ButtonUpdatePriceForService = new Button();
            LogOutButton = new Button();
            LabelAssignedHome = new Label();
            LabelChooseService = new Label();
            LabelTypeServicePriceUpdate = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // ComboChooseServiceToUpdatePrice
            // 
            ComboChooseServiceToUpdatePrice.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseServiceToUpdatePrice.FormattingEnabled = true;
            ComboChooseServiceToUpdatePrice.Location = new Point(16, 80);
            ComboChooseServiceToUpdatePrice.Name = "ComboChooseServiceToUpdatePrice";
            ComboChooseServiceToUpdatePrice.Size = new Size(172, 28);
            ComboChooseServiceToUpdatePrice.TabIndex = 1;
            // 
            // TextUpdatedServicePrice
            // 
            TextUpdatedServicePrice.Location = new Point(220, 80);
            TextUpdatedServicePrice.Name = "TextUpdatedServicePrice";
            TextUpdatedServicePrice.Size = new Size(172, 27);
            TextUpdatedServicePrice.TabIndex = 2;
            // 
            // ButtonUpdatePriceForService
            // 
            ButtonUpdatePriceForService.Location = new Point(16, 140);
            ButtonUpdatePriceForService.Name = "ButtonUpdatePriceForService";
            ButtonUpdatePriceForService.Size = new Size(376, 30);
            ButtonUpdatePriceForService.TabIndex = 3;
            ButtonUpdatePriceForService.Text = "Keisti paslaugos kainą";
            ButtonUpdatePriceForService.UseVisualStyleBackColor = true;
            ButtonUpdatePriceForService.Click += btnUpdatePrice_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Location = new Point(143, 484);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(150, 30);
            LogOutButton.TabIndex = 4;
            LogOutButton.Text = "Atsijungti";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // LabelAssignedHome
            // 
            LabelAssignedHome.AutoSize = true;
            LabelAssignedHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAssignedHome.Location = new Point(163, 3);
            LabelAssignedHome.Name = "LabelAssignedHome";
            LabelAssignedHome.Size = new Size(74, 23);
            LabelAssignedHome.TabIndex = 5;
            LabelAssignedHome.Text = "Namas2";
            // 
            // LabelChooseService
            // 
            LabelChooseService.AutoSize = true;
            LabelChooseService.Location = new Point(16, 57);
            LabelChooseService.Name = "LabelChooseService";
            LabelChooseService.Size = new Size(134, 20);
            LabelChooseService.TabIndex = 6;
            LabelChooseService.Text = "Pasirinkti paslaugą:";
            // 
            // LabelTypeServicePriceUpdate
            // 
            LabelTypeServicePriceUpdate.AutoSize = true;
            LabelTypeServicePriceUpdate.Location = new Point(220, 57);
            LabelTypeServicePriceUpdate.Name = "LabelTypeServicePriceUpdate";
            LabelTypeServicePriceUpdate.Size = new Size(125, 20);
            LabelTypeServicePriceUpdate.TabIndex = 7;
            LabelTypeServicePriceUpdate.Text = "Įvesti naują kainą:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.ItemSize = new Size(406, 25);
            tabControl1.Location = new Point(12, 230);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(413, 244);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ComboChooseServiceToUpdatePrice);
            tabPage1.Controls.Add(ButtonUpdatePriceForService);
            tabPage1.Controls.Add(LabelAssignedHome);
            tabPage1.Controls.Add(LabelTypeServicePriceUpdate);
            tabPage1.Controls.Add(TextUpdatedServicePrice);
            tabPage1.Controls.Add(LabelChooseService);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(405, 211);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Namo paslaugų valdymas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            ClientSize = new Size(439, 524);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(LogOutButton);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Manager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vadybininko langas - Komunalinių Paslaugų Sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}
