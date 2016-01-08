Feature: Access to page

@automates
Scenario Outline: I can access each page from the top menu
	Given User navigates to '<PageName>' page
	Then '<PageName>' page is displayed

Examples:
| PageName           |
| Conference         |
| Call for proposals |
| Quality Meetup     |
| Organisers         |
| Contact            |