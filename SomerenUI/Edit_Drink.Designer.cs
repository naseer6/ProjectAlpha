namespace SomerenUI
{
    partial class Edit_Drink
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
            textBoxName = new System.Windows.Forms.TextBox();
            labelType = new System.Windows.Forms.Label();
            comboBoxType = new System.Windows.Forms.ComboBox();
            Price = new System.Windows.Forms.Label();
            textBoxPrice = new System.Windows.Forms.TextBox();
            labelEdit = new System.Windows.Forms.Label();
            buttonUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(29, 62);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(52, 21);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxName.Location = new System.Drawing.Point(85, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(142, 29);
            textBoxName.TabIndex = 1;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelType.Location = new System.Drawing.Point(29, 107);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(42, 21);
            labelType.TabIndex = 2;
            labelType.Text = "Type";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "alcoholic", "non-alcoholic" });
            comboBoxType.Location = new System.Drawing.Point(85, 105);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(142, 29);
            comboBoxType.TabIndex = 3;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Price.Location = new System.Drawing.Point(29, 155);
            Price.Name = "Price";
            Price.Size = new System.Drawing.Size(44, 21);
            Price.TabIndex = 4;
            Price.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPrice.Location = new System.Drawing.Point(85, 147);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(142, 29);
            textBoxPrice.TabIndex = 5;
            // 
            // labelEdit
            // 
            labelEdit.AutoSize = true;
            labelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            labelEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEdit.Location = new System.Drawing.Point(29, 19);
            labelEdit.Name = "labelEdit";
            labelEdit.Size = new System.Drawing.Size(36, 21);
            labelEdit.TabIndex = 6;
            labelEdit.Text = "Edit";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(152, 210);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(75, 23);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // Edit_Drink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(285, 260);
            Controls.Add(buttonUpdate);
            Controls.Add(labelEdit);
            Controls.Add(textBoxPrice);
            Controls.Add(Price);
            Controls.Add(comboBoxType);
            Controls.Add(labelType);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "Edit_Drink";
            Text = "Edit_Drink";
            Load += Edit_Drink_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonUpdate;
    }
}