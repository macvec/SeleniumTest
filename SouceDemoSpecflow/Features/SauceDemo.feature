Feature: SauceDemo
SouceDemo Specflow Test

@mytag
Scenario: Login into SouceDemo
	Given I open "SouceDemo" page
	Then the login screen shall have "Username" textbox. It is enabled and empty.
	And the login screen shall have "Password" textbox. It is enabled and empty.
	And the login screen shall have "Login" button. It is enabled.
	When I log in with correct username and password the Home page is opened