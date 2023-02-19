Feature: LoginTest

To test the ability to create new user and login in the Buggy application

Scenario: Registration new user
	Given I am in the registration page
	When I enter the following info
	Then user should be registered

Scenario: Login with invalid credentials
	Given I am in the home page
	When I enter invalid credentials
	Then I should not be logged in

Scenario: Login with valid credentials
	Given a new user is created
	When I enter valid credentials
	Then I should be logged in