namespace SomerenUI
{
    partial class Bar_Managment
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
            labelBar = new System.Windows.Forms.Label();
            listViewDrinks = new System.Windows.Forms.ListView();
            DID = new System.Windows.Forms.ColumnHeader();
            DName = new System.Windows.Forms.ColumnHeader();
            DType = new System.Windows.Forms.ColumnHeader();
            DPrice = new System.Windows.Forms.ColumnHeader();
            DStock = new System.Windows.Forms.ColumnHeader();
            DStatus = new System.Windows.Forms.ColumnHeader();
            toolStripDrinks = new System.Windows.Forms.ToolStrip();
            toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonStock = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            toolStripDrinks.SuspendLayout();
            SuspendLayout();
            // 
            // labelBar
            // 
            labelBar.AutoSize = true;
            labelBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelBar.Location = new System.Drawing.Point(22, 41);
            labelBar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelBar.Name = "labelBar";
            labelBar.Size = new System.Drawing.Size(290, 51);
            labelBar.TabIndex = 0;
            labelBar.Text = "Bar Managment";
            // 
            // listViewDrinks
            // 
            listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { DID, DName, DType, DPrice, DStock, DStatus });
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.GridLines = true;
            listViewDrinks.Location = new System.Drawing.Point(22, 128);
            listViewDrinks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(1046, 371);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // DID
            // 
            DID.Text = "ID";
            // 
            // DName
            // 
            DName.Text = "Name";
            DName.Width = 200;
            // 
            // DType
            // 
            DType.Text = "Type";
            DType.Width = 150;
            // 
            // DPrice
            // 
            DPrice.Text = "Price";
            DPrice.Width = 80;
            // 
            // DStock
            // 
            DStock.Text = "Stock";
            DStock.Width = 80;
            // 
            // DStatus
            // 
            DStatus.Text = "Stock status";
            DStatus.Width = 300;
            // 
            // toolStripDrinks
            // 
            toolStripDrinks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            toolStripDrinks.Dock = System.Windows.Forms.DockStyle.None;
            toolStripDrinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripDrinks.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStripDrinks.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStripDrinks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonAdd, toolStripSeparator4, toolStripButtonDelete, toolStripSeparator5, toolStripButtonEdit, toolStripSeparator3, toolStripButtonStock, toolStripSeparator2, toolStripButtonSave });
            toolStripDrinks.Location = new System.Drawing.Point(22, 510);
            toolStripDrinks.Name = "toolStripDrinks";
            toolStripDrinks.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            toolStripDrinks.Size = new System.Drawing.Size(763, 55);
            toolStripDrinks.TabIndex = 2;
            toolStripDrinks.Text = "toolStrip";
            // 
            // toolStripButtonAdd
            // 
            toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonAdd.Name = "toolStripButtonAdd";
            toolStripButtonAdd.Size = new System.Drawing.Size(83, 49);
            toolStripButtonAdd.Text = "Add";
            toolStripButtonAdd.Click += toolStripButtonAdd_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonDelete
            // 
            toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonDelete.Name = "toolStripButtonDelete";
            toolStripButtonDelete.Size = new System.Drawing.Size(116, 49);
            toolStripButtonDelete.Text = "Delete";
            toolStripButtonDelete.Click += toolStripButtonDelete_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonEdit
            // 
            toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonEdit.Name = "toolStripButtonEdit";
            toolStripButtonEdit.Size = new System.Drawing.Size(78, 49);
            toolStripButtonEdit.Text = "Edit";
            toolStripButtonEdit.Click += toolStripButtonEdit_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonStock
            // 
            toolStripButtonStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonStock.Name = "toolStripButtonStock";
            toolStripButtonStock.Size = new System.Drawing.Size(218, 49);
            toolStripButtonStock.Text = "Change Stock";
            toolStripButtonStock.ToolTipText = "Change Stock";
            toolStripButtonStock.Click += toolStripButtonStock_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new System.Drawing.Size(238, 49);
            toolStripButtonSave.Text = "Save and Close";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // Bar_Managment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1330, 708);
            Controls.Add(toolStripDrinks);
            Controls.Add(listViewDrinks);
            Controls.Add(labelBar);
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            Name = "Bar_Managment";
            Text = "Bar_Managment";
            Load += Bar_Managment_Load;
            toolStripDrinks.ResumeLayout(false);
            toolStripDrinks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelBar;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader DID;
        private System.Windows.Forms.ColumnHeader DName;
        private System.Windows.Forms.ColumnHeader DType;
        private System.Windows.Forms.ColumnHeader DPrice;
        private System.Windows.Forms.ColumnHeader DStock;
        private System.Windows.Forms.ColumnHeader Dicon;
        private System.Windows.Forms.ToolStrip toolStripDrinks;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonStock;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader DStatus;
    }
}