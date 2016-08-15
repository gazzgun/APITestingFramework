using APITesting.Common;
using System;
using TechTalk.SpecFlow;

namespace APITesting.Specs
{
    [Binding]
    public class BasicPostRequestSteps
    {
        [When(@"I send the following information for the new user\. url = ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISendTheFollowingInformationForTheNewUser_Url(string url, string id, string name, string password)
        {
            HTTPHelper.HTTPPostNewUser(url, id, name, password);
        }



        [Then(@"the new user should be added\.")]
        public void ThenTheNewUserShouldBeAdded_()
        {
            Console.Write("");
        }

    }
}
