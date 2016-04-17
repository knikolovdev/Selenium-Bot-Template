using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Selenium_bot_template
{
    partial class Bot
    {
        /// <summary>
        /// Shorthand for URL Navigate
        /// </summary>
        /// <param name="url"></param>
        private void GoTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }
        /// <summary>
        /// Shorthand for Driver.FindElement(By.Id(id))
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private IWebElement Id(string id)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.Id(id));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with Id \"{0}\" not found !", id));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for Driver.FindElement(By.ClassName(className))
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        private IWebElement Class(string className)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.ClassName(className));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with Classname \"{0}\" not found !", className));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for Driver.FindElement(By.CssSelector(cssPath))
        /// </summary>
        /// <param name="cssPath"></param>
        /// <returns></returns>
        private IWebElement Css(string cssPath)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.CssSelector(cssPath));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with Css path \"{0}\" not found !", cssPath));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for Driver.FindElement(By.XPath(XPath))
        /// </summary>
        /// <param name="XPath"></param>
        /// <returns></returns>
        private IWebElement XPath(string XPath)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.XPath(XPath));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with XPath path \"{0}\" not found !", XPath));
                return null;
            }
        }

        /// <summary>
        /// IWebElement element = Driver.FindElement(By.TagName(TagName));
        /// </summary>
        /// <param name="TagName"></param>
        /// <returns></returns>
        private IWebElement TagName(string TagName)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.TagName(TagName));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with TagName \"{0}\" not found !", TagName));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for Driver.FindElement(By.LinkText(LinkText))
        /// </summary>
        /// <param name="LinkText"></param>
        /// <returns></returns>
        private IWebElement Link(string LinkText)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.LinkText(LinkText));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with Link text path \"{0}\" not found !", LinkText));
                return null;
            }

        }
        /// <summary>
        /// Shorhand for Driver.FindElement(By.PartialLinkText(PartialLinkText))
        /// </summary>
        /// <param name="PartialLinkText"></param>
        /// <returns></returns>
        private IWebElement PLink(string PartialLinkText)
        {
            try
            {
                IWebElement element = Driver.FindElement(By.PartialLinkText(PartialLinkText));
                return element;
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with Partial lLink text path \"{0}\" not found !", PartialLinkText));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for System.Threading.Thread.Sleep()
        /// </summary>
        /// <param name="milliseconds"></param>
        private void Wait(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }
        /// <summary>
        /// Shorthand for  wait.Until(ExpectedConditions.ElementIsVisible(By.Id(identifier)));
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        private IWebElement WaitId(string identifier)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(identifier)));
                return Id(identifier);
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with  Id : \"{0}\" did not appear. Wait time expired !", identifier));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(identifier)));
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        private IWebElement WaitClass(string identifier)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(identifier)));
                return Class(identifier);
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with  Class : \"{0}\" did not appear. Wait time expired !", identifier));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(identifier)));
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        private IWebElement WaitCss(string identifier)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(identifier)));
                return Css(identifier);
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with  Css : \"{0}\" did not appear. Wait time expired !", identifier));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(identifier)));
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        private IWebElement WaitXPath(string identifier)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(identifier)));
                return XPath(identifier);
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with  XPath : \"{0}\" did not appear. Wait time expired !", identifier));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(identifier)));
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        private IWebElement WaitLink(string identifier)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(identifier)));
                return Link(identifier);
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with Link text: \"{0}\" did not appear. Wait time expired !", identifier));
                return null;
            }
        }
        /// <summary>
        /// Shorthand for wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(identifier)));
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        private IWebElement WaitPLink(string identifier)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(identifier)));
                return PLink(identifier);
            }
            catch
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show(string.Format("Element with  Partial link text: \"{0}\" did not appear. Wait time expired !", identifier));
                return null;
            }
        }
    }
}
