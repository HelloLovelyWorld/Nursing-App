## User Stories

1. As a mother (role) I need a tracker(feature) so that I can know how much breastmilk I'm storing in my deep freezer.

2. As a father (role) I need an application that I can refer back to that notes frequency of my baby's feedings, sleep, and diaper changes (feature) 
   so that I can easily pass the information along to my baby's pediatrician while at doctor's appointments.
   
## Use - Cases

1. Given the current supply and demand of breastfeeding and pumping, when mom isn't pumping or nursing every three to four hours, then provide a 
   reminder within the app to remind mom that she needs to express milk at the three hour or four hour mark.

2. Given the amount of diapers a newborn is supposed to go through, when the parents are changing each diaper, then provide a tracker within the 
   application to ensure that each soiled diaper is been tracked.
   
3. Given the amount of sleep a newborn is, when parents need to be able to log the amount of time their child spends sleeping, then provide a section 
   within the application that has a sleep log.

4. Given the fact that a mother may not just exclusively nursing, when a mother wants to pump before or after a nursing session, then provide a
   section within the application that will be able to keep track of her milk storage.
   
## Use - Case Diagram (UML)

![Use - Case Diagram](https://github.com/HelloLovelyWorld/Nursing-Application/blob/main/UML.JPG)

## Requirements (List)

| Requirement ID | Requirement Description | Test Method | 
| --- | --- | --- |
| 1 | The system shall request the number of babies from the user. | Test |
| 1.1.1 | The system shall request permission to use baby's name. | Test |
| 1.1.2 | The system shall obtain baby's birthdate and gender. | Test |
| 1.1.3 | The system shall be able to request permission to use a picture of baby on the web page. | Test
| 1.2 | The system shall be to choose between the colors pink and blue based off of the gender of the child(ren). | Test |
| 2 | The system shall be able to log the amount of milk based off of how the user would like things measured (ounces or mililiters). | Inspection |
| 2.1.1 | The system shall be easy to read and easily accessible. | Analysis |
| 2.1.2 | The system shall request the user to choose the unit of measurement that they'd like to use. | Test |
| 2.1.3 | The system shall be able to keep the unit of measurement chosen consistent between nursing and pumping logs, bottle feeding logs, and milk storage logs. | Inspection |
| 2.2 | The system shall always allow user the option to change the unit of measurement. | Inspection |

## Draft Test Plan

| Test ID | Requirement ID | Test Procedure | Current Status | Time Stamp (if tested) | 
| --- | --- | --- | --- | --- |
| 1 | 1 | Program will ask the user for a number when the user signs up. | Not Yet Tested | N/A |
| 2 | 1.1.1 | Program will ask the user for a permission when the user signs up. | Not Yet Tested | N/A |
| 3 | 1.1.2 | Program will ask the user for a birthdate when the user signs up. | Not Yet Tested | N/A |
| 4 | 1.1.3 | Program will ask the user for permission when the user signs up. | Not Yet Tested | N/A |
| 5 | 1.2 | Program will have an algorithm that choose the color pink when the female gender is selected and the color blue when the male gender is selected. | Not Yet Tested | N/A |
| 6 | 2 | Program will have the metric system and input it into the software so that the usercan select their measurement of choice. | Not Yet Tested | N/A |
| 7 | 2.1.1 | Program will have a font and point that is readable for all users. | Not Yet Tested | N/A |
| 8 | 2.1.2 | Program will ask the user for permission when the user signs up. | Not Yet Tested | N/A |
| 9 | 2.1.3 | Program with code the software to not asks for the users choice of measurement each use, instead it will only need to ask during the initial set up. | Not Yet Tested | N/A |
| 10 | 2.2 | Program will have an option to change the unit of measurement in the user's setting. | Not Yet Tested | N/A |
