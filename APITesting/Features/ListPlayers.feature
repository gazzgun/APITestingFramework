Feature: ListPlayers
	

Scenario: I want to send a get request and verify it 
When i send the get request 
Then i the response should be this
"""
<?xml version="1.0" encoding="UTF-8" standalone="yes"?><users><user><id>1</id><name>Gary</name><password>gazz</password></user></users>
"""


Scenario: I want to post to the rest api
When I post the new user
Then it should be saved to the database