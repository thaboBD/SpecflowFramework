Feature: ProductPurchase
	Product purchase End to end 

Scenario: Add a product to Cart and Checkout
	Given I am on the automation practice website
	And I have signed in on the website
	When I search for a dress
	And I add it to cart
	Then I can complete the checkout process
