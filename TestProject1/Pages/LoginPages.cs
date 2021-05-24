using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class LoginPages: DriverHelperClass
    {
        IWebElement userName => driver.FindElement(By.Id("UserName"));

       IWebElement password => driver.FindElement(By.Id("Password"));

        IWebElement loginButton => driver.FindElement(By.XPath("//input[@type='submit']"));

        //methods on the LoginPage

        public void Enterusernamepwd(string username,string pwd)
        {
            userName.SendKeys(username);
            password.SendKeys(pwd);
        }

        public void LoginClick()
        {
            loginButton.Click();
        }
    }
}
