using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.Screens.MainForm.PopUps.OrderPopUp
{
    public partial class AddOrderPopUp : Form
    {
        public AddOrderPopUp()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TypeTextBox.Text) && 
                !string.IsNullOrEmpty(DescTextBox.Text))
            {
                Utility.OrderUtility.addOrderToStorage(TypeTextBox.Text, 
                                                       DescTextBox.Text, 
                                                       checkBox1.Checked);
                Close();
            }
        }
    }
}
