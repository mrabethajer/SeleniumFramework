using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.PageObject
{
   public class accueil
    {
        [FindsBy(How = How.Name, Using = "File")]
        public IWebElement FileMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Edit")]
        public IWebElement EditMenu { get; set; }

        [FindsBy(How = How.Name, Using = "View")]
        public IWebElement ViewMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Orders")]
        public IWebElement OrdersMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Data")]
        public IWebElement DataMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Tools")]
        public IWebElement ToolsMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Admin")]
        public IWebElement AdminMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Window")]
        public IWebElement WindowMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Help")]
        public IWebElement HelpMenu { get; set; }

        [FindsBy(How = How.Name, Using = "Portfolio Management")]
        public IWebElement PortfolioManagement { get; set; }

        [FindsBy(How = How.Name, Using = "Open")]
        public IWebElement Open { get; set; }

        [FindsBy(How = How.Name, Using = "Properties")]
        public IWebElement Properties { get; set; }

        [FindsBy(How = How.Name, Using = "Rebalance")]
        public IWebElement Rebalance { get; set; }

        [FindsBy(How = How.Name, Using = "Change Target")]
        public IWebElement ChangeTarget { get; set; }

        [FindsBy(How = How.Name, Using = "Select All")]
        public IWebElement SelectAll { get; set; }

        [FindsBy(How = How.Name, Using = "Send Orders")]
        public IWebElement SendOrders { get; set; }

        [FindsBy(How = How.Name, Using = "Advanced Rebalancer")]
        public IWebElement AdvancedRebalancer { get; set; }


        [FindsBy(How = How.Name, Using = "Sell Off")]
        public IWebElement SellOff { get; set; }

        [FindsBy(How = How.Name, Using = "Tax Lot")]
        public IWebElement TaxLot { get; set; }

        [FindsBy(How = How.Name, Using = "Security X-Ref Report")]
        public IWebElement SecurityXRefReport { get; set; }

        [FindsBy(How = How.Name, Using = "Cash Target Rebalance...")]
        public IWebElement CashTargetRebalance { get; set; }

        [FindsBy(How = How.Name, Using = "Quick Order")]
        public IWebElement QuickOrder { get; set; }

        
    }
}
