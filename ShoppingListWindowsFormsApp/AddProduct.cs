using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoppingListWindowsFormsApp
{
    public partial class AddProduct: Form
    {
        Product userProduct;
        public AddProduct(Product userProduct)
        {
            InitializeComponent();
            nameTextBox.Focus();
            this.userProduct = userProduct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userProduct.Name = nameTextBox.Text;
            var userPriceTxt = priceTextBox.Text;
            if (!isValidUserAnswer(userPriceTxt))
            {
                return;
            }
            userProduct.Price = Convert.ToDecimal(userPriceTxt);
            
            bool flag = true;
            while (flag)
            {
                switch (typeProductCheckedListBox.SelectedIndex)
                {
                    case 0:
                        userProduct.Type = TypeProduct.FoodProduct;
                        flag = false;
                        break;
                    case 1:
                        userProduct.Type = TypeProduct.NonFoodProduct;
                        flag = false;
                        break;
                    case 2:
                        userProduct.Type = TypeProduct.MedicalProduct;
                        flag = false;
                        break;
                    default:
                        MessageBox.Show("Пожалуйста, выберете тип продукта!");
                        break;
                }
            }
                        
            ProductStorage.Append(userProduct);
            this.Close();
            
        }
        private bool isValidUserAnswer(string userAnswerTxt)
        {
            decimal userAnswer;
            bool correctEntry;
            correctEntry = Decimal.TryParse(userAnswerTxt, out userAnswer);
            if (!correctEntry)
            {
                MessageBox.Show("Пожалуйста, введите число (не превосходящее 10^9)!");
                priceTextBox.Text = "";
            }
            return correctEntry;
        }

        private void typeProductCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeProductCheckedListBox.CheckedItems.Count > 1)
            {
                for (int i = 0; i < typeProductCheckedListBox.Items.Count; i++)
                    typeProductCheckedListBox.SetItemChecked(i, false);
                typeProductCheckedListBox.SetItemChecked(typeProductCheckedListBox.SelectedIndex, true);
            }
        }
    }
}
