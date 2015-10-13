using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApp1.BLL;
using FairManagementSystemApp1.Model;

namespace FairManagementSystemApp1.UI
{
    public partial class ZoneType : Form
    {
        public ZoneType()
        {
            InitializeComponent();
        }

        ZoneClass aZoneClass = new ZoneClass();

        ZoneTypeManager aZoneTypeManager = new ZoneTypeManager();
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        
        //public int VisitorZoneId = 0;

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (zoneTypeTextBox.Text == "")
            {
                MessageBox.Show("Zone field is required!");
            }
            else
            {

                aZoneClass.zoneType = zoneTypeTextBox.Text;

                MessageBox.Show(aZoneTypeManager.Save(aZoneClass));
                LoadAllZoneTypeListView();
                //ClearTextBoxes();
                visitorZoneIdTextBox.Text = string.Empty;
                zoneTypeTextBox.Text = string.Empty;
            }
        }

        private void LoadAllZoneTypeListView()
        {
            List<ZoneClass> zoneTypeList = aZoneTypeManager.LoadAllZoneType();

            zoneTypeListView.Items.Clear();
            
           
            foreach (var zone in zoneTypeList)
            {
                ListViewItem listViewItem = new ListViewItem(zone.zoneType.ToString());
                listViewItem.Tag = zone;
                zoneTypeListView.Items.Add(listViewItem);
            }
        }
    }
}
