using System;
using System.IO;
using System.Windows.Forms;

namespace QuizProtop
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text;
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;
            string price = txtProductPrice.Text;
            string imagePath = txtProductImage.Text;

            var product = $"{id},{name},{description},{price},{imagePath}";
            File.AppendAllText("products.csv", product + Environment.NewLine);
            MessageBox.Show("Product added successfully!");
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtProductImage.Text = openFileDialog.FileName;
            }
        }
    }
}
