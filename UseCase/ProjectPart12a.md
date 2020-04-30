#### Roxanna Barahona
#### April 13, 2020
#### Project Step 12A
#### USE CASE: Application for Nonverbal children
##### Actors
Patient, 

##### Trigger
The patient is showing signs of speech delay. The patient is too young to diagnosis. The patient has factors associated to him/her that do not clearly define whether the speech delay is tied to something bigger. Example: It could be a matter of premature birth and developmental delays. The caregiver wants to register the patient for this program.
##### Precondition "app must have data to do actors goal"
The application must be able to analyze the Patient's heart rate, voice frequency, and breathing so that information can be relayed back to the doctor.
##### Post-condition "user will have met their goal"
The patient's data will be recorded for further medical analysis

##### Normal Flow "steps"
1. The user indicates that they are a caregiver
2. The user will make an account if they don't have one
3. The user will have a log in
4. The user will be presented with form to fill out
5. The user will submit the form with the patient's information
6. The system will prompt the user to confirm all information is correct
7. The user will be presented with a live feed of the patient's heart rate and frequency sound waves. A baseline will be shown
8. The user will be able to request an appointment
9. The user will select from a calendar of available appointments
10. The system will send a confirmation email and notification to the medical staff
11. The user will exit the system

##### Alternate Flow "if changes need to be made"
A. The user changes their mind, and wants to cancel the appointment
  1. The user requests the appointment be canceled
  2. The system will prompt that this is correct
  3. The user will confirm
  4. The use case ends
B. The user wants to reschedule the appointment
  1. The user will repeat steps 8 - 11
