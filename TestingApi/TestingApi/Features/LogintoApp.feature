Feature: LogintoApp

A short summary of the feature

@tag1
Scenario: Loging as a member
	Given Navigate to Abc healthCare
	When I click on login button
	Then Login page Appear
	When  enter username and password
		| Username | Password |
		| tom      | Tom@123  |
	And  Click SignIn
	Then  See Catalog Page
