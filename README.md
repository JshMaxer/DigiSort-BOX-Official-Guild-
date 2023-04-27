# DigiSort Box Official Guild

## INTRODUCTION
  DigiSort Box is a Sorting and Inventory application that can be used to manage items and data easily. The 
  main purpose of this application is for the end users to manage and take care of all the items taken from 
  the database and local storage.
  
## **Functional requirements**
  1. Allow the users to manage and sort the items given and take on the database easily and with 
  friendly users.
  2. Allow the users to move from one form to another form using buttons.
  3. Allow users to manage and view the monthly sales on the dashboard.
  4. Allow the users to create an account.
  5. Allow the users to reset their passwords using their email.
  6. Allow the users to manage the database using the software.
  7. Allow the users to view their personal profiles.

## **Non-functional requirements**
  1. The system must handle a large number of items.
  2. The system must secure all the items in the database.
  3. The system must be available 24/7 to allow the users to manage items anytime.
  4. The system must be user-friendly and easy to use.
  5. The system must be secure to protect all the user’s personal data.
  6. The system must be fast and responsive to provide a good user experience.
  7. The system must not have delays to manage items quickly.
  
## **Prioritize requirements**

* Must-have ability to insert, update and delete items securely and availability.
* Should-have might the ability for users to create accounts.
* Could-have monthly view reports and track the numerous counts of items.
* Won’t-have requirements might include integration with social media platforms.

## **Database**

### Name of the database: ***digisortbox***

Tables in ***digisortbox***    |
------------------------------ |
account                        |
raw_material                   |
ready_to_sell_items            |
unprinted_shirts               |

### Tables Description: account ###
***Field***                    | ***Type***      | ***NULL***      | ***Key***      | ***Default***      | ***Extra***      |
------------------------------ |-----------------|-----------------|----------------|--------------------|------------------|
username                       | varchar(255)    | No              | PRI            | NULL               |                  |
first_name                     | varchar(255)    | No              |                | NULL               |                  |
last_name                      | varchar(255)    | No              |                | NULL               |                  |
email                          | varchar(255)    | No              |                | NULL               |                  |
password                       | varchar(255)    | No              |                | NULL               |                  |
