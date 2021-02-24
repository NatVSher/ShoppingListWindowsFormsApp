namespace ShoppingListWindowsFormsApp
{
    partial class MainForm
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameNonFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceNonFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalLabel = new System.Windows.Forms.Label();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalDataGridView = new System.Windows.Forms.DataGridView();
            this.nonFoodDataGridView = new System.Windows.Forms.DataGridView();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceTextBox = new System.Windows.Forms.TextBox();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonFoodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodLabel.Location = new System.Drawing.Point(12, 53);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(282, 25);
            this.foodLabel.TabIndex = 1;
            this.foodLabel.Text = "Продовольственные товары";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Непродовольственные товары";
            // 
            // nameNonFood
            // 
            this.nameNonFood.HeaderText = "Наименование";
            this.nameNonFood.Name = "nameNonFood";
            // 
            // PriceNonFood
            // 
            this.PriceNonFood.HeaderText = "Цена";
            this.PriceNonFood.Name = "PriceNonFood";
            // 
            // MedicalLabel
            // 
            this.MedicalLabel.AutoSize = true;
            this.MedicalLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MedicalLabel.Location = new System.Drawing.Point(643, 54);
            this.MedicalLabel.Name = "MedicalLabel";
            this.MedicalLabel.Size = new System.Drawing.Size(216, 25);
            this.MedicalLabel.TabIndex = 4;
            this.MedicalLabel.Text = "Медицинские товары";
            // 
            // MedName
            // 
            this.MedName.HeaderText = "Наименование";
            this.MedName.Name = "MedName";
            // 
            // MedPrice
            // 
            this.MedPrice.HeaderText = "Цена";
            this.MedPrice.Name = "MedPrice";
            // 
            // foodName
            // 
            this.foodName.HeaderText = "Наименование";
            this.foodName.Name = "foodName";
            // 
            // foodPrice
            // 
            this.foodPrice.HeaderText = "Цена";
            this.foodPrice.Name = "foodPrice";
            // 
            // medicalDataGridView
            // 
            this.medicalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedName,
            this.MedPrice});
            this.medicalDataGridView.Location = new System.Drawing.Point(643, 104);
            this.medicalDataGridView.Name = "medicalDataGridView";
            this.medicalDataGridView.Size = new System.Drawing.Size(240, 150);
            this.medicalDataGridView.TabIndex = 5;
            this.medicalDataGridView.Text = "dataGridView1";
            this.medicalDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDataGridView_CellDoubleClick);
            // 
            // nonFoodDataGridView
            // 
            this.nonFoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonFoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameNonFood,
            this.PriceNonFood});
            this.nonFoodDataGridView.Location = new System.Drawing.Point(340, 104);
            this.nonFoodDataGridView.Name = "nonFoodDataGridView";
            this.nonFoodDataGridView.Size = new System.Drawing.Size(240, 150);
            this.nonFoodDataGridView.TabIndex = 3;
            this.nonFoodDataGridView.Text = "dataGridView1";
            this.nonFoodDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDataGridView_CellDoubleClick);
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodName,
            this.foodPrice});
            this.foodDataGridView.Location = new System.Drawing.Point(36, 104);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.Size = new System.Drawing.Size(240, 150);
            this.foodDataGridView.TabIndex = 0;
            this.foodDataGridView.Text = "dataGridView1";
            this.foodDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDataGridView_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(374, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список покупок";
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Наименование";
            this.NameProduct.Name = "NameProduct";
            // 
            // finalPriceTextBox
            // 
            this.finalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalPriceTextBox.Location = new System.Drawing.Point(669, 374);
            this.finalPriceTextBox.Name = "finalPriceTextBox";
            this.finalPriceTextBox.Size = new System.Drawing.Size(158, 33);
            this.finalPriceTextBox.TabIndex = 8;
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalPriceLabel.Location = new System.Drawing.Point(643, 328);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(214, 21);
            this.finalPriceLabel.TabIndex = 9;
            this.finalPriceLabel.Text = "Примерная цена покупок";
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct});
            this.productDataGridView.Location = new System.Drawing.Point(384, 328);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(143, 150);
            this.productDataGridView.TabIndex = 7;
            this.productDataGridView.Text = "dataGridView1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 513);
            this.Controls.Add(this.finalPriceLabel);
            this.Controls.Add(this.finalPriceTextBox);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicalDataGridView);
            this.Controls.Add(this.MedicalLabel);
            this.Controls.Add(this.nonFoodDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.foodDataGridView);
            this.Name = "MainForm";
            this.Text = "Список покупок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonFoodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNonFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceNonFood;
        private System.Windows.Forms.Label MedicalLabel;
        private System.Windows.Forms.DataGridView nonFoodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedPrice;
        private System.Windows.Forms.DataGridView medicalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.TextBox finalPriceTextBox;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.DataGridView productDataGridView;
    }
}

