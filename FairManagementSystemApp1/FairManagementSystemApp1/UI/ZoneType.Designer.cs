namespace FairManagementSystemApp1.UI
{
    partial class ZoneType
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
            this.zoneGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.zoneTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneTypeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visitorZoneIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneGroupBox
            // 
            this.zoneGroupBox.Controls.Add(this.visitorZoneIdTextBox);
            this.zoneGroupBox.Controls.Add(this.label2);
            this.zoneGroupBox.Controls.Add(this.saveButton);
            this.zoneGroupBox.Controls.Add(this.zoneTypeTextBox);
            this.zoneGroupBox.Controls.Add(this.label1);
            this.zoneGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneGroupBox.Location = new System.Drawing.Point(23, 22);
            this.zoneGroupBox.Name = "zoneGroupBox";
            this.zoneGroupBox.Size = new System.Drawing.Size(338, 151);
            this.zoneGroupBox.TabIndex = 0;
            this.zoneGroupBox.TabStop = false;
            this.zoneGroupBox.Text = "Zone Type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(121, 122);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zoneTypeTextBox
            // 
            this.zoneTypeTextBox.Location = new System.Drawing.Point(121, 72);
            this.zoneTypeTextBox.Name = "zoneTypeTextBox";
            this.zoneTypeTextBox.Size = new System.Drawing.Size(192, 24);
            this.zoneTypeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // zoneTypeListView
            // 
            this.zoneTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.zoneTypeListView.Location = new System.Drawing.Point(23, 179);
            this.zoneTypeListView.Name = "zoneTypeListView";
            this.zoneTypeListView.Size = new System.Drawing.Size(338, 150);
            this.zoneTypeListView.TabIndex = 1;
            this.zoneTypeListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeListView.View = System.Windows.Forms.View.Details;
            this.zoneTypeListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone Type";
            this.columnHeader1.Width = 327;
            // 
            // visitorZoneIdTextBox
            // 
            this.visitorZoneIdTextBox.Location = new System.Drawing.Point(121, 34);
            this.visitorZoneIdTextBox.Name = "visitorZoneIdTextBox";
            this.visitorZoneIdTextBox.Size = new System.Drawing.Size(192, 24);
            this.visitorZoneIdTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visitor Zone Id";
            // 
            // ZoneType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 341);
            this.Controls.Add(this.zoneTypeListView);
            this.Controls.Add(this.zoneGroupBox);
            this.Name = "ZoneType";
            this.Text = "Zone Type Entry";
            this.zoneGroupBox.ResumeLayout(false);
            this.zoneGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox zoneGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox zoneTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView zoneTypeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox visitorZoneIdTextBox;
        private System.Windows.Forms.Label label2;
    }
}