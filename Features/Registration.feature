Feature: Registration

Valid registration for bpbonline

@tag1
Scenario: Valid Registration
	Given that a user navigates to bpbonline website 
	And  the user cliks on my account
	And  the user clicks on continue 
	And the user clicks on gender 
	And  the user enters first name "tuns"
	And the user enters last name  "ase"
	And  the user enters date of birth "12/12/2001"
	And  the user enters email address "qwerty@yahoo.com"
	And the user emters company name "tuns and sons ltd"
	And  the user enters street address "45 qwerty road"
	And the user enters suburb "essex"
	And  the user enters post code "qw2 1qw"
	And  the user eners city  "surrey"
	And  the user enters state "london"
	And  the user select country united kingdom
	And  the user enters telephone no "1234567890"
	And  the user enters fax number "123456"
	And  the user clicks newsleter
	And  the user enters password "qwerty"
	When the user enters comfirm password "qwerty"
	And I CLICK ON THE CONTINUE BUTTON
	Then the user is registrated with the following message "Your Account Has Been Created!"
