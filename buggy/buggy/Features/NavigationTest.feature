Feature: Navigation test

To test the ability to navigate between pages

Scenario: Click logo link - Overall page
	Given I navigate to the Overall page
	When I click the logo link
	Then I should be redirected to the main page

Scenario: Click logo link - Make page
	Given I navigate to the Make page
	When I click the logo link
	Then I should be redirected to the main page

Scenario: Click logo link - Model page
	Given I navigate to the Model page
	When I click the logo link
	Then I should be redirected to the main page
