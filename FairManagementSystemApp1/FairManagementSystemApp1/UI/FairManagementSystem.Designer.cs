namespace FairManagementSystemApp1
{
    partial class FairManagementSystem
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
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoneSpecificVisitorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoneSpecificVisitorNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(56, 201);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(571, 37);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Welcome To Fair Management System";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisitorToolStripMenuItem,
            this.SetupToolStripMenuItem,
            this.ReportToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(689, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // VisitorToolStripMenuItem
            // 
            this.VisitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisitorEntryToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.VisitorToolStripMenuItem.Name = "VisitorToolStripMenuItem";
            this.VisitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.VisitorToolStripMenuItem.Text = "Visitor";
            // 
            // VisitorEntryToolStripMenuItem
            // 
            this.VisitorEntryToolStripMenuItem.Name = "VisitorEntryToolStripMenuItem";
            this.VisitorEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.VisitorEntryToolStripMenuItem.Text = "Visitor Entry";
            this.VisitorEntryToolStripMenuItem.Click += new System.EventHandler(this.VisitorEntryToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SetupToolStripMenuItem
            // 
            this.SetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoneTypeToolStripMenuItem});
            this.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem";
            this.SetupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SetupToolStripMenuItem.Text = "Setup";
            // 
            // ZoneTypeToolStripMenuItem
            // 
            this.ZoneTypeToolStripMenuItem.Name = "ZoneTypeToolStripMenuItem";
            this.ZoneTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ZoneTypeToolStripMenuItem.Text = "Zone Type";
            this.ZoneTypeToolStripMenuItem.Click += new System.EventHandler(this.ZoneTypeToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoneSpecificVisitorDetailsToolStripMenuItem,
            this.ZoneSpecificVisitorNumberToolStripMenuItem});
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ReportToolStripMenuItem.Text = "Report";
            // 
            // ZoneSpecificVisitorDetailsToolStripMenuItem
            // 
            this.ZoneSpecificVisitorDetailsToolStripMenuItem.Name = "ZoneSpecificVisitorDetailsToolStripMenuItem";
            this.ZoneSpecificVisitorDetailsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ZoneSpecificVisitorDetailsToolStripMenuItem.Text = "Zone Specific Visitor Details";
            this.ZoneSpecificVisitorDetailsToolStripMenuItem.Click += new System.EventHandler(this.ZoneSpecificVisitorDetailsToolStripMenuItem_Click);
            // 
            // ZoneSpecificVisitorNumberToolStripMenuItem
            // 
            this.ZoneSpecificVisitorNumberToolStripMenuItem.Name = "ZoneSpecificVisitorNumberToolStripMenuItem";
            this.ZoneSpecificVisitorNumberToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ZoneSpecificVisitorNumberToolStripMenuItem.Text = "Zone Wise Visitor Number";
            this.ZoneSpecificVisitorNumberToolStripMenuItem.Click += new System.EventHandler(this.ZoneSpecificVisitorNumberToolStripMenuItem_Click);
            // 
            // FairManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 733);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.MenuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FairManagementSystem";
            this.Text = "Fair Management System";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem VisitorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem VisitorEntryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SetupToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ZoneTypeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ZoneSpecificVisitorDetailsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ZoneSpecificVisitorNumberToolStripMenuItem;
    }
}

