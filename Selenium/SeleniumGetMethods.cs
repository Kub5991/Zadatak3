﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public static class SeleniumGetMethods
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
       
        

    }
}
