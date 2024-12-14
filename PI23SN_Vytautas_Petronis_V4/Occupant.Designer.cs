namespace KPS
{
    partial class Occupant
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label LabelAssignedHome;
        private System.Windows.Forms.DataGridView DisplayOccupantHouseServicesAndPrices;
        private System.Windows.Forms.Button LogOutButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Occupant));
            LabelAssignedHome = new Label();
            DisplayOccupantHouseServicesAndPrices = new DataGridView();
            LogOutButton = new Button();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)DisplayOccupantHouseServicesAndPrices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelAssignedHome
            // 
            LabelAssignedHome.AutoSize = true;
            LabelAssignedHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAssignedHome.Location = new Point(163, 3);
            LabelAssignedHome.Name = "LabelAssignedHome";
            LabelAssignedHome.Size = new Size(74, 23);
            LabelAssignedHome.TabIndex = 0;
            LabelAssignedHome.Text = "Namas2";
            // 
            // DisplayOccupantHouseServicesAndPrices
            // 
            DisplayOccupantHouseServicesAndPrices.AllowUserToAddRows = false;
            DisplayOccupantHouseServicesAndPrices.AllowUserToDeleteRows = false;
            DisplayOccupantHouseServicesAndPrices.AllowUserToResizeColumns = false;
            DisplayOccupantHouseServicesAndPrices.AllowUserToResizeRows = false;
            DisplayOccupantHouseServicesAndPrices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayOccupantHouseServicesAndPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisplayOccupantHouseServicesAndPrices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayOccupantHouseServicesAndPrices.Location = new Point(6, 29);
            DisplayOccupantHouseServicesAndPrices.Name = "DisplayOccupantHouseServicesAndPrices";
            DisplayOccupantHouseServicesAndPrices.ReadOnly = true;
            DisplayOccupantHouseServicesAndPrices.RowHeadersWidth = 51;
            DisplayOccupantHouseServicesAndPrices.Size = new Size(393, 178);
            DisplayOccupantHouseServicesAndPrices.TabIndex = 1;
            // 
            // LogOutButton
            // 
            LogOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogOutButton.Location = new Point(143, 484);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(148, 30);
            LogOutButton.TabIndex = 2;
            LogOutButton.Text = "Atsijungti";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
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
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DisplayOccupantHouseServicesAndPrices);
            tabPage1.Controls.Add(LabelAssignedHome);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(405, 211);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Namo paslaugų kainų informacija";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Occupant
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(439, 524);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(LogOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Occupant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gyventojo langas - Komunalinių Paslaugų Sistema";
            ((System.ComponentModel.ISupportInitialize)DisplayOccupantHouseServicesAndPrices).EndInit();
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
