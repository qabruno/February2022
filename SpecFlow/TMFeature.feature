Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit and delete time and material records
So that I can manage employee's time and materials successfully


Scenario:  create time and material record with valid data
	Given I logged into TurnUp portal successfully
	And I navigate to time and material page
	When I create time and material record
	Then the record should be created successfully

Scenario Outline: edit time and material record with valid data
	Given I logged into TurnUp portal successfully
	And I navigate to time and material page
	When I update '<Description>', '<Code>', '<Price>' on an existing time and material record
	Then the record should have the updated '<Description>', '<Code>', '<Price>'

	Examples: 
	| Description | Code | Price |
	| Feb2022     | abc  | 123   |
	| Dog         | def  | 45    |
	| Keyboard    | ghi  | 7     |


