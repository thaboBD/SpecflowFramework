Feature: UserRegistration
	As a user 
	I want to create and account
	So i can log in

@mytag
Scenario: Create an account
	Given I am on the automation practice website
	When I click sign and create account
	And the user enters a firstname
	And the user enters a last name
	And the user enters a passoword
	And the user enters an address
	And the user enters a city
	And the user enters the state
	And the user enters a postcode
	And the user enters a phone number
	Then I can create an account to log in
