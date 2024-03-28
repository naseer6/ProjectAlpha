namespace SomerenUI
{
    partial class ManageStudents
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
            buttonDelete = new System.Windows.Forms.Button();
            buttonChange = new System.Windows.Forms.Button();
            buttonAdd = new System.Windows.Forms.Button();
            listViewStudents = new System.Windows.Forms.ListView();
            StudentID = new System.Windows.Forms.ColumnHeader();
            SFullName = new System.Windows.Forms.ColumnHeader();
            STel = new System.Windows.Forms.ColumnHeader();
            Class = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDelete.Location = new System.Drawing.Point(540, 292);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(145, 61);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonChange
            // 
            buttonChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonChange.Location = new System.Drawing.Point(540, 187);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new System.Drawing.Size(145, 61);
            buttonChange.TabIndex = 15;
            buttonChange.Text = "CHANGE";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAdd.Location = new System.Drawing.Point(540, 92);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(145, 61);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listViewStudents
            // 
            listViewStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StudentID, SFullName, STel, Class });
            listViewStudents.FullRowSelect = true;
            listViewStudents.GridLines = true;
            listViewStudents.Location = new System.Drawing.Point(46, 64);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(387, 307);
            listViewStudents.TabIndex = 13;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // StudentID
            // 
            StudentID.Text = "Id";
            StudentID.Width = 40;
            // 
            // SFullName
            // 
            SFullName.Text = "Full Name";
            SFullName.Width = 140;
            // 
            // STel
            // 
            STel.Text = "Tel. number";
            STel.Width = 100;
            // 
            // Class
            // 
            Class.Text = "Class";
            Class.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(46, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 12;
            label1.Text = "Students";
            // 
            // ManageStudents
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonChange);
            Controls.Add(buttonAdd);
            Controls.Add(listViewStudents);
            Controls.Add(label1);
            Name = "ManageStudents";
            Text = "ManageStudents";
            Load += ManageStudents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader SFullName;
        private System.Windows.Forms.ColumnHeader STel;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.Label label1;
    }
}