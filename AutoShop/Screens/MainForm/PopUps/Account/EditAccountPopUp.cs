using System;
using System.Linq;
using System.Windows.Forms;

using AutoShop.Models;
using AutoShop.Utility;

namespace AutoShop.Screens.MainForm.PopUps.AccountPopUp
{
    public partial class EditAccountPopUp : Form
    {
        private Account m_accountToEdit;
        public EditAccountPopUp(Account account)
        {
            InitializeComponent();
            m_accountToEdit = account;
            NameTextBox.Text = account.Name;
            LoginTextBox.Text = account.Login;
            PasswordTextBox.Text = account.Password;
            AccessDropMenu.SelectedIndex = Convert.ToInt32(account.Access.ToString() != "Admin");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(LoginTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) &&
                !string.IsNullOrEmpty(AccessDropMenu.Text))
            {
                Utility.AccountUtility.editAccountInStorage(
                    m_accountToEdit.Id, 
                    NameTextBox.Text, 
                    LoginTextBox.Text, 
                    PasswordTextBox.Text,
                    AccessDropMenu.Text == "Admin" ? Account.LevelAccess.Admin : Account.LevelAccess.Employee);
                Close();
            }
        }
    }
}
