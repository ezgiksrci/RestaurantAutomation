using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new();
            this.Hide();
            tableForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new();
            this.Hide();
            orderForm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new();
            this.Hide();
            menuForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
