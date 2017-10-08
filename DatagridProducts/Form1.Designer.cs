namespace DatagridProducts
{
    partial class Form1
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStockWithCostMoreThan3 = new System.Windows.Forms.Button();
            this.btnProductNamesOnly = new System.Windows.Forms.Button();
            this.btnCapitalizeProductName = new System.Windows.Forms.Button();
            this.btnOrderByProductNameLength = new System.Windows.Forms.Button();
            this.btnOrderByDescendingUnitsInStock = new System.Windows.Forms.Button();
            this.btnOrderByProductNameLengthThenAlphabetically = new System.Windows.Forms.Button();
            this.btnProductWhereSecondLetterIsH = new System.Windows.Forms.Button();
            this.btnGroupByCategory = new System.Windows.Forms.Button();
            this.btnGroupByCategoryAndCountProducts = new System.Windows.Forms.Button();
            this.btnTotalUnitsOfStockForEachCategory = new System.Windows.Forms.Button();
            this.btnCheapestInCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(-1, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(689, 247);
            this.dgvProducts.TabIndex = 0;
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Location = new System.Drawing.Point(171, 274);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(135, 56);
            this.btnOutOfStock.TabIndex = 1;
            this.btnOutOfStock.Text = "Products out of stock";
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            this.btnOutOfStock.Click += new System.EventHandler(this.btnOutOfStock_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 274);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 56);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStockWithCostMoreThan3
            // 
            this.btnStockWithCostMoreThan3.Location = new System.Drawing.Point(328, 274);
            this.btnStockWithCostMoreThan3.Name = "btnStockWithCostMoreThan3";
            this.btnStockWithCostMoreThan3.Size = new System.Drawing.Size(135, 56);
            this.btnStockWithCostMoreThan3.TabIndex = 3;
            this.btnStockWithCostMoreThan3.Text = "Products in stock cost > 3.00";
            this.btnStockWithCostMoreThan3.UseVisualStyleBackColor = true;
            this.btnStockWithCostMoreThan3.Click += new System.EventHandler(this.btnStockWithCostMoreThan3_Click);
            // 
            // btnProductNamesOnly
            // 
            this.btnProductNamesOnly.Location = new System.Drawing.Point(484, 274);
            this.btnProductNamesOnly.Name = "btnProductNamesOnly";
            this.btnProductNamesOnly.Size = new System.Drawing.Size(135, 56);
            this.btnProductNamesOnly.TabIndex = 4;
            this.btnProductNamesOnly.Text = "Products names only";
            this.btnProductNamesOnly.UseVisualStyleBackColor = true;
            this.btnProductNamesOnly.Click += new System.EventHandler(this.btnProductNamesOnly_Click);
            // 
            // btnCapitalizeProductName
            // 
            this.btnCapitalizeProductName.Location = new System.Drawing.Point(12, 346);
            this.btnCapitalizeProductName.Name = "btnCapitalizeProductName";
            this.btnCapitalizeProductName.Size = new System.Drawing.Size(135, 56);
            this.btnCapitalizeProductName.TabIndex = 5;
            this.btnCapitalizeProductName.Text = "Product name uppercase";
            this.btnCapitalizeProductName.UseVisualStyleBackColor = true;
            this.btnCapitalizeProductName.Click += new System.EventHandler(this.btnCapitalizeProductName_Click);
            // 
            // btnOrderByProductNameLength
            // 
            this.btnOrderByProductNameLength.Location = new System.Drawing.Point(171, 346);
            this.btnOrderByProductNameLength.Name = "btnOrderByProductNameLength";
            this.btnOrderByProductNameLength.Size = new System.Drawing.Size(135, 56);
            this.btnOrderByProductNameLength.TabIndex = 6;
            this.btnOrderByProductNameLength.Text = "Order by product name length";
            this.btnOrderByProductNameLength.UseVisualStyleBackColor = true;
            this.btnOrderByProductNameLength.Click += new System.EventHandler(this.btnOrderByProductNameLength_Click);
            // 
            // btnOrderByDescendingUnitsInStock
            // 
            this.btnOrderByDescendingUnitsInStock.Location = new System.Drawing.Point(328, 346);
            this.btnOrderByDescendingUnitsInStock.Name = "btnOrderByDescendingUnitsInStock";
            this.btnOrderByDescendingUnitsInStock.Size = new System.Drawing.Size(135, 56);
            this.btnOrderByDescendingUnitsInStock.TabIndex = 7;
            this.btnOrderByDescendingUnitsInStock.Text = "Order by descending units in stock";
            this.btnOrderByDescendingUnitsInStock.UseVisualStyleBackColor = true;
            this.btnOrderByDescendingUnitsInStock.Click += new System.EventHandler(this.btnOrderByDescendingUnitsInStock_Click);
            // 
            // btnOrderByProductNameLengthThenAlphabetically
            // 
            this.btnOrderByProductNameLengthThenAlphabetically.Location = new System.Drawing.Point(484, 346);
            this.btnOrderByProductNameLengthThenAlphabetically.Name = "btnOrderByProductNameLengthThenAlphabetically";
            this.btnOrderByProductNameLengthThenAlphabetically.Size = new System.Drawing.Size(135, 56);
            this.btnOrderByProductNameLengthThenAlphabetically.TabIndex = 8;
            this.btnOrderByProductNameLengthThenAlphabetically.Text = "Order by product name length then alphabetically";
            this.btnOrderByProductNameLengthThenAlphabetically.UseVisualStyleBackColor = true;
            this.btnOrderByProductNameLengthThenAlphabetically.Click += new System.EventHandler(this.btnOrderByProductNameLengthThenAlphabetically_Click);
            // 
            // btnProductWhereSecondLetterIsH
            // 
            this.btnProductWhereSecondLetterIsH.Location = new System.Drawing.Point(12, 419);
            this.btnProductWhereSecondLetterIsH.Name = "btnProductWhereSecondLetterIsH";
            this.btnProductWhereSecondLetterIsH.Size = new System.Drawing.Size(135, 56);
            this.btnProductWhereSecondLetterIsH.TabIndex = 9;
            this.btnProductWhereSecondLetterIsH.Text = "Products where second letter is h";
            this.btnProductWhereSecondLetterIsH.UseVisualStyleBackColor = true;
            this.btnProductWhereSecondLetterIsH.Click += new System.EventHandler(this.btnProductWhereSecondLetterIsH_Click);
            // 
            // btnGroupByCategory
            // 
            this.btnGroupByCategory.Location = new System.Drawing.Point(171, 419);
            this.btnGroupByCategory.Name = "btnGroupByCategory";
            this.btnGroupByCategory.Size = new System.Drawing.Size(135, 56);
            this.btnGroupByCategory.TabIndex = 10;
            this.btnGroupByCategory.Text = "Group by category";
            this.btnGroupByCategory.UseVisualStyleBackColor = true;
            this.btnGroupByCategory.Click += new System.EventHandler(this.btnGroupByCategory_Click);
            // 
            // btnGroupByCategoryAndCountProducts
            // 
            this.btnGroupByCategoryAndCountProducts.Location = new System.Drawing.Point(328, 419);
            this.btnGroupByCategoryAndCountProducts.Name = "btnGroupByCategoryAndCountProducts";
            this.btnGroupByCategoryAndCountProducts.Size = new System.Drawing.Size(135, 56);
            this.btnGroupByCategoryAndCountProducts.TabIndex = 11;
            this.btnGroupByCategoryAndCountProducts.Text = "Group by category and count products";
            this.btnGroupByCategoryAndCountProducts.UseVisualStyleBackColor = true;
            this.btnGroupByCategoryAndCountProducts.Click += new System.EventHandler(this.btnGroupByCategoryAndCountProducts_Click);
            // 
            // btnTotalUnitsOfStockForEachCategory
            // 
            this.btnTotalUnitsOfStockForEachCategory.Location = new System.Drawing.Point(484, 419);
            this.btnTotalUnitsOfStockForEachCategory.Name = "btnTotalUnitsOfStockForEachCategory";
            this.btnTotalUnitsOfStockForEachCategory.Size = new System.Drawing.Size(135, 56);
            this.btnTotalUnitsOfStockForEachCategory.TabIndex = 12;
            this.btnTotalUnitsOfStockForEachCategory.Text = "Total units of stock for each category";
            this.btnTotalUnitsOfStockForEachCategory.UseVisualStyleBackColor = true;
            this.btnTotalUnitsOfStockForEachCategory.Click += new System.EventHandler(this.btnTotalUnitsOfStockForEachCategory_Click);
            // 
            // btnCheapestInCategory
            // 
            this.btnCheapestInCategory.Location = new System.Drawing.Point(12, 490);
            this.btnCheapestInCategory.Name = "btnCheapestInCategory";
            this.btnCheapestInCategory.Size = new System.Drawing.Size(135, 56);
            this.btnCheapestInCategory.TabIndex = 13;
            this.btnCheapestInCategory.Text = "Cheapest price among each category\'s products";
            this.btnCheapestInCategory.UseVisualStyleBackColor = true;
            this.btnCheapestInCategory.Click += new System.EventHandler(this.btnCheapestInCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 558);
            this.Controls.Add(this.btnCheapestInCategory);
            this.Controls.Add(this.btnTotalUnitsOfStockForEachCategory);
            this.Controls.Add(this.btnGroupByCategoryAndCountProducts);
            this.Controls.Add(this.btnGroupByCategory);
            this.Controls.Add(this.btnProductWhereSecondLetterIsH);
            this.Controls.Add(this.btnOrderByProductNameLengthThenAlphabetically);
            this.Controls.Add(this.btnOrderByDescendingUnitsInStock);
            this.Controls.Add(this.btnOrderByProductNameLength);
            this.Controls.Add(this.btnCapitalizeProductName);
            this.Controls.Add(this.btnProductNamesOnly);
            this.Controls.Add(this.btnStockWithCostMoreThan3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOutOfStock);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnOutOfStock;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStockWithCostMoreThan3;
        private System.Windows.Forms.Button btnProductNamesOnly;
        private System.Windows.Forms.Button btnCapitalizeProductName;
        private System.Windows.Forms.Button btnOrderByProductNameLength;
        private System.Windows.Forms.Button btnOrderByDescendingUnitsInStock;
        private System.Windows.Forms.Button btnOrderByProductNameLengthThenAlphabetically;
        private System.Windows.Forms.Button btnProductWhereSecondLetterIsH;
        private System.Windows.Forms.Button btnGroupByCategory;
        private System.Windows.Forms.Button btnGroupByCategoryAndCountProducts;
        private System.Windows.Forms.Button btnTotalUnitsOfStockForEachCategory;
        private System.Windows.Forms.Button btnCheapestInCategory;
    }
}

