Feature: Calculator2

Background: 
	Given I have an calculator
	
Scenario: Add two numbers
	Given reset the calculator
	When I enter '1'
	And I press '+'
	And I enter '1'
	Then the calculator displays '2'
