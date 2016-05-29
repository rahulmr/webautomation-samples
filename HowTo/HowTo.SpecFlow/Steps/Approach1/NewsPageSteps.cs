using HowTo.SpecFlow.Pages.Approach1_2;
using TechTalk.SpecFlow;
using WebAutomation.SpecFlow;

namespace HowTo.SpecFlow.Steps.Approach1
{
    [Binding]
    class NewsPageSteps : SpecFlowTestBase
    {
        [Then(@"following articles are displayed in the News table")]
        public void ThenFollowingArticlessAreDisplayedInTheNewsTable(Table table)
        {
            var newsPage = this.GetContainer<NewsPage>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var row = new string[]
                {
                    (i+1).ToString(),
                    table.Rows[i]["ID"],
                    table.Rows[i]["Title"],
                    table.Rows[i]["Content"],
                };

                newsPage.TableRowByValues.With(row).Assert.Is.Displayed();
            }
        }
    }
}
