using FlightTicketMatic_V2.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FlightTicketMatic_V2
{
    public partial class AdminLogin : Form
    {
        public static string adminName;
        private static string connectionString = "Data Source=..\\..\\Data\\FlightTicketMaticDb.db;Version=3;";

        public AdminLogin()
        {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            adminName = tb_adminName.Text;
            string password = tb_password.Text;

            if (!string.IsNullOrWhiteSpace(adminName) && !string.IsNullOrWhiteSpace(password))
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Admins WHERE adminName = @AdminName;";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AdminName", adminName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["password"].ToString();
                                int dbAdminId = reader.GetInt32(reader.GetOrdinal("id"));
                                if (password == dbPassword)
                                {
                                    MessageBox.Show("successfully logged in");


                                    UC_Reservation.Instance.GetUserId(dbAdminId);
                                    new AdminPanel().Show();
                                    this.Hide();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("incorrect password!");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("admin does not exist!");
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("adminName and password field cannot be blank!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_adminName.Text = "";
            tb_password.Text = "";
        }

        private void btn_clickMe_Click(object sender, EventArgs e)
        {
            tb_adminName.Text = "admin1";
            tb_password.Text = "adminpassword1";
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
