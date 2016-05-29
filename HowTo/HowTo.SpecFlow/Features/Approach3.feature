Feature: Approach3
	Each type of actions has steps which can be reused on all pages.
	Page Object Pattern is no longer useful

	Pros: 
	+ steps are readable by business people
	+ small number of steps
	+ steps are reusable on all pages
	+ very simple XML with page definitions

	Cons:
	- some coding is still required (comparing to approach2)
	- strongly depends on consistent html strucutre of elements in tested website
	  (for example all buttons, tables should be implemented in the same way in all
	  places on the page).


Scenario: Approach3 - News page
	Given I am on "Home" page
	When I click on "News" link
	Then table is displayed
	| #    | Title          | Content           |
	| ID 1 | First article  | Article 1 content |
	| ID 2 | Second article | Article 2 content |

