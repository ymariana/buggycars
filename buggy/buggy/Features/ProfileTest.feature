Feature: Update user profile details

To test the ability to update the profile

Scenario: Update details
	Given a new user is created
	And I enter valid credentials
	And I should be logged in
	And I navigate to the Profile page
	When I send the new values
	Then profile should be updated
