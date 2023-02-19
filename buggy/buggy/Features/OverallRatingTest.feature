Feature: Overall Rating test

To test the ability to vote

Scenario: Vote in the most popular car
	Given a new user is created
	And I enter valid credentials
	And I should be logged in
	When I navigate to the Overall page
	And I navigate to the most popular model
	And I vote
	Then vote should be counted
