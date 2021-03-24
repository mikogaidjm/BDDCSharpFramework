Feature: AccountChecking
	It allows a user to check his/her bank account

Background:
	Given I log in with chippendale and Test@123
	When the Log In button is clicked

Scenario: Go to Account Overview
	Given that someone clicks the 13455 link
	When the Account Details table is displayed 
	Then the accountType row value should be CHECKING
	And the balance row value should be $515.50