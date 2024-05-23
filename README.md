# wild-identity
Authenticate using Identity with Entity Framework.

## Objective

Challenge:

Set up an MVC project with the pre-configured Identity module and then create a controller that restricts access to registered users on the site.

## Validation Criteria

- The Identity service is injected and coupled with Entity Framework
- The Identity service is added in the correct place in the middleware pipeline
- It is possible to register a user
- It is possible to log in a registered user
- At least one route restricts access to members only

![image](https://image.noelshack.com/fichiers/2024/21/4/1716490509-screenshot-2024-05-23-205204.png)
