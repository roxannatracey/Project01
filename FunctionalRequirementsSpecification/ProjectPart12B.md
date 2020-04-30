#### Roxanna Barahona
#### April 13, 2020
#### Project Step 12B
#### Functional Requirements Specification for application 'Expression' for nonverbal children


1.1 Functional Requirements
- This section of the specification includes all the requirements that specify the fundamental actions of the software system titled Expression geared towards non-verbal children

1.1.1 User Class 1 - The User

1.1.1.1 Functional Requirement 1.1
ID: FR1
TITLE: Download the mobile application
DESCRIPTION: This mobile application will be available for download on all smart forms whether Android or Apple. This application will not cost money to the customer and is intended to help assist in the medical journey of those caring for nonverbal children under the age of 5.  
RAT: This is intended to allow user to download the mobile application.
DEP: None


1.1.1.2 Functional Requirement 1.2
ID: FR2
TITLE: User Registration AND patient registration via the mobile application
DESCRIPTION: The user will make an account if they don't have one. Since this application requires information from medical staff, the user will need to be cross matched to the correct patient. If the profile does not exist the user will indicate they have a new patient (+) and will fill out the information.  The user will need to provide name, physical address, social security number, treatment facility name, age(s), and social security number.
RAT: In order for a user to register for the mobile application and to create the patient portal
DEP: FR1

1.1.1.3 Functional Requirement 1.3
ID: FR3
TITLE: User Registration via the mobile application
DESCRIPTION: The user will make an account if they don't have one. Since this application requires information from medical staff, the user will need to be cross matched to the correct patient. The user will need to provide name, user-name, password, email-address, physical address, social security number, treatment facility name, phone number, patient name, patient security number.
RAT: In order for a user to register for the mobile application and for the patient to get matched to the correct patient
DEP: FR2

1.1.1.4 Functional Requirement 1.4
ID: FR4
TITLE: The user will log in via the mobile application
DESCRIPTION: The phone will cache the user's login information(if they select yes via their phones settings). The user will then be prompted for their password and login is complete.
RAT: In order for the user to gain access to the application
DEP: FR3

1.1.1.5 Functional Requirement 1.5
ID: FR5
TITLE: Patient frequency wave feed
DESCRIPTION: The user will be presented with  a live feed of the patient's heart rate and frequency sound waves. A baseline will be shown
RAT: This is to help medical staff understand when the patient may be in need for further medical attention. The live feed will try to match heart rate with the frequency waves so that even if the patient is not physically showing signs of distress, the medical staff can step in
DEP: FR4 , FR3,  FR1


1.1.1.6 Functional Requirement 1.6
ID: FR6
TITLE: Patient frequency wave baseline versus anomalies
DESCRIPTION: This is where the low frequency waves that are collected will be matched against a baseline. This baseline will help both the caregiver and medical staff track the child's progress
RAT: Advance the patient's care if things are getting worse.
DEP: FR4, FR3

1.1.1.7 Functional Requirement 1.7
ID: FR7
TITLE: Request for appointment with provider  
DESCRIPTION: This feature is for the convenience of both the medical staff and caregiver. This will allow the user to select a date and time from a calendar listing availability. The provider will be able to view all the requested appointments in a calendar
RAT: To set up an appointment with the patient's caregiver
DEP:  FR4, FR5


1.1.1.8 Functional Requirement 1.8
ID: FR8
TITLE: Confirmation of selected appointment
DESCRIPTION: The system will prompt the user to confirm the requested appointment
RAT: To confirm available appointment
DEP: FR5, FR6, FR7


1.1.1.9 Functional Requirement 1.9
ID: FR9
TITLE: Confirmation email sent out to provider and patient's caregiver
DESCRIPTION: Once the system has confirmed the appointment, the system will send out an email with the details of the appointment to the provider and the patient's caregiver.  
RAT: To keep a trail and confirmation of the appointment made
DEP: FR6, FR7

1.1.1.10 Functional Requirement 1.10
ID: FR10
TITLE: Profile page via the mobile application
DESCRIPTION: The application will provide an interface titled the profile page. On the profile page the user can edit information to include patient, treatment facility, email address, physical address, and appointments.
RAT: Provides the user with a profile page to edit
DEP: FR1
