# **Airport Board**

## **Assumption**
+ **Network environment**
    + We have two environments with two clusters of web servers. one is connecting to internet another one can only be accessed within intranet
    + Each web site is deployed on a cluster of servers and people access it through NLB (Network Load Balance)
    + Two of these cluster web servers could access the same database

+ **App**
    + Users subscribe the flight information through our App. 

## **Frameworks**
+ **backend**: 
    + Asp.net core web API + SignalR + Entity framework
    + *reason*
        - Asp.net core is the mainstream technology in NZ and it has been proven that it is a stable and efficient technology.
        - SignalR is used to notify users about the real-time subscribed airlines' information
        - Entity Framework is an ORM framework to quickly convert the relation database row into Object

+ **frontend**: 
    + React + React Hook + Typescript + webpack
    + *reason* 
        - React is one of the mainstream frontend frameworks. 
        - Typescript helps to make JavaScript code could be checked before run. 
        - Webpack could package the whole project  

+ **database**: 
    + MySQL
    + *reason* Most acceptable free database and stable 

+ **Cache**:
    + Redis
    + *reason* Reliable, free and support master-slave cluster. It is used to cache frequent query data

+ **CI**: 
    + TeamCity
    + *reason* Free, and easy to customize to fit each environment





## **Implementation && Not Implemented**
+ **Implementation**
    - Query specified flight information
    - Update flight information && check the permission during update
    - Fully implement the flight data model and entity
    - basic data operation
    - Can only update flight information from intranet

+ **Not Implemented**
    - Board display
    - Subscribe flight information
    - Cache data for large volume query
    - Keep the flight schedule up-to-date
    - Display a list of upcoming flights

## **Estimation**
+ Current work is done with 4 hours.
+ Still need about 1~2 days to develop the API and SignalR Hubs
+ About 1 day and a half to build the web pages and establish the socket connection
+ About 1 day to test all these functionalities