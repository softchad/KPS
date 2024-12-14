using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KPS
{
    public partial class Manager : Form
    {
        private readonly int _userId;
        private readonly DB _db;

        public Manager(int userId) : this(userId, new DB()) { }

        public Manager(int userId, DB db)
        {
            InitializeComponent();
            _userId = userId;
            _db = db ?? throw new ArgumentNullException(nameof(db));

            InitializeManagerData();
        }

        private void InitializeManagerData()
        {
            LoadAssignedHome();
            LoadServices();
        }

        private void LoadAssignedHome()
        {
            try
            {
                string homeName = GetAssignedHome();
                LabelAssignedHome.Text = !string.IsNullOrEmpty(homeName)
                    ? $"'{homeName}'"
                    : "Jūsų paskyrai priskirto namo nėra.";
            }
            catch (Exception ex)
            {
                DisplayError("Nepavyko priskirti namo paskyrai.", ex);
            }
        }

        private string GetAssignedHome()
        {
            const string query = @"
                SELECT name_home 
                FROM home 
                WHERE id_manager = @userId";

            MySqlParameter[] parameters = { new MySqlParameter("@userId", _userId) };

            DataTable result = _db.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 ? result.Rows[0]["name_home"].ToString() : string.Empty;
        }

        private void LoadServices()
        {
            try
            {
                DataTable services = GetServices();
                BindServicesToComboBox(services);
            }
            catch (Exception ex)
            {
                DisplayError("Nepavyko įkelti paslaugų.", ex);
            }
        }

        private DataTable GetServices()
        {
            const string query = @"
                SELECT p.id_service, p.name_service
                FROM service p
                JOIN price k ON p.id_service = k.id_service
                JOIN home n ON k.id_home = n.id_home
                WHERE n.id_manager = @userId";

            MySqlParameter[] parameters = { new MySqlParameter("@userId", _userId) };
            return _db.ExecuteQuery(query, parameters);
        }

        private void BindServicesToComboBox(DataTable services)
        {
            ComboChooseServiceToUpdatePrice.DataSource = services;
            ComboChooseServiceToUpdatePrice.DisplayMember = "name_service";
            ComboChooseServiceToUpdatePrice.ValueMember = "id_service";
            ComboChooseServiceToUpdatePrice.SelectedIndex = -1;
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (ComboChooseServiceToUpdatePrice.SelectedValue == null || string.IsNullOrWhiteSpace(TextUpdatedServicePrice.Text))
            {
                MessageBox.Show("Pasirinkite paslaugą ir įveskite naują kainą.");
                return;
            }

            if (!decimal.TryParse(TextUpdatedServicePrice.Text, out decimal price))
            {
                MessageBox.Show("Įveskite tinkamą kainą.");
                return;
            }

            try
            {
                UpdateServicePrice(price);
                MessageBox.Show("Priskirto namo paslaugos kaina sėkmingai atnaujinta.");
            }
            catch (Exception ex)
            {
                DisplayError("Nepavyko atnaujinti priskirto namo paslaugos kainos.", ex);
            }
        }

        private void UpdateServicePrice(decimal price)
        {
            const string query = @"
                UPDATE price
                SET id_price = @price
                WHERE id_service = @serviceId
                AND id_home = (
                    SELECT id_home
                    FROM home 
                    WHERE id_manager = @userId
                )";

            MySqlParameter[] parameters = {
                new MySqlParameter("@price", price),
                new MySqlParameter("@serviceId", ComboChooseServiceToUpdatePrice.SelectedValue),
                new MySqlParameter("@userId", _userId)
            };

            int rowsAffected = _db.ExecuteNonQuery(query, parameters);
            if (rowsAffected <= 0)
            {
                throw new Exception("Nepavyko atnaujinti priskirto namo paslaugos kainos.");
            }
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

        private void DisplayError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
