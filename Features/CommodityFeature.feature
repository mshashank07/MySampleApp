
@Initialize


Feature: CommodityFeature
	In order to give more information about specific commodities
	As a product owner 
	I want to display commodity details on a commodity page


Scenario Outline: verification of TBC section headers on commodity page
Given I view the '<url>' page
Then I should see tabs "how can we help", "market overview","news & analysis","services","methodology", "about" on page
When I click on CTA link
Then I should see the '<page>'
Examples: 
| url                 | page                     |
| chemicals/methanol/ | Free sample price report |
| chemicals/benzene/  | Free sample price report |

	