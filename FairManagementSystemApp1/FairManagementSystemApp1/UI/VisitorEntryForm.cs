using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApp1.BLL;
using FairManagementSystemApp1.Model;

namespace FairManagementSystemApp1.UI
{
    public partial class VisitorEntryForm : Form
    {
        FM_manager aFmManager = new FM_manager();
        public VisitorEntryForm()
        {
            InitializeComponent();
        }
        visitor aVisitor = new visitor();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" && contactNumberTextBox.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                aVisitor.visitorName = nameTextBox.Text;
                aVisitor.visitorEmail = emailTextBox.Text;
                aVisitor.visitorCellNo = int.Parse(contactNumberTextBox.Text);

                MessageBox.Show(aFmManager.Save(aVisitor));
                //ClearTextBoxes();
                nameTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                contactNumberTextBox.Text = string.Empty;
            }
        }
    }
}
