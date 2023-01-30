using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class SeleniumGetMethods
    {
        //Na otvorenoj stranici vrijednost value je ista za za checkbox English i radio button i ona je "male"
        
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }

        //Dohvacanje teksta iz drop izbornika
        public static string GetTextFromDrop(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }
        //Zasebna metoda za uzimanje vrijednosti za Gender i Language known
        //Na otvorenoj stranici vrijednost value je ista za za checkbox English i radio button i ona je "male" 
        //Zbog čega dolazi do ispisa "male" za Languages Known ako se koristi metoda "GetText"
        public static string GetTextButton(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("name");
            else
                return String.Empty;
        }

    }
}
