namespace KPS
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            LogOutButton = new Button();
            PictureBigLogo = new PictureBox();
            tabControl1 = new TabControl();
            EditHomestabPage1 = new TabPage();
            ComboChooseHouseToDelete = new ComboBox();
            TextChooseName1 = new Label();
            TextNewHomeName = new TextBox();
            ButtonCreateHome = new Button();
            ButtonDeleteChosenHome = new Button();
            LabelNewHomeName = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            ComboChooseOccupantToRemoveHome = new ComboBox();
            ComboChooseHouseToRemoveOccupant = new ComboBox();
            ComboChooseOccupantToDelete = new ComboBox();
            ComboHomeToAddOccupantTo = new ComboBox();
            LabelChooseHome3 = new Label();
            LabelOccupant1 = new Label();
            ComboChooseOccupantToAddHomeTo = new ComboBox();
            LabelOccupantName = new Label();
            TextOccupantName = new TextBox();
            LabelOccupantPassword = new Label();
            TextOccupantPassword = new TextBox();
            ButtonCreateNewOccupant = new Button();
            ButtonDeleteOccupant = new Button();
            ButtonAssignOccupant = new Button();
            ButtonRemoveOccupantFromHome = new Button();
            EditServicestabPage1 = new TabPage();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            TextServicePriceForHome = new TextBox();
            ComboHomesAddServiceTo = new ComboBox();
            ComboRemoveHouseFromService = new ComboBox();
            ComboChangePriceForHouseService = new ComboBox();
            ComboChangePriceForServiceHouse = new ComboBox();
            ComboServiceAddHouseTo = new ComboBox();
            ComboRemoveServiceFromHouse = new ComboBox();
            ComboDeleteServices1 = new ComboBox();
            TextServicePriceForHouseServiceUpdate = new TextBox();
            TextNewServiceName = new TextBox();
            ButtonCreateNewService = new Button();
            ButtonDeleteService = new Button();
            ButtonAssignServiceToHome = new Button();
            ButtonRemoveServiceFromHome = new Button();
            ButtonUpdatePrice = new Button();
            LabelChooseServices6 = new Label();
            LabelServicePrice = new Label();
            LabelNewServiceName = new Label();
            EditManagerstabPage2 = new TabPage();
            label8 = new Label();
            ComboChooseManagerToDelete = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            ComboChooseManagerToRemoveHome = new ComboBox();
            ComboChooseHomeToRemoveManager = new ComboBox();
            label2 = new Label();
            ComboChooseHomeToAddManager = new ComboBox();
            LabelManagers = new Label();
            ComboChooseManagerForAHome = new ComboBox();
            ButtonAssignManagerToHome = new Button();
            ButtonRemoveManagerFromHome = new Button();
            LabelNewManagerName = new Label();
            TextNewManagerName = new TextBox();
            LabelNewManagerPassword = new Label();
            TextNewManagerPassword = new TextBox();
            ButtonCreateManager = new Button();
            ButtonDeleteManager = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBigLogo).BeginInit();
            tabControl1.SuspendLayout();
            EditHomestabPage1.SuspendLayout();
            EditServicestabPage1.SuspendLayout();
            EditManagerstabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // LogOutButton
            // 
            LogOutButton.Location = new Point(818, 634);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(148, 30);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Atsijungti";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // PictureBigLogo
            // 
            PictureBigLogo.Image = (Image)resources.GetObject("PictureBigLogo.Image");
            PictureBigLogo.Location = new Point(12, 12);
            PictureBigLogo.Name = "PictureBigLogo";
            PictureBigLogo.Size = new Size(951, 150);
            PictureBigLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBigLogo.TabIndex = 7;
            PictureBigLogo.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EditHomestabPage1);
            tabControl1.Controls.Add(EditServicestabPage1);
            tabControl1.Controls.Add(EditManagerstabPage2);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(317, 27);
            tabControl1.Location = new Point(12, 168);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(958, 460);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // EditHomestabPage1
            // 
            EditHomestabPage1.Controls.Add(ComboChooseHouseToDelete);
            EditHomestabPage1.Controls.Add(TextChooseName1);
            EditHomestabPage1.Controls.Add(TextNewHomeName);
            EditHomestabPage1.Controls.Add(ButtonCreateHome);
            EditHomestabPage1.Controls.Add(ButtonDeleteChosenHome);
            EditHomestabPage1.Controls.Add(LabelNewHomeName);
            EditHomestabPage1.Controls.Add(label5);
            EditHomestabPage1.Controls.Add(label3);
            EditHomestabPage1.Controls.Add(label4);
            EditHomestabPage1.Controls.Add(ComboChooseOccupantToRemoveHome);
            EditHomestabPage1.Controls.Add(ComboChooseHouseToRemoveOccupant);
            EditHomestabPage1.Controls.Add(ComboChooseOccupantToDelete);
            EditHomestabPage1.Controls.Add(ComboHomeToAddOccupantTo);
            EditHomestabPage1.Controls.Add(LabelChooseHome3);
            EditHomestabPage1.Controls.Add(LabelOccupant1);
            EditHomestabPage1.Controls.Add(ComboChooseOccupantToAddHomeTo);
            EditHomestabPage1.Controls.Add(LabelOccupantName);
            EditHomestabPage1.Controls.Add(TextOccupantName);
            EditHomestabPage1.Controls.Add(LabelOccupantPassword);
            EditHomestabPage1.Controls.Add(TextOccupantPassword);
            EditHomestabPage1.Controls.Add(ButtonCreateNewOccupant);
            EditHomestabPage1.Controls.Add(ButtonDeleteOccupant);
            EditHomestabPage1.Controls.Add(ButtonAssignOccupant);
            EditHomestabPage1.Controls.Add(ButtonRemoveOccupantFromHome);
            EditHomestabPage1.Location = new Point(4, 31);
            EditHomestabPage1.Name = "EditHomestabPage1";
            EditHomestabPage1.Padding = new Padding(3);
            EditHomestabPage1.Size = new Size(950, 425);
            EditHomestabPage1.TabIndex = 0;
            EditHomestabPage1.Text = "Bendrijų valdymas";
            EditHomestabPage1.UseVisualStyleBackColor = true;
            // 
            // ComboChooseHouseToDelete
            // 
            ComboChooseHouseToDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseHouseToDelete.FormattingEnabled = true;
            ComboChooseHouseToDelete.Location = new Point(390, 231);
            ComboChooseHouseToDelete.Name = "ComboChooseHouseToDelete";
            ComboChooseHouseToDelete.Size = new Size(172, 28);
            ComboChooseHouseToDelete.TabIndex = 44;
            // 
            // TextChooseName1
            // 
            TextChooseName1.AutoSize = true;
            TextChooseName1.Location = new Point(388, 208);
            TextChooseName1.Name = "TextChooseName1";
            TextChooseName1.Size = new Size(111, 20);
            TextChooseName1.TabIndex = 43;
            TextChooseName1.Text = "Pasirinkti namą:";
            // 
            // TextNewHomeName
            // 
            TextNewHomeName.Location = new Point(390, 173);
            TextNewHomeName.Name = "TextNewHomeName";
            TextNewHomeName.Size = new Size(172, 27);
            TextNewHomeName.TabIndex = 39;
            // 
            // ButtonCreateHome
            // 
            ButtonCreateHome.Location = new Point(584, 171);
            ButtonCreateHome.Name = "ButtonCreateHome";
            ButtonCreateHome.Size = new Size(282, 30);
            ButtonCreateHome.TabIndex = 40;
            ButtonCreateHome.Text = "Sukurti naują namą";
            ButtonCreateHome.UseVisualStyleBackColor = true;
            ButtonCreateHome.Click += btnCreateHome_Click;
            // 
            // ButtonDeleteChosenHome
            // 
            ButtonDeleteChosenHome.Location = new Point(584, 229);
            ButtonDeleteChosenHome.Name = "ButtonDeleteChosenHome";
            ButtonDeleteChosenHome.Size = new Size(282, 30);
            ButtonDeleteChosenHome.TabIndex = 41;
            ButtonDeleteChosenHome.Text = "Ištrinti namą";
            ButtonDeleteChosenHome.UseVisualStyleBackColor = true;
            ButtonDeleteChosenHome.Click += btnDeleteHome_Click;
            // 
            // LabelNewHomeName
            // 
            LabelNewHomeName.AutoSize = true;
            LabelNewHomeName.Location = new Point(388, 150);
            LabelNewHomeName.Name = "LabelNewHomeName";
            LabelNewHomeName.Size = new Size(170, 20);
            LabelNewHomeName.TabIndex = 42;
            LabelNewHomeName.Text = "Įvesti namo pavadinimą:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 88);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 32;
            label5.Text = "Pasirinkti gyventoją:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 330);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 30;
            label3.Text = "Pasirinkti namą:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 330);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 31;
            label4.Text = "Pasirinkti gyventoją:";
            // 
            // ComboChooseOccupantToRemoveHome
            // 
            ComboChooseOccupantToRemoveHome.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseOccupantToRemoveHome.FormattingEnabled = true;
            ComboChooseOccupantToRemoveHome.Location = new Point(388, 353);
            ComboChooseOccupantToRemoveHome.Name = "ComboChooseOccupantToRemoveHome";
            ComboChooseOccupantToRemoveHome.Size = new Size(172, 28);
            ComboChooseOccupantToRemoveHome.TabIndex = 29;
            // 
            // ComboChooseHouseToRemoveOccupant
            // 
            ComboChooseHouseToRemoveOccupant.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseHouseToRemoveOccupant.FormattingEnabled = true;
            ComboChooseHouseToRemoveOccupant.Location = new Point(170, 353);
            ComboChooseHouseToRemoveOccupant.Name = "ComboChooseHouseToRemoveOccupant";
            ComboChooseHouseToRemoveOccupant.Size = new Size(172, 28);
            ComboChooseHouseToRemoveOccupant.TabIndex = 28;
            // 
            // ComboChooseOccupantToDelete
            // 
            ComboChooseOccupantToDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseOccupantToDelete.FormattingEnabled = true;
            ComboChooseOccupantToDelete.Location = new Point(388, 111);
            ComboChooseOccupantToDelete.Name = "ComboChooseOccupantToDelete";
            ComboChooseOccupantToDelete.Size = new Size(172, 28);
            ComboChooseOccupantToDelete.TabIndex = 27;
            // 
            // ComboHomeToAddOccupantTo
            // 
            ComboHomeToAddOccupantTo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboHomeToAddOccupantTo.FormattingEnabled = true;
            ComboHomeToAddOccupantTo.Location = new Point(169, 290);
            ComboHomeToAddOccupantTo.Name = "ComboHomeToAddOccupantTo";
            ComboHomeToAddOccupantTo.Size = new Size(172, 28);
            ComboHomeToAddOccupantTo.TabIndex = 26;
            // 
            // LabelChooseHome3
            // 
            LabelChooseHome3.AutoSize = true;
            LabelChooseHome3.Location = new Point(169, 267);
            LabelChooseHome3.Name = "LabelChooseHome3";
            LabelChooseHome3.Size = new Size(111, 20);
            LabelChooseHome3.TabIndex = 22;
            LabelChooseHome3.Text = "Pasirinkti namą:";
            // 
            // LabelOccupant1
            // 
            LabelOccupant1.AutoSize = true;
            LabelOccupant1.Location = new Point(388, 267);
            LabelOccupant1.Name = "LabelOccupant1";
            LabelOccupant1.Size = new Size(139, 20);
            LabelOccupant1.TabIndex = 23;
            LabelOccupant1.Text = "Pasirinkti gyventoją:";
            // 
            // ComboChooseOccupantToAddHomeTo
            // 
            ComboChooseOccupantToAddHomeTo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseOccupantToAddHomeTo.FormattingEnabled = true;
            ComboChooseOccupantToAddHomeTo.Location = new Point(388, 290);
            ComboChooseOccupantToAddHomeTo.Name = "ComboChooseOccupantToAddHomeTo";
            ComboChooseOccupantToAddHomeTo.Size = new Size(172, 28);
            ComboChooseOccupantToAddHomeTo.TabIndex = 14;
            // 
            // LabelOccupantName
            // 
            LabelOccupantName.AutoSize = true;
            LabelOccupantName.Location = new Point(87, 28);
            LabelOccupantName.Name = "LabelOccupantName";
            LabelOccupantName.Size = new Size(157, 20);
            LabelOccupantName.TabIndex = 24;
            LabelOccupantName.Text = "Įvesti gyventojo vardą:";
            // 
            // TextOccupantName
            // 
            TextOccupantName.Location = new Point(87, 51);
            TextOccupantName.Name = "TextOccupantName";
            TextOccupantName.Size = new Size(172, 27);
            TextOccupantName.TabIndex = 15;
            // 
            // LabelOccupantPassword
            // 
            LabelOccupantPassword.AutoSize = true;
            LabelOccupantPassword.Location = new Point(305, 28);
            LabelOccupantPassword.Name = "LabelOccupantPassword";
            LabelOccupantPassword.Size = new Size(257, 20);
            LabelOccupantPassword.TabIndex = 25;
            LabelOccupantPassword.Text = "Įvesti gyventojo pavardę (slaptažodį):";
            // 
            // TextOccupantPassword
            // 
            TextOccupantPassword.Location = new Point(305, 51);
            TextOccupantPassword.Name = "TextOccupantPassword";
            TextOccupantPassword.Size = new Size(257, 27);
            TextOccupantPassword.TabIndex = 16;
            // 
            // ButtonCreateNewOccupant
            // 
            ButtonCreateNewOccupant.Location = new Point(584, 49);
            ButtonCreateNewOccupant.Name = "ButtonCreateNewOccupant";
            ButtonCreateNewOccupant.Size = new Size(282, 30);
            ButtonCreateNewOccupant.TabIndex = 17;
            ButtonCreateNewOccupant.Text = "Sukurti naują gyventojo paskyrą";
            ButtonCreateNewOccupant.UseVisualStyleBackColor = true;
            ButtonCreateNewOccupant.Click += btnCreateResident_Click;
            // 
            // ButtonDeleteOccupant
            // 
            ButtonDeleteOccupant.Location = new Point(584, 109);
            ButtonDeleteOccupant.Name = "ButtonDeleteOccupant";
            ButtonDeleteOccupant.Size = new Size(282, 30);
            ButtonDeleteOccupant.TabIndex = 18;
            ButtonDeleteOccupant.Text = "Ištrinti gyventojo paskyrą";
            ButtonDeleteOccupant.UseVisualStyleBackColor = true;
            ButtonDeleteOccupant.Click += btnDeleteResident_Click;
            // 
            // ButtonAssignOccupant
            // 
            ButtonAssignOccupant.Location = new Point(584, 288);
            ButtonAssignOccupant.Name = "ButtonAssignOccupant";
            ButtonAssignOccupant.Size = new Size(282, 30);
            ButtonAssignOccupant.TabIndex = 19;
            ButtonAssignOccupant.Text = "Priskirti gyventoją prie namo";
            ButtonAssignOccupant.UseVisualStyleBackColor = true;
            ButtonAssignOccupant.Click += btnAssignResident_Click;
            // 
            // ButtonRemoveOccupantFromHome
            // 
            ButtonRemoveOccupantFromHome.Location = new Point(584, 351);
            ButtonRemoveOccupantFromHome.Name = "ButtonRemoveOccupantFromHome";
            ButtonRemoveOccupantFromHome.Size = new Size(282, 30);
            ButtonRemoveOccupantFromHome.TabIndex = 20;
            ButtonRemoveOccupantFromHome.Text = "Pašalinti gyventoją iš namo";
            ButtonRemoveOccupantFromHome.UseVisualStyleBackColor = true;
            ButtonRemoveOccupantFromHome.Click += btnRemoveResident_Click;
            // 
            // EditServicestabPage1
            // 
            EditServicestabPage1.Controls.Add(label16);
            EditServicestabPage1.Controls.Add(label15);
            EditServicestabPage1.Controls.Add(label14);
            EditServicestabPage1.Controls.Add(label13);
            EditServicestabPage1.Controls.Add(label12);
            EditServicestabPage1.Controls.Add(label11);
            EditServicestabPage1.Controls.Add(label10);
            EditServicestabPage1.Controls.Add(TextServicePriceForHome);
            EditServicestabPage1.Controls.Add(ComboHomesAddServiceTo);
            EditServicestabPage1.Controls.Add(ComboRemoveHouseFromService);
            EditServicestabPage1.Controls.Add(ComboChangePriceForHouseService);
            EditServicestabPage1.Controls.Add(ComboChangePriceForServiceHouse);
            EditServicestabPage1.Controls.Add(ComboServiceAddHouseTo);
            EditServicestabPage1.Controls.Add(ComboRemoveServiceFromHouse);
            EditServicestabPage1.Controls.Add(ComboDeleteServices1);
            EditServicestabPage1.Controls.Add(TextServicePriceForHouseServiceUpdate);
            EditServicestabPage1.Controls.Add(TextNewServiceName);
            EditServicestabPage1.Controls.Add(ButtonCreateNewService);
            EditServicestabPage1.Controls.Add(ButtonDeleteService);
            EditServicestabPage1.Controls.Add(ButtonAssignServiceToHome);
            EditServicestabPage1.Controls.Add(ButtonRemoveServiceFromHome);
            EditServicestabPage1.Controls.Add(ButtonUpdatePrice);
            EditServicestabPage1.Controls.Add(LabelChooseServices6);
            EditServicestabPage1.Controls.Add(LabelServicePrice);
            EditServicestabPage1.Controls.Add(LabelNewServiceName);
            EditServicestabPage1.Location = new Point(4, 31);
            EditServicestabPage1.Name = "EditServicestabPage1";
            EditServicestabPage1.Size = new Size(950, 425);
            EditServicestabPage1.TabIndex = 2;
            EditServicestabPage1.Text = "Paslaugų valdymas";
            EditServicestabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(241, 310);
            label16.Name = "label16";
            label16.Size = new Size(134, 20);
            label16.TabIndex = 54;
            label16.Text = "Pasirinkti paslaugą:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(437, 239);
            label15.Name = "label15";
            label15.Size = new Size(134, 20);
            label15.TabIndex = 53;
            label15.Text = "Pasirinkti paslaugą:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(241, 170);
            label14.Name = "label14";
            label14.Size = new Size(134, 20);
            label14.TabIndex = 52;
            label14.Text = "Pasirinkti paslaugą:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 172);
            label13.Name = "label13";
            label13.Size = new Size(111, 20);
            label13.TabIndex = 51;
            label13.Text = "Pasirinkti namą:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(241, 239);
            label12.Name = "label12";
            label12.Size = new Size(111, 20);
            label12.TabIndex = 50;
            label12.Text = "Pasirinkti namą:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 310);
            label11.Name = "label11";
            label11.Size = new Size(111, 20);
            label11.TabIndex = 49;
            label11.Text = "Pasirinkti namą:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(437, 172);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 48;
            label10.Text = "Įvesti kainą:";
            // 
            // TextServicePriceForHome
            // 
            TextServicePriceForHome.Location = new Point(437, 194);
            TextServicePriceForHome.Name = "TextServicePriceForHome";
            TextServicePriceForHome.Size = new Size(172, 27);
            TextServicePriceForHome.TabIndex = 46;
            // 
            // ComboHomesAddServiceTo
            // 
            ComboHomesAddServiceTo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboHomesAddServiceTo.FormattingEnabled = true;
            ComboHomesAddServiceTo.Location = new Point(54, 193);
            ComboHomesAddServiceTo.Name = "ComboHomesAddServiceTo";
            ComboHomesAddServiceTo.Size = new Size(172, 28);
            ComboHomesAddServiceTo.TabIndex = 44;
            // 
            // ComboRemoveHouseFromService
            // 
            ComboRemoveHouseFromService.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboRemoveHouseFromService.FormattingEnabled = true;
            ComboRemoveHouseFromService.Location = new Point(241, 261);
            ComboRemoveHouseFromService.Name = "ComboRemoveHouseFromService";
            ComboRemoveHouseFromService.Size = new Size(172, 28);
            ComboRemoveHouseFromService.TabIndex = 43;
            // 
            // ComboChangePriceForHouseService
            // 
            ComboChangePriceForHouseService.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChangePriceForHouseService.FormattingEnabled = true;
            ComboChangePriceForHouseService.Location = new Point(53, 331);
            ComboChangePriceForHouseService.Name = "ComboChangePriceForHouseService";
            ComboChangePriceForHouseService.Size = new Size(172, 28);
            ComboChangePriceForHouseService.TabIndex = 42;
            // 
            // ComboChangePriceForServiceHouse
            // 
            ComboChangePriceForServiceHouse.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChangePriceForServiceHouse.FormattingEnabled = true;
            ComboChangePriceForServiceHouse.Location = new Point(241, 331);
            ComboChangePriceForServiceHouse.Name = "ComboChangePriceForServiceHouse";
            ComboChangePriceForServiceHouse.Size = new Size(172, 28);
            ComboChangePriceForServiceHouse.TabIndex = 41;
            // 
            // ComboServiceAddHouseTo
            // 
            ComboServiceAddHouseTo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboServiceAddHouseTo.FormattingEnabled = true;
            ComboServiceAddHouseTo.Location = new Point(241, 193);
            ComboServiceAddHouseTo.Name = "ComboServiceAddHouseTo";
            ComboServiceAddHouseTo.Size = new Size(172, 28);
            ComboServiceAddHouseTo.TabIndex = 40;
            // 
            // ComboRemoveServiceFromHouse
            // 
            ComboRemoveServiceFromHouse.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboRemoveServiceFromHouse.FormattingEnabled = true;
            ComboRemoveServiceFromHouse.Location = new Point(437, 261);
            ComboRemoveServiceFromHouse.Name = "ComboRemoveServiceFromHouse";
            ComboRemoveServiceFromHouse.Size = new Size(172, 28);
            ComboRemoveServiceFromHouse.TabIndex = 39;
            // 
            // ComboDeleteServices1
            // 
            ComboDeleteServices1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDeleteServices1.FormattingEnabled = true;
            ComboDeleteServices1.Location = new Point(437, 126);
            ComboDeleteServices1.Name = "ComboDeleteServices1";
            ComboDeleteServices1.Size = new Size(172, 28);
            ComboDeleteServices1.TabIndex = 20;
            // 
            // TextServicePriceForHouseServiceUpdate
            // 
            TextServicePriceForHouseServiceUpdate.Location = new Point(437, 332);
            TextServicePriceForHouseServiceUpdate.Name = "TextServicePriceForHouseServiceUpdate";
            TextServicePriceForHouseServiceUpdate.Size = new Size(172, 27);
            TextServicePriceForHouseServiceUpdate.TabIndex = 22;
            // 
            // TextNewServiceName
            // 
            TextNewServiceName.Location = new Point(400, 60);
            TextNewServiceName.Name = "TextNewServiceName";
            TextNewServiceName.Size = new Size(209, 27);
            TextNewServiceName.TabIndex = 23;
            // 
            // ButtonCreateNewService
            // 
            ButtonCreateNewService.Location = new Point(632, 60);
            ButtonCreateNewService.Name = "ButtonCreateNewService";
            ButtonCreateNewService.Size = new Size(282, 30);
            ButtonCreateNewService.TabIndex = 26;
            ButtonCreateNewService.Text = "Sukurti naują paslaugą";
            ButtonCreateNewService.UseVisualStyleBackColor = true;
            ButtonCreateNewService.Click += btnCreateService_Click_1;
            // 
            // ButtonDeleteService
            // 
            ButtonDeleteService.Location = new Point(632, 127);
            ButtonDeleteService.Name = "ButtonDeleteService";
            ButtonDeleteService.Size = new Size(282, 30);
            ButtonDeleteService.TabIndex = 27;
            ButtonDeleteService.Text = "Ištrinti paslaugą";
            ButtonDeleteService.UseVisualStyleBackColor = true;
            ButtonDeleteService.Click += btnDeleteService_Click_1;
            // 
            // ButtonAssignServiceToHome
            // 
            ButtonAssignServiceToHome.Location = new Point(632, 194);
            ButtonAssignServiceToHome.Name = "ButtonAssignServiceToHome";
            ButtonAssignServiceToHome.Size = new Size(282, 30);
            ButtonAssignServiceToHome.TabIndex = 28;
            ButtonAssignServiceToHome.Text = "Priskirti paslaugą namui";
            ButtonAssignServiceToHome.UseVisualStyleBackColor = true;
            ButtonAssignServiceToHome.Click += btnAssignServiceToHome_Click;
            // 
            // ButtonRemoveServiceFromHome
            // 
            ButtonRemoveServiceFromHome.Location = new Point(632, 261);
            ButtonRemoveServiceFromHome.Name = "ButtonRemoveServiceFromHome";
            ButtonRemoveServiceFromHome.Size = new Size(282, 30);
            ButtonRemoveServiceFromHome.TabIndex = 29;
            ButtonRemoveServiceFromHome.Text = "Pašalinti paslaugą iš namo";
            ButtonRemoveServiceFromHome.UseVisualStyleBackColor = true;
            ButtonRemoveServiceFromHome.Click += btnRemoveServiceFromHome_Click;
            // 
            // ButtonUpdatePrice
            // 
            ButtonUpdatePrice.Location = new Point(632, 332);
            ButtonUpdatePrice.Name = "ButtonUpdatePrice";
            ButtonUpdatePrice.Size = new Size(282, 30);
            ButtonUpdatePrice.TabIndex = 30;
            ButtonUpdatePrice.Text = "Pakeisti namo paslaugos kainą";
            ButtonUpdatePrice.UseVisualStyleBackColor = true;
            ButtonUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // LabelChooseServices6
            // 
            LabelChooseServices6.AutoSize = true;
            LabelChooseServices6.Location = new Point(437, 103);
            LabelChooseServices6.Name = "LabelChooseServices6";
            LabelChooseServices6.Size = new Size(134, 20);
            LabelChooseServices6.TabIndex = 34;
            LabelChooseServices6.Text = "Pasirinkti paslaugą:";
            // 
            // LabelServicePrice
            // 
            LabelServicePrice.AutoSize = true;
            LabelServicePrice.Location = new Point(437, 310);
            LabelServicePrice.Name = "LabelServicePrice";
            LabelServicePrice.Size = new Size(85, 20);
            LabelServicePrice.TabIndex = 35;
            LabelServicePrice.Text = "Įvesti kainą:";
            // 
            // LabelNewServiceName
            // 
            LabelNewServiceName.AutoSize = true;
            LabelNewServiceName.Location = new Point(400, 37);
            LabelNewServiceName.Name = "LabelNewServiceName";
            LabelNewServiceName.Size = new Size(199, 20);
            LabelNewServiceName.TabIndex = 36;
            LabelNewServiceName.Text = "Įvesti paslaugos pavadinimą:";
            // 
            // EditManagerstabPage2
            // 
            EditManagerstabPage2.Controls.Add(label8);
            EditManagerstabPage2.Controls.Add(ComboChooseManagerToDelete);
            EditManagerstabPage2.Controls.Add(label6);
            EditManagerstabPage2.Controls.Add(label7);
            EditManagerstabPage2.Controls.Add(ComboChooseManagerToRemoveHome);
            EditManagerstabPage2.Controls.Add(ComboChooseHomeToRemoveManager);
            EditManagerstabPage2.Controls.Add(label2);
            EditManagerstabPage2.Controls.Add(ComboChooseHomeToAddManager);
            EditManagerstabPage2.Controls.Add(LabelManagers);
            EditManagerstabPage2.Controls.Add(ComboChooseManagerForAHome);
            EditManagerstabPage2.Controls.Add(ButtonAssignManagerToHome);
            EditManagerstabPage2.Controls.Add(ButtonRemoveManagerFromHome);
            EditManagerstabPage2.Controls.Add(LabelNewManagerName);
            EditManagerstabPage2.Controls.Add(TextNewManagerName);
            EditManagerstabPage2.Controls.Add(LabelNewManagerPassword);
            EditManagerstabPage2.Controls.Add(TextNewManagerPassword);
            EditManagerstabPage2.Controls.Add(ButtonCreateManager);
            EditManagerstabPage2.Controls.Add(ButtonDeleteManager);
            EditManagerstabPage2.Location = new Point(4, 31);
            EditManagerstabPage2.Name = "EditManagerstabPage2";
            EditManagerstabPage2.Padding = new Padding(3);
            EditManagerstabPage2.Size = new Size(950, 425);
            EditManagerstabPage2.TabIndex = 1;
            EditManagerstabPage2.Text = "Vadybininkų valdymas";
            EditManagerstabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(386, 136);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 31;
            label8.Text = "Pasirinkti vadybininką:";
            // 
            // ComboChooseManagerToDelete
            // 
            ComboChooseManagerToDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseManagerToDelete.FormattingEnabled = true;
            ComboChooseManagerToDelete.Location = new Point(386, 159);
            ComboChooseManagerToDelete.Name = "ComboChooseManagerToDelete";
            ComboChooseManagerToDelete.Size = new Size(172, 28);
            ComboChooseManagerToDelete.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 290);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 28;
            label6.Text = "Pasirinkti namą:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 290);
            label7.Name = "label7";
            label7.Size = new Size(153, 20);
            label7.TabIndex = 29;
            label7.Text = "Pasirinkti vadybininką:";
            // 
            // ComboChooseManagerToRemoveHome
            // 
            ComboChooseManagerToRemoveHome.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseManagerToRemoveHome.FormattingEnabled = true;
            ComboChooseManagerToRemoveHome.Location = new Point(386, 313);
            ComboChooseManagerToRemoveHome.Name = "ComboChooseManagerToRemoveHome";
            ComboChooseManagerToRemoveHome.Size = new Size(172, 28);
            ComboChooseManagerToRemoveHome.TabIndex = 27;
            // 
            // ComboChooseHomeToRemoveManager
            // 
            ComboChooseHomeToRemoveManager.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseHomeToRemoveManager.FormattingEnabled = true;
            ComboChooseHomeToRemoveManager.Location = new Point(176, 313);
            ComboChooseHomeToRemoveManager.Name = "ComboChooseHomeToRemoveManager";
            ComboChooseHomeToRemoveManager.Size = new Size(172, 28);
            ComboChooseHomeToRemoveManager.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 213);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 13;
            label2.Text = "Pasirinkti namą:";
            // 
            // ComboChooseHomeToAddManager
            // 
            ComboChooseHomeToAddManager.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseHomeToAddManager.FormattingEnabled = true;
            ComboChooseHomeToAddManager.Location = new Point(176, 236);
            ComboChooseHomeToAddManager.Name = "ComboChooseHomeToAddManager";
            ComboChooseHomeToAddManager.Size = new Size(172, 28);
            ComboChooseHomeToAddManager.TabIndex = 14;
            // 
            // LabelManagers
            // 
            LabelManagers.AutoSize = true;
            LabelManagers.Location = new Point(386, 213);
            LabelManagers.Name = "LabelManagers";
            LabelManagers.Size = new Size(153, 20);
            LabelManagers.TabIndex = 15;
            LabelManagers.Text = "Pasirinkti vadybininką:";
            // 
            // ComboChooseManagerForAHome
            // 
            ComboChooseManagerForAHome.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboChooseManagerForAHome.FormattingEnabled = true;
            ComboChooseManagerForAHome.Location = new Point(386, 236);
            ComboChooseManagerForAHome.Name = "ComboChooseManagerForAHome";
            ComboChooseManagerForAHome.Size = new Size(172, 28);
            ComboChooseManagerForAHome.TabIndex = 16;
            // 
            // ButtonAssignManagerToHome
            // 
            ButtonAssignManagerToHome.Location = new Point(590, 234);
            ButtonAssignManagerToHome.Name = "ButtonAssignManagerToHome";
            ButtonAssignManagerToHome.Size = new Size(282, 30);
            ButtonAssignManagerToHome.TabIndex = 17;
            ButtonAssignManagerToHome.Text = "Priskirti namą vadybininkui";
            ButtonAssignManagerToHome.UseVisualStyleBackColor = true;
            ButtonAssignManagerToHome.Click += btnAssignManager_Click;
            // 
            // ButtonRemoveManagerFromHome
            // 
            ButtonRemoveManagerFromHome.Location = new Point(590, 311);
            ButtonRemoveManagerFromHome.Name = "ButtonRemoveManagerFromHome";
            ButtonRemoveManagerFromHome.Size = new Size(282, 30);
            ButtonRemoveManagerFromHome.TabIndex = 18;
            ButtonRemoveManagerFromHome.Text = "Pašalinti vadybininkui namą";
            ButtonRemoveManagerFromHome.UseVisualStyleBackColor = true;
            ButtonRemoveManagerFromHome.Click += btnRemoveManager_Click;
            // 
            // LabelNewManagerName
            // 
            LabelNewManagerName.AutoSize = true;
            LabelNewManagerName.Location = new Point(77, 65);
            LabelNewManagerName.Name = "LabelNewManagerName";
            LabelNewManagerName.Size = new Size(171, 20);
            LabelNewManagerName.TabIndex = 19;
            LabelNewManagerName.Text = "Įvesti vadybininko vardą:";
            // 
            // TextNewManagerName
            // 
            TextNewManagerName.Location = new Point(77, 88);
            TextNewManagerName.Name = "TextNewManagerName";
            TextNewManagerName.Size = new Size(172, 27);
            TextNewManagerName.TabIndex = 20;
            // 
            // LabelNewManagerPassword
            // 
            LabelNewManagerPassword.AutoSize = true;
            LabelNewManagerPassword.Location = new Point(287, 65);
            LabelNewManagerPassword.Name = "LabelNewManagerPassword";
            LabelNewManagerPassword.Size = new Size(271, 20);
            LabelNewManagerPassword.TabIndex = 21;
            LabelNewManagerPassword.Text = "Įvesti vadybininko pavardę (slaptažodį):";
            // 
            // TextNewManagerPassword
            // 
            TextNewManagerPassword.Location = new Point(287, 88);
            TextNewManagerPassword.Name = "TextNewManagerPassword";
            TextNewManagerPassword.Size = new Size(271, 27);
            TextNewManagerPassword.TabIndex = 22;
            // 
            // ButtonCreateManager
            // 
            ButtonCreateManager.Location = new Point(590, 86);
            ButtonCreateManager.Name = "ButtonCreateManager";
            ButtonCreateManager.Size = new Size(282, 30);
            ButtonCreateManager.TabIndex = 23;
            ButtonCreateManager.Text = "Sukurti naują vadybininko paskyrą";
            ButtonCreateManager.UseVisualStyleBackColor = true;
            ButtonCreateManager.Click += btnCreateManager_Click;
            // 
            // ButtonDeleteManager
            // 
            ButtonDeleteManager.Location = new Point(590, 157);
            ButtonDeleteManager.Name = "ButtonDeleteManager";
            ButtonDeleteManager.Size = new Size(282, 30);
            ButtonDeleteManager.TabIndex = 24;
            ButtonDeleteManager.Text = "Ištrinti vadybininko paskyrą";
            ButtonDeleteManager.UseVisualStyleBackColor = true;
            ButtonDeleteManager.Click += btnDeleteManager_Click;
            // 
            // Admin
            // 
            ClientSize = new Size(982, 671);
            Controls.Add(tabControl1);
            Controls.Add(PictureBigLogo);
            Controls.Add(LogOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administratoriaus langas - Komunalinių Paslaugų Sistema";
            ((System.ComponentModel.ISupportInitialize)PictureBigLogo).EndInit();
            tabControl1.ResumeLayout(false);
            EditHomestabPage1.ResumeLayout(false);
            EditHomestabPage1.PerformLayout();
            EditServicestabPage1.ResumeLayout(false);
            EditServicestabPage1.PerformLayout();
            EditManagerstabPage2.ResumeLayout(false);
            EditManagerstabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox PictureBigLogo;
        private TabControl tabControl1;
        private TabPage EditHomestabPage1;
        private TabPage EditManagerstabPage2;
        private TabPage EditServicestabPage1;
        private ComboBox ComboDeleteServices1;
        private TextBox TextServicePriceForHouseServiceUpdate;
        private TextBox TextNewServiceName;
        private Button ButtonCreateNewService;
        private Button ButtonDeleteService;
        private Button ButtonAssignServiceToHome;
        private Button ButtonRemoveServiceFromHome;
        private Button ButtonUpdatePrice;
        private Label LabelChooseServices6;
        private Label LabelServicePrice;
        private Label LabelNewServiceName;
        private Label label2;
        private ComboBox ComboChooseHomeToAddManager;
        private Label LabelManagers;
        private ComboBox ComboChooseManagerForAHome;
        private Button ButtonAssignManagerToHome;
        private Button ButtonRemoveManagerFromHome;
        private Label LabelNewManagerName;
        private TextBox TextNewManagerName;
        private Label LabelNewManagerPassword;
        private TextBox TextNewManagerPassword;
        private Button ButtonCreateManager;
        private Button ButtonDeleteManager;
        private Label LabelChooseHome3;
        private Label LabelOccupant1;
        private ComboBox ComboChooseOccupantToAddHomeTo;
        private Label LabelOccupantName;
        private TextBox TextOccupantName;
        private Label LabelOccupantPassword;
        private TextBox TextOccupantPassword;
        private Button ButtonCreateNewOccupant;
        private Button ButtonDeleteOccupant;
        private Button ButtonAssignOccupant;
        private Button ButtonRemoveOccupantFromHome;
        private ComboBox ComboHomeToAddOccupantTo;
        private Label label5;
        private Label label3;
        private Label label4;
        private ComboBox ComboChooseOccupantToRemoveHome;
        private ComboBox ComboChooseHouseToRemoveOccupant;
        private ComboBox ComboChooseOccupantToDelete;
        private Label label6;
        private Label label7;
        private ComboBox ComboChooseManagerToRemoveHome;
        private ComboBox ComboChooseHomeToRemoveManager;
        private Label label8;
        private ComboBox ComboChooseManagerToDelete;
        private Label label10;
        private TextBox TextServicePriceForHome;
        private ComboBox ComboHomesAddServiceTo;
        private ComboBox ComboRemoveHouseFromService;
        private ComboBox ComboChangePriceForHouseService;
        private ComboBox ComboChangePriceForServiceHouse;
        private ComboBox ComboServiceAddHouseTo;
        private ComboBox ComboRemoveServiceFromHouse;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private ComboBox ComboChooseHouseToDelete;
        private Label TextChooseName1;
        private TextBox TextNewHomeName;
        private Button ButtonCreateHome;
        private Button ButtonDeleteChosenHome;
        private Label LabelNewHomeName;
    }
}
