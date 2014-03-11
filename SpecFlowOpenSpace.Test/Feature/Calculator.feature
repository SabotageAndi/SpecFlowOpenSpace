Feature: Calculator
	
Scenario: Add two numbers
	Given I have an calculator 
	When I enter '1'
	And I press '+'
	And I enter '1'
	Then the calculator displays '2'

Scenario Outline: Add two numbers example
	Given I have an calculator 
	When I enter '<first>'
	And I press '+'
	And I enter '<second>'
	Then the calculator displays '<sum>'

Examples: 
	| first | second | sum |
	| 1     | 2      | 3   |
	| 3     | 4      | 7   |
	| 5     | 5      | 10  |



Scenario: Add three numbers
	Given I have an calculator 
	When I enter '1'
	And I press '+'
	And I enter '1'
	And I press '+'
	And I enter '1'
	Then the calculator displays '3'


Scenario: Add Number Multi Number and Sub Number
	Given I have an calculator 
	When I enter '3'
	And I press '+'
	And I enter '4'
	And I press '*'
	And I enter '2'
	And I press '-'
	And I enter '3'
	Then the calculator displays '11'

Scenario: Add 1 to 24
	Given I have an calculator 
	When I enter '1'
	And I press '+'
	And I enter '2'
	And I press '+'
	And I enter '3'
	And I press '+'
	And I enter '4'
	And I press '+'
	And I enter '5'
	And I press '+'
	And I enter '6'
	And I press '+'
	And I enter '7'
	And I press '+'
	And I enter '8'
	And I press '+'
	And I enter '9'
	And I press '+'
	And I enter '10'
	And I press '+'
	And I enter '11'
	And I press '+'
	And I enter '12'
	And I press '+'
	And I enter '13'
	And I press '+'
	And I enter '14'
	And I press '+'
	And I enter '15'
	And I press '+'
	And I enter '16'
	And I press '+'
	And I enter '17'
	And I press '+'
	And I enter '18'
	And I press '+'
	And I enter '19'
	And I press '+'
	And I enter '20'
	And I press '+'
	And I enter '21'
	And I press '+'
	And I enter '22'
	And I press '+'
	And I enter '23'
	And I press '+'
	And I enter '24'
	Then the calculator displays '300'

Scenario: Mulitply and Division

Given I have an calculator
When I enter following numbers and operators:
	| Value |
	| 3     |
	| *     |
	| 2     |
	| *     |
	| 6     |
	| /     |
	| 4     |
Then the calculator displays '9'