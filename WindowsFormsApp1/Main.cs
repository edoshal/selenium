using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        InternetExplorerDriver driver;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver = new InternetExplorerDriver();
            driver.Url = ("http://localhost:8080/");


            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(By.XPath("//a[@href='/project/']")));
            IWebElement element =
                driver.FindElement(By.XPath("//a[@href='/project/']"));
            element.Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            driver.Close();
        }
    }
}
