using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KPS
{
    public partial class Admin : Form
    {
        private DB db = new DB();
        public Admin()
        {
            InitializeComponent();
            LoadHomeData();
            LoadManagerData();
            LoadOccupantData();
            LoadServicesData();
        }
        private void DataReset()
        {
            LoadHomeData();
            LoadServicesData();
        }
        private void LoadHomeData()
        {
            try
            {
                ComboHomeToAddOccupantTo.Items.Clear();
                string query = "SELECT id_home, name_home FROM home";
                DataTable dataTable = db.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    ComboHomeToAddOccupantTo.Items.Add(new ComboBoxItem(row["name_home"].ToString(), Convert.ToInt32(row["id_home"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_home, name_home FROM home";
                DataTable dataTable = db.ExecuteQuery(query);

                ComboChooseHomeToAddManager.DataSource = dataTable;
                ComboChooseHomeToAddManager.DisplayMember = "name_home";
                ComboChooseHomeToAddManager.ValueMember = "id_home";
                ComboChooseHomeToAddManager.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_home, name_home FROM home";
                DataTable dataTable = db.ExecuteQuery(query);

                ComboChooseHomeToRemoveManager.DataSource = dataTable;
                ComboChooseHomeToRemoveManager.DisplayMember = "name_home";
                ComboChooseHomeToRemoveManager.ValueMember = "id_home";
                ComboChooseHomeToRemoveManager.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                ComboChooseHouseToRemoveOccupant.Items.Clear();
                string query = "SELECT id_home, name_home FROM home";
                DataTable dataTable = db.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    ComboChooseHouseToRemoveOccupant.Items.Add(new ComboBoxItem(row["name_home"].ToString(), Convert.ToInt32(row["id_home"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_home, name_home FROM home";
                DataTable homes = db.ExecuteQuery(query);

                ComboChooseHouseToDelete.DataSource = homes;
                ComboChooseHouseToDelete.DisplayMember = "name_home";
                ComboChooseHouseToDelete.ValueMember = "id_home";
                ComboChooseHouseToDelete.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_home, name_home FROM home";
                DataTable homes = db.ExecuteQuery(query);

                ComboChangePriceForHouseService.DataSource = homes;
                ComboChangePriceForHouseService.DisplayMember = "name_home";
                ComboChangePriceForHouseService.ValueMember = "id_home";
                ComboChangePriceForHouseService.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_home, name_home FROM home";
                DataTable homes = db.ExecuteQuery(query);

                ComboRemoveHouseFromService.DataSource = homes;
                ComboRemoveHouseFromService.DisplayMember = "name_home";
                ComboRemoveHouseFromService.ValueMember = "id_home";
                ComboRemoveHouseFromService.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_home, name_home FROM home";
                DataTable homes = db.ExecuteQuery(query);

                ComboHomesAddServiceTo.DataSource = homes;
                ComboHomesAddServiceTo.DisplayMember = "name_home";
                ComboHomesAddServiceTo.ValueMember = "id_home";
                ComboHomesAddServiceTo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti namų: {ex.Message}");
            }
        }

        private void LoadManagerData()
        {

            try
            {
                string query = "SELECT id_user, name_user FROM user WHERE role = 'manager'";
                DataTable dataTable = db.ExecuteQuery(query);
                ComboChooseManagerForAHome.DataSource = dataTable;
                ComboChooseManagerForAHome.DisplayMember = "name_user";
                ComboChooseManagerForAHome.ValueMember = "id_user";
                ComboChooseManagerForAHome.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti vadybininkų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_user, name_user FROM user WHERE role = 'manager'";
                DataTable dataTable = db.ExecuteQuery(query);
                ComboChooseManagerToRemoveHome.DataSource = dataTable;
                ComboChooseManagerToRemoveHome.DisplayMember = "name_user";
                ComboChooseManagerToRemoveHome.ValueMember = "id_user";
                ComboChooseManagerToRemoveHome.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti vadybininkų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_user, name_user FROM user WHERE role = 'manager'";
                DataTable dataTable = db.ExecuteQuery(query);
                ComboChooseManagerToDelete.DataSource = dataTable;
                ComboChooseManagerToDelete.DisplayMember = "name_user";
                ComboChooseManagerToDelete.ValueMember = "id_user";
                ComboChooseManagerToDelete.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti vadybininkų: {ex.Message}");
            }

        }
        private void LoadOccupantData()
        {
            try
            {
                ComboChooseOccupantToAddHomeTo.Items.Clear();
                string query = "SELECT id_user, name_user FROM user WHERE role = 'occupant'";
                DataTable dataTable = db.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    ComboChooseOccupantToAddHomeTo.Items.Add(new ComboBoxItem(row["name_user"].ToString(), Convert.ToInt32(row["id_user"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti gyventojų: {ex.Message}");
            }

            try
            {
                ComboChooseOccupantToRemoveHome.Items.Clear();
                string query = "SELECT id_user, name_user FROM user WHERE role = 'occupant'";
                DataTable dataTable = db.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    ComboChooseOccupantToRemoveHome.Items.Add(new ComboBoxItem(row["name_user"].ToString(), Convert.ToInt32(row["id_user"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti gyventojų: {ex.Message}");
            }

            try
            {
                ComboChooseOccupantToDelete.Items.Clear();
                string query = "SELECT id_user, name_user FROM user WHERE role = 'occupant'";
                DataTable dataTable = db.ExecuteQuery(query);
                foreach (DataRow row in dataTable.Rows)
                {
                    ComboChooseOccupantToDelete.Items.Add(new ComboBoxItem(row["name_user"].ToString(), Convert.ToInt32(row["id_user"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti gyventojų: {ex.Message}");
            }
        }
        private void LoadServicesData()
        {
            try
            {
                string query = "SELECT id_service, name_service FROM service";
                DataTable services = db.ExecuteQuery(query);

                ComboDeleteServices1.DataSource = services;
                ComboDeleteServices1.DisplayMember = "name_service";
                ComboDeleteServices1.ValueMember = "id_service";
                ComboDeleteServices1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti paslaugų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_service, name_service FROM service";
                DataTable services = db.ExecuteQuery(query);

                ComboServiceAddHouseTo.DataSource = services;
                ComboServiceAddHouseTo.DisplayMember = "name_service";
                ComboServiceAddHouseTo.ValueMember = "id_service";
                ComboServiceAddHouseTo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti paslaugų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_service, name_service FROM service";
                DataTable services = db.ExecuteQuery(query);

                ComboRemoveServiceFromHouse.DataSource = services;
                ComboRemoveServiceFromHouse.DisplayMember = "name_service";
                ComboRemoveServiceFromHouse.ValueMember = "id_service";
                ComboRemoveServiceFromHouse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti paslaugų: {ex.Message}");
            }

            try
            {
                string query = "SELECT id_service, name_service FROM service";
                DataTable services = db.ExecuteQuery(query);

                ComboChangePriceForServiceHouse.DataSource = services;
                ComboChangePriceForServiceHouse.DisplayMember = "name_service";
                ComboChangePriceForServiceHouse.ValueMember = "id_service";
                ComboChangePriceForServiceHouse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko įkelti paslaugų: {ex.Message}");
            }
        }
        private void btnCreateResident_Click(object sender, EventArgs e)
        {
            string loginName = TextOccupantName.Text.Trim();
            string password = TextOccupantPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(loginName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Įveskite gyventojo paskyros vardą ir pavardę (slaptažodį).");
                return;
            }

            try
            {

                string query = @"
                    INSERT INTO user (name_user, pass_user, role) 
                    VALUES (@loginName, @password, 'occupant')";

                var parameters = new[]
                {
                    new MySqlParameter("@loginName", loginName),
                    new MySqlParameter("@password", password)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Gyventojo paskyra sėkmingai sukurta.");
                    LoadOccupantData();
                    TextOccupantName.Clear();
                    TextOccupantPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Nepavyko sukurti gyventojo paskyros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko sukurti gyventojo paskyros: {ex.Message}");
            }
        }

        private void btnDeleteResident_Click(object sender, EventArgs e)
        {
            if (ComboChooseOccupantToDelete.SelectedItem is ComboBoxItem selectedResident)
            {
                try
                {
                    string query = "DELETE FROM user WHERE id_user = @id";
                    var parameters = new[] { new MySqlParameter("@id", selectedResident.Value) };

                    int rowsAffected = db.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Gyventojo paskyra sėkmingai ištrinta.");
                        LoadOccupantData();
                    }
                    else
                    {
                        MessageBox.Show("Nepavyko ištrinti gyventojo paskyros.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nepavyko ištrinti gyventojo paskyros: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite gyventojo paskyrą.");
            }
        }

        private void btnAssignResident_Click(object sender, EventArgs e)
        {
            if (ComboHomeToAddOccupantTo.SelectedItem is ComboBoxItem selectedHome && ComboChooseOccupantToAddHomeTo.SelectedItem is ComboBoxItem selectedResident)
            {
                try
                {
                    string query = "INSERT INTO occupant (id_home, id_user) VALUES (@homeId, @residentId)";
                    var parameters = new[]
                    {
                        new MySqlParameter("@homeId", selectedHome.Value),
                        new MySqlParameter("@residentId", selectedResident.Value)
                    };

                    int rowsAffected = db.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Gyventojas sėkmingai priskirtas namui.");
                    }
                    else
                    {
                        MessageBox.Show("Nepavyko priskirti gyventojo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nepavyko priskirti gyventojo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite namą ir gyventoją paskyrą iš sąrašo.");
            }
        }

        private void btnRemoveResident_Click(object sender, EventArgs e)
        {
            if (ComboChooseHouseToRemoveOccupant.SelectedItem is ComboBoxItem selectedHome && ComboChooseOccupantToRemoveHome.SelectedItem is ComboBoxItem selectedResident)
            {
                try
                {
                    string query = "DELETE FROM occupant WHERE id_home = @homeId AND id_user = @residentId";
                    var parameters = new[]
                    {
                        new MySqlParameter("@homeId", selectedHome.Value),
                        new MySqlParameter("@residentId", selectedResident.Value)
                    };

                    int rowsAffected = db.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Gyventojas sėkmingai pašalintas iš namo.");
                    }
                    else
                    {
                        MessageBox.Show("Nepavyko pašalinti gyventojo iš namo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Nepavyko pašalinti gyventojo iš namo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite namą ir gyventojo paskyrą iš sąrašo.");
            }
        }
        private void btnAssignManager_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboChooseHomeToAddManager.SelectedValue == null || ComboChooseManagerForAHome.SelectedValue == null)
                {
                    MessageBox.Show("Pasirinkite namą ir vadybininko paskyrą.");
                    return;
                }

                int managerId = Convert.ToInt32(ComboChooseManagerForAHome.SelectedValue);
                int homeId = Convert.ToInt32(ComboChooseHomeToAddManager.SelectedValue);

                string query = @"UPDATE home SET id_manager = @managerId WHERE id_home = @homeId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@managerId", managerId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Namas sėkmingai priskirtas vadybininkui");
                    LoadHomeData();
                }
                else
                {
                    MessageBox.Show("Nepavyko priskirti namui vadybininką.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko priskirti namui vadybininką: {ex.Message}");
            }
        }
        private void btnRemoveManager_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboChooseHomeToRemoveManager.SelectedValue == null || ComboChooseManagerToRemoveHome.SelectedValue == null)
                {
                    MessageBox.Show("Pasirinkite namą ir vadybininko paskyrą.");
                    return;
                }

                int managerId = Convert.ToInt32(ComboChooseManagerToRemoveHome.SelectedValue);
                int homeId = Convert.ToInt32(ComboChooseHomeToRemoveManager.SelectedValue);

                string query = @"UPDATE home SET id_manager = NULL WHERE id_home = @homeId AND id_manager = @managerId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@managerId", managerId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Namas pašalintas iš vadybininko paskyros.");
                    LoadHomeData();
                }
                else
                {
                    MessageBox.Show("Nepavyko pašalinti namo iš vadybininko paskyros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko pašalinti namo iš vadybininko paskyros: {ex.Message}");
            }
        }

        private void btnCreateManager_Click(object sender, EventArgs e)
        {
            try
            {
                string managerName = TextNewManagerName.Text.Trim();
                string password = TextNewManagerPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(managerName) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Įveskite vadybininko paskyros vardą ir pavardę (slaptažodį).");
                    return;
                }

                string query = @"INSERT INTO user (name_user, pass_user, role) 
                                 VALUES (@username, @password, 'manager')";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@username", managerName),
                    new MySqlParameter("@password", password)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sukurta nauja vadybininko paskyra.");
                    LoadManagerData();
                }
                else
                {
                    MessageBox.Show("Nepavyko sukurti naujos vadybininko paskyros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko sukurti naujos vadybininko paskyros: {ex.Message}");
            }
        }

        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboChooseManagerToDelete.SelectedValue == null)
                {
                    MessageBox.Show("Pasirinkite vadybininko paskyrą.");
                    return;
                }

                int managerId = Convert.ToInt32(ComboChooseManagerToDelete.SelectedValue);

                string query = "DELETE FROM user WHERE id_user = @managerId AND role = 'manager'";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@managerId", managerId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Vadybininko paskyra sėkmingai ištrinta.");
                    LoadManagerData();
                }
                else
                {
                    MessageBox.Show("Nepavyko ištrinti vadybininko paskyros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko ištrinti vadybininko paskyros: {ex.Message}");
            }
        }

        private void btnCreateHome_Click(object sender, EventArgs e)
        {
            string homeName = TextNewHomeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(homeName))
            {
                MessageBox.Show("Įveskite namo pavadimą.");
                return;
            }

            try
            {
                string query = "INSERT INTO home (name_home) VALUES (@homeName)";
                MySqlParameter[] parameters = { new MySqlParameter("@homeName", homeName) };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Namas sėkmingai sukurtas.");
                    DataReset();
                    TextNewHomeName.Clear();
                }
                else
                {
                    MessageBox.Show("Nepavyko sukurti namo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko sukurti namo: {ex.Message}");
            }
        }
        private void btnDeleteHome_Click(object sender, EventArgs e)
        {
            if (ComboChooseHouseToDelete.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą.");
                return;
            }

            int homeId = Convert.ToInt32(ComboChooseHouseToDelete.SelectedValue);

            try
            {
                string query = "DELETE FROM home WHERE id_home = @homeId";
                MySqlParameter[] parameters = { new MySqlParameter("@homeId", homeId) };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Namas sėkmingai ištrintas.");
                    DataReset();
                }
                else
                {
                    MessageBox.Show("Nepavyko ištrinti namo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko ištrinti namo: {ex.Message}");
            }
        }
        private void btnCreateService_Click(object sender, EventArgs e)
        {
            string serviceName = TextNewServiceName.Text.Trim();

            if (string.IsNullOrWhiteSpace(serviceName))
            {
                MessageBox.Show("Įveskite paslaugos pavadinimą.");
                return;
            }

            try
            {
                string query = "INSERT INTO service (name_service) VALUES (@serviceName)";
                MySqlParameter[] parameters = { new MySqlParameter("@serviceName", serviceName) };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai sukurta.");
                    DataReset();
                    TextNewServiceName.Clear();
                }
                else
                {
                    MessageBox.Show("Nepavyko sukurti paslaugos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko sukurti paslaugos: {ex.Message}");
            }
        }
        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (ComboDeleteServices1.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite paslaugą.");
                return;
            }

            int serviceId = Convert.ToInt32(ComboDeleteServices1.SelectedValue);

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM price WHERE id_service = @serviceId";
                MySqlParameter[] checkParams = { new MySqlParameter("@serviceId", serviceId) };
                int associationCount = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));

                if (associationCount > 0)
                {
                    MessageBox.Show("Nepavyko ištrinti paslaugos: Paslauga priskirta namui.");
                    return;
                }

                string deleteQuery = "DELETE FROM service WHERE id_service = @serviceId";
                MySqlParameter[] deleteParams = { new MySqlParameter("@serviceId", serviceId) };

                int rowsAffected = db.ExecuteNonQuery(deleteQuery, deleteParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai ištrinta.");
                    DataReset();
                }
                else
                {
                    MessageBox.Show("Nepavyko ištrinti paslaugos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko ištrinti paslaugos: {ex.Message}");
            }
        }
        private void btnAssignServiceToHome_Click(object sender, EventArgs e)
        {
            if (ComboHomesAddServiceTo.SelectedValue == null || ComboServiceAddHouseTo.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą ir paslaugą.");
                return;
            }

            int homeId = Convert.ToInt32(ComboHomesAddServiceTo.SelectedValue);
            int serviceId = Convert.ToInt32(ComboServiceAddHouseTo.SelectedValue);

            if (!decimal.TryParse(TextServicePriceForHome.Text, out decimal price))
            {
                MessageBox.Show("Įveskite teisingą kainą.");
                return;
            }

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM price WHERE id_home = @homeId AND id_service = @serviceId";
                MySqlParameter[] checkParams = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId)
                };
                int associationCount = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));

                if (associationCount > 0)
                {
                    MessageBox.Show("Paslauga jau yra priskirta prie šio namo.");
                    return;
                }

                string insertQuery = "INSERT INTO price (id_home, id_service, id_price) VALUES (@homeId, @serviceId, @price)";
                MySqlParameter[] insertParams = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId),
                    new MySqlParameter("@price", price)
                };

                int rowsAffected = db.ExecuteNonQuery(insertQuery, insertParams);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai priskita prie šio namo su įvesta kaina.");
                    DataReset();
                }
                else
                {
                    MessageBox.Show("Nepavyko priskirti paslaugos prie šio namo su įvesta kaina.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko priskirti paslaugos prie šio namo su įvesta kaina: {ex.Message}");
            }
        }
        private void btnRemoveServiceFromHome_Click(object sender, EventArgs e)
        {
            if (ComboRemoveHouseFromService.SelectedValue == null || ComboRemoveServiceFromHouse.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą ir paslaugą.");
                return;
            }

            int homeId = Convert.ToInt32(ComboRemoveHouseFromService.SelectedValue);
            int serviceId = Convert.ToInt32(ComboRemoveServiceFromHouse.SelectedValue);

            try
            {
                string query = "DELETE FROM price WHERE id_home = @homeId AND id_service = @serviceId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Paslauga sėkmingai pašalinta iš namo.");
                    DataReset();
                }
                else
                {
                    MessageBox.Show("Nepavyko pašalinti paslaugos iš namo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko pašalinti paslaugos iš namo: {ex.Message}");
            }
        }
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (ComboChangePriceForHouseService.SelectedValue == null || ComboChangePriceForServiceHouse.SelectedValue == null)
            {
                MessageBox.Show("Pasirinkite namą ir paslaugą.");
                return;
            }

            int homeId = Convert.ToInt32(ComboChangePriceForHouseService.SelectedValue);
            int serviceId = Convert.ToInt32(ComboChangePriceForServiceHouse.SelectedValue);

            if (!decimal.TryParse(TextServicePriceForHouseServiceUpdate.Text, out decimal newPrice))
            {
                MessageBox.Show("Įveskite teisingą kainą.");
                return;
            }

            try
            {
                string query = "UPDATE price SET id_price = @newPrice WHERE id_home = @homeId AND id_service = @serviceId";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@newPrice", newPrice),
                    new MySqlParameter("@homeId", homeId),
                    new MySqlParameter("@serviceId", serviceId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Pasirinkto namo paslaugos kaina sėkmingai atnaujinta.");
                    DataReset();
                }
                else
                {
                    MessageBox.Show("Nepavyko atnaujinti pasirinkto namo paslaugos kainos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko atnaujinti pasirinkto namo paslaugos kainos: {ex.Message}");
            }
        }

        private void btnCreateService_Click_1(object sender, EventArgs e)
        {
            btnCreateService_Click(sender, e);
        }

        private void btnDeleteService_Click_1(object sender, EventArgs e)
        {
            btnDeleteService_Click(sender, e);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Ar tikrai norite atsijungti?",
            "Atsijungti",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Login loginForm = new Login();

                loginForm.Show();

                this.Close();
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; }
        public int Value { get; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
