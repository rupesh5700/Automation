using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ICICI.Generic_Library;
using ICICI.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ICICI.TestScrpits
{
    public class LogInTest : BaseClass
    {
        [Test]
        [Obsolete]
        public void Test1() {
            Console.WriteLine("First Test Case");
            LogIn logtest = new LogIn(driver);
            logtest.Googletext();
            logtest.FacebookSertch();
            logtest.AccountCrate();
            SignUp signup = new SignUp(driver);
            signup.EnterName();
            signup.EnterSurname();
            signup.Dropdoen();
            signup.DropMonth();
            signup.Dropyear();
            Actions action = new Actions(driver);
            action.DoubleClick(driver.FindElement(By.XPath("//label[contains(text(), 'Custom')]"))).Build().Perform();
        }
    }
}
