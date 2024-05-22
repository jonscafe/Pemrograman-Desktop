using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuizProtop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            string hashedPassword = HashPassword(password);
            SaveUser(username, hashedPassword);

            MessageBox.Show("User registered successfully!");
            this.Close();
        }

        private bool IsUsernameTaken(string username)
        {
            if (!File.Exists("users.csv"))
            {
                return false;
            }

            var lines = File.ReadAllLines("users.csv");
            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (data[0] == username)
                {
                    return true;
                }
            }
            return false;
        }

        private void SaveUser(string username, string hashedPassword)
        {
            using (StreamWriter writer = new StreamWriter("users.csv", true))
            {
                writer.WriteLine($"{username},{hashedPassword}");
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
