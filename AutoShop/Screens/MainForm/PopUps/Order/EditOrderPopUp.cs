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

namespace AutoShop.Screens.MainForm.PopUps.OrderPopUp
{
    public partial class EditOrderPopUp : Form
    {
        Order m_editOrder;
        public EditOrderPopUp(Order order)
        {
            InitializeComponent();
            m_editOrder = order;
            TypeTextBox.Text = order.Type;
            DescTextBox.Text = order.Description;
            CompletedCheck.Checked = order.IsCompleted;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TypeTextBox.Text) &&
                !string.IsNullOrEmpty(DescTextBox.Text))
            {
                Utility.OrderUtility.editOrderInStorage(m_editOrder.Id, 
                    TypeTextBox.Text, 
                    DescTextBox.Text, 
                    CompletedCheck.Checked);
                Close();
            }
        }
    }
}
