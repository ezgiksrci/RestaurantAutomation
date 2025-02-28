namespace RestaurantAutomation.UI.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            txtSearchproduct = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            grpProduct = new GroupBox();
            txtPrice = new TextBox();
            btnUploadImage = new Button();
            label7 = new Label();
            pcbImage = new PictureBox();
            label6 = new Label();
            txtDescription = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            txtProductName = new TextBox();
            btnAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colPrice });
            dgwProducts.Location = new Point(6, 21);
            dgwProducts.Margin = new Padding(2, 1, 2, 1);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 82;
            dgwProducts.Size = new Size(478, 259);
            dgwProducts.TabIndex = 0;
            // 
            // colName
            // 
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.Resizable = DataGridViewTriState.True;
            colName.Width = 400;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 10;
            colCategory.Name = "colCategory";
            colCategory.Resizable = DataGridViewTriState.True;
            colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCategory.Width = 200;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 10;
            colPrice.Name = "colPrice";
            colPrice.Width = 200;
            // 
            // txtSearchproduct
            // 
            txtSearchproduct.Location = new Point(12, 288);
            txtSearchproduct.Margin = new Padding(2, 1, 2, 1);
            txtSearchproduct.Name = "txtSearchproduct";
            txtSearchproduct.PlaceholderText = "Search Product";
            txtSearchproduct.Size = new Size(110, 23);
            txtSearchproduct.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            comboBox1.Location = new Point(354, 289);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 289);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Filter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.125F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(422, 315);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 12);
            label2.TabIndex = 4;
            label2.Text = "Clean Filters";
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(txtPrice);
            grpProduct.Controls.Add(btnUploadImage);
            grpProduct.Controls.Add(label7);
            grpProduct.Controls.Add(pcbImage);
            grpProduct.Controls.Add(label6);
            grpProduct.Controls.Add(txtDescription);
            grpProduct.Controls.Add(label5);
            grpProduct.Controls.Add(label4);
            grpProduct.Controls.Add(label3);
            grpProduct.Controls.Add(cmbCategory);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Location = new Point(515, 21);
            grpProduct.Margin = new Padding(2, 1, 2, 1);
            grpProduct.Name = "grpProduct";
            grpProduct.Padding = new Padding(2, 1, 2, 1);
            grpProduct.Size = new Size(307, 295);
            grpProduct.TabIndex = 5;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product Details";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(125, 91);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 23);
            txtPrice.TabIndex = 10;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(25, 237);
            btnUploadImage.Margin = new Padding(2, 1, 2, 1);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(81, 22);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 202);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 8;
            label7.Text = "Upload Picture:";
            // 
            // pcbImage
            // 
            pcbImage.Location = new Point(125, 202);
            pcbImage.Margin = new Padding(2, 1, 2, 1);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(125, 56);
            pcbImage.TabIndex = 7;
            pcbImage.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 135);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 6;
            label6.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(125, 129);
            txtDescription.Margin = new Padding(2, 1, 2, 1);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(166, 53);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 91);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 60);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 33);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            cmbCategory.Location = new Point(125, 58);
            cmbCategory.Margin = new Padding(2, 1, 2, 1);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(166, 23);
            cmbCategory.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(125, 30);
            txtProductName.Margin = new Padding(2, 1, 2, 1);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(166, 23);
            txtProductName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(671, 326);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(527, 326);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(124, 40);
            button2.TabIndex = 7;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(527, 380);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 8;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(671, 380);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(124, 39);
            button5.TabIndex = 9;
            button5.Text = "CLEAN";
            button5.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 465);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(grpProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtSearchproduct);
            Controls.Add(dgwProducts);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MenuForm";
            Text = "MenuScreen";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwProducts;
        private TextBox txtSearchproduct;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private GroupBox grpProduct;
        private Label label3;
        private ComboBox cmbCategory;
        private TextBox txtProductName;
        private Label label6;
        private RichTextBox txtDescription;
        private Label label5;
        private Label label4;
        private Label label7;
        private PictureBox pcbImage;
        private Button btnAdd;
        private Button btnUploadImage;
        private Button button2;
        private Button button3;
        private Button button5;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private TextBox txtPrice;
    }
}