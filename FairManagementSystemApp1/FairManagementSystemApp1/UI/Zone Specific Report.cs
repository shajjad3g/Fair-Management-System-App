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
using Microsoft.Office.Interop.Excel;

namespace FairManagementSystemApp1.UI
{
    public partial class Zone_Specific_Report : Form
    {
        FM_manager aFmManager = new FM_manager();
        public Zone_Specific_Report()
        {
            InitializeComponent();
            LoadAllVisitorsListView();
        }

        private void zoneListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadAllVisitorsListView()
        {
            List<visitor> visitorsList = aFmManager.LoadAllVisitors();

            visitorZoneListView.Items.Clear();
           
            foreach (var visitors in visitorsList)
            {
               
                ListViewItem listViewItem = new ListViewItem(visitors.visitorName.ToString());
                listViewItem.SubItems.Add(visitors.visitorEmail.ToString());
                listViewItem.SubItems.Add(visitors.visitorCellNo.ToString());
                listViewItem.Tag = visitors;

                visitorZoneListView.Items.Add(listViewItem);
            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {

        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet) Excel.ActiveSheet;

            Excel.Visible = true;

            ws.Cells[1, 2] = "Visitor Name";
            ws.Cells[1, 3] = "Email";
            ws.Cells[1, 4] = "Contact Number";

            for (int j = 2; j <= visitorZoneListView.Items.Count; j++)
            {
                for (int i = 2; i <= 3; i++)
                {
                    //ws.Cells[j, i] = visitorZoneListView.Items[j - 2];
                    
                }
            }

        }
    }
}
