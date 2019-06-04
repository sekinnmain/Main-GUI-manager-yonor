using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewUsers;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class CreateUser : Form
    {

        VipCustomer myVipCustomer = new VipCustomer();
        RegisteredUser myRegUser = new RegisteredUser();

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            comboBox1CreateUser.Items.Add("Vipuser");
            comboBox1CreateUser.Items.Add("Employee");
            comboBox1CreateUser.Items.Add("Guest");

        }
    }
}
