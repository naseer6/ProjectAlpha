namespace SomerenUI
{
    partial class Add_Drink
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
            labeltype = new System.Windows.Forms.Label();
            labelPrice = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            buttonAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Add drink";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(11, 62);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(52, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labeltype
            // 
            labeltype.AutoSize = true;
            labeltype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labeltype.Location = new System.Drawing.Point(11, 99);
            labeltype.Name = "labeltype";
            labeltype.Size = new System.Drawing.Size(42, 21);
            labeltype.TabIndex = 2;
            labeltype.Text = "Type";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPrice.Location = new System.Drawing.Point(11, 136);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(44, 21);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // textBoxName
            // 
            textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxName.Location = new System.Drawing.Point(69, 59);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(121, 29);
            textBoxName.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPrice.Location = new System.Drawing.Point(69, 133);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(121, 29);
            textBoxPrice.TabIndex = 5;
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "alcoholic", "non-alcoholic" });
            comboBoxType.Location = new System.Drawing.Point(69, 98);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(121, 29);
            comboBoxType.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(115, 188);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(75, 23);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Add_Drink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(235, 249);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labeltype);
            Controls.Add(labelName);
            Controls.Add(label1);
            Name = "Add_Drink";
            Text = "Add_Drink";
            Load += Add_Drink_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
    }
}