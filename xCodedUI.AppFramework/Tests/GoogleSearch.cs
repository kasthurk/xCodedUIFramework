using System.Configuration;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using xCodedUI.AppControls;
using xCodedUI.AppFramework.Pages;
using xCodedUI.AppFramework.Tests;

namespace xCodedUI.AppFramework
{
    [CodedUITest]
    public class GoogleSearch : Base
    {
        private readonly string _environment = ConfigurationManager.AppSettings["Environment"];
        xBrowser _browser;
        GoogleHomePage g;

        /// <summary>
        /// This method is a sample 'Hello World' automated UI test
        /// </summary>
        [TestMethod, Timeout(TestTimeout.Infinite)]
        public void SearchTest()
        {
            // Your objects
            _browser = new xBrowser(_environment);
            g = new GoogleHomePage(_browser);

            // Your test steps
            g.Search();
        }

        /// <summary>
        /// Utilizing test data source
        /// </summary>
        [TestMethod, Timeout(TestTimeout.Infinite)]
        [DataSource("System.Data.OleDb", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.xlsx;Persist Security Info=False;Extended Properties='Excel 12.0 Xml;HDR=YES'",
            "Sheet1$", DataAccessMethod.Sequential), DeploymentItem(@"Data\Data.xlsx")]
        public void SearchTestFromDataSource()
        {
            // Variable from data source
            string searchText = TestContext.DataRow["Search Text"].ToString();

            _browser = new xBrowser(_environment);
            g = new GoogleHomePage(_browser);
            g.Search(searchText);
        }
    }
}
