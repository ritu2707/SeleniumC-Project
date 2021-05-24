using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.Pages;

namespace TestProject1
{
    [TestClass]
    public class Project1test1: DriverHelperClass
    {

        [TestMethod]
        public void LoginTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage homepage = new HomePage();
            LoginPages loginpage = new LoginPages();
            homepage.ClickLogin();
            loginpage.Enterusernamepwd("admin", "password");
            loginpage.LoginClick();
            driver.Close();



        }
        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Mango");
            CustomControl.ClickWebElement(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"))); 
            String Element = "ContentPlaceHolder1_AllMealsCombo";
            CustomControl.SelectCombo(Element, "Almonds");
            //selecting from Select tag element
            CustomControl.SelectValue(driver.FindElement(By.XPath("//select[@id='ContentPlaceHolder1_Add1-awed']")), "Cauliflower");
            Console.WriteLine("test is completed");
            driver.Close();
        }

        
    }
}
