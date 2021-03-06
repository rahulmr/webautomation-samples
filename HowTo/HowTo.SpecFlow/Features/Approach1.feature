﻿Feature: Approach1
	All actions have dedicated step

	Pros: 
	+ steps are readable by business people

	Cons:
	- hard to maintain (each new action will require a new step)
	- not reusable steps


Scenario: Approach1 - News page
	Given I am on "Home" page
	When I click on News button in top menu 
	Then following articles are displayed in the News table
	| ID   | Title          | Content           |
	| ID 1 | First article  | Article 1 content |
	| ID 2 | Second article | Article 2 content |


Scenario Outline: Approach1 - Login page
	Given I am on "Home" page
	When I click on Login button in top menu 
		And I fill login form with "<Login>" and "<Password>"
		And I click on Login button
	Then login message "<Message>" appears
Examples: 
	| Login | Password   | Message             |
	| Admin | pass       | Your are logged!    |
	| Admin | wrong_pass | Incorrect password! |