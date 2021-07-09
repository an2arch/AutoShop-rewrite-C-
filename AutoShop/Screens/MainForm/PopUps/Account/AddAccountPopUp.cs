using System;
using System.Windows.Forms;

using AutoShop.Utility;
using AutoShop.Models;

namespace AutoShop.Screens.MainForm.PopUps.AccountPopUp
{
    public partial class AddAccountPopUp : Form
    {
        public AddAccountPopUp()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text)     &&
                !string.IsNullOrEmpty(LoginTextBox.Text)    &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) &&
                !string.IsNullOrEmpty(AccessDropMenu.Text))
            {
                Account.LevelAccess access = AccessDropMenu.Text == "Admin" ?
                                                  Account.LevelAccess.Admin:
                                                  Account.LevelAccess.Employee;
                if (Utility.AccountUtility.addAccountToStorage(NameTextBox.Text,
                                                       LoginTextBox.Text,
                                                       PasswordTextBox.Text,
                                                       access))
                {
                    Close();
                } else
                {
                    MessageBox.Show("Account with that login already exists",
                                    "Registration Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
