namespace RestaurantAutomation.UI.Forms
{
    partial class TableForm
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
            lblTotal = new Label();
            label7 = new Label();
            lstAddition = new ListBox();
            lstOrders = new ListBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUpdateTable = new Button();
            btnMainMenu = new Button();
            btnListTables = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lstAddition);
            groupBox1.Controls.Add(lstOrders);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(btnUpdateTable);
            groupBox1.Controls.Add(btnMainMenu);
            groupBox1.Controls.Add(btnListTables);
            groupBox1.Controls.Add(btnDeleteTable);
            groupBox1.Controls.Add(btnAddTable);
            groupBox1.Location = new Point(17, 10);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(889, 720);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(706, 537);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(107, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "00000000 ₺";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(647, 537);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 11;
            label7.Text = "Total:";
            // 
            // lstAddition
            // 
            lstAddition.FormattingEnabled = true;
            lstAddition.ItemHeight = 25;
            lstAddition.Location = new Point(647, 130);
            lstAddition.Name = "lstAddition";
            lstAddition.Size = new Size(217, 404);
            lstAddition.TabIndex = 10;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 25;
            lstOrders.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "6", "d", "d", "sd", "sd", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "s", "", "s", "s", "s" });
            lstOrders.Location = new Point(417, 129);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(202, 429);
            lstOrders.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(682, 102);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 9;
            label6.Text = "Addition:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 99);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 9;
            label4.Text = "Order Items:";
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(48, 64);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 33);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 13);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 8;
            label5.Text = "Waiter Table Panel";
            label5.Visible = false;
            // 
            // label2
            // 
            label2.BackColor = Color.LawnGreen;
            label2.Location = new Point(228, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 33);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 13);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 7;
            label1.Text = "Admin Table Panel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(41, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(352, 460);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(228, 570);
            btnUpdateTable.Margin = new Padding(4, 5, 4, 5);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(165, 50);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Table";
            btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(0, 13);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(44, 50);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnListTables
            // 
            btnListTables.Location = new Point(228, 630);
            btnListTables.Margin = new Padding(4, 5, 4, 5);
            btnListTables.Name = "btnListTables";
            btnListTables.Size = new Size(165, 50);
            btnListTables.TabIndex = 2;
            btnListTables.Text = "Show Table List";
            btnListTables.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(40, 630);
            btnDeleteTable.Margin = new Padding(4, 5, 4, 5);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(165, 50);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(40, 570);
            btnAddTable.Margin = new Padding(4, 5, 4, 5);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(165, 55);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Add New Table";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 750);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TableForm";
            Text = "Table Screen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateTable;
        private Button btnListTables;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Label label2;
        private Button btnMainMenu;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label5;
        private ListBox lstAddition;
        private ListBox lstOrders;
        private Label label6;
        private Label label4;
        private Label lblTotal;
        private Label label7;
    }
}