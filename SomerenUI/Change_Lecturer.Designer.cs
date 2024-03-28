namespace SomerenUI
{
    partial class Change_Lecturer
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
            labelName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            textBoxLastName = new System.Windows.Forms.TextBox();
            textBoxTelNumber = new System.Windows.Forms.TextBox();
            textBoxAge = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            buttonUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(15, 74);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(102, 28);
            labelName.TabIndex = 3;
            labelName.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 28);
            label2.TabIndex = 4;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(174, 28);
            label3.TabIndex = 5;
            label3.Text = "Telephone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(12, 203);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 28);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxFirstName.Location = new System.Drawing.Point(218, 74);
            textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new System.Drawing.Size(138, 34);
            textBoxFirstName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxLastName.Location = new System.Drawing.Point(218, 112);
            textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new System.Drawing.Size(138, 34);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxTelNumber
            // 
            textBoxTelNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxTelNumber.Location = new System.Drawing.Point(218, 156);
            textBoxTelNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxTelNumber.Name = "textBoxTelNumber";
            textBoxTelNumber.Size = new System.Drawing.Size(138, 34);
            textBoxTelNumber.TabIndex = 11;
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxAge.Location = new System.Drawing.Point(218, 203);
            textBoxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new System.Drawing.Size(138, 34);
            textBoxAge.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 32);
            label1.TabIndex = 13;
            label1.Text = "Edit teacher";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(270, 256);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(86, 31);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Change_Lecturer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(372, 300);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxTelNumber);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelName);
            Name = "Change_Lecturer";
            Text = "Change_Lecturer";
            Load += Change_Lecturer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTelNumber;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}