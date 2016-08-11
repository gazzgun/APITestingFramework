using System;
using TechTalk.SpecFlow;

namespace APITesting.StepDefinitions
{
    [Binding]
    public class ListPlayersSteps
    {
        [Given(@"there are players in the system")]
        public void GivenThereArePlayersInTheSystem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i retrieve the list of players")]
        public void WhenIRetrieveTheListOfPlayers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"there should be somthing")]
        public void ThenThereShouldBeSomthing()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
