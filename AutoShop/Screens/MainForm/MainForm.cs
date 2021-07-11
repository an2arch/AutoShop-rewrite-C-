using System;
using System.Linq;
using System.Windows.Forms;

using AutoShop.Screens.MainForm.PopUps.AccountPopUp;
using AutoShop.Screens.MainForm.PopUps.OrderPopUp;
using AutoShop.Screens.MainForm.PopUps.SparePopUp;
using AutoShop.Models;
using AutoShop.Storage;

namespace AutoShop.Screens.MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Storage.Storage storage = Storage.Storage.getStorage();
            if (storage.getState().currentUser.Access == Account.LevelAccess.Admin)
            {
                AddAccountsPage();
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Name == "ExitTabPage") {
                Storage.Storage storage = Storage.Storage.getStorage();
                storage.dispatch(new Storage.Action.Action(
                    Storage.Action.ActionType.CLEAR_CURRENT_USER
                    ));

                Hide();

                var auth = new Auth.Auth();
                auth.ShowDialog();

                if (storage.getState().currentUser != null)
                {
                    if(storage.getState().currentUser.Access == Account.LevelAccess.Admin)
                    {
                        AddAccountsPage();
                    } else
                    {
                        DeleteAccountsPage();
                    }

                    Show();
                    TabControl.SelectTab(0);
                } else
                {
                    Close();
                }
            }
        }

        private void AccountsTabPage_Enter(object sender, EventArgs e)
        {
            var source = new BindingSource(Storage.Storage.getStorage().getState().accounts, null);
            AccountsDataGrid.DataSource = source;
        }

        private void SparesTabPage_Enter(object sender, EventArgs e)
        {
            var source = new BindingSource(Storage.Storage.getStorage().getState().spares, null);
            SparesDataGrid.DataSource = source;
        }

        private void OrdersTabPage_Enter(object sender, EventArgs e)
        {
            var source = new BindingSource(Storage.Storage.getStorage().getState().orders, null);
            OrdersDataGrid.DataSource = source;
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountPopUp addAccountPopUp = new AddAccountPopUp();

            Enabled = false;
            addAccountPopUp.ShowDialog(this);
            Enabled = true;
        }

        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            if (AccountsDataGrid.SelectedCells.Count > 0)
            {
                int selectedId = Convert.ToInt32(AccountsDataGrid
                                                .Rows[AccountsDataGrid.CurrentRow.Index]
                                                .Cells[0]
                                                .Value);
                Account editAccount = 
                    Storage.Storage.getStorage().getState()
                        .accounts.Single((Account account) => account.Id == selectedId);

                EditAccountPopUp popUp = new EditAccountPopUp(editAccount);

                Enabled = false;
                popUp.ShowDialog(this);
                Enabled = true;
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if (AccountsDataGrid.SelectedCells.Count > 0)
            {
                int selectedId = Convert.ToInt32(
                    AccountsDataGrid
                    .Rows[AccountsDataGrid.CurrentRow.Index]
                    .Cells[0]
                    .Value
                    .ToString()
                    );
                var accounts = Storage.Storage.getStorage().getState().accounts;
                if (accounts.Single((Account acc) => acc.Id == selectedId).Access != Account.LevelAccess.Admin)
                {
                    Utility.AccountUtility.deleteAccountFromStorage(selectedId);
                    if (Storage.Storage.getStorage().getState().currentUser.Id == selectedId)
                    {
                        TabControl.SelectTab(TabControl.TabCount - 1);
                    }
                } else
                {
                    MessageBox.Show("You cannot delete admins account",
                                     "Deletion Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            var popUp = new AddOrderPopUp();

            Enabled = false;
            popUp.ShowDialog(this);
            Enabled = true;
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            if (OrdersDataGrid.SelectedCells.Count > 0)
            {
                int selectedId = Convert.ToInt32(OrdersDataGrid
                                                .Rows[OrdersDataGrid.CurrentRow.Index]
                                                .Cells[0]
                                                .Value);
                Order editOrder = 
                    Storage.Storage.getStorage().getState()
                        .orders.Single((Order order) => order.Id == selectedId);

                var popUp = new EditOrderPopUp(editOrder);

                Enabled = false;
                popUp.ShowDialog(this);
                Enabled = true;
            }
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (OrdersDataGrid.SelectedCells.Count > 0)
            {
                uint selectedId = Convert.ToUInt32(
                    OrdersDataGrid
                    .Rows[OrdersDataGrid.CurrentRow.Index]
                    .Cells[0]
                    .Value
                    .ToString()
                    );
                Utility.OrderUtility.completeOrder(selectedId);

                var source = new BindingSource(Storage.Storage.getStorage().getState().orders, null);
                OrdersDataGrid.DataSource = source;
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (OrdersDataGrid.SelectedCells.Count > 0)
            {
                int selectedId = Convert.ToInt32(
                    OrdersDataGrid
                    .Rows[OrdersDataGrid.CurrentRow.Index]
                    .Cells[0]
                    .Value
                    .ToString()
                    );
                Utility.OrderUtility.deleteOrderFromStorage(selectedId);
            }
        }

        private void AddSpareButton_Click(object sender, EventArgs e)
        {
            var popUp = new AddSparePopUp();

            Enabled = false;
            popUp.ShowDialog(this);
            Enabled = true;
        }

        private void EditSpareButton_Click(object sender, EventArgs e)
        {
            if (SparesDataGrid.SelectedCells.Count > 0)
            {
                int selectedId = Convert.ToInt32(SparesDataGrid
                                                .Rows[SparesDataGrid.CurrentRow.Index]
                                                .Cells[0]
                                                .Value);
                Spare editSpare = 
                    Storage.Storage.getStorage().getState()
                        .spares.Single((Spare spare) => spare.Id == selectedId);

                var popUp = new EditSparePopUp(editSpare);

                Enabled = false;
                popUp.ShowDialog(this);
                Enabled = true;
            }
        }

        private void DeleteSpareButton_Click(object sender, EventArgs e)
        {
            if (SparesDataGrid.SelectedCells.Count > 0)
            {
                int selectedId = Convert.ToInt32(
                    OrdersDataGrid
                    .Rows[SparesDataGrid.CurrentRow.Index]
                    .Cells[0]
                    .Value
                    .ToString()
                    );
                Utility.SpareUtility.deleteSpareFromStorage(selectedId);
            }
        }

        private void AddAccountsPage() 
        {
            if (AccountsTabPage == null) 
            {
                TabControl.TabPages.Insert(TabControl.TabPages.Count - 1, "Accounts");
                AccountsTabPage = TabControl.TabPages[TabControl.TabPages.Count - 2];

                AccountsTabPage.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(AccountsDataGrid)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(accountBindingSource)).BeginInit();

                // 
                // AccountsTabPage
                // 
                AccountsTabPage.Controls.Add(DeleteAccountButton);
                AccountsTabPage.Controls.Add(EditAccountButton);
                AccountsTabPage.Controls.Add(AddAccountButton);
                AccountsTabPage.Controls.Add(AccountsDataGrid);
                AccountsTabPage.Location = new System.Drawing.Point(4, 31);
                AccountsTabPage.Name = "AccountsTabPage";
                AccountsTabPage.Padding = new System.Windows.Forms.Padding(3);
                AccountsTabPage.Size = new System.Drawing.Size(731, 431);
                AccountsTabPage.TabIndex = 2;
                AccountsTabPage.Text = "Accounts";
                AccountsTabPage.UseVisualStyleBackColor = true;
                AccountsTabPage.Enter += new System.EventHandler(AccountsTabPage_Enter);
                // 
                // DeleteAccountButton
                // 
                DeleteAccountButton.Location = new System.Drawing.Point(7, 82);
                DeleteAccountButton.Name = "DeleteAccountButton";
                DeleteAccountButton.Size = new System.Drawing.Size(205, 31);
                DeleteAccountButton.TabIndex = 2;
                DeleteAccountButton.Text = "Delete account";
                DeleteAccountButton.UseVisualStyleBackColor = true;
                DeleteAccountButton.Click += new System.EventHandler(DeleteAccountButton_Click);
                // 
                // EditAccountButton
                // 
                EditAccountButton.Location = new System.Drawing.Point(7, 45);
                EditAccountButton.Name = "EditAccountButton";
                EditAccountButton.Size = new System.Drawing.Size(205, 31);
                EditAccountButton.TabIndex = 1;
                EditAccountButton.Text = "Edit account";
                EditAccountButton.UseVisualStyleBackColor = true;
                EditAccountButton.Click += new System.EventHandler(EditAccountButton_Click);
                // 
                // AddAccountButton
                // 
                AddAccountButton.Location = new System.Drawing.Point(7, 8);
                AddAccountButton.Name = "AddAccountButton";
                AddAccountButton.Size = new System.Drawing.Size(205, 31);
                AddAccountButton.TabIndex = 0;
                AddAccountButton.Text = "Add new account";
                AddAccountButton.UseVisualStyleBackColor = true;
                AddAccountButton.Click += new System.EventHandler(AddAccountButton_Click);

                AccountsTabPage.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(AccountsDataGrid)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(accountBindingSource)).EndInit();
            }
        }

        private void DeleteAccountsPage()
        {
            if (AccountsTabPage != null)
            {
                TabControl.TabPages.Remove(AccountsTabPage);
                AccountsTabPage = null;
            }
        }
    }
}
