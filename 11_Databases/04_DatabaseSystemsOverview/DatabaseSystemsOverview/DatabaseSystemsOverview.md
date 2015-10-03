## 1) What database models do you know?
* Hierarchical
* Network
* Relational
* Object-oriented

## 2) Which are the main functions performed by a Relational Database Management System (RDBMS)?
* Perform CRUD operations on the data in the database
* Create, edit, delete tables in the database

## 3) Define what is "table" in database terms.
* Database table is data arranged in rows and columns
* Each row has same structure
* Columns define the type and other constraints of the data in the row

## 4) Explain the difference between a primary and a foreign key.
* Primary key is a column of a table that identifies each row
* Foreign key is a link to other table's primary key

## 5) Explain the different kinds of relationships between tables in relational databases.
* One to one:
    - This relationship is like inheritance in the object-oriented programming languages
* One to many:
    - This relationship describes the way how multiple entities in one table can be connected to exactly one entity from other table
* Many to many:
    - This relationship describes the way how multiple entities in one table can be connected to multiple entities from other table
    - It is done by creating a new table "middleman" which contains the connections between the two tables

## 6) When is a certain database schema normalized?
* 
    - The database schema is normalized when each table contains only the data it needs
    - All the repeating information is moved to other tables and the needed relationships between these tables are created
* What are the advantages of normalized databases?
    - There is no repeating information in the database
    - The size of the database is reduced

## 7) What are database integrity constraints and when are they used?
* The integrity constraints are the constraints which ensure each entity in the database has valid state and no "bad" entities are saved to the database

## 8) Point out the pros and cons of using indexes in a database.
* Pros:
    - The indexes make the searching in the database exponentially quicker
* Cons:
    - The indexes make the work with database slower because the B-Tree must be loaded in the memory and when adding or removing entity this tree must be ballanced.

## 9) What's the main purpose of the SQL language?
* The main purpose of SQL is to manipulate relational databases.

## 10) What are transactions used for?
* Transactions are used when the given data from the database is used by multiple users at the same time and the changes of this data must always be done on valid data.
    - Transactions are used when working with money

## 11) What is a NoSQL database?
* NoSQL database is database which is document-based model

## 12) Explain the classical non-relational data models.
* Document model
    - represents set of documents
* Key-value model
    - represents set of key-value pairs
* Hierarchical key-value model
    - represents hierarchical set of key-value pairs
* Wide-column model
    - represents key-value model with schema
* Object model
    - represents set of OOP-style objects

## 13) Give few examples of NoSQL databases and their pros and cons.
* MongoDB:
    - It can store any kind of information, but there is no guarantee that all the data is valid
* Redis:
    - Realy fast database, but the informations is stored in the RAM