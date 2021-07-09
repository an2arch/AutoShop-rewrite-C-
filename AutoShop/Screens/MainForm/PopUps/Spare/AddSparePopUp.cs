using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShop.Screens.MainForm.PopUps.SparePopUp
{
    public partial class AddSparePopUp : Form
    {
        public AddSparePopUp()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(TypeTextBox.Text))
            {
                Utility.SpareUtility.addSpareToStorage(NameTextBox.Text, 
                    TypeTextBox.Text, 
                    Convert.ToUInt32(AmountNumeric.Value));
                Close();
            }
        }
    }
}
