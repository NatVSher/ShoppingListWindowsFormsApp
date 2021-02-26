using System;
using System.Windows.Forms;

namespace ShoppingListWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public User user;
        public decimal priceOfSelectedProducts = 0;
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
            var foodProducts = ProductStorage.GetAll();
            foreach (var foodProduct in foodProducts)
            {
                if (foodProduct.Type == TypeProduct.FoodProduct)
                {
                    foodDataGridView.Rows.Add(foodProduct.Name, foodProduct.Price);
                }
                if (foodProduct.Type == TypeProduct.NonFoodProduct)
                {
                    nonFoodDataGridView.Rows.Add(foodProduct.Name, foodProduct.Price);
                }
                if (foodProduct.Type == TypeProduct.MedicalProduct)
                {
                    medicalDataGridView.Rows.Add(foodProduct.Name, foodProduct.Price);
                }
            }
        }

        private void foodDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView clickedDataGridView = (DataGridView)sender;
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && foodDataGridView[e.ColumnIndex, e.RowIndex].Value != null)
            {
                productDataGridView.Rows.Add(clickedDataGridView[0, e.RowIndex].Value);
                user.ListProducts.Add(clickedDataGridView[0, e.RowIndex].Value.ToString());
                priceOfSelectedProducts += (decimal)clickedDataGridView[1, e.RowIndex].Value;
                finalPriceTextBox.Text = priceOfSelectedProducts.ToString();
            }
        }


    }
}
