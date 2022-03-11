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
    public class SignUp
    {
        public IWebDriver Driver { get; private set; }
       [FindsBy(How =How.XPath, Using = "//input[@placeholder='First name']")]
       public IWebElement Element { get; private set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement Sname { get; private set; }

        [FindsBy(How =How.Id, Using ="day")]
        public IWebElement IdSelect { get; private set; }

       [FindsBy(How =How.Id, Using = "month")]
       public IWebElement Month { get; private set; }

        [FindsBy(How = How.Id, Using = "year")]
        public IWebElement Year { get; private set; }

        [Obsolete]
        public SignUp(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        public void EnterName() {
            Element.SendKeys("Rupesh");
        }
        public void EnterSurname() {
            Sname.SendKeys("Baberwal");
        }

        public void Dropdoen() {
            SelectElement select = new SelectElement(IdSelect);
            select.SelectByValue("22");
        }
        public void DropMonth()
        {
            SelectElement select = new SelectElement(Month);
            select.SelectByText("Jun");
            IList<IWebElement> elementCount = select.Options;
            int iSize = elementCount.Count;
            Console.Write(iSize);
            for (int i = 0; i > iSize; i++)
            {
                Console.Write(elementCount[i]);
                String sValue = elementCount.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }
        }
        public void Dropyear()
        {
            SelectElement selects = new SelectElement(Year);
            selects.SelectByIndex(8);
        }

    }
}
