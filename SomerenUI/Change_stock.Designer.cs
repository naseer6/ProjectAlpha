namespace SomerenUI
{
    partial class Change_stock
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
            labelStock = new System.Windows.Forms.Label();
            textBoxStock = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelStock.Location = new System.Drawing.Point(31, 25);
            labelStock.Name = "labelStock";
            labelStock.Size = new System.Drawing.Size(104, 21);
            labelStock.TabIndex = 0;
            labelStock.Text = "Change Stock";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new System.Drawing.Point(35, 58);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new System.Drawing.Size(100, 23);
            textBoxStock.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(60, 98);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Change_stock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(176, 152);
            Controls.Add(button1);
            Controls.Add(textBoxStock);
            Controls.Add(labelStock);
            Name = "Change_stock";
            Text = "Change_stock";
            Load += Change_stock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Button button1;
    }
}