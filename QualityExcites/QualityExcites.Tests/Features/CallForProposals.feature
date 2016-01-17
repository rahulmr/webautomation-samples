Feature: Call For Proposals

@automated
Scenario: Register with correct data
	Given User navigates to 'Call for proposals' page
	When User fills following fields on 'Call for proposals' page
		| name         | value                |
		| title        | Presentation 1       |
		| form         | lecture (25 minutes) |
		| speaker      | no                   |
		| presented    | no                   |
		| presentation | Presentation.txt     |
		| description  | 400                  |
	And User clicks on 'Next step' button
	And User fills following fields on 'Call for proposals' page
		| name                | value          |
		| first name          | Mark           |
		| surname             | Smith          |
		| position            | QA             |
		| company institution | FP             |
		| biography           | 400            |
		| email address       | test@test.test |
		| phone number        | 123123123      |
		| photo               | Photo.png      |
		| agreement           | yes            |
		| captcha             | 1234           |
	And User clicks on submit button
	Then User is successfully registered

@automated
Scenario: Mandatory fields - step 1
	Given User navigates to 'Call for proposals' page
	When User clicks on 'Next step' button
	Then All fields from step 1 are marked as invalid

@automated
Scenario: Mandatory fields - step 2
	Given User navigates to 'Call for proposals' page
	When User fills following fields on 'Call for proposals' page
		| name         | value                |
		| title        | Presentation 1       |
		| form         | lecture (25 minutes) |
		| speaker      | no                   |
		| presented    | no                   |
		| presentation | Presentation.txt     |
		| description  | 400                  |
	And User clicks on 'Next step' button
	And User clicks on submit button
	Then All fields from step 2 are marked as invalid