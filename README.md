# [FILE DESCRIPTION](https://www.condesigns.com/)

# COVID-19 Temperature Recorder

## Task:
Develop a program to record 2 weeks of temperature readings and give a diagnosis of the average temperature.

## Form: 
- Use a textbox to record a reading from the end user and a listbox to record each valid reading.
- Use textbox to display the last temperature recorded and a diagnosis
- Use textboxes to display the 14 day average based on data stored in the listbox
- Include buttons for Record Reading and Clear Readings

## For Full Credit:
- Program must be well documented and controls well named according to standards.
- Data must be validated and formatted appropriately. 
- Readings must be numeric and accept decimal places
- Readings must be between 0 and 115 
- if statement with LOGICAL OPERATOR must be used.
- Appropriate and distinct error messages should be displayed.
- Temperatures must be formatted with 2 decimal places
- You must use a SELECT CASE  to determine the diagnosis based on ranges for the last reading and average reading.
  - less than 95 is Hypothermia
  - 95 to 99 is Normal
  - 99 and greater or equal to 103 is Fever
  - greater than 103 is Seek Attention
- A FOR NEXT loop must be used to iterate the readings list box and accumulate the total readings
- The program must NOT  allow more than 14 readings.
- It should disable the record and textbox when that count has been hit.
- You must use a CONSTANT    for the max number of readings.
- Use the same set of data for your program and the Runtime.  They must match.
- Record and Clear buttons must be functional

# Sales Person Calculator

## Task:
Create a project to calculate the weekly salary and commission rate for a sales person based on their weekly sales. Provide a summary of the running totals of the weekly salary and commissions paid and an About Box.

## Form: 
- Ask for the Salesperson's name and their Weekly Sales (both required and sales must be numeric)
-Include menu with options

  - File (Pay, Summary - must be separate form, Exit)
  - Edit (Clear)
  - Help (About - must be separate form)

## Code: 
  - Class
  - Properties
    - An external class is required.
    - Properties for Name (must not be blank), Weekly Sales (must not be < 0)
    - Readonly properties for Commission and Pay
    - Readonly properties Total Sales, Total Commission, Total Pay 
- Commission:
  - If Sales > Quota (400) then Commission = Sales * Commission Rate (10%) 
  - Else Commission = 0
  - Pay = Base Salary (500) + Commission
  - Total Sales/Commission/Pay should accumulate for ALL sales person's entered

- Methods
  - Sub FindPay, Function CalculateCommission(SalesDecimal)
  - Both methods should be hidden 

- Constructor
  - Overloaded to accept Name and Sales and should calculate Pay on instantiation
- Form
  - Verify a name was entered
  - Verify sales amount entered is numeric
  - Pay should instantiate an object and calculate and display Pay.
  - Summary should open in separate form. Display total sales, commissions, pay for all sales persons entered.  
  - MUST be opened Modelessly and updated on Form Activation
  - About should open separate form
  - MUST be opened Modally
  - Exit should close the program 

## For Full Credit:
- Program must be well documented and controls well named according to standards.
- Data must be validated and formatted appropriately
- NO Autoimplemented properties
- Results must match Runtime answers
- All items in Code section above must be completed

# Calorie Calculator 

## Task:
-Create a website that calculates the total of fat, carbohydrate, and protein calories. Allow the user to enter (in text boxes) the grams of fat, the grams of carbohydrates, and the grams of protein. Each gram of fat is nine calories; a gram of protein or carbohydrate is four calories.

## Code: 
- You  MUST use a custom class
  - This class must contain properties for Fat, Carbs, and Protein.
  - Your class must have a function to return ItemCalories
  - ItemCalories should equal Fat * 9 + Cards * 4 + Protein * 4
  - Your class MUST contain one constructor to initialize the properties.
- You must have required field validators for Fat, Carbs and Protein
- You must validate the range of Fat, Carbs, and Protein between 1 and 1000
- You must have a calculate button that:
  - Creates an instance of your class using the overloaded constructor
  - Displays resulting output from calculation
  - Displays totals on the screen 
- You must have a Clear button to clear individual calculations 
- Accumulate totals for number of calculations and total calories
- HINT: Use HiddenFields to store the totals in between page posts. You cannot use shared variables for this. 

## For Full Credit:
- Program must be well documented and controls well named according to standards.
- Data must be validated and formatted appropriately
- Results must match Runtime answers
- All items in Code section above must be completed 

# Random Sayings

- Write a project that displays four sayings, such as "The early bird gets the worm" or "A penny saved is a penny earned." (You will want to keep the sayings short, as each must be entered on one line.)  When the sayings displays on your form, long lines will run off the form if the label's AutoSize property is set to True.  To wrap text within the label, change the AutoSize property to False and use the sizing handles to make the label large enough. 
  - Make a button for each saying with a descriptive Text property for each, a button to print, and a button to exit the project.
  - Include a label that holds your name at the bottom of the form.  Also, make sure to change the form's title bar to something meaningful.
  - You may change the Font properties of the large label to the font and size of your choice.
  - Make sure the buttons are large enough to hold their entire Text properties.
- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels.

# Book Sale Application l10
  
- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels. 
- R 'n R has decided to start selling books online. Create a web site to calculate the amount due, including discounts. Allow the user to display the total of the discounts. 

 - The user enters the quantity, title, and price of a book, and the program calculates the extended price, a 15 percent discount, and the discounted price.  

  - The input must be validated. The quantity and price are required fields, and the quantity must be an integer between 1 and 100. 

  - Additionally, the program will maintain a total of all discounts given and display that total on the page in response to a button cick.  

  - Include a second page for contact information..


- Use a custom class for the BookSale including Title, Quantity, Price, ExtendedPrice, Discount

# Contact Form l11

- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels. 
- Implement a web based contact form.  It should consist of 2 pages:

- Default page with contact form on it
  - Panel 1
    - Ask for name (Required), email address (required and pattern match), phone number (pattern match), contact via, comments
    - Form should have a validation summary on it
    - When submitted, create a subroutine to send email to your email address with the results of the contact form using System.Net.Mail library
    - Once submitted, set a cookie to prevent duplicate submissions
  - Panel 2
    - This panel will appear if the page is loaded and the duplicate cookie was already set.
    - Thank you page with an image
- REMEMBER, if you can't submit the project, remove the Bin and Packages folders from your archive if they exist

# Books Viewer l12
   
- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels. 
- Create a web application to display the Books table in the RNR Books MDB file.

- Display 15 records per page and enable paging.

# Banking Account l4
  

- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels.
- In this lab you will create a simple banking application that will accept deposits, checks, and service charges. If the user tries to withdraw more money than is available, the withdrawal will fail and a service charge of $10 will be applied. You will also keep track of the number and amount of the deposits, withdrawals, and service charges.

# Banking Account with Methods l5
  
- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels.
- In this lab you will create a simple banking application that will accept deposits, checks, and service charges. If the user tries to withdraw more money than is available, the withdrawal will fail and a service charge of $10 will be applied. You will also keep track of the number and amount of the deposits, withdrawals, and service charges.
- Program should have at least 3 methods
  - Deposit : one parameter representing the amount to deposit
  - ServiceCharge : one parameter byref representing balance, second optional parameter for amount with default being 10
  - Withdraw :  one parameter representing the amount to balance, one parameter representing the amount to withdraw, returns new balance amount
  
# BookSale App l9
   
- Be sure to include comments at the top of each procedure and at the top of the file.
- Be sure to use meaningful names for all buttons and labels.
- Write a program that computes the values for a book sale using an external classes using inheritance.  


