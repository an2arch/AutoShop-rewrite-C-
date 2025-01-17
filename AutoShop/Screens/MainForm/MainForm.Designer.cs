﻿
namespace AutoShop.Screens.MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.OrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.IdOrderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOrderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescOrderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedOrderCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SparesTabPage = new System.Windows.Forms.TabPage();
            this.DeleteSpareButton = new System.Windows.Forms.Button();
            this.EditSpareButton = new System.Windows.Forms.Button();
            this.AddSpareButton = new System.Windows.Forms.Button();
            this.SparesDataGrid = new System.Windows.Forms.DataGridView();
            this.IdSpareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSpareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeSpareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountSpareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExitTabPage = new System.Windows.Forms.TabPage();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.AccountsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdAccountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAccountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginAccountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordAccountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessAccountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SparesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SparesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Controls.Add(this.SparesTabPage);
            this.TabControl.Controls.Add(this.ExitTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(739, 466);
            this.TabControl.TabIndex = 0;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.DeleteOrderButton);
            this.OrdersTabPage.Controls.Add(this.CompleteButton);
            this.OrdersTabPage.Controls.Add(this.EditOrderButton);
            this.OrdersTabPage.Controls.Add(this.AddOrderButton);
            this.OrdersTabPage.Controls.Add(this.OrdersDataGrid);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 31);
            this.OrdersTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrdersTabPage.Size = new System.Drawing.Size(731, 431);
            this.OrdersTabPage.TabIndex = 0;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            this.OrdersTabPage.Enter += new System.EventHandler(this.OrdersTabPage_Enter);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(7, 119);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(205, 31);
            this.DeleteOrderButton.TabIndex = 3;
            this.DeleteOrderButton.Text = "Delete order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(7, 82);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(205, 31);
            this.CompleteButton.TabIndex = 2;
            this.CompleteButton.Text = "Complete order";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Location = new System.Drawing.Point(7, 45);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(205, 31);
            this.EditOrderButton.TabIndex = 1;
            this.EditOrderButton.Text = "Edit order";
            this.EditOrderButton.UseVisualStyleBackColor = true;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(7, 8);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(205, 31);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Add new order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.AllowUserToAddRows = false;
            this.OrdersDataGrid.AllowUserToDeleteRows = false;
            this.OrdersDataGrid.AllowUserToOrderColumns = true;
            this.OrdersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGrid.AutoGenerateColumns = false;
            this.OrdersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.OrdersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.OrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrderCol,
            this.TypeOrderCol,
            this.DescOrderCol,
            this.CompletedOrderCol});
            this.OrdersDataGrid.DataSource = this.orderBindingSource;
            this.OrdersDataGrid.Location = new System.Drawing.Point(218, 0);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.ReadOnly = true;
            this.OrdersDataGrid.Size = new System.Drawing.Size(513, 431);
            this.OrdersDataGrid.TabIndex = 2;
            // 
            // IdOrderCol
            // 
            this.IdOrderCol.DataPropertyName = "Id";
            this.IdOrderCol.HeaderText = "Id";
            this.IdOrderCol.Name = "IdOrderCol";
            this.IdOrderCol.ReadOnly = true;
            this.IdOrderCol.Width = 49;
            // 
            // TypeOrderCol
            // 
            this.TypeOrderCol.DataPropertyName = "Type";
            this.TypeOrderCol.HeaderText = "Type";
            this.TypeOrderCol.Name = "TypeOrderCol";
            this.TypeOrderCol.ReadOnly = true;
            this.TypeOrderCol.Width = 71;
            // 
            // DescOrderCol
            // 
            this.DescOrderCol.DataPropertyName = "Description";
            this.DescOrderCol.HeaderText = "Description";
            this.DescOrderCol.Name = "DescOrderCol";
            this.DescOrderCol.ReadOnly = true;
            this.DescOrderCol.Width = 123;
            // 
            // CompletedOrderCol
            // 
            this.CompletedOrderCol.DataPropertyName = "IsCompleted";
            this.CompletedOrderCol.HeaderText = "Is Completed?";
            this.CompletedOrderCol.Name = "CompletedOrderCol";
            this.CompletedOrderCol.ReadOnly = true;
            this.CompletedOrderCol.Width = 122;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(AutoShop.Models.Order);
            // 
            // SparesTabPage
            // 
            this.SparesTabPage.Controls.Add(this.DeleteSpareButton);
            this.SparesTabPage.Controls.Add(this.EditSpareButton);
            this.SparesTabPage.Controls.Add(this.AddSpareButton);
            this.SparesTabPage.Controls.Add(this.SparesDataGrid);
            this.SparesTabPage.Location = new System.Drawing.Point(4, 31);
            this.SparesTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SparesTabPage.Name = "SparesTabPage";
            this.SparesTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SparesTabPage.Size = new System.Drawing.Size(731, 431);
            this.SparesTabPage.TabIndex = 1;
            this.SparesTabPage.Text = "Spares";
            this.SparesTabPage.UseVisualStyleBackColor = true;
            this.SparesTabPage.Enter += new System.EventHandler(this.SparesTabPage_Enter);
            // 
            // DeleteSpareButton
            // 
            this.DeleteSpareButton.Location = new System.Drawing.Point(7, 82);
            this.DeleteSpareButton.Name = "DeleteSpareButton";
            this.DeleteSpareButton.Size = new System.Drawing.Size(205, 31);
            this.DeleteSpareButton.TabIndex = 2;
            this.DeleteSpareButton.Text = "Delete spare";
            this.DeleteSpareButton.UseVisualStyleBackColor = true;
            this.DeleteSpareButton.Click += new System.EventHandler(this.DeleteSpareButton_Click);
            // 
            // EditSpareButton
            // 
            this.EditSpareButton.Location = new System.Drawing.Point(7, 45);
            this.EditSpareButton.Name = "EditSpareButton";
            this.EditSpareButton.Size = new System.Drawing.Size(205, 31);
            this.EditSpareButton.TabIndex = 1;
            this.EditSpareButton.Text = "Edit spare";
            this.EditSpareButton.UseVisualStyleBackColor = true;
            this.EditSpareButton.Click += new System.EventHandler(this.EditSpareButton_Click);
            // 
            // AddSpareButton
            // 
            this.AddSpareButton.Location = new System.Drawing.Point(7, 8);
            this.AddSpareButton.Name = "AddSpareButton";
            this.AddSpareButton.Size = new System.Drawing.Size(205, 31);
            this.AddSpareButton.TabIndex = 0;
            this.AddSpareButton.Text = "Add new spare";
            this.AddSpareButton.UseVisualStyleBackColor = true;
            this.AddSpareButton.Click += new System.EventHandler(this.AddSpareButton_Click);
            // 
            // SparesDataGrid
            // 
            this.SparesDataGrid.AllowUserToAddRows = false;
            this.SparesDataGrid.AllowUserToDeleteRows = false;
            this.SparesDataGrid.AllowUserToOrderColumns = true;
            this.SparesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SparesDataGrid.AutoGenerateColumns = false;
            this.SparesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.SparesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SparesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SparesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSpareCol,
            this.NameSpareCol,
            this.TypeSpareCol,
            this.AmountSpareCol});
            this.SparesDataGrid.DataSource = this.spareBindingSource;
            this.SparesDataGrid.Location = new System.Drawing.Point(218, 0);
            this.SparesDataGrid.Name = "SparesDataGrid";
            this.SparesDataGrid.ReadOnly = true;
            this.SparesDataGrid.Size = new System.Drawing.Size(513, 431);
            this.SparesDataGrid.TabIndex = 7;
            // 
            // IdSpareCol
            // 
            this.IdSpareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdSpareCol.DataPropertyName = "Id";
            this.IdSpareCol.Frozen = true;
            this.IdSpareCol.HeaderText = "Id";
            this.IdSpareCol.Name = "IdSpareCol";
            this.IdSpareCol.ReadOnly = true;
            this.IdSpareCol.Width = 49;
            // 
            // NameSpareCol
            // 
            this.NameSpareCol.DataPropertyName = "Name";
            this.NameSpareCol.Frozen = true;
            this.NameSpareCol.HeaderText = "Name";
            this.NameSpareCol.Name = "NameSpareCol";
            this.NameSpareCol.ReadOnly = true;
            this.NameSpareCol.Width = 80;
            // 
            // TypeSpareCol
            // 
            this.TypeSpareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TypeSpareCol.DataPropertyName = "Type";
            this.TypeSpareCol.Frozen = true;
            this.TypeSpareCol.HeaderText = "Type";
            this.TypeSpareCol.Name = "TypeSpareCol";
            this.TypeSpareCol.ReadOnly = true;
            this.TypeSpareCol.Width = 71;
            // 
            // AmountSpareCol
            // 
            this.AmountSpareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AmountSpareCol.DataPropertyName = "Amount";
            this.AmountSpareCol.Frozen = true;
            this.AmountSpareCol.HeaderText = "Amount";
            this.AmountSpareCol.Name = "AmountSpareCol";
            this.AmountSpareCol.ReadOnly = true;
            this.AmountSpareCol.Width = 96;
            // 
            // spareBindingSource
            // 
            this.spareBindingSource.DataSource = typeof(AutoShop.Models.Spare);
            // 
            // ExitTabPage
            // 
            this.ExitTabPage.Location = new System.Drawing.Point(4, 31);
            this.ExitTabPage.Name = "ExitTabPage";
            this.ExitTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExitTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitTabPage.Size = new System.Drawing.Size(731, 431);
            this.ExitTabPage.TabIndex = 3;
            this.ExitTabPage.Text = "Exit";
            this.ExitTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(0, 0);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteAccountButton.TabIndex = 0;
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.Location = new System.Drawing.Point(0, 0);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(75, 23);
            this.EditAccountButton.TabIndex = 0;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(0, 0);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(75, 23);
            this.AddAccountButton.TabIndex = 0;
            // 
            // AccountsDataGrid
            // 
            this.AccountsDataGrid.AllowUserToAddRows = false;
            this.AccountsDataGrid.AllowUserToDeleteRows = false;
            this.AccountsDataGrid.AllowUserToOrderColumns = true;
            this.AccountsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsDataGrid.AutoGenerateColumns = false;
            this.AccountsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AccountsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAccountCol,
            this.NameAccountCol,
            this.LoginAccountCol,
            this.PasswordAccountCol,
            this.AccessAccountCol});
            this.AccountsDataGrid.DataSource = this.accountBindingSource;
            this.AccountsDataGrid.Location = new System.Drawing.Point(218, 0);
            this.AccountsDataGrid.Name = "AccountsDataGrid";
            this.AccountsDataGrid.ReadOnly = true;
            this.AccountsDataGrid.Size = new System.Drawing.Size(513, 431);
            this.AccountsDataGrid.TabIndex = 1;
            // 
            // IdAccountCol
            // 
            this.IdAccountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdAccountCol.DataPropertyName = "Id";
            this.IdAccountCol.Frozen = true;
            this.IdAccountCol.HeaderText = "Id";
            this.IdAccountCol.Name = "IdAccountCol";
            this.IdAccountCol.ReadOnly = true;
            // 
            // NameAccountCol
            // 
            this.NameAccountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NameAccountCol.DataPropertyName = "Name";
            this.NameAccountCol.Frozen = true;
            this.NameAccountCol.HeaderText = "Name";
            this.NameAccountCol.Name = "NameAccountCol";
            this.NameAccountCol.ReadOnly = true;
            // 
            // LoginAccountCol
            // 
            this.LoginAccountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoginAccountCol.DataPropertyName = "Login";
            this.LoginAccountCol.Frozen = true;
            this.LoginAccountCol.HeaderText = "Login";
            this.LoginAccountCol.Name = "LoginAccountCol";
            this.LoginAccountCol.ReadOnly = true;
            // 
            // PasswordAccountCol
            // 
            this.PasswordAccountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PasswordAccountCol.DataPropertyName = "Password";
            this.PasswordAccountCol.Frozen = true;
            this.PasswordAccountCol.HeaderText = "Password";
            this.PasswordAccountCol.Name = "PasswordAccountCol";
            this.PasswordAccountCol.ReadOnly = true;
            // 
            // AccessAccountCol
            // 
            this.AccessAccountCol.DataPropertyName = "Access";
            this.AccessAccountCol.Frozen = true;
            this.AccessAccountCol.HeaderText = "Level Access";
            this.AccessAccountCol.Name = "AccessAccountCol";
            this.AccessAccountCol.ReadOnly = true;
            this.AccessAccountCol.Width = 128;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(AutoShop.Models.Account);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 466);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(740, 243);
            this.Name = "MainForm";
            this.Text = "Auto Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.SparesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SparesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private System.Windows.Forms.TabPage SparesTabPage;
        private System.Windows.Forms.TabPage AccountsTabPage;
        private System.Windows.Forms.TabPage ExitTabPage;
        private System.Windows.Forms.DataGridView AccountsDataGrid;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button EditAccountButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridView OrdersDataGrid;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOrderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescOrderCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CompletedOrderCol;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button DeleteSpareButton;
        private System.Windows.Forms.Button EditSpareButton;
        private System.Windows.Forms.Button AddSpareButton;
        private System.Windows.Forms.DataGridView SparesDataGrid;
        private System.Windows.Forms.BindingSource spareBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSpareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSpareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSpareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountSpareCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAccountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAccountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginAccountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordAccountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessAccountCol;
    }
}