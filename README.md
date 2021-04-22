# [File Descriptions](https://www.condesigns.com/)

# Homework2 - COVID-19 Temperature Recorder

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

# Homework4 - Sales Person Calculator

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
