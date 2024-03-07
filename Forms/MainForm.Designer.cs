using System.Windows.Forms;

namespace InventoryManager
{
    partial class Main_Screen
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
            this.AddPartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.mainPartsSearchButton = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.mainPartsSearchBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PartLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.mainProductsSearchBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.mainProductsSearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPartButton
            // 
            this.AddPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPartButton.Location = new System.Drawing.Point(206, 232);
            this.AddPartButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(72, 32);
            this.AddPartButton.TabIndex = 0;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyPartButton.Location = new System.Drawing.Point(283, 232);
            this.ModifyPartButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(72, 32);
            this.ModifyPartButton.TabIndex = 1;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePartButton.Location = new System.Drawing.Point(359, 232);
            this.DeletePartButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(72, 32);
            this.DeletePartButton.TabIndex = 2;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // mainPartsSearchButton
            // 
            this.mainPartsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPartsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mainPartsSearchButton.Location = new System.Drawing.Point(201, 0);
            this.mainPartsSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainPartsSearchButton.Name = "mainPartsSearchButton";
            this.mainPartsSearchButton.Size = new System.Drawing.Size(51, 28);
            this.mainPartsSearchButton.TabIndex = 7;
            this.mainPartsSearchButton.Text = "Search";
            this.mainPartsSearchButton.UseVisualStyleBackColor = true;
            this.mainPartsSearchButton.Click += new System.EventHandler(this.mainPartsSearchButton_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToResizeColumns = false;
            this.partsDataGridView.AllowUserToResizeRows = false;
            this.partsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartPrice,
            this.PartInStock,
            this.PartMin,
            this.PartMax});
            this.partsDataGridView.Location = new System.Drawing.Point(2, 34);
            this.partsDataGridView.Margin = new System.Windows.Forms.Padding(159, 7, 95, 7);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.ReadOnly = true;
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partsDataGridView.Size = new System.Drawing.Size(429, 188);
            this.partsDataGridView.TabIndex = 9;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "PartID";
            this.PartID.MinimumWidth = 6;
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // PartPrice
            // 
            this.PartPrice.HeaderText = "Price";
            this.PartPrice.MinimumWidth = 6;
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.ReadOnly = true;
            // 
            // PartInStock
            // 
            this.PartInStock.HeaderText = "InStock";
            this.PartInStock.MinimumWidth = 6;
            this.PartInStock.Name = "PartInStock";
            this.PartInStock.ReadOnly = true;
            // 
            // PartMin
            // 
            this.PartMin.HeaderText = "Min";
            this.PartMin.MinimumWidth = 6;
            this.PartMin.Name = "PartMin";
            this.PartMin.ReadOnly = true;
            // 
            // PartMax
            // 
            this.PartMax.HeaderText = "Max";
            this.PartMax.MinimumWidth = 6;
            this.PartMax.Name = "PartMax";
            this.PartMax.ReadOnly = true;
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenLabel.Location = new System.Drawing.Point(10, 7);
            this.mainScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(211, 18);
            this.mainScreenLabel.TabIndex = 11;
            this.mainScreenLabel.Text = "Inventory Management System";
            // 
            // mainPartsSearchBox
            // 
            this.mainPartsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPartsSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartsSearchBox.Location = new System.Drawing.Point(271, 2);
            this.mainPartsSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainPartsSearchBox.MinimumSize = new System.Drawing.Size(161, 22);
            this.mainPartsSearchBox.Name = "mainPartsSearchBox";
            this.mainPartsSearchBox.Size = new System.Drawing.Size(161, 24);
            this.mainPartsSearchBox.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(10, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PartLabel);
            this.splitContainer1.Panel1.Controls.Add(this.mainPartsSearchBox);
            this.splitContainer1.Panel1.Controls.Add(this.AddPartButton);
            this.splitContainer1.Panel1.Controls.Add(this.ModifyPartButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeletePartButton);
            this.splitContainer1.Panel1.Controls.Add(this.mainPartsSearchButton);
            this.splitContainer1.Panel1.Controls.Add(this.partsDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductLabel);
            this.splitContainer1.Panel2.Controls.Add(this.mainProductsSearchBox);
            this.splitContainer1.Panel2.Controls.Add(this.productsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.AddProductButton);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyProductButton);
            this.splitContainer1.Panel2.Controls.Add(this.mainProductsSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.ExitButton);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteProductButton);
            this.splitContainer1.Size = new System.Drawing.Size(882, 333);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 15;
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartLabel.Location = new System.Drawing.Point(2, 8);
            this.PartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(51, 24);
            this.PartLabel.TabIndex = 16;
            this.PartLabel.Text = "Parts";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(2, 8);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(84, 24);
            this.ProductLabel.TabIndex = 17;
            this.ProductLabel.Text = "Products";
            // 
            // mainProductsSearchBox
            // 
            this.mainProductsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProductsSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductsSearchBox.Location = new System.Drawing.Point(273, 2);
            this.mainProductsSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainProductsSearchBox.MinimumSize = new System.Drawing.Size(161, 22);
            this.mainProductsSearchBox.Name = "mainProductsSearchBox";
            this.mainProductsSearchBox.Size = new System.Drawing.Size(161, 24);
            this.mainProductsSearchBox.TabIndex = 22;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.productsDataGridView.Location = new System.Drawing.Point(6, 34);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.Size = new System.Drawing.Size(429, 188);
            this.productsDataGridView.TabIndex = 21;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductInventory
            // 
            this.ProductInventory.HeaderText = "Inventory";
            this.ProductInventory.Name = "ProductInventory";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductMin
            // 
            this.ProductMin.HeaderText = "Min";
            this.ProductMin.Name = "ProductMin";
            // 
            // ProductMax
            // 
            this.ProductMax.HeaderText = "Max";
            this.ProductMax.Name = "ProductMax";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductButton.Location = new System.Drawing.Point(208, 232);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(72, 32);
            this.AddProductButton.TabIndex = 16;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyProductButton.Location = new System.Drawing.Point(285, 232);
            this.ModifyProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(72, 32);
            this.ModifyProductButton.TabIndex = 17;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // mainProductsSearchButton
            // 
            this.mainProductsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProductsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainProductsSearchButton.Location = new System.Drawing.Point(203, 0);
            this.mainProductsSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainProductsSearchButton.Name = "mainProductsSearchButton";
            this.mainProductsSearchButton.Size = new System.Drawing.Size(51, 28);
            this.mainProductsSearchButton.TabIndex = 7;
            this.mainProductsSearchButton.Text = "Search";
            this.mainProductsSearchButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(391, 269);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(40, 32);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.Location = new System.Drawing.Point(362, 232);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(72, 32);
            this.DeleteProductButton.TabIndex = 18;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(903, 376);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainScreenLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(919, 404);
            this.Name = "Main_Screen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button mainPartsSearchButton;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.TextBox mainPartsSearchBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox mainProductsSearchBox;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button mainProductsSearchButton;
        private System.Windows.Forms.Label PartLabel;
        private System.Windows.Forms.Label ProductLabel;
        private DataGridViewTextBoxColumn ProductID;
        private new DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductInventory;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductMin;
        private DataGridViewTextBoxColumn ProductMax;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn PartName;
        private DataGridViewTextBoxColumn PartPrice;
        private DataGridViewTextBoxColumn PartInStock;
        private DataGridViewTextBoxColumn PartMin;
        private DataGridViewTextBoxColumn PartMax;
    }
}