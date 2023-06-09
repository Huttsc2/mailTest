﻿using yandexTests.Driver;
using OpenQA.Selenium;

namespace yandexTests.PageElement
{
    public class WebElement
    {
        private IWebElement? Element;
        private Browser Browser = Browser.GetInstance();
        private string XPath;
        private int TimeoutInSec = 30;

        public WebElement(string xpath)
        {
            XPath = xpath;
        }

        public void SetElement(IWebElement element)
        {
            Element = element;
        }

        public void Click()
        {
            Element = Browser.FindClickableElement(XPath, TimeoutInSec);
            Element.Click();
        }

        public void SendKey(string data)
        {
            Element = Browser.FindClickableElement(XPath, TimeoutInSec);
            Element.SendKeys(data);
        }


        public string GetText()
        {
            Element = Browser.FindClickableElement(XPath, TimeoutInSec);
            return Element.Text;
        }
    }
}