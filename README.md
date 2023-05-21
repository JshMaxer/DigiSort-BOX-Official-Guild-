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

### Tables Description: raw_material ###
***Field***                    | ***Type***      | ***NULL***      | ***Key***      | ***Default***      | ***Extra***      |
------------------------------ |-----------------|-----------------|----------------|--------------------|------------------|
material                       | varchar(255)    | No              | PRI            | NULL               |                  |
design                         | varchar(255)    | No              |                | NULL               |                  |
color                          | varchar(255)    | No              |                | NULL               |                  |
quantity                       | int(255)        | No              |                | NULL               |                  |

### Tables Description: ready_to_sell_items ###
***Field***                    | ***Type***      | ***NULL***      | ***Key***      | ***Default***      | ***Extra***      |
------------------------------ |-----------------|-----------------|----------------|--------------------|------------------|
product_name                   | varchar(255)    | No              | PRI            | NULL               |                  |
color                          | varchar(255)    | No              | MUL            | NULL               |                  |
shade                          | varchar(255)    | No              |                | NULL               |                  |
size                           | varchar(255)    | No              |                | NULL               |                  |
quantity                       | int(255)        | No              |                | NULL               |                  |

### Tables Description: unprinted_shirts; ###
***Field***                    | ***Type***      | ***NULL***      | ***Key***      | ***Default***      | ***Extra***      |
------------------------------ |-----------------|-----------------|----------------|--------------------|------------------|
color                          | varchar(255)    | No              | PRI            | NULL               |                  |
shade                          | varchar(255)    | No              |                | NULL               |                  |
size                           | varchar(255)    | No              |                | NULL               |                  |
quantity                       | int(255)        | No              |                | NULL               |                  |


# Database #
#### Guide to import database ####

1. Create local database on xampp/MySQL
    1. Name it **digisortbox**
2. Click import on upper tab >6 tab
3. Click choose file
4. Select the zip file
5. Scroll down then click import

* You should see the tables after you imported.

# Database File # 
[UpdatedDB - 5/21/23](https://github.com/JshMaxer/DigiSort-BOX-Official-Guild-/files/11524680/digisortbox.sql_2.gz)
