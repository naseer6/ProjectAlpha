namespace SomerenUI
{
    partial class Add_Teacher
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
            labelName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxTelNumber = new System.Windows.Forms.TextBox();
            textBoxAge = new System.Windows.Forms.TextBox();
            buttonAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 32);
            label1.TabIndex = 2;
            label1.Text = "Add teacher";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(12, 78);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(102, 28);
            labelName.TabIndex = 3;
            labelName.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 126);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 28);
            label2.TabIndex = 4;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 173);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(174, 28);
            label3.TabIndex = 5;
            label3.Text = "Telephone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(12, 220);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 28);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxFirstName.Location = new System.Drawing.Point(216, 78);
            textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new System.Drawing.Size(138, 34);
            textBoxFirstName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxLastName.Location = new System.Drawing.Point(216, 126);
            textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(138, 34);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxTelNumber
            // 
            textBoxTelNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxTelNumber.Location = new System.Drawing.Point(216, 173);
            textBoxTelNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxTelNumber.Name = "textBoxTelNumber";
            textBoxTelNumber.Size = new System.Drawing.Size(138, 34);
            textBoxTelNumber.TabIndex = 11;
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxAge.Location = new System.Drawing.Point(216, 220);
            textBoxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new System.Drawing.Size(138, 34);
            textBoxAge.TabIndex = 12;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(268, 262);
            buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(86, 31);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // Add_Teacher
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 316);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxTelNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "Add_Teacher";
            Text = "Add_Teacher";
            Load += Add_Teacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTelNumber;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonAdd;
    }
}