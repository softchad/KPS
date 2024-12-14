using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KPS
{
    public partial class Occupant : Form
    {
        private readonly int _userId;
        private readonly DB _db;

        public Occupant(int userId) : this(userId, new DB())
        {
        }

        public Occupant(int userId, DB db)
        {
            InitializeComponent();
            _userId = userId;
            _db = db ?? throw new ArgumentNullException(nameof(db));
            LoadResidentData();
        }

        private void LoadResidentData()
        {
            try
            {
                string assignedHome = GetAssignedHome();
                LabelAssignedHome.Text = !string.IsNullOrEmpty(assignedHome)
                    ? $"'{assignedHome}'"
                    : "Jūsų paskyra neturi priskirto namo.";

                DataTable servicesTable = GetServicesForAssignedHome();
                DisplayOccupantHouseServicesAndPrices.DataSource = servicesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nepavyko priskirti namo paskyrai. {ex.Message}", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAssignedHome()
        {
            const string query = @"
                SELECT home.name_home 
                FROM home 
                INNER JOIN occupant ON home.id_home = occupant.id_home 
                WHERE occupant.id_user = @userId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@userId", _userId)
            };

            DataTable resultTable = _db.ExecuteQuery(query, parameters);
            return resultTable.Rows.Count > 0 ? resultTable.Rows[0]["name_home"].ToString() : string.Empty;
        }

        private DataTable GetServicesForAssignedHome()
        {
            const string query = @"
                SELECT service.name_service AS 'Paslauga', price.id_price AS 'Kaina'
                FROM price
                INNER JOIN service ON price.id_service = service.id_service
                INNER JOIN home ON price.id_home = home.id_home
                WHERE home.id_home = (
                    SELECT id_home 
                    FROM occupant 
                    WHERE id_user = @userId
                )";

            MySqlParameter[] parameters = {
                new MySqlParameter("@userId", _userId)
            };

            return _db.ExecuteQuery(query, parameters);
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
}
