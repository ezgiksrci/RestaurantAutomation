namespace RestaurantAutomation.UI.Forms
{
    partial class OrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dgwCancel = new DataGridViewTextBoxColumn();
            dgwProductName = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewComboBoxColumn();
            dgwUnitPrice = new DataGridViewTextBoxColumn();
            dgwAmount = new DataGridViewTextBoxColumn();
            dgwDate = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(799, 141);
            button1.Name = "button1";
            button1.Size = new Size(138, 70);
            button1.TabIndex = 4;
            button1.Text = "Main Courses";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(799, 29);
            button2.Name = "button2";
            button2.Size = new Size(138, 70);
            button2.TabIndex = 5;
            button2.Text = "Startes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgwCancel, dgwProductName, Column1, dgwUnitPrice, dgwAmount, dgwDate });
            dataGridView1.Location = new Point(12, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 158);
            dataGridView1.TabIndex = 6;
            // 
            // dgwCancel
            // 
            dgwCancel.HeaderText = "İptal";
            dgwCancel.MinimumWidth = 6;
            dgwCancel.Name = "dgwCancel";
            dgwCancel.Width = 50;
            // 
            // dgwProductName
            // 
            dgwProductName.HeaderText = "Ürün Adı";
            dgwProductName.MinimumWidth = 6;
            dgwProductName.Name = "dgwProductName";
            dgwProductName.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Miktar";
            Column1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dgwUnitPrice
            // 
            dataGridViewCellStyle2.NullValue = "0";
            dgwUnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            dgwUnitPrice.HeaderText = "Fiyat";
            dgwUnitPrice.MinimumWidth = 6;
            dgwUnitPrice.Name = "dgwUnitPrice";
            dgwUnitPrice.Width = 125;
            // 
            // dgwAmount
            // 
            dgwAmount.HeaderText = "Tutar";
            dgwAmount.MinimumWidth = 6;
            dgwAmount.Name = "dgwAmount";
            dgwAmount.Width = 125;
            // 
            // dgwDate
            // 
            dgwDate.HeaderText = "ShippDate";
            dgwDate.MinimumWidth = 6;
            dgwDate.Name = "dgwDate";
            dgwDate.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(799, 365);
            button3.Name = "button3";
            button3.Size = new Size(138, 72);
            button3.TabIndex = 7;
            button3.Text = "Beverages";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(799, 251);
            button4.Name = "button4";
            button4.Size = new Size(138, 72);
            button4.TabIndex = 7;
            button4.Text = "Desserts";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(599, 206);
            button5.Name = "button5";
            button5.Size = new Size(168, 39);
            button5.TabIndex = 8;
            button5.Text = "Sipariş Kaydet";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 265);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(755, 172);
            dataGridView2.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(12, 206);
            button6.Name = "button6";
            button6.Size = new Size(168, 39);
            button6.TabIndex = 10;
            button6.Text = "Yeni Sipariş";
            button6.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 459);
            Controls.Add(button6);
            Controls.Add(dataGridView2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "OrderForm";
            Text = "OrderScreen";
            Load += OrderScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn dgwCancel;
        private DataGridViewTextBoxColumn dgwProductName;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn dgwUnitPrice;
        private DataGridViewTextBoxColumn dgwAmount;
        private DataGridViewTextBoxColumn dgwDate;
        private Button button5;
        private DataGridView dataGridView2;
        private Button button6;
    }
}