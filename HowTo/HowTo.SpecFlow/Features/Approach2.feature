Feature: Approach2
	Steps provided by WebAutomation.SpecFlowGenericSteps package

	Pros: 
	+ you don't have to write your own steps (no coding required)
	+ no code review required

	Cons:
	- not all steps are readable by business people


Scenario: Approach2 - News page
	Given I am on "Home" page
	When user clicks 'MyWebsite-MenuNewsButton'
	Then the 'NewsPage-TableRowByValues' is displayed
	| order | ID   | Title          | Content           |
	| 1     | ID 1 | First article  | Article 1 content |
	| 2     | ID 2 | Second article | Article 2 content |

