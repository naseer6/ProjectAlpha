namespace SomerenUI
{
    partial class Activity_Part
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity_Part));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBoxActivityP = new System.Windows.Forms.ComboBox();
            listViewActiveStudents = new System.Windows.Forms.ListView();
            SId = new System.Windows.Forms.ColumnHeader();
            SFullName = new System.Windows.Forms.ColumnHeader();
            STel = new System.Windows.Forms.ColumnHeader();
            SClass = new System.Windows.Forms.ColumnHeader();
            listViewNonActiveStudents = new System.Windows.Forms.ListView();
            NSId = new System.Windows.Forms.ColumnHeader();
            NSFullName = new System.Windows.Forms.ColumnHeader();
            NSTel = new System.Windows.Forms.ColumnHeader();
            NSClass = new System.Windows.Forms.ColumnHeader();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButtonPRem = new System.Windows.Forms.ToolStripButton();
            toolStrip2 = new System.Windows.Forms.ToolStrip();
            toolStripButtonPAdd = new System.Windows.Forms.ToolStripButton();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Participants";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(40, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Activities";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(40, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 21);
            label3.TabIndex = 2;
            label3.Text = "Activity Participants";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(40, 365);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(181, 21);
            label4.TabIndex = 3;
            label4.Text = "Non-Activity Participants";
            // 
            // comboBoxActivityP
            // 
            comboBoxActivityP.DropDownWidth = 246;
            comboBoxActivityP.FormattingEnabled = true;
            comboBoxActivityP.Location = new System.Drawing.Point(40, 95);
            comboBoxActivityP.Name = "comboBoxActivityP";
            comboBoxActivityP.Size = new System.Drawing.Size(313, 23);
            comboBoxActivityP.TabIndex = 4;
            comboBoxActivityP.SelectedIndexChanged += comboBoxActivityP_SelectedIndexChanged;
            // 
            // listViewActiveStudents
            // 
            listViewActiveStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { SId, SFullName, STel, SClass });
            listViewActiveStudents.FullRowSelect = true;
            listViewActiveStudents.GridLines = true;
            listViewActiveStudents.Location = new System.Drawing.Point(40, 158);
            listViewActiveStudents.Name = "listViewActiveStudents";
            listViewActiveStudents.Size = new System.Drawing.Size(412, 137);
            listViewActiveStudents.TabIndex = 5;
            listViewActiveStudents.UseCompatibleStateImageBehavior = false;
            listViewActiveStudents.View = System.Windows.Forms.View.Details;
            // 
            // SId
            // 
            SId.Text = "ID";
            SId.Width = 40;
            // 
            // SFullName
            // 
            SFullName.Text = "Full Name";
            SFullName.Width = 100;
            // 
            // STel
            // 
            STel.Text = "Telephone";
            STel.Width = 100;
            // 
            // SClass
            // 
            SClass.Text = "Class";
            SClass.Width = 70;
            // 
            // listViewNonActiveStudents
            // 
            listViewNonActiveStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { NSId, NSFullName, NSTel, NSClass });
            listViewNonActiveStudents.FullRowSelect = true;
            listViewNonActiveStudents.GridLines = true;
            listViewNonActiveStudents.Location = new System.Drawing.Point(40, 389);
            listViewNonActiveStudents.Name = "listViewNonActiveStudents";
            listViewNonActiveStudents.Size = new System.Drawing.Size(412, 137);
            listViewNonActiveStudents.TabIndex = 6;
            listViewNonActiveStudents.UseCompatibleStateImageBehavior = false;
            listViewNonActiveStudents.View = System.Windows.Forms.View.Details;
            // 
            // NSId
            // 
            NSId.Text = "ID";
            NSId.Width = 40;
            // 
            // NSFullName
            // 
            NSFullName.Text = "Full Name";
            NSFullName.Width = 100;
            // 
            // NSTel
            // 
            NSTel.Text = "Telephone";
            NSTel.Width = 100;
            // 
            // NSClass
            // 
            NSClass.Text = "Class";
            NSClass.Width = 70;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonPRem });
            toolStrip1.Location = new System.Drawing.Point(40, 298);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(74, 28);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPRem
            // 
            toolStripButtonPRem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            toolStripButtonPRem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonPRem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripButtonPRem.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonPRem.Image");
            toolStripButtonPRem.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonPRem.Name = "toolStripButtonPRem";
            toolStripButtonPRem.Size = new System.Drawing.Size(71, 25);
            toolStripButtonPRem.Text = "Remove";
            toolStripButtonPRem.Click += toolStripButton1_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonPAdd });
            toolStrip2.Location = new System.Drawing.Point(40, 529);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(45, 28);
            toolStrip2.TabIndex = 8;
            toolStrip2.Text = "Add";
            // 
            // toolStripButtonPAdd
            // 
            toolStripButtonPAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonPAdd.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonPAdd.Image");
            toolStripButtonPAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonPAdd.Name = "toolStripButtonPAdd";
            toolStripButtonPAdd.Size = new System.Drawing.Size(42, 25);
            toolStripButtonPAdd.Text = "Add";
            toolStripButtonPAdd.Click += toolStripButton2_Click;
            // 
            // Activity_Part
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(516, 594);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(listViewNonActiveStudents);
            Controls.Add(listViewActiveStudents);
            Controls.Add(comboBoxActivityP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Activity_Part";
            Text = "Activity Participants";
            Load += Activity_Part_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxActivityP;
        private System.Windows.Forms.ListView listViewActiveStudents;
        private System.Windows.Forms.ColumnHeader SId;
        private System.Windows.Forms.ColumnHeader SFullName;
        private System.Windows.Forms.ColumnHeader STel;
        private System.Windows.Forms.ColumnHeader SClass;
        private System.Windows.Forms.ListView listViewNonActiveStudents;
        private System.Windows.Forms.ColumnHeader NSId;
        private System.Windows.Forms.ColumnHeader NSFullName;
        private System.Windows.Forms.ColumnHeader NSTel;
        private System.Windows.Forms.ColumnHeader NSClass;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPRem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPAdd;
    }
}