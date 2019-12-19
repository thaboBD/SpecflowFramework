Feature: ContactUs
	The abilit to send a message with an attachment

@mytag
Scenario: Send a message with an attachment
	Given I have signed in on the website
	When I navigate to the contact us page
	And select a heading
	And Select an order Ref
	And attach a file
	Then the message is sent
