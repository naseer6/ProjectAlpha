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
            SFirstName = new System.Windows.Forms.ColumnHeader();
            SLastName = new System.Windows.Forms.ColumnHeader();
            STel = new System.Windows.Forms.ColumnHeader();
            Sclass = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDelete.Location = new System.Drawing.Point(617, 389);
            buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(166, 81);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonChange
            // 
            buttonChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonChange.Location = new System.Drawing.Point(617, 249);
            buttonChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new System.Drawing.Size(166, 81);
            buttonChange.TabIndex = 15;
            buttonChange.Text = "CHANGE";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAdd.Location = new System.Drawing.Point(617, 123);
            buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(166, 81);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listViewStudents
            // 
            listViewStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StudentID, SFirstName, SLastName, STel, Sclass });
            listViewStudents.FullRowSelect = true;
            listViewStudents.GridLines = true;
            listViewStudents.Location = new System.Drawing.Point(53, 85);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(498, 408);
            listViewStudents.TabIndex = 13;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            listViewStudents.SelectedIndexChanged += listViewStudents_SelectedIndexChanged;
            // 
            // StudentID
            // 
            StudentID.Text = "Id";
            StudentID.Width = 40;
            // 
            // SFirstName
            // 
            SFirstName.Text = "First Name";
            SFirstName.Width = 140;
            // 
            // SLastName
            // 
            SLastName.Text = "Last Name";
            SLastName.Width = 100;
            // 
            // STel
            // 
            STel.Text = "Tel. number";
            STel.Width = 80;
            // 
            // Sclass
            // 
            Sclass.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(53, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 12;
            label1.Text = "Students";
            // 
            // ManageStudents
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(buttonDelete);
            Controls.Add(buttonChange);
            Controls.Add(buttonAdd);
            Controls.Add(listViewStudents);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ColumnHeader SFirstName;
        private System.Windows.Forms.ColumnHeader SLastName;
        private System.Windows.Forms.ColumnHeader STel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Sclass;
    }
}