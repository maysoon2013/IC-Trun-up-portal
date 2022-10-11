
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

//navigate to time and management page by clicking administration

IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
administration.Click();

//click on time and material
IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterial.Click();

// cliock on Create New button/link
IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNew.Click();

//Click on Material Icon
IWebElement materialIcon = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
materialIcon.Click();
Thread.Sleep(1000);
//Click on Time
IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
time.Click();

//Click on Code Text box and type the code
IWebElement codeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
codeTextBox.SendKeys("2022");
//Click on Description Text Box and type description
IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
descriptionTextBox.SendKeys("September2022");

//Click on Price per Unit and type the pric
IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
price.Click();
IWebElement priccTextBox = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
priccTextBox.SendKeys("$100");

//Click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(1000);

//Check if user able to create new time & material

//click on last Page icon
IWebElement lastpageIcon = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastpageIcon.Click();

Thread.Sleep(1000);

IWebElement newrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
if (newrecord.Text=="September2022")
{
    Console.WriteLine(" User successfully add new time and materials, Test Pass ");
}

else
{
    Console.WriteLine("user Unable to add, Test failed");
}

Thread.Sleep(2000);
//Click on Edit button
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();

//Enter new price on Price text box
IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
newPrice.Click();
IWebElement newPriccTextBox = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
newPriccTextBox.Clear();

IWebElement newPrice1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
newPrice1.Click();
IWebElement newPriccTextBox1 = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
newPriccTextBox1.SendKeys("$250");

Thread.Sleep(500);

//Click on save button after Edit
IWebElement saveButton1 = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
saveButton1.Click();

//Check if User able to Edit Time & material new record

Thread.Sleep(1000);
//click on last Page icon
IWebElement lastpageIcon1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastpageIcon1.Click();

//Check User able to edit new time & material record
IWebElement updatedPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
if(updatedPrice.Text=="$250.00")
    {
    Console.WriteLine("User successfully edited new pric");
}
else
{
    Console.WriteLine("user unable to Edited new price");
}

//click on Delete button for deleting item
IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deletebutton.Click();
//Handling Alert
driver.SwitchTo().Alert().Accept();

Thread.Sleep(500);

//Check If user successfully able to delete the Item
IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
if (lastRecord.Text=="Detail description 1010")
{
    Console.WriteLine(" User successfully deleted the record, Test Pass ");
}

else
{
    Console.WriteLine("user Unable to delete the record, Test failed");
}




















