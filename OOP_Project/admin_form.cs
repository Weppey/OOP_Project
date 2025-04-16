using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class admin_form : Form
    {

        private string connectionString = "Server=localhost;Database=movierecommendationdb;Uid=root;Pwd=;";
        private string userType;
        private int currentUserId;
        public admin_form()
        {
            InitializeComponent();

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            home_form homeForm = new home_form(userType, currentUserId);
            homeForm.Show();
        }
    }
}
