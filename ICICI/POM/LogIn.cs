using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ICICI.POM
{
    public class LogIn
    {
        public IWebDriver Driver { get; private set; }

        [FindsBy(How =How.Name, Using = "q")]
        public IWebElement GoogleSertch { get;  set; }

        [FindsBy(How =How.XPath, Using = "//h3[contains(text(), 'Facebook - Log In or Sign Up')]")]
        public IWebElement Sertch { get; set; }

        [FindsBy(How =How.XPath, Using = "//a[text()='Create New Account']")]
        public IWebElement CreateAccount { get; set; }

        

          
       
        [Obsolete]
        public LogIn(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }


        public void Googletext() {
            GoogleSertch.SendKeys("facebook");
            GoogleSertch.SendKeys(Keys.Enter);
        }

        public void FacebookSertch() { 
            Sertch.Click(); 
        }
        public void AccountCrate() { 
            CreateAccount.Click();
        
        }
        

    }
}
