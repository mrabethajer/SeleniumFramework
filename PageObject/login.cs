using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.PageObject
{
    public class login
    {
        [FindsBy(How =How.Id,Using = "8640")]
        public IWebElement UsernameInput { get; set; }

        [FindsBy(How = How.Id, Using = "8646")]
        public IWebElement PasswordInput { get; set; }


        [FindsBy(How = How.Name, Using = "OK")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.Name, Using = "Cancel")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.Name, Using = "Options >>")]
        public IWebElement OptionsButton { get; set; }
    }
}
