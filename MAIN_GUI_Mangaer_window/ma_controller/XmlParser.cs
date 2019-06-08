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
using Main.yonor;

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
        public static string xmlAds = $"{dataDir}\\Data\\Ads.xml";
        public static string xmlSmtpSettings = $"{dataDir}\\Data\\Smtp.xml";
        public static string adTemp = $"{dataDir}\\Resources\\email-temp.html";




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
                       new XElement("Type", passDish.DishType),
                       new XElement("Image", passDish.DishImage)));
            doc.Save(xmlDishPath);
        }

        public static void XmlParserVipCustomer(VipCustomer vip)
        {
            XDocument doc = XDocument.Load(xmlUsers);
            XElement school = doc.Element("Users");
            school.Add(new XElement("RegisteredUser",
                       new XElement("FirstName", vip.FirstName),
                       new XElement("LastName", vip.LastName),
                       new XElement("Type", vip.userType),
                       new XElement("UserName", vip.UserName),
                       new XElement("PassWord", vip.PassWord),
                       new XElement("Email", vip.Email),
                       new XElement("Address", vip.Address),
                       new XElement("PhoneNumber", vip.PhoneNumber)));
                       //new XElement("CreditCard", vip.CreditCard)));

            doc.Save(xmlUsers);
        }
        public static void XmlParserEmployee(Employee crtEmp)
        {
            XDocument doc = XDocument.Load(xmlUsers);
            XElement school = doc.Element("Users");
            school.Add(new XElement("RegisteredUser",
                       new XElement("FirstName", crtEmp.FirstName),
                       new XElement("LastName", crtEmp.LastName),
                        new XElement("Type", crtEmp.userType),
                       new XElement("ID", crtEmp.ID),
                       new XElement("Email", crtEmp.Email),
                       new XElement("Address", crtEmp.Address),
                       new XElement("PhoneNumber", crtEmp.PhoneNumber)
                    ));

            doc.Save(xmlUsers);
        }
        public static void XmlParserManager(Manager crtManager)
        {
            XDocument doc = XDocument.Load(xmlUsers);
            XElement school = doc.Element("Users");
            school.Add(new XElement("RegisteredUser",
                       new XElement("FirstName", crtManager.FirstName),
                       new XElement("LastName", crtManager.LastName),
                        new XElement("Type", crtManager.userType),
                       //new XElement("ID", crtManager.ID),
                       new XElement("Email", crtManager.Email),
                       new XElement("Address", crtManager.Address),
                       new XElement("PhoneNumber", crtManager.PhoneNumber)
                    ));

            doc.Save(xmlUsers);
        }
        public static void XmlParserAds(Advertisement crtAd)
        {
            XDocument doc = XDocument.Load(xmlAds);
            XElement school = doc.Element("Ads");
            school.Add(new XElement("Ad",
                       new XElement("CompanyName", crtAd.CompanyName),
                       new XElement("Price", crtAd.Price),
                       new XElement("Active", crtAd.Active),
                        new XElement("AdBody", crtAd.AdBody),
                       new XElement("CreationDate", crtAd.CreationDate),
                       new XElement("ExpirationDate", crtAd.ExpirationDate.ToString()),
                       new XElement("URL", crtAd.Url),
                       new XElement("Image", crtAd.ImgPath)
                    ));

            doc.Save(xmlAds);
        }
        //public static void XmlParserSmtp(Advertisement smtpSett)
        //{
        //    XDocument doc = XDocument.Load(xmlSmtpSettings);
        //    XElement school = doc.Element("Ads");
        //    school.Add(new XElement("Ad",
        //               new XElement("CompanyName", smtpSett.CompanyName),
        //               new XElement("Price", smtpSett.Price),
        //               new XElement("Active", smtpSett.Active),
        //                new XElement("AdBody", smtpSett.AdBody),
        //               new XElement("CreationDate", smtpSett.CreationDate),
        //               new XElement("ExpirationDate", smtpSett.ExpirationDate.ToString()),
        //               new XElement("URL", smtpSett.Url),
        //               new XElement("Image", smtpSett.ImgPath)
        //            ));

        //    doc.Save(xmlSmtpSettings);
        //}

    }
}
