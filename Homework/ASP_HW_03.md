#### Roxanna Barahona
#### March 4, 2020
#### ISTA322 MVC Ch 3

***Read chapter 3, pages 51 – 66 in the Pro ASP.NET MVC 5 book.***

1. The book states, “Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless.” What does it mean for the view to be stateless?
- it doesn't have a memory of what went on in the past. doesn't keep track of configuration, or data.

2. The book identifies two kinds of models. Briefly describe each of them.
View models, represent data being transferred between views and controllers.
- Domain models, contain the data in a business domain as well as the operations, transformations, and rules for manipulating that data.

3. Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.
- Delegate different people for different tasks depending on rank and ability 

**S** eparation of Concerns

**O** pen/Closed Principle

**L** iskov Principle

**I** interface Separation

**D** epending Injection
 4. What is a view engine?
- Is the component responsible for processing a view in
order to generate a response for the browser.

 5. The book notes that the three-tier structure, or n-tier model, is “the most widely used pattern for business applications.” Why do you think that this is true? An answer like, “Because it works well,” is not a sufficient answer to this question.
Database on button glue in the middle, html on top. it didnt matter what lenguage you use because it still produced html

6. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-ViewModel (MVVM). What is the difference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?
In UWP its stateful ( uses memory) in MVC it's stateless. MVW has no controller. the model and the view communicate directly.

7. Describe the two parts of the dependency injection (DI) design pattern.
PasswordResetHelper remove any dependencies on concrete classes from my
component
- inject means is that I need to decide which class that implements the IEmailSender interface I am going to use, create an object from that class and then pass the object as an argument to the PasswordResetHelper constructor.

8. Give an example of loose coupling from your own life experience. This should be a simple, everyday example.
- You are not tied to any particular implementation.

9. What are the two types of testing discussed in the book?
- Automated Testing

- Unit Testing

10. What are the seven steps of the test driven development (TDD) workflow, as stated in the book?
a. Determine that you need to add a new feature or method to your application.

b.  Write the test that will validate the behavior of the new feature when it is written.

c. Run the test and get a red light.

d. Write the code that implements the new feature.

e. Run the test again and correct the code until you get a green light.

f. Refactor the code if required. For example, reorganize the statements, rename the variables, and so on.

g. Run the test to confirm that your changes have not changed the behavior of your additions.
