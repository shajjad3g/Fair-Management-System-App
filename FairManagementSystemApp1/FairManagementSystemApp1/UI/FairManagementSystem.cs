using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApp1.UI;

namespace FairManagementSystemApp1
{
    public partial class FairManagementSystem : Form
    {
        public FairManagementSystem()
        {
            InitializeComponent();
        }

        private void VisitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryForm aVisitorEntryForm = new VisitorEntryForm();
            aVisitorEntryForm.Show();
        }

        private void ZoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneType aZoneType = new ZoneType();
            aZoneType.Show();
        }

        private void ZoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zone_Specific_Report aZoneSpecificReport = new Zone_Specific_Report();
            aZoneSpecificReport.Show();
        }

        private void ZoneSpecificVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorNumberReport aVisitorNumberReport = new VisitorNumberReport();
            aVisitorNumberReport.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FairManagementSystem aFairManagementSystem = new FairManagementSystem();
            aFairManagementSystem.Close();
        }

    }
}
