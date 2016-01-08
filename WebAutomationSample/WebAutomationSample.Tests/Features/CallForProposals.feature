Feature: Call For Proposals

@automated
Scenario: Register with correct data
	Given User navigates to 'Call for proposals' page
	When User fills following fields
		| name      | value                |
		| title     | Presentation 1       |
		| form      | lecture (25 minutes) |
		| speaker   | no                   |
		| presented | no                   |
		| file      | Presentation.txt     |
	And User fills 'description' field with '400' characters
	And User clicks on 'Next step' button
