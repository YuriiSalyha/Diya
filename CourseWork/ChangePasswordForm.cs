using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Diia
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void confirmPasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                string password = newPasswordBox.Text;
                if (password.Length <= 10 && password.Length >= 6
                    && password == repeatPasswordBox.Text)
                {
                    using (var db = new ApplicationDbContext())
                    {
                        var currentUser = db.TaxPayerCards.Where(p => p.Number == CurrentUserTaxPayerNumber.TaxPayerNumber).ToList();
                        string passwordSalt = currentUser.FirstOrDefault().Person.Password.FirstOrDefault().PasswordSalt;
                        string passwordWithSalt = passwordSalt + password;
                        string newHash = Hash(passwordWithSalt);
                        currentUser.FirstOrDefault().Person.Password.FirstOrDefault().PasswordHash = newHash;
                        db.SaveChanges();
                        MessageBox.Show("Password is successfully saved");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Password is not saved");
            }
            this.Close();
        }
        public string Hash(string input)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = hasher.ComputeHash(Encoding.Unicode.GetBytes(input));

                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("X2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
    }
}
