Feature: BasicGetRequest

Background: 
Given That the API is available at "http://localhost:8080/A00144521GaryGunning/rest/player/"

Scenario: I want to send a get request for a player and verify the response
When I make a get request to "http://localhost:8080/A00144521GaryGunning/rest/player/1"
Then the repsonse should be 
"""
<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<player>
<id>1</id>
<name>Sean Cronin</name>
<age>29</age>
<position>Hooker</position>
<club>Leinster</club>
<caps>48</caps>
<height>1.8</height>
<weight>101</weight>
</player>
"""

Scenario Outline: I want to find and verify a specific element of a get request
When I retreive the xml from the api "http://localhost:8080/A00144521GaryGunning/rest/player/" and check the "name" is <playername>
Then the test should pass.
Examples: 
| playername     |
| "Rory Best"	 |	
|"Robbie Henshaw"|
|"Sean Cronin"   |
|"Tadhg Furlong" |
|"Cian Healy"    |
|"Jack McGrath"  |
|"Mike Ross"     |
|"Nathan White"  |
|"Ian Henderson" |
|"Mike McCarthy" |
|"Donnacha Ryan" |
|"Devin Toner"   |
|"Chris Henry"   |


