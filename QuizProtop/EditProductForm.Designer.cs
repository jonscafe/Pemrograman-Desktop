namespace QuizProtop
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewProducts = new DataGridView();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtProductDescription = new TextBox();
            txtProductPrice = new TextBox();
            txtProductImage = new TextBox();
            btnSaveChanges = new Button();
            btnBrowseImage = new Button();
            lblProductId = new Label();
            lblProductName = new Label();
            lblProductDescription = new Label();
            lblProductPrice = new Label();
            lblProductImage = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(40, 46);
            dataGridViewProducts.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(800, 308);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(187, 385);
            txtProductId.Margin = new Padding(4, 5, 4, 5);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(265, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(187, 446);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(265, 27);
            txtProductName.TabIndex = 2;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(187, 508);
            txtProductDescription.Margin = new Padding(4, 5, 4, 5);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(265, 27);
            txtProductDescription.TabIndex = 3;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(187, 569);
            txtProductPrice.Margin = new Padding(4, 5, 4, 5);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(265, 27);
            txtProductPrice.TabIndex = 4;
            // 
            // txtProductImage
            // 
            txtProductImage.Location = new Point(187, 631);
            txtProductImage.Margin = new Padding(4, 5, 4, 5);
            txtProductImage.Name = "txtProductImage";
            txtProductImage.Size = new Size(265, 27);
            txtProductImage.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(187, 692);
            btnSaveChanges.Margin = new Padding(4, 5, 4, 5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(133, 35);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(467, 628);
            btnBrowseImage.Margin = new Padding(4, 5, 4, 5);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(100, 35);
            btnBrowseImage.TabIndex = 7;
            btnBrowseImage.Text = "Browse...";
            btnBrowseImage.UseVisualStyleBackColor = true;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(40, 389);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(79, 20);
            lblProductId.TabIndex = 8;
            lblProductId.Text = "Product ID";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(40, 451);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 9;
            lblProductName.Text = "Product Name";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(40, 512);
            lblProductDescription.Margin = new Padding(4, 0, 4, 0);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(140, 20);
            lblProductDescription.TabIndex = 10;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(40, 574);
            lblProductPrice.Margin = new Padding(4, 0, 4, 0);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(96, 20);
            lblProductPrice.TabIndex = 11;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductImage
            // 
            lblProductImage.AutoSize = true;
            lblProductImage.Location = new Point(40, 635);
            lblProductImage.Margin = new Padding(4, 0, 4, 0);
            lblProductImage.Name = "lblProductImage";
            lblProductImage.Size = new Size(106, 20);
            lblProductImage.TabIndex = 12;
            lblProductImage.Text = "Product Image";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 754);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(320, 751);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button1
            // 
            button1.Location = new Point(740, 382);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 15;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(740, 427);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 16;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 863);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblProductImage);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductDescription);
            Controls.Add(lblProductName);
            Controls.Add(lblProductId);
            Controls.Add(btnBrowseImage);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtProductImage);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductDescription);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(dataGridViewProducts);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditProductForm";
            Text = "Edit Products";
            Load += EditProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductImage;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private Button button1;
        private Button button2;
    }
}
