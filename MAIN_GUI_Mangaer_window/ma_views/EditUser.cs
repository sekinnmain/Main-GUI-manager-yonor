using main;
using NewUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class EditUser : Form
    {

        private VipCustomer myVipCustomer = new VipCustomer();
        private Employee myEmployee = new Employee();
        private ma_controller.Manager myManager = new ma_controller.Manager();
        private int indexUserToEdit;


        public EditUser(int userIndex, string userToEditName, string userEditType)
        {
            InitializeComponent();
            indexUserToEdit = userIndex;
            BindDataEditDish(userToEditName, userEditType);
        }



        private void BindDataEditDish(string myUser, string userType)
        {

            foreach (XElement xe in (XDocument.Load(ma_controller.XmlParser.xmlUsers).XPathSelectElements($"//{userType}")))
            {
                if (xe.Element("Name").Value.Equals(myUser))
                {
             
                    textBox1editUserName.Text = xe.Element("Name").Value;
                    textBoeditUserLastName.Text = xe.Element("LastName").Value;
                    textBox3Addressedit.Text = xe.Element("Address").Value;
                    textBox4PhoneNumberedit.Text = xe.Element("PhoneNumber").Value;
                    textBox5EmailUseredit.Text = xe.Element("Email").Value;
                    if (comboBox1EditUser.SelectedItem.Equals("Vipuser"))
                    {
                        textBox7editserUsername.Text = xe.Element("UserName").Value;
                        textBox6editUserID.Text = xe.Element("ID").Value;

                    }
                }
            }


           
        }
        private void ChangeUserPass()
        {
            if(checkBox1EditPasswordEditForm.Checked == true)
            {
                textBox8editUserPassword.ReadOnly = false;
                textBox9editPassVerify.ReadOnly = false;
            }else
                {
                textBox8editUserPassword.ReadOnly = true;
                textBox9editPassVerify.ReadOnly = true;
            }
           


        }

        private bool PassMatch()
        {
            if ((comboBox1EditUser.SelectedItem.Equals("Vipuser")))
            {
                if (!textBox8editUserPassword.Text.Equals(textBox9editPassVerify.Text))
                {
                    MessageBox.Show("Passwords don't match, please try again", "Password miss match",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    myVipCustomer.PassWord = textBox8editUserPassword.Text;
                return true;
            }

            return true;
        }

        private void LoadDefaultValuesForComponents()

        {
            checkBox1EditPasswordEditForm.Checked = false;
            comboBox1EditUser.Items.Add("Vipuser");
            comboBox1EditUser.Items.Add("Employee");
            comboBox1EditUser.Items.Add("Manager");
            comboBox1EditUser.SelectedIndex = indexUserToEdit;
         
            if (comboBox1EditUser.SelectedItem.Equals("Vipuser"))
                {
                textBox8editUserPassword.ReadOnly = true;
                textBox9editPassVerify.ReadOnly = true;
                

                }



            
        }

        private void hideElementsByType()
        {
            if (comboBox1EditUser.SelectedItem.Equals("Vipuser"))
            {

                showElements(true);

            }
            else if (comboBox1EditUser.SelectedItem.Equals("Employee"))
            {
                showElements(false);


            }
            else if (comboBox1EditUser.SelectedItem.Equals("Manager"))
            {
                showElements(false);
            }
        }

        private void showElements(bool state)
        {
            textBox7editserUsername.Visible = state;
            textBox8editUserPassword.Visible = state;
            textBox9editPassVerify.Visible = state;
            textBox6editUserID.Visible = state;
            label10EditUserVrfyPass.Visible = state;
            label7EditUserID.Visible = state;
            label9EditUserPassword.Visible = state;
            label7EditUserID.Visible = state;
        }

        private void CheckBox1EditPasswordEditForm_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUserPass();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            hideElementsByType();
            LoadDefaultValuesForComponents();
        }
    }
}
