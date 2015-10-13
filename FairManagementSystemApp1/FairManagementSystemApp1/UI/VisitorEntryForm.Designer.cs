namespace FairManagementSystemApp1.UI
{
    partial class VisitorEntryForm
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
            this.visitorEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.zoneGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.visitorEntryGroupBox.SuspendLayout();
            this.zoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // visitorEntryGroupBox
            // 
            this.visitorEntryGroupBox.Controls.Add(this.contactNumberTextBox);
            this.visitorEntryGroupBox.Controls.Add(this.emailTextBox);
            this.visitorEntryGroupBox.Controls.Add(this.nameTextBox);
            this.visitorEntryGroupBox.Controls.Add(this.label3);
            this.visitorEntryGroupBox.Controls.Add(this.label2);
            this.visitorEntryGroupBox.Controls.Add(this.label1);
            this.visitorEntryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorEntryGroupBox.Location = new System.Drawing.Point(23, 23);
            this.visitorEntryGroupBox.Name = "visitorEntryGroupBox";
            this.visitorEntryGroupBox.Size = new System.Drawing.Size(493, 162);
            this.visitorEntryGroupBox.TabIndex = 0;
            this.visitorEntryGroupBox.TabStop = false;
            this.visitorEntryGroupBox.Text = "Visitor\'s Information";
            this.visitorEntryGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(151, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(308, 26);
            this.nameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(151, 73);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(308, 26);
            this.emailTextBox.TabIndex = 4;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(151, 114);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(220, 26);
            this.contactNumberTextBox.TabIndex = 5;
            // 
            // zoneGroupBox
            // 
            this.zoneGroupBox.Controls.Add(this.checkBox5);
            this.zoneGroupBox.Controls.Add(this.checkBox4);
            this.zoneGroupBox.Controls.Add(this.checkBox3);
            this.zoneGroupBox.Controls.Add(this.checkBox2);
            this.zoneGroupBox.Controls.Add(this.checkBox1);
            this.zoneGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneGroupBox.Location = new System.Drawing.Point(23, 218);
            this.zoneGroupBox.Name = "zoneGroupBox";
            this.zoneGroupBox.Size = new System.Drawing.Size(493, 268);
            this.zoneGroupBox.TabIndex = 1;
            this.zoneGroupBox.TabStop = false;
            this.zoneGroupBox.Text = "Zone Type Visitor Wants To Visit";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enterprise Application Zone";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(102, 88);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mobile Apps Zone";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(102, 130);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(197, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Game & Multimedia Zone";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(102, 175);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(197, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Telecom Software Zone";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(102, 220);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(202, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Digital Bangladesh Zone";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(398, 502);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VisitorEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 546);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.zoneGroupBox);
            this.Controls.Add(this.visitorEntryGroupBox);
            this.Name = "VisitorEntryForm";
            this.Text = "VisitorEntryForm";
            this.visitorEntryGroupBox.ResumeLayout(false);
            this.visitorEntryGroupBox.PerformLayout();
            this.zoneGroupBox.ResumeLayout(false);
            this.zoneGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox visitorEntryGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox zoneGroupBox;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button saveButton;
    }
}