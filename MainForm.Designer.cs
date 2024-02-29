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
            this.PartsSearchButton = new System.Windows.Forms.Button();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.PartsSearchBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ProductsSearchBox = new System.Windows.Forms.TextBox();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.ProductsSearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPartButton
            // 
            this.AddPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPartButton.Location = new System.Drawing.Point(261, 310);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(90, 40);
            this.AddPartButton.TabIndex = 0;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyPartButton.Location = new System.Drawing.Point(357, 310);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(90, 40);
            this.ModifyPartButton.TabIndex = 1;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePartButton.Location = new System.Drawing.Point(453, 310);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(90, 40);
            this.DeletePartButton.TabIndex = 2;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // PartsSearchButton
            // 
            this.PartsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsSearchButton.Location = new System.Drawing.Point(257, 5);
            this.PartsSearchButton.Name = "PartsSearchButton";
            this.PartsSearchButton.Size = new System.Drawing.Size(80, 26);
            this.PartsSearchButton.TabIndex = 7;
            this.PartsSearchButton.Text = "Search";
            this.PartsSearchButton.UseVisualStyleBackColor = true;
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGrid.Location = new System.Drawing.Point(3, 43);
            this.PartsDataGrid.Margin = new System.Windows.Forms.Padding(199, 9, 119, 9);
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.RowHeadersWidth = 51;
            this.PartsDataGrid.Size = new System.Drawing.Size(540, 255);
            this.PartsDataGrid.TabIndex = 9;
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenLabel.Location = new System.Drawing.Point(12, 9);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(255, 22);
            this.mainScreenLabel.TabIndex = 11;
            this.mainScreenLabel.Text = "Inventory Management System";
            // 
            // PartsSearchBox
            // 
            this.PartsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsSearchBox.Location = new System.Drawing.Point(343, 3);
            this.PartsSearchBox.MinimumSize = new System.Drawing.Size(200, 22);
            this.PartsSearchBox.Name = "PartsSearchBox";
            this.PartsSearchBox.Size = new System.Drawing.Size(200, 28);
            this.PartsSearchBox.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PartsSearchBox);
            this.splitContainer1.Panel1.Controls.Add(this.AddPartButton);
            this.splitContainer1.Panel1.Controls.Add(this.ModifyPartButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeletePartButton);
            this.splitContainer1.Panel1.Controls.Add(this.PartsSearchButton);
            this.splitContainer1.Panel1.Controls.Add(this.PartsDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ProductsSearchBox);
            this.splitContainer1.Panel2.Controls.Add(this.ProductsDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.AddProductButton);
            this.splitContainer1.Panel2.Controls.Add(this.ModifyProductButton);
            this.splitContainer1.Panel2.Controls.Add(this.ProductsSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.ExitButton);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteProductButton);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 400);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 15;
            // 
            // ProductsSearchBox
            // 
            this.ProductsSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsSearchBox.Location = new System.Drawing.Point(343, 3);
            this.ProductsSearchBox.MinimumSize = new System.Drawing.Size(200, 22);
            this.ProductsSearchBox.Name = "ProductsSearchBox";
            this.ProductsSearchBox.Size = new System.Drawing.Size(200, 28);
            this.ProductsSearchBox.TabIndex = 22;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.Size = new System.Drawing.Size(540, 255);
            this.ProductsDataGridView.TabIndex = 21;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductButton.Location = new System.Drawing.Point(264, 310);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(90, 40);
            this.AddProductButton.TabIndex = 16;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyProductButton.Location = new System.Drawing.Point(360, 310);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(90, 40);
            this.ModifyProductButton.TabIndex = 17;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // ProductsSearchButton
            // 
            this.ProductsSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsSearchButton.Location = new System.Drawing.Point(257, 5);
            this.ProductsSearchButton.Name = "ProductsSearchButton";
            this.ProductsSearchButton.Size = new System.Drawing.Size(80, 26);
            this.ProductsSearchButton.TabIndex = 7;
            this.ProductsSearchButton.Text = "Search";
            this.ProductsSearchButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.Location = new System.Drawing.Point(493, 356);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 40);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.Location = new System.Drawing.Point(456, 310);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(90, 40);
            this.DeleteProductButton.TabIndex = 18;
            this.DeleteProductButton.Text = "Del;ete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // Main_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1127, 448);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainScreenLabel);
            this.MinimumSize = new System.Drawing.Size(1145, 495);
            this.Name = "Main_Screen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button PartsSearchButton;
        private System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.TextBox PartsSearchBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox ProductsSearchBox;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ProductsSearchButton;
    }
}