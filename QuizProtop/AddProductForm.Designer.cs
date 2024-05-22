namespace QuizProtop
{
    partial class AddProductForm
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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductImage = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(150, 30);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(200, 20);
            this.txtProductId.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(150, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(150, 110);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(200, 20);
            this.txtProductDescription.TabIndex = 2;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(150, 150);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(200, 20);
            this.txtProductPrice.TabIndex = 3;
            // 
            // txtProductImage
            // 
            this.txtProductImage.Location = new System.Drawing.Point(150, 190);
            this.txtProductImage.Name = "txtProductImage";
            this.txtProductImage.Size = new System.Drawing.Size(200, 20);
            this.txtProductImage.TabIndex = 4;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(150, 230);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(360, 188);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImage.TabIndex = 6;
            this.btnBrowseImage.Text = "Browse...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(50, 33);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(58, 13);
            this.lblProductId.TabIndex = 7;
            this.lblProductId.Text = "Product ID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(50, 73);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(50, 113);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(100, 13);
            this.lblProductDescription.TabIndex = 9;
            this.lblProductDescription.Text = "Product Description";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(50, 153);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(71, 13);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductImage
            // 
            this.lblProductImage.AutoSize = true;
            this.lblProductImage.Location = new System.Drawing.Point(50, 193);
            this.lblProductImage.Name = "lblProductImage";
            this.lblProductImage.Size = new System.Drawing.Size(77, 13);
            this.lblProductImage.TabIndex = 11;
            this.lblProductImage.Text = "Product Image";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.lblProductImage);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductImage);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductImage;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductImage;
    }
}
