Feature: Log in to the app
	As a user
	I want to open the app
	So i can log in to the app

Scenario: Log in to the application

	Given I open this url "http://localhost:5000/"
	When I enter "user" in the field Name
	And I enter "user" in the field Password
	And I click on the button Send
	Then I see headline Home page on page