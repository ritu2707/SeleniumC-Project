using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    class HomePage:DriverHelperClass
    {
        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));

        public void ClickLogin() => lnkLogin.Click();
        
    }
}
