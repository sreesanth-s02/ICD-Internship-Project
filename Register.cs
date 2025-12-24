using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Project1ICD
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            textBox3.MaxLength = 3;
            textBox3.KeyPress += (s, e) =>
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            };
            textBox4.MaxLength = 12;
            textBox4.KeyPress += (s, e) =>
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            };
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string GetMD5Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox1.Text.Trim().Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Length < 3)
            {
                MessageBox.Show("Password must be at least 3 characters long", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            string username = textBox1.Text.Trim();
            string connstr = "Host=localhost;Port=5432;Username=postgres;Password=Kuttuz@06;Database=postgres;";

            // ✅ Step 1: Check if username already exists
            using (NpgsqlConnection conn = new NpgsqlConnection(connstr))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose another one.");
                        return;
                    }
                }
            }

            // ✅ Step 2: Insert new user
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connstr))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO users (user_id, username, password, age, phone_no, email_id) " +
                                         "VALUES (@user_id, @username, @password, @age, @phone_no, @email_id)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", int.Parse(textBox6.Text.Trim()));
                        cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", GetMD5Hash(textBox2.Text.Trim()));
                        cmd.Parameters.AddWithValue("@age", int.Parse(textBox3.Text.Trim()));
                        cmd.Parameters.AddWithValue("@phone_no", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@email_id", textBox5.Text.Trim());

                        MessageBox.Show("Trying to register user: " + textBox1.Text);
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Registered Successfully");
                        else
                            MessageBox.Show("Insert Failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int SuggestNextUserId(NpgsqlConnection conn)
        {
            int nextId = 1;
            string query = "SELECT user_id FROM users ORDER BY user_id ASC";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                HashSet<int> usedIds = new HashSet<int>();
                while (reader.Read())
                {
                    usedIds.Add(reader.GetInt32(0));
                }

                while (usedIds.Contains(nextId))
                {
                    nextId++;
                }
            }

            return nextId;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string userIdText = textBox6.Text.Trim();
            int userId;
            if (!int.TryParse(userIdText, out userId))
            {
                MessageBox.Show("User ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=Kuttuz@06;Database=postgres;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM users WHERE user_id = @userId";
                using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        int nextAvailable = SuggestNextUserId(conn);
                        MessageBox.Show($"User ID {userId} is not available.\nSuggested User ID: {nextAvailable}", "User ID Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox6.Text = nextAvailable.ToString();
                        textBox6.Focus();
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text, @"^\d*$"))
            {
                MessageBox.Show("Please enter numbers only.");
                textBox3.Text = string.Concat(textBox3.Text.Where(char.IsDigit));
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox4.Text, @"^\d*$"))
            {
                MessageBox.Show("Please enter numbers only.");
                textBox4.Text = string.Concat(textBox4.Text.Where(char.IsDigit));
                textBox4.SelectionStart = textBox4.Text.Length;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox5.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
            }
        }
    }
}
