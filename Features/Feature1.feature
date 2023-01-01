Feature: Feature1
	
@inputText
Scenario: Validate inputing text changes button value
	Given I navigate to the application
	And I input a name in the text field
	When I click the button
	Then the button value should change 