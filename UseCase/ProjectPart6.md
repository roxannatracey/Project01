#### Roxanna Barahona
#### February 28, 2020
#### Project Step 6
#### USE CASE: Application for Nonverbal children
##### Actors
Parent

##### Trigger
The Parent indicates that their child is showing signs of speech delay. The doctors are not ready to make a diagnosis. The parent is having a hard time communicating with the child's needs.
##### Precondition "app must have data to do actors goal"
The application must be able to analyze the child's heart rate, voice frequency, and breathing so that information can be relayed back to the parent.
##### Post-condition "user will have met their goal"
The parent will be able to communicate better with their child.

##### Normal Flow "steps"
1. The user indicates that their child is nonverbal and seeks help.
2. The user will make an account if they don't have one
3. The user will log in
4. The user will be presented with form to fill out
5. The user will submit the form
6. The system will prompt the user to confirm all information is correct
7. The user will be presented with a live feed of the child's heart rate and frequency sound waves. A baseline will be shown
8. The user can then select an appointment time if they are concerned and want to speak with the doctor
9. The system will prompt the user to confirm the time is correct
10. The system will send a conformation email to customer
11. The system will send a conformation email to Doctor
12. The user will exit the system

##### Alternate Flow "if changes need to be made"
A. The user will discover the appointment time they selected is unavailable.
  1. The system will prompt an error that the time they selected is unavailable.
  1. The use case returns to step 8
B. The user changes their mind, and wants to cancel the appointment
  1. The user requests the appointment be canceled
  2. The system will prompt that this is correct
  3. The user will confirm
  4. The use case ends
C. The user wants to change the provider or medical facility
  1. The user will be prompted to contact their insurance company and the medical facility
  2. The user case ends
