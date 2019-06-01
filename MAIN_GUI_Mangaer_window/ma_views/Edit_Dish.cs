using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class Edit_Dish : Form
    {
        public Edit_Dish()
        {
            InitializeComponent();
            BindDataEditDish();
        }

        private void Edit_Dish_Load(object sender, EventArgs e)
        {

        }

        private void BindDataEditDish()
        {
            DataSet DishLoad = new DataSet();
            DishLoad.ReadXml(ma_controller.XmlParser.xmlDishPath);

            textBox1EditDishName.DataBindings.Add("Text", DishLoad.Tables[0], "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            //comboBox1DishTypeEdit.DataBindings.Add("Text",DishLoad.Tables[])
        }
    }
}
