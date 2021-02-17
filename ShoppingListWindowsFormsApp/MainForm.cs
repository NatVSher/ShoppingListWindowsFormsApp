using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
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
    }
}
