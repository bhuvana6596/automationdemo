using CSharpSeleniumFramework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumFramework.TestCase
{
    public class Assignment1 : TestBase
    {
        [Test]
        public void TestAssignment1()
        {
            Home_POM home = new Home_POM();
            home.IndustriesPage();
            Industries_POM industries = new Industries_POM();
            industries.BuildAutomationPage();
            BuildAutomation_POM buildAutomationPage = new BuildAutomation_POM();
            buildAutomationPage.NewsLetterPage();
            buildAutomationPage.VerifyCurrentURL();
            buildAutomationPage.TitlesOfNewsLetters();
        }
    }
}
