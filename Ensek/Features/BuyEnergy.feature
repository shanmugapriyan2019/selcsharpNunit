Feature: BuyEnergy

A short summary of the feature


Scenario Outline: Register with invalid credentials
	Given navigate to Register page
	When enter email address '<email>'
	Then enter password '<password>'
	Then enter confirm password '<confirmPassword>'
	Then click register button
	Then verify error message
	Examples: 
	| email   | password       | confirmPassword |
	| a@a.com | Tester@2023    | Tester@2022     |
	| b@b.com | WrongPass@2023 | WrongPass@2022  |


Scenario: Buy Gas
	Given navigate to buy energy page
	When enter 'Gas' units in unit field '20'
	Then click buy button for 'Gas'
	Then verify purchase message

Scenario: Buy Oil
	Given navigate to buy energy page
	When enter 'Oil' units in unit field '3'
	Then click buy button for 'Oil'
	Then verify purchase message

