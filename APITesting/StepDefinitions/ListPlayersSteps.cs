using APITesting.Actions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class ListPlayersSteps
    {
        GetRequest getRequest;
        PostRequest postRequest = new PostRequest();
        [When(@"i send the get request")]
        public void WhenISendTheGetRequest()
        {
            getRequest = new GetRequest("http://localhost:8080/A00144521GaryGunning/rest/user/2", "GET");
        }

        [Then(@"i the response should be this")]
        public void ThenITheResponseShouldBeThis(string multilineText)
        {
            Assert.AreEqual(multilineText, getRequest.GetResponse());
        }

        [When(@"I post the new user")]
        public void WhenIPostTheNewUser()
        {
            postRequest.postRequest("http://localhost:8080/A00144521GaryGunning/rest/user/");
        }

        [Then(@"it should be saved to the database")]
        public void ThenItShouldBeSavedToTheDatabase()
        {
            postRequest.getRequest("http://localhost:8080/A00144521GaryGunning/rest/user/2");
            Assert.AreEqual("", postRequest.responseReturn());
        }

    }
}
