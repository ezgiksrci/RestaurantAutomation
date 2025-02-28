namespace RestaurantAutomation.UI.Forms
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();

            for (int i = 0; i < 19; i++)
            {
                Button b = new Button();
                b.Text = "Table " + i;
                b.Name = "btn_" + i;
                b.Size = new Size(100, 100);

                if (i % 2 == 0)
                {
                    b.BackColor = Color.GreenYellow;
                }
                else
                {
                    b.BackColor = Color.Red;
                }
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            this.Hide();
        }
    }
}
