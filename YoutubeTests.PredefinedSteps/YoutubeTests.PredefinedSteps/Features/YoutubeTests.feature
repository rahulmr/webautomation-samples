Feature: Youtube tests

Scenario: Open a video
	# Use only steps provided by WebAutomation.GenericSteps (see SpecFlowGenericSteps.cs)
	And user navigates to 'http://www.youtube.com'
	When user fills 'YoutubePage-SearchInput' with 'Hans Zimmer greatest hits'
	And user clicks 'YoutubePage-OkButton'
	Then the 'YoutubeSearchResultPage-Link' will be displayed
		| LinkText                           |
		| The greatest hits from Hans Zimmer |
	When user clicks 'YoutubeSearchResultPage-Link'
		| LinkText                           |
		| The greatest hits from Hans Zimmer |
	Then the 'YoutubePlayerPage-Player' will be displayed
	Given user closes the web browser
