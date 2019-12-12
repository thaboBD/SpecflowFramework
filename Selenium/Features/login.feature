Feature: login
	Login to the automation practice website


Scenario: Login to Automation Website
	Given I am on the automation website
	When I press sign 
	And enter my username
	And enter my password
	And Click Login 
	Then the landing page is displayed
