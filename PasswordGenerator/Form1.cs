using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private string[] _allowedCharacters;
        public Form1()
        {
            InitializeComponent();
            _allowedCharacters = txtAllowedCharacters.Text.Split();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            var passwordIsValid = false;
            string generatedPassword = GetPassword();

            while (passwordIsValid == false)
            {
                passwordIsValid = true;
                foreach (char c in generatedPassword)
                {
                    if (char.IsLetterOrDigit(c)) continue;

                    if (_allowedCharacters.Contains(c.ToString()) == false)
                    {
                        passwordIsValid = false;
                        break;
                    }
                }

                if (generatedPassword.Any(char.IsUpper) == false
                    || generatedPassword.Any(char.IsLower) == false
                    || generatedPassword.Any(char.IsDigit) == false)
                {
                    passwordIsValid = false;
                }

                if (passwordIsValid == false)
                {
                    generatedPassword = GetPassword();
                }
            }

            txtGeneratedPassword.Text = generatedPassword;
            Clipboard.SetText(generatedPassword);
        }

        private string GetPassword()
        {
            return Membership.GeneratePassword((int)numPasswordLength.Value, (int)numSpecialCharacters.Value);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
