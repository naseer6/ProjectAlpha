namespace SomerenUI
{
    partial class Lecturer_Managment
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
            labelLecturer = new System.Windows.Forms.Label();
            listViewTeachers_ = new System.Windows.Forms.ListView();
            Id = new System.Windows.Forms.ColumnHeader();
            FullName = new System.Windows.Forms.ColumnHeader();
            TelephoneNumber = new System.Windows.Forms.ColumnHeader();
            Age = new System.Windows.Forms.ColumnHeader();
            buttonAdd = new System.Windows.Forms.Button();
            buttonChange = new System.Windows.Forms.Button();
            buttonRemove = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelLecturer
            // 
            labelLecturer.AutoSize = true;
            labelLecturer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLecturer.Location = new System.Drawing.Point(14, 26);
            labelLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLecturer.Name = "labelLecturer";
            labelLecturer.Size = new System.Drawing.Size(237, 32);
            labelLecturer.TabIndex = 0;
            labelLecturer.Text = "Lecturer Managment";
            // 
            // listViewTeachers_
            // 
            listViewTeachers_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, FullName, TelephoneNumber, Age });
            listViewTeachers_.FullRowSelect = true;
            listViewTeachers_.GridLines = true;
            listViewTeachers_.Location = new System.Drawing.Point(14, 62);
            listViewTeachers_.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewTeachers_.Name = "listViewTeachers_";
            listViewTeachers_.Size = new System.Drawing.Size(353, 248);
            listViewTeachers_.TabIndex = 2;
            listViewTeachers_.UseCompatibleStateImageBehavior = false;
            listViewTeachers_.View = System.Windows.Forms.View.Details;
            listViewTeachers_.SelectedIndexChanged += listViewTeachers_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 40;
            // 
            // FullName
            // 
            FullName.Text = "Full name";
            FullName.Width = 150;
            // 
            // TelephoneNumber
            // 
            TelephoneNumber.Text = "Tel. Number";
            TelephoneNumber.Width = 100;
            // 
            // Age
            // 
            Age.Text = "Age";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAdd.Location = new System.Drawing.Point(14, 317);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(95, 47);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonChange
            // 
            buttonChange.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonChange.Location = new System.Drawing.Point(115, 317);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new System.Drawing.Size(108, 47);
            buttonChange.TabIndex = 4;
            buttonChange.Text = "Change";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRemove.Location = new System.Drawing.Point(229, 317);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(108, 47);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Lecturer_Managment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(421, 450);
            Controls.Add(buttonRemove);
            Controls.Add(buttonChange);
            Controls.Add(buttonAdd);
            Controls.Add(listViewTeachers_);
            Controls.Add(labelLecturer);
            Name = "Lecturer_Managment";
            Text = "Lecturer_Managment";
            Load += Lecturer_Managment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelLecturer;
        private System.Windows.Forms.ListView listViewTeachers_;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.ColumnHeader TelephoneNumber;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonRemove;
    }
}