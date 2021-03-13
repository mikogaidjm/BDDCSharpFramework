Feature: ParaBank
	Simple calculator for adding two numbers

@initialize
Scenario: User opens the website
	Given that 'Chrome' is the browser
	When I access this link: 'https://parabank.parasoft.com/parabank/index.htm'
	Then the page should be displayed

@register
Scenario: Someone tries to register
	Given that I click 'Register'

