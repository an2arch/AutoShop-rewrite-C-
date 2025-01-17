﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoShop.Utility;

namespace AutoShop.Screens.Auth
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            Name_Window.Show();
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            registerMode = !registerMode;
            if (registerMode)
            {
                NameLabel.Show();
                NameTextBox.Show();
                Name_Window.Text = "Registration";
                SubmitButton.Text = "Sign up";
                SwitchButton.Text = "Back to Authorization";
            } else
            {
                NameLabel.Hide();
                NameTextBox.Hide();
                Name_Window.Text = "Authorization";
                SubmitButton.Text = "Sign in";
                SwitchButton.Text = "Register";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!registerMode && 
                !string.IsNullOrEmpty(LoginTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                if (!Utility.AccountUtility.Auth(LoginTextBox.Text, PasswordTextBox.Text))
                {
                    MessageBox.Show(
                        "Account with that login and password does not exist",
                        "Authorization error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } else
                {
                    Close();
                }
            } else if (registerMode &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(LoginTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                if (!Utility.AccountUtility.Register(NameTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text))
                {
                    MessageBox.Show(
                        "Account with that login already exists",
                        "Registration error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } else
                {
                    Close();
                }
            }
        }
    }
}
