namespace SomerenUI
{
    partial class Lecturer_Supervises
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
            label1 = new System.Windows.Forms.Label();
            labelSupervisors = new System.Windows.Forms.Label();
            comboBoxActivities = new System.Windows.Forms.ComboBox();
            labelActivities = new System.Windows.Forms.Label();
            listViewActiveSupervisors = new System.Windows.Forms.ListView();
            Id = new System.Windows.Forms.ColumnHeader();
            ALFullName = new System.Windows.Forms.ColumnHeader();
            ALtel = new System.Windows.Forms.ColumnHeader();
            ALage = new System.Windows.Forms.ColumnHeader();
            listViewNonActiveLecturers = new System.Windows.Forms.ListView();
            NALId = new System.Windows.Forms.ColumnHeader();
            NALFullName = new System.Windows.Forms.ColumnHeader();
            NALTel = new System.Windows.Forms.ColumnHeader();
            NALage = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            toolStripActiveLecturers = new System.Windows.Forms.ToolStrip();
            toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            toolStripNonActiveLecturers = new System.Windows.Forms.ToolStrip();
            toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            toolStripActiveLecturers.SuspendLayout();
            toolStripNonActiveLecturers.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 45);
            label1.TabIndex = 0;
            // 
            // labelSupervisors
            // 
            labelSupervisors.AutoSize = true;
            labelSupervisors.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSupervisors.Location = new System.Drawing.Point(43, 46);
            labelSupervisors.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelSupervisors.Name = "labelSupervisors";
            labelSupervisors.Size = new System.Drawing.Size(213, 51);
            labelSupervisors.TabIndex = 1;
            labelSupervisors.Text = "Supervisors";
            // 
            // comboBoxActivities
            // 
            comboBoxActivities.FormattingEnabled = true;
            comboBoxActivities.Location = new System.Drawing.Point(43, 170);
            comboBoxActivities.Name = "comboBoxActivities";
            comboBoxActivities.Size = new System.Drawing.Size(454, 40);
            comboBoxActivities.TabIndex = 2;
            comboBoxActivities.SelectedIndexChanged += comboBoxActivities_SelectedIndexChanged;
            // 
            // labelActivities
            // 
            labelActivities.AutoSize = true;
            labelActivities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelActivities.Location = new System.Drawing.Point(37, 122);
            labelActivities.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelActivities.Name = "labelActivities";
            labelActivities.Size = new System.Drawing.Size(148, 45);
            labelActivities.TabIndex = 3;
            labelActivities.Text = "Activities";
            // 
            // listViewActiveSupervisors
            // 
            listViewActiveSupervisors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, ALFullName, ALtel, ALage });
            listViewActiveSupervisors.FullRowSelect = true;
            listViewActiveSupervisors.GridLines = true;
            listViewActiveSupervisors.Location = new System.Drawing.Point(43, 312);
            listViewActiveSupervisors.Name = "listViewActiveSupervisors";
            listViewActiveSupervisors.Size = new System.Drawing.Size(618, 187);
            listViewActiveSupervisors.TabIndex = 4;
            listViewActiveSupervisors.UseCompatibleStateImageBehavior = false;
            listViewActiveSupervisors.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            Id.Text = "ID";
            // 
            // ALFullName
            // 
            ALFullName.Text = "Full Name";
            ALFullName.Width = 250;
            // 
            // ALtel
            // 
            ALtel.Text = "Telephon";
            ALtel.Width = 150;
            // 
            // ALage
            // 
            ALage.Text = "Age";
            ALage.Width = 80;
            // 
            // listViewNonActiveLecturers
            // 
            listViewNonActiveLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { NALId, NALFullName, NALTel, NALage });
            listViewNonActiveLecturers.FullRowSelect = true;
            listViewNonActiveLecturers.GridLines = true;
            listViewNonActiveLecturers.Location = new System.Drawing.Point(37, 627);
            listViewNonActiveLecturers.Name = "listViewNonActiveLecturers";
            listViewNonActiveLecturers.Size = new System.Drawing.Size(624, 252);
            listViewNonActiveLecturers.TabIndex = 5;
            listViewNonActiveLecturers.UseCompatibleStateImageBehavior = false;
            listViewNonActiveLecturers.View = System.Windows.Forms.View.Details;
            // 
            // NALId
            // 
            NALId.Text = "ID";
            // 
            // NALFullName
            // 
            NALFullName.Text = "Full Name";
            NALFullName.Width = 250;
            // 
            // NALTel
            // 
            NALTel.Text = "Telephon";
            NALTel.Width = 150;
            // 
            // NALage
            // 
            NALage.Text = "Age";
            NALage.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(43, 244);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(293, 45);
            label2.TabIndex = 6;
            label2.Text = "Activity supervisors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(43, 559);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(374, 45);
            label3.TabIndex = 7;
            label3.Text = "Non-Supervisor lecturers";
            // 
            // toolStripActiveLecturers
            // 
            toolStripActiveLecturers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            toolStripActiveLecturers.Dock = System.Windows.Forms.DockStyle.None;
            toolStripActiveLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripActiveLecturers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStripActiveLecturers.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStripActiveLecturers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonRemove });
            toolStripActiveLecturers.Location = new System.Drawing.Point(43, 504);
            toolStripActiveLecturers.Name = "toolStripActiveLecturers";
            toolStripActiveLecturers.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            toolStripActiveLecturers.Size = new System.Drawing.Size(153, 55);
            toolStripActiveLecturers.TabIndex = 8;
            toolStripActiveLecturers.Text = "toolStrip";
            // 
            // toolStripButtonRemove
            // 
            toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonRemove.Name = "toolStripButtonRemove";
            toolStripButtonRemove.Size = new System.Drawing.Size(147, 49);
            toolStripButtonRemove.Text = "Remove ";
            toolStripButtonRemove.Click += toolStripButtonRemove_Click;
            // 
            // toolStripNonActiveLecturers
            // 
            toolStripNonActiveLecturers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            toolStripNonActiveLecturers.Dock = System.Windows.Forms.DockStyle.None;
            toolStripNonActiveLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripNonActiveLecturers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStripNonActiveLecturers.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStripNonActiveLecturers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonAdd });
            toolStripNonActiveLecturers.Location = new System.Drawing.Point(37, 882);
            toolStripNonActiveLecturers.Name = "toolStripNonActiveLecturers";
            toolStripNonActiveLecturers.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            toolStripNonActiveLecturers.Size = new System.Drawing.Size(151, 55);
            toolStripNonActiveLecturers.TabIndex = 9;
            toolStripNonActiveLecturers.Text = "toolStrip";
            // 
            // toolStripButtonAdd
            // 
            toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonAdd.Name = "toolStripButtonAdd";
            toolStripButtonAdd.Size = new System.Drawing.Size(83, 49);
            toolStripButtonAdd.Text = "Add";
            toolStripButtonAdd.Click += toolStripButtonAdd_Click;
            // 
            // Lecturer_Supervises
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(828, 1002);
            Controls.Add(toolStripNonActiveLecturers);
            Controls.Add(toolStripActiveLecturers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listViewNonActiveLecturers);
            Controls.Add(listViewActiveSupervisors);
            Controls.Add(labelActivities);
            Controls.Add(comboBoxActivities);
            Controls.Add(labelSupervisors);
            Controls.Add(label1);
            Name = "Lecturer_Supervises";
            Text = "Lecturer_Supervises";
            Load += Lecturer_Supervises_Load;
            toolStripActiveLecturers.ResumeLayout(false);
            toolStripActiveLecturers.PerformLayout();
            toolStripNonActiveLecturers.ResumeLayout(false);
            toolStripNonActiveLecturers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSupervisors;
        private System.Windows.Forms.ComboBox comboBoxActivities;
        private System.Windows.Forms.Label labelActivities;
        private System.Windows.Forms.ListView listViewActiveSupervisors;
        private System.Windows.Forms.ListView listViewNonActiveLecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ALFullName;
        private System.Windows.Forms.ColumnHeader ALtel;
        private System.Windows.Forms.ColumnHeader ALage;
        private System.Windows.Forms.ColumnHeader NALId;
        private System.Windows.Forms.ColumnHeader NALFullName;
        private System.Windows.Forms.ColumnHeader NALTel;
        private System.Windows.Forms.ColumnHeader NALage;
        private System.Windows.Forms.ToolStrip toolStripActiveLecturers;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.ToolStrip toolStripNonActiveLecturers;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
    }
}