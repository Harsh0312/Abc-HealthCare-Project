Feature: ConfirmOrder

A short summary of the feature

@tag1
Scenario: Confirming Order
	Given Open the Website
	When I click on login
	Then Login Page Appears
	When I Enter the username and pass
	And click the login button
	Then Catalog page Appears
	When I Add a item to Cart
	And I click on Cart icon 
	Then Cart Page appears
	When I click on Checkout button
	Then Checkout page appears
