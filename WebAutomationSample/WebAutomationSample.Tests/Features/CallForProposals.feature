Feature: Call For Proposals

@automated
Scenario: Register with correct data
	Given User navigates to 'Call for proposals' page
	When User fills following fields on 'Call for proposals' page
		| name         | value                | type       |
		| title        | Presentation 1       |            |
		| form         | lecture (25 minutes) | select     |
		| speaker      | no                   | radio      |
		| presented    | no                   | radio      |
		| presentation | Presentation.txt     | file       |
		| description  | 400                  | characters |
	And User clicks on 'Next step' button
	And User fills following fields on 'Call for proposals' page
		| name                | value          | type       |
		| first name          | Mark           |            |
		| surname             | Smith          |            |
		| position            | QA             |            |
		| company institution | FP             |            |
		| email address       | test@test.test |            |
		| phone number        | 123123123      |            |
		| biography           | 400            | characters |
		| photo               | Photo.png      | file       |
		| agreement           | yes            | checkbox   |
	And User clicks on submit button