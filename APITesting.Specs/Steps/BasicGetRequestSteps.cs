using APITesting.Common;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace APITesting.Specs.Steps
{
    [Binding]
    public class BasicGetRequestSteps
    {
        private string actualXmlResponse;
        [Given(@"That the API is available at ""(.*)""")]
        public void GivenThatTheAPIIsAvailableAt(string url)
        {
            var httpCode = HTTPHelper.GetResponseCode(url);
            Assert.AreEqual(200, httpCode);
        }

        [When(@"I make a get request to ""(.*)""")]
        public void WhenIMakeAGetRequestTo(string url)
        {
            actualXmlResponse = HTTPHelper.HTTPGet(url);
            Assert.AreNotEqual(actualXmlResponse, null);
        }

        [Then(@"the repsonse should be")]
        public void ThenTheRepsonseShouldBe(string multilineText)
        {
            var isIdentical = XMLHelper.GenerateDiffGram2(multilineText, actualXmlResponse);
            Assert.AreEqual(true, isIdentical);
        }

        //[When(@"I retreive the xml from the api ""(.*)"" and check the ""(.*)"" is ""(.*)""")]
        //public void WhenIRetreiveTheXmlFromTheApiAndCheckTheIs(string url, string elementType, string elementValue)
        //{
        //    XMLHelper.VerifyXmlElement(url, elementType, elementValue);
        //}

        [When(@"I retreive the xml from the api ""(.*)"" and check the ""(.*)"" is ""(.*)""")]
        public void WhenIRetreiveTheXmlFromTheApiAndCheckTheIsRoryBest(string url, string elementType, string elementValue)
        {
            XMLHelper.VerifyXmlElement(url, elementType, elementValue);
        }



        [Then(@"the test should pass\.")]
        public void ThenTheTestShouldPass_()
        {
            Assert.IsTrue(XMLHelper.ConfirmXML());
        }



    }
}
