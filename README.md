# Student Application Form

## Project Overview

This project is a **Student Application Form** designed for students who want to join a school. The form collects important personal, contact, and academic information and stores the information in a Microsoft Access database.

## School

**Heringsholm Vocational School**

**Motto:** Skills Today, Brighter Tomorrow

## Purpose of the Project

The purpose of this project is to provide a simple and organized way of collecting student admission/application information. It demonstrates how a database form can be used to enter, save, and manage student records.

## Application Form Sections

### 1. Personal Information
The form collects:
- Full Name
- Date of Birth
- Gender
- Nationality

### 2. Contact Information
The form collects:
- Phone Number
- Email
- Address

### 3. Academic Information
The form collects:
- Previous School
- Course
- Application Date

## Form Controls Used

The Microsoft Access form uses different controls to make data entry easier:

| Control | Purpose |
|---|---|
| Label | Displays field names, headings, and instructions |
| Text Box | Allows the user to enter information |
| Combo Box | Allows the user to select options such as Gender and Course |
| Command Button | Performs actions such as saving a record or starting a new application |
| Image | Displays the school logo |
| Line/Rectangle | Helps organize and separate sections of the form |

## Database Table

The main table is named **StudentApplication**.

It contains the following fields:

| Field | Data Type | Purpose |
|---|---|---|
| StudentID | AutoNumber | Unique student identification number |
| FullName | Short Text | Student's full name |
| DateOfBirth | Date/Time | Student's date of birth |
| Gender | Short Text | Student's gender |
| Nationality | Short Text | Student's nationality |
| PhoneNumber | Short Text | Student's telephone number |
| Email | Short Text | Student's email address |
| Address | Long Text | Student's home address |
| PreviousSchool | Short Text | Student's previous school |
| Course | Short Text | Course selected by the student |
| ApplicationDate | Date/Time | Date the application was made |

**StudentID** is used as the primary key.

## Main Features

- Simple and easy-to-use student application form
- Organized into personal, contact, and academic sections
- Gender selection using a Combo Box
- Course selection using a Combo Box
- Automatic application date
- Save/Submit Application button
- New Application button
- School logo and form title
- Student information stored in a database

## Software Used

- Microsoft Access
- Microsoft Windows
- GitHub for project storage and version control

## Project Files

The repository may contain:

- `StudentApplication.accdb` — Microsoft Access database and form
- `SchoolLogo.png` — School logo used on the application form
- `README.md` — Project documentation

## How to Use

1. Open the `StudentApplication.accdb` file using Microsoft Access.
2. Open the Student Application Form.
3. Enter the student's personal information.
4. Enter the contact information.
5. Enter the academic information.
6. Select the appropriate options from the Combo Boxes.
7. Click **SUBMIT APPLICATION** to save the application.
8. Click **NEW APPLICATION** when entering another student's information.


