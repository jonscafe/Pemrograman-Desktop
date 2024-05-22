using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuizProtop
{
    public partial class EditProductForm : Form
    {
        private DataTable productTable;

        public EditProductForm()
        {
            InitializeComponent();
            this.Activated += new EventHandler(EditProductForm_Activated); // Event to refresh data
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void EditProductForm_Activated(object sender, EventArgs e)
        {
            LoadProductData(); // Refresh the data whenever the form is activated
        }

        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        private void LoadProductData()
        {
            if (productTable == null) // Only load data if it's not already loaded
            {
                productTable = new DataTable();
                productTable.Columns.Add("ProductId");
                productTable.Columns.Add("ProductName");
                productTable.Columns.Add("ProductDescription");
                productTable.Columns.Add("ProductPrice");
                productTable.Columns.Add("ProductImagePath");

                string[] lines = File.ReadAllLines("products.csv");
                productTable.Clear(); // Clear existing data before loading new data

                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    if (values.Length == productTable.Columns.Count) // Ensure the line has correct number of columns
                    {
                        productTable.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                    }
                }

                dataGridViewProducts.DataSource = productTable;
                AddImageColumn();
                DisplayImagesInGridView();
            }
        }

        private void RefreshData()
        {
            productTable = new DataTable();
            productTable.Columns.Add("ProductId");
            productTable.Columns.Add("ProductName");
            productTable.Columns.Add("ProductDescription");
            productTable.Columns.Add("ProductPrice");
            productTable.Columns.Add("ProductImagePath");

            string[] lines = File.ReadAllLines("products.csv");
            productTable.Clear(); // Clear existing data before loading new data

            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == productTable.Columns.Count) // Ensure the line has correct number of columns
                {
                    productTable.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                }
            }

            dataGridViewProducts.DataSource = productTable;
            AddImageColumn();
            DisplayImagesInGridView();
        }


        private void AddImageColumn()
        {
            if (!dataGridViewProducts.Columns.Contains("ProductImage"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "ProductImage";
                imageColumn.HeaderText = "Product Image";
                dataGridViewProducts.Columns.Add(imageColumn);
            }
        }

        private void DisplayImagesInGridView()
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells["ProductImagePath"].Value != null)
                {
                    string imagePath = row.Cells["ProductImagePath"].Value.ToString();
                    if (File.Exists(imagePath))
                    {
                        Image img = ScaleImage(Image.FromFile(imagePath), 50, 50);
                        row.Cells["ProductImage"].Value = img;
                    }
                }
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewProducts.SelectedRows[0];
                txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                txtProductDescription.Text = row.Cells["ProductDescription"].Value?.ToString();
                txtProductPrice.Text = row.Cells["ProductPrice"].Value?.ToString();
                txtProductImage.Text = row.Cells["ProductImagePath"].Value?.ToString();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridViewProducts.SelectedRows[0];

                    DataRow dataRow = productTable.Rows[row.Index];
                    dataRow["ProductId"] = txtProductId.Text;
                    dataRow["ProductName"] = txtProductName.Text;
                    dataRow["ProductDescription"] = txtProductDescription.Text;
                    dataRow["ProductPrice"] = txtProductPrice.Text;
                    dataRow["ProductImagePath"] = txtProductImage.Text;

                    SaveProductData();
                    dataGridViewProducts.Refresh();
                    MessageBox.Show("Changes saved successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a row to save changes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }


        private void SaveProductData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("products.csv"))
                {
                    foreach (DataRow row in productTable.Rows)
                    {
                        writer.WriteLine($"{row["ProductId"]},{row["ProductName"]},{row["ProductDescription"]},{row["ProductPrice"]},{row["ProductImagePath"]}");
                    }
                }
                MessageBox.Show("Product data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}"); //error handler buat debug
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtProductImage.Text = openFileDialog.FileName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = productTable.DefaultView;
            dv.RowFilter = string.Format("ProductName LIKE '%{0}%'", txtSearch.Text);
            dataGridViewProducts.DataSource = dv.ToTable();
            DisplayImagesInGridView(); // Ensure images are displayed after filtering
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
