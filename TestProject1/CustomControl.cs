using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

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
    }
}
