Feature: Load Polar Hrm Data
	In order to see information on my cycling
	As a cyclist
	I want to be able to upload my raw HRM files

Background: I have loaded valid Polar Hrm Data
Given I am on the home page
 When I upload a valid polar hrm file
 Then I am redirected to the dashboard

Scenario: Raw HRM Data can be viewed
Given I am on the home page
 When I upload a valid polar hrm file
  And I navigate to the Raw Data View
 Then '3980' Results are displayed