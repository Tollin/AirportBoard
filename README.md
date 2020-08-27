# **Airport Board**

## **Frameworks**
+ **backend**: 
    + Asp.net core web api + signalR + Entity framework
    + *reason*
        - asp.net core is the mainstream technology in NZ and it has been proven that it is a stable and effcient technology.
        - signalR is used to notify users about the real-time subscribed airlines' information
        - Entity Framework is an ORM framework to quickly convert the relation database row into Object

+ **frontend**: 
    + Reactjs + React Hook + Typescript + webpack
    + *reason* 
        - Reactjs is one of the mainstream frontend frameworks. 
        - Typescript helps to make javascript code could be checked before run. 
        - Webpack could package the whole project  

+ **database**: 
    + MySQL
    + *reason* Most acceptable free database and stable 

+ **Cache**:
    + Redis
    + *reason* reliable, free and support master-slave cluster. It is used to cache frequent query data

+ **CI**: 
    + TeamCity
    + *reason* free, and easy to customize to fit each environment




