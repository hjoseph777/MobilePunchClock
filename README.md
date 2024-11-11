# PunchClock
# Project Requirement Document: Punching Clock Application
=====================================================

## Team Members
---------------

* Harry Joseph: Developer lead
* Barkat Khan: Senior Developer
* Mark Porteous: Manager Director Partner
* Baburao Rawool: Tester


## Project Overview
-----------------

The objective of this project is to develop a Punching Clock application with three primary functionalities:

1. **Main Tab**: Time to punch in and punch out.
2. **Second Tab**: Graphical view of punch-in/punch-out times.
3. **Third Tab**: Display personal information.

The application should be accessible via web browsers and mobile applications on iOS and Android. The entire system will be hosted on the Azure cloud platform.

## Technical Requirements
------------------------

### Platform and Accessibility

* **Web Application**: Accessible through modern web browsers.
* **Mobile Applications**: Compatible with both iOS and Android devices.
* **Cloud Hosting**: Deploy and run on Azure cloud services.

### Development Environment

* **Visual Studio**: Use for development to facilitate code sharing and management.
* **Version Control and Collaboration**: Managed using the Git repository within Visual Studio.

## Functional Requirements
-------------------------

### Main Tab: Punch In/Out

* **Interface**: For users to punch in and punch out.
* **Record Timestamp**: Record the timestamp of each punch-in and punch-out.
* **Validate Entries**: Validate entries to prevent duplicate or erroneous punches.

### Second Tab: Graphical View

* **Display Graphical Representation**: Display a graphical representation of punch-in and punch-out times.
* **Information Source**: Information will come from the Main Tab (punching menu).
* **Line Graph**:
	+ **Red Line**: Indicates the user is off (not punched in).
	+ **Green Line**: Indicates the user is on (punched in).
* **Display Total Time**: Display the total off-time (red) and the total on-time (green).
* **Display 24 Hours**: Always display 24 hours in (black) to represent an entire day.
* **Daily View**: Provide a daily view from Monday through Sunday.

### Third Tab: Personal Information

* **Display Personal Details**: Display the user’s personal details such as name, employee ID, and role.
* **Update Personal Information**: Allow users to update certain personal information (e.g., contact details).

## Non-Functional Requirements
---------------------------

### Performance

* **Load and Respond Time**: The application should load and respond within 2 seconds under normal usage.
* **Smooth and Responsive User Experience**: Ensure smooth and responsive user experience across all platforms (web, iOS, Android).

### Security

* **User Authentication and Authorization**: Implement user authentication and authorization.
* **Data Encryption**: Ensure data encryption for sensitive information both in transit and at rest.
* **Best Practices**: Follow best practices for securing web and mobile applications.

### Scalability

* **Design for Growth**: Design the system to handle growing numbers of users and data without degradation in performance.
* **Azure Services**: Use Azure services to ensure the application can scale automatically based on demand.

### Reliability and Availability

* **High Availability**: Ensure the application has high availability, targeting 99.9% uptime.
* **Error Handling and Logging**: Implement robust error handling and logging mechanisms.

## Development Approach
----------------------

* **Starting from Scratch**: The project will be developed from the ground up using best practices in software development, ensuring the latest technologies and methodologies are employed.

## Tools and Technologies
-------------------------

### Frontend

* **Web**: HTML, CSS, JavaScript, and relevant frameworks (e.g., React, Angular, or Vue.js).
* **Mobile**: Native development with Swift for iOS and Kotlin/Java for Android, or cross-platform framework like Flutter or React Native.

### Backend

* **Language**: C# or JavaScript (Node.js).
* **Framework**:.NET Core or Express.js.

### Database

* **Azure SQL Database**: Or other Azure-supported database services.

### Hosting and Deployment

* **Azure App Service**: For web applications.
* **Azure Mobile Apps or Azure Kubernetes Service (AKS)**: For mobile backend services.

### Version Control and Collaboration

* **Git Repository**: Integrated within Visual Studio.
* **Azure DevOps**: For CI/CD pipelines.

### Graphical Representation

* **Line Graph**: To display punch-in and punch-out times.
