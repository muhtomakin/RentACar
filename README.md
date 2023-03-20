# RentACar

### This project is developed with SOLID Principles, Enterprise Software Architecture, AOP.
 
* .Net Core 6.0 is used
* **Cross Cutting Concerns**  **interceptor *Autofac** library is used.
  * Performance   
  * Transaction
  * Validation
  * Caching

* Entity Framework ORM kullanılarak geliştirildi.
* **AOP** is developed in modularity with **Cross Cutting Concerns**. 
* **Exception Middleware** provide central error mechanism.
* **Claim** mekanism provides that role based authorization.
* **JWT (JSON Web Token)** identity verification.
* With **Fluent Validation** is developed validation process.
* With **IoC(Inversion Of Control)** (loose coupling) is created classes.
* With **REST and RESTFUL WEB SERVICES** communicate server-client.

### C# Backend Layers

* **Core**: It is a generic layer that allows tools to be used in other projects. 
* **Entities**: The layer where we convert the tables in the database into objects.
* **DataAccess**: The layer that can access to database.
* **Business**: The layer where we develop our business rules.
* **WebAPI**: Restful (Representational State Transfer) is the layer where we provide server-client communication with the HTTP protocol.
