using System;
using System.Windows.Forms;

namespace ShoppingListWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public User user;
        public decimal priceOfSelectedProducts = 0;
        public Product userProduct;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user = new User("Инкогнито");
            var enterNameForm = new EnterNameForm(user);
            var result = enterNameForm.ShowDialog(this);
            if (result == DialogResult.None)
                return;
            if (result != DialogResult.OK)
            {
                Close();
            }

            FillingTables();

        }

        private void FillingTables()
        {
            var products = ProductStorage.GetAll();
            foreach (var item in products)
            {
                FillingDataGridView(item);
            }
        }

        private void FillingDataGridView(Product product)
        {
            if (product.Type == TypeProduct.FoodProduct)
            {
                foodDataGridView.Rows.Add(product.Name, product.Price);
            }
            if (product.Type == TypeProduct.NonFoodProduct)
            {
                nonFoodDataGridView.Rows.Add(product.Name, product.Price);
            }
            if (product.Type == TypeProduct.MedicalProduct)
            {
                medicalDataGridView.Rows.Add(product.Name, product.Price);
            }
        }

        private void foodDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView clickedDataGridView = (DataGridView)sender;
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && clickedDataGridView[e.ColumnIndex, e.RowIndex].Value != null)
            {
                productDataGridView.Rows.Add(clickedDataGridView[0, e.RowIndex].Value);                
                priceOfSelectedProducts += (decimal)clickedDataGridView[1, e.RowIndex].Value;
                finalPriceTextBox.Text = priceOfSelectedProducts.ToString();
                user.ListProducts.Add(clickedDataGridView[0, e.RowIndex].Value.ToString());
                user.PriceSelectedProducts = priceOfSelectedProducts;
                UserListStorage.Save(user);
            }
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && clickedDataGridView[e.ColumnIndex, e.RowIndex].Value == null)
            {
                DialogResult dialogResult = MessageBox.Show("Хотите добавить продукт?", "Добавление продуктов", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userProduct = new Product("", 0, 0);
                    var addProduct = new AddProduct(userProduct);
                    addProduct.ShowDialog();
                }
                FillingDataGridView(userProduct);
            }
        }  
        
    }
}
