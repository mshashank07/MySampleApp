
@Initialize

Feature: ChemicalCardFeature
	In order to give users more details about commodities
	As a marketing analyst
	I want to display channel cards on homepage


	Scenario Outline:  Verification of chemical cards on home page
	Given I view the '<url>' page
	Then Links in channel card should be as follows
	| links         |
	| ethylene      |
	| methanol      |
	| polyethylene  |
	| base oils     |
	| polypropylene |

	Examples: 
	| url | 
	|     |     
	



