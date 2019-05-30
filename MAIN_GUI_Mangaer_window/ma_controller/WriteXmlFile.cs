using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NewUsers;
using Main;
using System.IO;

namespace WriteXMLfile
{
    public class WriteXmlFile
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        private static string dataDir = myDir.Parent.Parent.FullName.ToString();
        private static string xmlDishPath = $"{dataDir}\\Data\\Dishes.xml";
        private static string xmlFeedBack = $"{dataDir}\\Data\\FeedBack.xml";
        private static string xmlUsers = $"{dataDir}\\Data\\Users.xml";
        private static string xmlOrder = $"{dataDir}\\Data\\Order.xml";

        private Dish dsh = new Dish();
        DataTable dt1 = new DataTable();
        //VipCustomer vip = new VipCustomer();
        //Employee emp = new Employee();

        public WriteXmlFile(Dish myDish)
        {
            if(Directory.Exists(xmlDishPath))
            {
                DataTable dt = new DataTable();
                dt.ReadXml(xmlDishPath);
                dt1 = dt;
            }
            dsh = myDish;

        }
        //public WriteXmlFile(VipCustomer vipCustomer)
        //{
        //    vip = vipCustomer;
        //}
        //public WriteXmlFile(Employee empUser)
        //{
        //    emp = empUser;
        //}
        public void XmlDishWrite()
        {
            //DataTable dt1 = new DataTable("tbl");
            
            dt1.Columns.Add("Dish Name", typeof(string));
            dt1.Columns.Add("Dish Price", typeof(float));
            dt1.Columns.Add("size", typeof(float));
            dt1.Columns.Add("Image Path", typeof(string));
            dt1.Columns.Add("Dish description", typeof(string));
            dt1.Columns.Add("Dish type", typeof(string));
            dt1.Rows.Add(dsh.DishName, dsh.DishPrice, dsh.DishSize, dsh.image, dsh.DishDescripation, dsh.dishType );
            dt1.AcceptChanges();
            dt1.WriteXml(xmlDishPath, XmlWriteMode.WriteSchema);
        }
        //public void XmlUserWrite()
        //{

        //    DataTable dt2 = new DataTable("Vip Customers");
        //    dt2.Columns.Add("First Name", typeof(string));
        //    dt2.Columns.Add("Last Name", typeof(string));
        //    dt2.Columns.Add("User Name", typeof(string));
        //    dt2.Columns.Add("Pass Word", typeof(string));
        //    dt2.Columns.Add("Email", typeof(string));
        //    dt2.Columns.Add("Adress", typeof(string));
        //    dt2.Columns.Add("Phone Number", typeof(string));
        //    dt2.Columns.Add("Credit Card", typeof(string));
        //    dt2.Rows.Add(vip.FirstName, vip.LastName, vip.UserName, vip.PassWord, vip.Email, vip.adress, vip.PhoneNumber, vip.CreditCard);

        //}
        //public void XmlEmpWrite()
        //{
        //    DataTable dt3 = new DataTable("Employees");
        //    dt3.Columns.Add("First Name", typeof(string));
        //    dt3.Columns.Add("Last Name", typeof(string));
        //    dt3.Columns.Add("ID", typeof(string));
        //    dt3.Columns.Add("Email", typeof(string));
        //    dt3.Columns.Add("Adress", typeof(string));
        //    dt3.Columns.Add("Phone Number", typeof(string));
        //    dt3.Columns.Add("Bank Account", typeof(string));
        //    dt3.Rows.Add(emp.FirstName, emp.LastName, emp.ID, emp.Email, emp.adress, emp.BankAccount);
        //}
    }
}
