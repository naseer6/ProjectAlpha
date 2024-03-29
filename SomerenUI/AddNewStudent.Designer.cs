namespace SomerenUI
{
    partial class AddNewStudent
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
            firstName = new System.Windows.Forms.TextBox();
            lastName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            telNumber = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            class1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(125, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // firstName
            // 
            firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            firstName.Location = new System.Drawing.Point(125, 108);
            firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            firstName.Name = "firstName";
            firstName.Size = new System.Drawing.Size(209, 34);
            firstName.TabIndex = 1;
            // 
            // lastName
            // 
            lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lastName.Location = new System.Drawing.Point(125, 231);
            lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lastName.Name = "lastName";
            lastName.Size = new System.Drawing.Size(209, 34);
            lastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(125, 191);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 28);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // telNumber
            // 
            telNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            telNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            telNumber.Location = new System.Drawing.Point(125, 351);
            telNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            telNumber.Name = "telNumber";
            telNumber.Size = new System.Drawing.Size(209, 34);
            telNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(125, 311);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 28);
            label3.TabIndex = 4;
            label3.Text = "Tel. Number:";
            // 
            // class1
            // 
            class1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            class1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            class1.Location = new System.Drawing.Point(125, 467);
            class1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            class1.Name = "class1";
            class1.Size = new System.Drawing.Size(209, 34);
            class1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(125, 427);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 28);
            label4.TabIndex = 6;
            label4.Text = "Class:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HotTrack;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            button1.Location = new System.Drawing.Point(153, 559);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(147, 67);
            button1.TabIndex = 8;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddNewStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(461, 673);
            Controls.Add(button1);
            Controls.Add(class1);
            Controls.Add(label4);
            Controls.Add(telNumber);
            Controls.Add(label3);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AddNewStudent";
            Text = "AddNewStudent";
            Load += AddNewStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox class1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}