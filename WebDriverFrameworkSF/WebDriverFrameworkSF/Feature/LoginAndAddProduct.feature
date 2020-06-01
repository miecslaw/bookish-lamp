Feature: Log in to the app
	As a user
	I want to open the app
	So i can log in to the app

Scenario: Log in to the application

	Given I open this url "http://localhost:5000/"
	When I enter "user" in the field Name
	And I enter "user" in the field Password
	And I click on the button Send
	And I click on the button AllProducts
	And I click on the button CreateNew
	And I enter the product data in the field: NameProduct "TestProduct", UnitPrice "1", QuantityPerUnit "2", UnitInStock "3", UnitsOnOrder "4"
	And I select category "1" and supplier "2" in fields
	When I click on the button CreateProduct
	Then I see product "TestProduct" in the table All Product