using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Main;
using NewUsers;
using main;


namespace MAIN_GUI_Mangaer_window.ma_controller
{
    public class XmlParser
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        private static string dataDir = myDir.Parent.Parent.FullName.ToString();
        public static string xmlDishPath = $"{dataDir}\\Data\\Dishes.xml";
        public static string xmlFeedBack = $"{dataDir}\\Data\\FeedBack.xml";
        public static string xmlUsers = $"{dataDir}\\Data\\Users.xml";
        public static string xmlOrder = $"{dataDir}\\Data\\Order.xml";

        //Dish myDish = new Dish();

        public static void XmlParserDish(Dish passDish)
        {
            XDocument doc = XDocument.Load(xmlDishPath);
            XElement school = doc.Element("Dishes");
            school.Add(new XElement("Dish",
                       new XElement("Name", passDish.DishName),
                       new XElement("Price", passDish.DishPrice),
                       new XElement("Size", passDish.DishSize),
                       new XElement("Description", passDish.DishDescription),
                       new XElement("Image", passDish.DishImage)));
            doc.Save(xmlDishPath);
        }

        public static void XmlParserVipCustomer(VipCustomer vip)
        {
            XDocument doc = XDocument.Load(xmlUsers);
            XElement school = doc.Element("VIPCustomers");
            school.Add(new XElement("VIPCustomer",
                       new XElement("FirstName", vip.FirstName),
                       new XElement("LastName", vip.LastName),
                       new XElement("UserName", vip.UserName),
                       new XElement("PassWord", vip.PassWord),
                       new XElement("Email", vip.Email),
                       new XElement("Adress", vip.Address),
                       new XElement("PhoneNumber", vip.PhoneNumber),
                       new XElement("CreditCard", vip.CreditCard)));

            doc.Save(xmlUsers);
        }
        public static void XmlParserEmployee(Employee crtEmp)
        {
            XDocument doc = XDocument.Load(xmlUsers);
            XElement school = doc.Element("Employees");
            school.Add(new XElement("Emplooyee",
                       new XElement("FirstName", crtEmp.FirstName),
                       new XElement("LastName", crtEmp.LastName),
                       new XElement("ID", crtEmp.ID),
                       new XElement("Email", crtEmp.Email),
                       new XElement("Adress", crtEmp.Address),
                       new XElement("PhoneNumber", crtEmp.PhoneNumber)
                    ));

            doc.Save(xmlUsers);
        }
        public static void XmlParserManager(Manager crtManager)
        {
            XDocument doc = XDocument.Load(xmlUsers);
            XElement school = doc.Element("Managers");
            school.Add(new XElement("Manager",
                       new XElement("FirstName", crtManager.FirstName),
                       new XElement("LastName", crtManager.LastName),
                       //new XElement("ID", crtManager.ID),
                       new XElement("Email", crtManager.Email),
                       new XElement("Adress", crtManager.Address),
                       new XElement("PhoneNumber", crtManager.PhoneNumber)
                    ));

            doc.Save(xmlUsers);
        }

    }
}
