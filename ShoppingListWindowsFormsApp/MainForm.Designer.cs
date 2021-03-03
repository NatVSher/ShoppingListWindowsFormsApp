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
            this.finalPriceTextBox = new System.Windows.Forms.TextBox();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.nameNonFood.ReadOnly = true;
            // 
            // PriceNonFood
            // 
            this.PriceNonFood.HeaderText = "Цена";
            this.PriceNonFood.Name = "PriceNonFood";
            this.PriceNonFood.ReadOnly = true;
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
            this.MedName.ReadOnly = true;
            // 
            // MedPrice
            // 
            this.MedPrice.HeaderText = "Цена";
            this.MedPrice.Name = "MedPrice";
            this.MedPrice.ReadOnly = true;
            // 
            // foodName
            // 
            this.foodName.HeaderText = "Наименование";
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            // 
            // foodPrice
            // 
            this.foodPrice.HeaderText = "Цена";
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.ReadOnly = true;
            // 
            // medicalDataGridView
            // 
            this.medicalDataGridView.AllowUserToDeleteRows = false;
            this.medicalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedName,
            this.MedPrice});
            this.medicalDataGridView.Location = new System.Drawing.Point(643, 104);
            this.medicalDataGridView.Name = "medicalDataGridView";
            this.medicalDataGridView.ReadOnly = true;
            this.medicalDataGridView.Size = new System.Drawing.Size(240, 150);
            this.medicalDataGridView.TabIndex = 5;
            this.medicalDataGridView.Text = "dataGridView1";
            this.medicalDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDataGridView_CellDoubleClick);
            // 
            // nonFoodDataGridView
            // 
            this.nonFoodDataGridView.AllowUserToDeleteRows = false;
            this.nonFoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonFoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameNonFood,
            this.PriceNonFood});
            this.nonFoodDataGridView.Location = new System.Drawing.Point(340, 104);
            this.nonFoodDataGridView.Name = "nonFoodDataGridView";
            this.nonFoodDataGridView.ReadOnly = true;
            this.nonFoodDataGridView.Size = new System.Drawing.Size(240, 150);
            this.nonFoodDataGridView.TabIndex = 3;
            this.nonFoodDataGridView.Text = "dataGridView1";
            this.nonFoodDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodDataGridView_CellDoubleClick);
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AllowUserToDeleteRows = false;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodName,
            this.foodPrice});
            this.foodDataGridView.Location = new System.Drawing.Point(36, 104);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.ReadOnly = true;
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
            // finalPriceTextBox
            // 
            this.finalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finalPriceTextBox.Location = new System.Drawing.Point(669, 374);
            this.finalPriceTextBox.Name = "finalPriceTextBox";
            this.finalPriceTextBox.ReadOnly = true;
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
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Наименование";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameProduct.Width = 200;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct});
            this.productDataGridView.Location = new System.Drawing.Point(340, 328);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(240, 150);
            this.productDataGridView.TabIndex = 7;
            this.productDataGridView.Text = "dataGridView1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.aboutToolStripMenuItem.Text = "&About...";
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
        private System.Windows.Forms.TextBox finalPriceTextBox;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

