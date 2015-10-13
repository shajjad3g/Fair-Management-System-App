namespace FairManagementSystemApp1.UI
{
    partial class Zone_Specific_Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.zoneSpecificComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.visitorZoneListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.total1TextBox = new System.Windows.Forms.TextBox();
            this.excelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // zoneSpecificComboBox
            // 
            this.zoneSpecificComboBox.FormattingEnabled = true;
            this.zoneSpecificComboBox.Items.AddRange(new object[] {
            "Enterprise Application Zone",
            "Mobile Apps Zone",
            "Game & Multimedia Zone",
            "Telecom Software Zone",
            "Digital Bangladesh Zone"});
            this.zoneSpecificComboBox.Location = new System.Drawing.Point(194, 28);
            this.zoneSpecificComboBox.Name = "zoneSpecificComboBox";
            this.zoneSpecificComboBox.Size = new System.Drawing.Size(197, 21);
            this.zoneSpecificComboBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(425, 27);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 22);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // visitorZoneListView
            // 
            this.visitorZoneListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.visitorZoneListView.Location = new System.Drawing.Point(27, 78);
            this.visitorZoneListView.Name = "visitorZoneListView";
            this.visitorZoneListView.Size = new System.Drawing.Size(596, 251);
            this.visitorZoneListView.TabIndex = 3;
            this.visitorZoneListView.UseCompatibleStateImageBehavior = false;
            this.visitorZoneListView.View = System.Windows.Forms.View.Details;
            this.visitorZoneListView.SelectedIndexChanged += new System.EventHandler(this.zoneListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Visitor Name";
            this.columnHeader1.Width = 222;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 191;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total";
            // 
            // total1TextBox
            // 
            this.total1TextBox.Location = new System.Drawing.Point(523, 350);
            this.total1TextBox.Name = "total1TextBox";
            this.total1TextBox.Size = new System.Drawing.Size(100, 20);
            this.total1TextBox.TabIndex = 5;
            // 
            // excelButton
            // 
            this.excelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelButton.Location = new System.Drawing.Point(500, 406);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(123, 23);
            this.excelButton.TabIndex = 6;
            this.excelButton.Text = "Export To Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // Zone_Specific_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.total1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitorZoneListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.zoneSpecificComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Zone_Specific_Report";
            this.Text = "Zone Specific Visitor Information Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox zoneSpecificComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListView visitorZoneListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox total1TextBox;
        private System.Windows.Forms.Button excelButton;
    }
}