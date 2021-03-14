Feature: ParaBank
	Simple calculator for adding two numbers

Background:
	Given that Chrome is the browser
	And I access this link: https://parabank.parasoft.com/parabank/index.htm

@register
Scenario: (1) Someone tries to register
	Given that someone clicks the Register link
	And someone sets the following fields
	| FieldName                | FieldValue          |
	| customer.firstName       | Chip                |
	| customer.lastName        | Dale                |
	| customer.address.street  | 3142  Doctors Drive |
	| customer.address.city    | Los Angeles         |
	| customer.address.state   | CA                  |
	| customer.address.zipCode | 90017               |
	| customer.phoneNumber     | 310-341-3324        |
	| customer.ssn             | 547-47-4914         |
	| customer.username        | chippendale         |
	| customer.password        | Test@123            |
	| repeatedPassword         | Test@123            |
	When the Register button is clicked
	Then the welcome page should be displayed