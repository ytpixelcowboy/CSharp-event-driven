namespace Inventory
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            label8 = new Label();
            btnAddProduct = new Button();
            richTxtDescription = new RichTextBox();
            gridViewProductList = new DataGridView();
            cbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 50);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Mfg Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 177);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 205);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(106, 47);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(281, 23);
            txtProductName.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(106, 174);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(281, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(106, 202);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(281, 23);
            txtSellPrice.TabIndex = 10;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(106, 113);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(279, 23);
            dtPickerMfgDate.TabIndex = 11;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(106, 145);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(279, 23);
            dtPickerExpDate.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 47);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 13;
            label8.Text = "Description";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(592, 231);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(102, 37);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(414, 70);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(280, 155);
            richTxtDescription.TabIndex = 16;
            richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 274);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(682, 164);
            gridViewProductList.TabIndex = 17;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(106, 80);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(281, 23);
            cbCategory.TabIndex = 18;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(cbCategory);
            Controls.Add(gridViewProductList);
            Controls.Add(richTxtDescription);
            Controls.Add(btnAddProduct);
            Controls.Add(label8);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Add Product";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private Label label8;
        private Button btnAddProduct;
        private RichTextBox richTxtDescription;
        private DataGridView gridViewProductList;
        private ComboBox cbCategory;
    }
}
