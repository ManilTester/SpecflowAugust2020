Feature: TM


Scenario: Verify user is able to Login into TM
Given I navigate to the TurnUp Portal
When I login to the TurnUp Portal
Then I verify I am on the TurnUp Portal

Scenario: Verify able to create time record
Given I navigate to the TurnUp Portal
When I login to the TurnUp Portal
Then I verify I am on the TurnUp Portal
When I click option "Time & Materials" under Administration Drop Down on the Main Page
