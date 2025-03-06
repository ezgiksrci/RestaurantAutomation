﻿using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using static RestaurantAutomation.UI.Forms.LoginForm;

namespace RestaurantAutomation.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly RoleService _roleService;
        private readonly RoleRepository roleRepository;
        private readonly AppDbContext _context;

        public MainForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
            roleRepository = new RoleRepository(_context);
            _roleService = new RoleService(roleRepository);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnReports.Visible = false;
            if (SessionManager.LoggedInUser != null)
            {
                var role = _roleService.GetByID(SessionManager.LoggedInUser.RoleID);

                // Hide Reports button if the user is not an admin
                btnReports.Visible = role.Name == "admin";
            }
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
            OrderForm orderForm = new(null);
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
            ReportForm reportForm = new();
            this.Hide();
            reportForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            this.Hide();
            loginForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout logic...
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new();
            this.Hide();
            categoryForm.Show();
        }
    }
}
