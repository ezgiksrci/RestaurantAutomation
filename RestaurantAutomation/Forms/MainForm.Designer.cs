namespace RestaurantAutomation.UI.Forms
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            btnReports = new Button();
            btnMenu = new Button();
            btnOrder = new Button();
            btnTable = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReports);
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnTable);
            groupBox1.Location = new Point(56, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(729, 499);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(374, 218);
            btnReports.Margin = new Padding(4, 5, 4, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(290, 111);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(76, 218);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(290, 111);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu Management";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(374, 95);
            btnOrder.Margin = new Padding(4, 5, 4, 5);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(290, 111);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnTable
            // 
            btnTable.Location = new Point(76, 95);
            btnTable.Margin = new Padding(4, 5, 4, 5);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(290, 111);
            btnTable.TabIndex = 6;
            btnTable.Text = "Table Management";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 544);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainScreen";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnReports;
        private Button btnMenu;
        private Button btnOrder;
        private Button btnTable;
    }
}