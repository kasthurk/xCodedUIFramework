using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xCodedUI.AppControls;
using xCodedUI.AppControls.WebControls;

namespace xCodedUI.AppFramework.Pages
{
    /// <summary>
    /// Represent's the home page of the Google Search Application
    /// </summary>
    public class GoogleHomePage
    {
        private Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow browser;
        private xHtmlEdit searchBox;
        private xHtmlButton searchBtn;

        public GoogleHomePage(Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow b)
        {
            this.browser = b;

            searchBox = new xHtmlEdit(b, "lst-ib");
            searchBtn = new xHtmlButton(b, "btnG", "Name");
        }

        /// <summary>
        /// This method is a sample hello world test on Google's search home page
        /// Optional parameter would be used if the desire was to get search string from data source for data driven testing
        /// </summary>
        /// <param name="text">Search Text</param>
        public void Search(string text = "Hello World")
        {
            searchBox.SendKeys(text);
            searchBtn.Click();
        }

    }
}
