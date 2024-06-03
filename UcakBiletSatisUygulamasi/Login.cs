﻿using FlightTicketMatic_V2.UserControls;
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
    public partial class Login : Form
    {
        public static string userName;
        private static string connectionString = "Data Source=..\\..\\Data\\FlightTicketMaticDb.db;Version=3;";

        public Login()
        {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            userName = tb_userName.Text;
            string password = tb_password.Text;

            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Users WHERE userName = @UserName;";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["password"].ToString();
                                int dbUserId = reader.GetInt32(reader.GetOrdinal("id"));
                                if (password == dbPassword)
                                {
                                    MessageBox.Show("successfully logged in");


                                    UC_Reservation.Instance.GetUserId(dbUserId);
                                    new FlightTicketMatic().Show();
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
                                MessageBox.Show("user does not exist!");
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("userName and password field cannot be blank!");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_userName.Text = "";
            tb_password.Text = "";
        }

        private void btn_clickMe_Click(object sender, EventArgs e)
        {
            tb_userName.Text = "user1";
            tb_password.Text = "userpassword1";
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            new AdminLogin().Show();
            this.Hide();
        }
    }
}
