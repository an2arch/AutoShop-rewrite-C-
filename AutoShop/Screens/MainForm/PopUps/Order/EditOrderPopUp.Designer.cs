
namespace AutoShop.Screens.MainForm.PopUps.OrderPopUp
{
    partial class EditOrderPopUp
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
            this.CompletedCheck = new System.Windows.Forms.CheckBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompletedCheck
            // 
            this.CompletedCheck.Location = new System.Drawing.Point(123, 79);
            this.CompletedCheck.Name = "CompletedCheck";
            this.CompletedCheck.Size = new System.Drawing.Size(140, 30);
            this.CompletedCheck.TabIndex = 2;
            this.CompletedCheck.Text = "Is completed?";
            this.CompletedCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompletedCheck.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(16, 127);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(356, 32);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DescTextBox
            // 
            this.DescTextBox.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescTextBox.Location = new System.Drawing.Point(158, 44);
            this.DescTextBox.MaxLength = 16;
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(214, 29);
            this.DescTextBox.TabIndex = 1;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeTextBox.Location = new System.Drawing.Point(158, 9);
            this.TypeTextBox.MaxLength = 16;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(214, 29);
            this.TypeTextBox.TabIndex = 0;
            // 
            // DescLabel
            // 
            this.DescLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescLabel.Location = new System.Drawing.Point(12, 44);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(122, 29);
            this.DescLabel.TabIndex = 22;
            this.DescLabel.Text = "Description";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(12, 9);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(122, 29);
            this.TypeLabel.TabIndex = 21;
            this.TypeLabel.Text = "Type";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditOrderPopUp
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 170);
            this.Controls.Add(this.CompletedCheck);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.TypeLabel);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditOrderPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CompletedCheck;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label TypeLabel;
    }
}