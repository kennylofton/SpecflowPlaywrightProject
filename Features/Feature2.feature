Feature: Feature2

@sampleApp
Scenario: Verify login
	Given I navigate to the app
	And I input a username
	And I input the correct password
	When I select the Login button
	Then I should be presented with the welcome message