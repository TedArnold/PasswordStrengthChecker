# 1. Title & Objective

## Building a C# Windows Forms Password Strength Checker – A Beginner-Friendly Guide

## Technology Chosen:

I chose C# with Windows Forms (WinForms).

## Why I Chose It:

I selected WinForms because it is one of the easiest and most beginner-friendly ways to build a real desktop application using Visual Studio Code and the .NET SDK. It allows me to create a graphical user interface (GUI) without needing advanced frontend frameworks or web technologies. C# also has strong built-in support for event handling, form design, and real-time input validation, which makes it perfect for this project.

## End Goal of the Project:

The goal is to create a fully functional Password Strength Checker application that:

Accepts a user’s password input

Analyzes the password in real time

Displays its strength (Weak, Medium, Strong) with color indicators

Provides helpful suggestions for improvement (e.g., “Add a special character”)

Presents a clean, centered, earth-tone themed user interface

This demonstrates practical knowledge of C#, GUI design, event-driven programming, and basic security concepts such as password best practices.


# 2. Quick Summary of the Technology

C# Windows Forms, also called WinForms, is a graphical user interface framework used to build desktop applications for Windows. It provides ready made visual components such as text boxes, buttons, labels, and panels that developers can easily customize and connect to application logic. WinForms uses an event driven programming model, which means the application reacts to user actions like typing, clicking, or moving the mouse.

WinForms is commonly used for desktop utilities, internal company tools, data entry systems, dashboards, and simple standalone applications. It is known for being very easy to learn, which makes it a popular choice for beginners and for developers who want to quickly create functional, interactive software.

A real world example of software built with similar Windows interface principles is the early version of Microsoft Paint. Many small business tools and administrative applications still rely on WinForms today because it is stable, simple, and fast to develop with.

## 3. System Requirements

Operating System: Windows 10 or later, Mac OS, or Linux with .NET SDK installed

Tools and Editors Required: Visual Studio Code, .NET 6 or later SDK, optional terminal or command prompt for running commands

Packages and Dependencies: No external packages are required for this project, all functionality uses the standard .NET libraries included with C# and WinForms

# 4. Installation & Setup Instructions

## Step 1: Install .NET SDK

Go to the official .NET download page: https://dotnet.microsoft.com/en-us/download

Download and install the latest .NET SDK for your operating system.

After installation, open a terminal or command prompt and run:

dotnet --version


This should display the installed version, confirming the installation was successful.

## Step 2: Install Visual Studio Code

Download VS Code from https://code.visualstudio.com

Install VS Code following the setup instructions for your OS.

Open VS Code, go to the Extensions tab, and install:

C# extension (by Microsoft)

C# Dev Kit (optional, improves IntelliSense and debugging)

## Step 3: Create a New WinForms Project

Open a terminal in the folder where you want your project.

Run the following command to create a new Windows Forms app:

dotnet new winforms -n PasswordStrengthChecker


This will create a folder named PasswordStrengthChecker with all necessary files.

Navigate into the project folder:

cd PasswordStrengthChecker

## Step 4: Open Project in VS Code

In the terminal, type:

code .


This opens the project in VS Code.

Open Form1.cs and replace the existing code with the Password Strength Checker code provided earlier.

## Step 5: Run the Project

In VS Code terminal, run:

dotnet run


The Password Strength Checker window will open.

Enter a password in the text box, click Check Strength, and observe the color-coded strength and suggestions.


# 5. Minimal Working Example

## What the Example Does

The application is a Password Strength Checker built using C# Windows Forms. It accepts a password from the user, evaluates its strength, and displays the result with color-coded feedback. In addition, it provides suggestions to improve weak passwords, such as adding uppercase letters, numbers, special characters, or increasing the length. The interface is centered, visually appealing, and uses an earth-tone color scheme.

## Code Overview

The main code is in Form1.cs. The key components are:

Title Label – Displays “Capstone Project Password Strength Checker”

Password TextBox – Where the user enters a password

Check Button – When clicked, evaluates the password strength

Strength Label – Shows the strength as Weak, Medium, or Strong

Suggestion Label – Shows improvement suggestions

The evaluation uses simple rules:

Minimum 8 characters

At least one uppercase letter

At least one lowercase letter

At least one number

At least one special character

The code uses regular expressions to check these rules.

# 6. AI Prompt Journal

https://chatgpt.com/share/693181d7-0594-8012-a86c-00a45729b591

# 7. Common Issues & Fixes
   
## 1. Nullability Warnings (CS8618)

Issue: When opening Form1.cs, the compiler shows warnings that fields like titleLabel, passwordBox, or checkButton “must contain a non-null value when exiting constructor.”

Fix:

Ensure all controls are initialized in the constructor or in a method called from the constructor.

Alternatively, disable nullable reference checking for the file by adding #nullable disable at the top of Form1.cs.
This removes warnings while keeping the code functional.

## 2. Controls Not Centering Properly

Issue: Labels, text boxes, or buttons appear misaligned or off-center.

Fix:

Use a TableLayoutPanel to center all controls both vertically and horizontally.

Set each control’s Anchor property to AnchorStyles.None inside the layout panel.

Adjust RowStyles and ColumnStyles to allocate space evenly.

## 3. Password Evaluation Not Updating

Issue: Clicking the “Check Strength” button does not update the strength or suggestions.

Fix:

Ensure the Click event of the button is correctly linked to the CheckButton_Click method:

checkButton.Click += CheckButton_Click;


Make sure the evaluation logic is inside the CheckButton_Click method and references the correct TextBox and Label controls.

## 4. Colors Not Displaying Correctly
   
Issue: Strength colors (red, gold, green) do not appear as expected.

Fix:

Verify the ForeColor of strengthLabel is updated in the switch statement according to the score.

Check for typos in Color.Red, Color.Gold, or Color.Green.

# 8. References

Microsoft. (2023). Windows Forms overview. Microsoft Docs. https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview

Microsoft. (2023). C# Guide. Microsoft Docs. https://learn.microsoft.com/en-us/dotnet/csharp/
