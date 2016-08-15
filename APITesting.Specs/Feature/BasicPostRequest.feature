Feature: BasicPostRequest

Scenario: I want to post a new user
Given That the API is available at "http://localhost:8080/A00144521GaryGunning/rest/user/"
When I send the following information for the new user. url = "http://localhost:8080/A00144521GaryGunning/rest/user/" "50" "Tom" "password"
Then the new user should be added.