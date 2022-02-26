# BookStoresAPI
The soultion is developed based on the requirement mentioned in the document.
This solution contains 2 project, with One WEB API and one Console Application which consumes the WEB API.
WEB API - **BookStoresAPI**
This WEB API is built with the SQL as a backend and used Entity Framework6 for developing as a ORM framework.
Connected to SQL Using Local database connection and the Database name is Master.
The script of the table is within the WEB API Project named SQL Script.
Used Repositiory design Pattern in WEB API.
There are 2 methods within the WEB API as mentioned in the requirement which is inside values controller for PUT and POST method.
The second project, is a console Application -**BookServiceAPIConsumptionConsole**
Console Application Consumes the WEB API created for POST and PUT method.
To create/Update a record we need to input the data on to the console application.
