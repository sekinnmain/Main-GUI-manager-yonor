using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class CreateDish : Form
    {
        Dish myDish = new Dish();
        

        public CreateDish()
        {
            InitializeComponent();
        }

        private void Button2Create_Click(object sender, EventArgs e)
        {
            myDish.DishName = textBox1CreateDishName.Text;
            myDish.DishDescripation = textBox4DishDescripton.Text;
            var priceDish = Convert.ToInt32(numericUpDown1CreDishPrice.Value);
            myDish.DishPrice = priceDish;
            myDish.DishSize = Convert.ToInt32(numericUpDown2DishCreateSize.Value);
            //XmlWrite(myDish);
            MessageBox.Show($"Your {myDish.DishName} dish has been created.","Dish created!" );


        }

        private void Button1CraDishImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // image file path  
                myDish.image = open.FileName;
                label7PathToImgDish.Text = "* Image Loaded *";

            }
        }

        private void CreateDish_Load(object sender, EventArgs e)
        {
            comboBox1DishType.Items.Add("Appetizer");
            comboBox1DishType.Items.Add("Main");
            comboBox1DishType.Items.Add("Dessert");
            comboBox1DishType.Items.Add("Drink");
        }

        private void Button3Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
