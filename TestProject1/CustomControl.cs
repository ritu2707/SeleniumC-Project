using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
   public class CustomControl  :DriverHelperClass
    {
        public static void SelectCombo(String WebElement, String Value)
        {
            IWebElement element = driver.FindElement(By.XPath($"//input[@id='{WebElement}-awed']"));
            element.Clear();
            element.SendKeys(Value);
        }

        public static void EnterText(IWebElement element, String value) => element.SendKeys(value);

        public static void ClickWebElement(IWebElement element)
        {
            element.Click();
        }

        public static void SelectValue(IWebElement element, String value)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByValue(value);
        }
    }
}
