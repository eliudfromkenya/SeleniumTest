// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Testing Chrome");
using IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://mis.kenyafarmersassociation.co.ke/bc130");

Thread.Sleep(10000);

var elements = driver.FindElements(By.CssSelector("span"));

var sellSpanTexts = elements.Select(c => c.GetAttribute("class")).ToArray();//.FirstOrDefault(v => v.Text == "Sell");


var sellSpan = elements.FirstOrDefault(v => v.Text == "Sell");

IWebElement element = driver
    .FindElement(By
      //.ClassName("ms-Link root--8JfOhDucwdMhqzYjuaT8R ms-navbar-node thm-navi-c2-color-2--medflat thm-navi-c2-font-size-2--minflat thm-navi-c2-font-stack-2--minflat root-34"));
      .CssSelector(".ms-navbar-node-caption"));

element?.Click();

driver.Close();
