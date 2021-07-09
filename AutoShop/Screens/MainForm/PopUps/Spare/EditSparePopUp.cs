using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoShop.Models;

namespace AutoShop.Screens.MainForm.PopUps.SparePopUp
{
    public partial class EditSparePopUp : Form
    {
        Spare m_editSpare;
        public EditSparePopUp(Spare spare)
        {
            InitializeComponent();
            m_editSpare = spare;
            NameTextBox.Text = spare.Name;
            TypeTextBox.Text = spare.Type;
            AmountNumeric.Value = spare.Amount;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(TypeTextBox.Text))
            {
                Utility.SpareUtility.editSpareToStorage(m_editSpare.Id, 
                    NameTextBox.Text,
                    TypeTextBox.Text, 
                    Convert.ToUInt32(AmountNumeric.Value));
                Close();
            }
        }
    }
}
