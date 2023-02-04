using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Program
    {
        //Dodavanje reference za preglednik
        IWebDriver driver = new FirefoxDriver();


        static void Main(string[] args)
        {
                           
        }

        //otvaranje linka sa tutorijala
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }
        //Testiranje upisivanja u textbox i odabiranja gumbova. Ispis unesenih podataka 
        [Test]
        public void ExecuteTest()
        {
            
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            
            SeleniumSetMethods.EnterText(driver, "Initial", "T.K." ,"Name");
            SeleniumSetMethods.EnterText(driver, "FirstName", "Toni", "Name");
            SeleniumSetMethods.EnterText(driver, "MiddleName", "Kubat", "Name");

            SeleniumSetMethods.Click(driver, "Male", "Name");

            SeleniumSetMethods.Click(driver, "english", "Name");

            SeleniumSetMethods.Click(driver, "Save", "Name");

            Console.WriteLine("Odabrana vrijednost u selectu je: " + SeleniumGetMethods.GetTextFromDrop(driver, "TitleId", "Id"));

            Console.WriteLine("Upisana vrijednost u initial je: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            Console.WriteLine("Upisana vrijednost u First Name je: " + SeleniumGetMethods.GetText(driver, "FirstName", "Name"));
            Console.WriteLine("Upisana vrijednost u Middle Name je: " + SeleniumGetMethods.GetText(driver, "MiddleName", "Name"));

            
        }
        //Zatvranje preglednika
        [TearDown]
        public void CloseUp()
        {
            driver.Close();
            Console.WriteLine("Closing browser");
        }

    }
}
