using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace CaveCat.Interpreter.Runner
{
    public class Chrome
    {
        public ChromeDriver API { get; set; }

        public Chrome(string bin, bool openBrowser=true)
        {
            var options = new ChromeOptions
            {
                BinaryLocation = bin,
                AcceptInsecureCertificates = true
            };
            if (!openBrowser)
            {
                options.AddArguments("headless");
            }
            API = new ChromeDriver(options);
        }    
        
        public Chrome(string bin, string loginProfile, bool openBrowser)
        {
            var test = "--user-data-dir=C:/Users/{userName}/AppData/Local/Google/Chrome/User Data/Profile {#}/";
            var options = new ChromeOptions
            {
                BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe",
                AcceptInsecureCertificates = true
            };
            if (!openBrowser)
            {
                options.AddArguments("headless");
            }
            API = new ChromeDriver(options);
            API.Manage().Window.Maximize();
        }

        public void Goto(string url)
        {
            API.Navigate().GoToUrl(url);
        }
        public IWebElement Element(string xpath)
        {
            var element = API.FindElement(By.XPath(xpath));
            return element;
        }

        public void Click(string xpath)
        {
            Element(xpath).Click();
        }

        public void SelectByText(string xpath, string optionText)
        {
            var select = new SelectElement(Element(xpath));
            select.SelectByText(optionText);
        }

        public void SelectByIndex(string xpath, int index)
        {
            var select = new SelectElement(Element(xpath));
            select.SelectByIndex(index);
        }

        public void SelectByValue(string xpath, string selection)
        {
            var select = new SelectElement(Element(xpath));
            select.SelectByValue(selection);
        }

        public void UploadFile(string fileSelectorId, string content, string filename, string type = "text/plain")
        {
            var script = @"const fileInput = document.getElementById('"+ fileSelectorId + @"')
            const dataTransfer = new DataTransfer()
            const file = new File(['" + content + @"'], '" + filename + @"', {type: '" + type + @"'})
            dataTransfer.items.add(file)
            fileInput.files = dataTransfer.files";
            ((IJavaScriptExecutor)API).ExecuteScript(script);
        }

        public void ScrollTo(string xPath)
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)API;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", Element(xPath));
        }

        public object RunJavaScript(string script)
        {
            return ((IJavaScriptExecutor)API).ExecuteScript(script);
        }

        public void Type(string xpath, string text)
        {
            var element = Element(xpath);
            element.Clear();
            element.SendKeys(text);
        }

        public void NaturalType(string xpath, string text)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            var element = Element(xpath);
            foreach(var letter in text)
            {
                element.SendKeys(letter.ToString());
                Thread.Sleep(rnd.Next(100, 1000));
            }            
            element.Clear();
            
        }

        public string GetSource()
        {
            return API.PageSource;
        }

        public ChromeDriver GetInstance()
        {
            return API;
        }
    }
}
