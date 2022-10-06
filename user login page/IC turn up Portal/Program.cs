
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open Chrome browser
IWebDriver driver = new ChromeDriver();

// Navigate to URL
driver.Navigate().GoToUrl("http://horse.industryconnect.io");

//Maximize the Browser
driver.Manage().Window.Maximize();

// Identify User name textfield and enter valid username
IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");

//identify Password textfield and enter valid password
IWebElement password = driver.FindElement(By.Id("Password"));
password.SendKeys("123123");

// Identify Loin button and click on it
IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
login.Click();

//Check if User logged in Successfully
IWebElement helloHeri = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHeri.Text=="Hello hari!")
{
    Console.WriteLine("Logged in Successful, Test passed.");
}
else
{ 
    Console.WriteLine("Login failed, test failed,");

}






