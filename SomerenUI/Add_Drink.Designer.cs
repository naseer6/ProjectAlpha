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
            label1.Location = new System.Drawing.Point(14, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 32);
            label1.TabIndex = 0;
            label1.Text = "Add drink";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(13, 83);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(64, 28);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labeltype
            // 
            labeltype.AutoSize = true;
            labeltype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labeltype.Location = new System.Drawing.Point(13, 132);
            labeltype.Name = "labeltype";
            labeltype.Size = new System.Drawing.Size(53, 28);
            labeltype.TabIndex = 2;
            labeltype.Text = "Type";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPrice.Location = new System.Drawing.Point(13, 181);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(54, 28);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // textBoxName
            // 
            textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxName.Location = new System.Drawing.Point(79, 79);
            textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(138, 34);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPrice.Location = new System.Drawing.Point(79, 177);
            textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(138, 34);
            textBoxPrice.TabIndex = 5;
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "alcoholic", "non-alcoholic" });
            comboBoxType.Location = new System.Drawing.Point(79, 131);
            comboBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(138, 36);
            comboBoxType.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(131, 251);
            buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(86, 31);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Add_Drink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(269, 332);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labeltype);
            Controls.Add(labelName);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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