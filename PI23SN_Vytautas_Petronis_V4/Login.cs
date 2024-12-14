using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KPS
{
    public partial class Login : Form
    {
        private readonly DB _database;

        public Login()
        {
            InitializeComponent();
            _database = new DB();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = TextUsername.Text.Trim();
            string password = TextPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Įveskite naudotojo vardą ir slaptažodį.", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User user = AuthenticateUser(username, password);
                if (user != null)
                {
                    NavigateToRoleSpecificForm(user);
                }
                else
                {
                    MessageBox.Show("Neteisingi prisijungimo duomenys.", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Įvyko klaida: {ex.Message}", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private User AuthenticateUser(string username, string password)
        {

            string query = "SELECT id_user, name_user, role FROM user WHERE name_user = @username AND pass_user = @password";

            MySqlParameter[] parameters = {
        new MySqlParameter("@username", username),
        new MySqlParameter("@password", password)
    };

            DataTable userTable = _database.ExecuteQuery(query, parameters);

            if (userTable.Rows.Count > 0)
            {
                return new User
                {
                    UserId = Convert.ToInt32(userTable.Rows[0]["id_user"]),
                    Name = userTable.Rows[0]["name_user"].ToString(),
                    Role = userTable.Rows[0]["role"].ToString()
                };
            }

            return null;
        }

        private void NavigateToRoleSpecificForm(User user)
        {
            this.Hide();

            Form nextForm = user.Role switch
            {
                "admin" => new Admin(),
                "manager" => new Manager(user.UserId),
                "occupant" => new Occupant(user.UserId),
                _ => null
            };

            if (nextForm != null)
            {
                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Nepavyko nustatyti naudotojo vaidmens.", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();

        }

    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }


}
