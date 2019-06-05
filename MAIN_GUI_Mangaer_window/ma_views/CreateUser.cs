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
using main;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class CreateUser : Form
    {

        VipCustomer myVipCustomer = new VipCustomer();
        Employee myEmployee = new Employee();
        ma_controller.Manager myManager = new ma_controller.Manager();

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            comboBox1CreateUser.Items.Add("VipUser");
            comboBox1CreateUser.Items.Add("Employee");
            comboBox1CreateUser.Items.Add("Manager");
            comboBox1CreateUser.SelectedIndex = 2;
            textBox8CreateUserPassword.Text = "";
            textBox8CreateUserPassword.PasswordChar = '*';
            textBox9CrePassVerify.Text = "";
            textBox9CrePassVerify.PasswordChar = '*';


        }

        private void hideElementsByType()
        {
            if (comboBox1CreateUser.SelectedItem.Equals("VipUser"))
            {

                textBox6CreateUserID.Visible = false;

            }
            else if (comboBox1CreateUser.SelectedItem.Equals("Employee"))
            {
                textBox7createUserUsername.Visible = false;
                textBox8CreateUserPassword.Visible = false;
            }
            else if (comboBox1CreateUser.SelectedItem.Equals("Manager"))
            {
               
            }
        }

        private void createUserFromType()
        {
            if (comboBox1CreateUser.SelectedItem.Equals("Vipuser"))
            {
                myVipCustomer.FirstName = textBox1CreateUserName.Text;
                myVipCustomer.LastName = textBox2CreUserLastName.Text;
                myVipCustomer.PhoneNumber = textBox4PhoneNumber.Text;
                myVipCustomer.UserName = textBox4PhoneNumber.Text;
                myVipCustomer.PassWord = textBox4PhoneNumber.Text;
                myVipCustomer.Address = textBox5EmailCreateUser.Text;
                myVipCustomer.Email = textBox5EmailCreateUser.Text;
                ma_controller.XmlParser.XmlParserVipCustomer(myVipCustomer);
                userCreatedMsg(myVipCustomer.FirstName);

            }
            else if(comboBox1CreateUser.SelectedItem.Equals("Employee"))
            {
                myEmployee.FirstName = textBox1CreateUserName.Text;
                myEmployee.LastName = textBox2CreUserLastName.Text;
                myEmployee.PhoneNumber = textBox4PhoneNumber.Text;
                myEmployee.Address = textBox5EmailCreateUser.Text;
                myEmployee.Email = textBox5EmailCreateUser.Text;
                myEmployee.ID = textBox6CreateUserID.Text;
                ma_controller.XmlParser.XmlParserEmployee(myEmployee);
                userCreatedMsg(myEmployee.FirstName);

            }
            else if(comboBox1CreateUser.SelectedItem.Equals("Manager"))
            {
                myManager.FirstName = textBox1CreateUserName.Text;
                myManager.LastName = textBox2CreUserLastName.Text;
                myManager.PhoneNumber = textBox4PhoneNumber.Text;
                //myManager.UserName = textBox4PhoneNumber.Text;
                //myManager.PassWord = textBox4PhoneNumber.Text;
                myManager.Address = textBox5EmailCreateUser.Text;
                myManager.Email = textBox5EmailCreateUser.Text;
                ma_controller.XmlParser.XmlParserManager(myManager);
                userCreatedMsg(myManager.FirstName);

            }
        }
        private bool passMatch()
        {
            if (!textBox8CreateUserPassword.Text.Equals(textBox9CrePassVerify.Text))
            {
                MessageBox.Show("Passwords don't match, please try again", "Password missmatch",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                myVipCustomer.PassWord = textBox8CreateUserPassword.Text;
                return true;
        }

        private void ComboBox1CreateUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideElementsByType();
        }

        private void Button2CancelCreateUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1CreateUser_Click(object sender, EventArgs e)
        {
            if(passMatch())
            {
                createUserFromType();
            }

            
        }
        private void userCreatedMsg(string myUsrCreated)
        {
            MessageBox.Show($"User {myUsrCreated} was successfully created", "User created",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
