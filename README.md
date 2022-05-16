# StoreMiniApp

Implementing the Repository and Unit of Work Patterns in an .Net Core API(6.0)


# Install & Run
   1. Clone the Repository
   2. Create a db with using sql script.
   3. Change the ConnectionStrings in appsettings.json
   4. The app running on localhost:7102
   
# Tooling
1.	Swagger - API documentation
2.	MSSQL - DB
3.	AutoMapper - Mapping framework
5.  Mock - Test
4.	EntityFrameworkCore

# UML Diagram
![StoreMiniApp](https://github.com/erolakdogan/StoreMiniApp/blob/master/StoreMiniAppDiagram.png)

# Api-Endpoint List for User e.q

```
  GET http://localhost:7102/api/Users/GetUsers
  GET http://localhost:7102/api/Users/GetUserById/{id}
  POST http://localhost:7102/api/Users/CreateUser
  DELETE http://localhost:7102/api/Users/Delete{id}
```
