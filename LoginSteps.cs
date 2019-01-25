using System;
using TechTalk.SpecFlow;

namespace Project5
{
    [Binding]
    public class LoginSteps
    {
        [When(@"I enter invalid username")]
        public void WhenIEnterInvalidUsername()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
