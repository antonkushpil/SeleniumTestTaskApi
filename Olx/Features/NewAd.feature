Feature: NewAd
	As a user I want to create new Ad

@Ready
@Olx
Scenario: Create new Ad
	Given Main page is opened
	And NewAd button is clicked
	And I am logged in
	And Form is filled
	When Preview button is clicked
	Then My Ad is shown
