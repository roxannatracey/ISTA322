#### Roxanna Barahona
#### March 5, 2020
#### ISTA 322 Ch 4.

1.	Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the use of automatic properties avoids.
- It avoids the additional logic for get and set
- get { return _name; }
- set {_name = value;}

2.	Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.
- It avoids calling the constructor for example it would avoid calling kayak.
- Product kayak = new Product();kayak.Name = "Kayak";kayak.Category = "Water Craft";kayak.Price = 275M;

3.	What is the purpose of creating extension methods?
- A convenient way of adding methods to classes that you do not own and cannot modify directly.

4.	What is the one feature of extension methods that will always allow you to identify a method as an extension method?
- Their first parameter specifies which type the method operates on, and the parameter is preceded by the this (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this) modifier. Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.

5.	How do you create an extension method that filters the results returned by the method on a user specified criterion?
-	An extension method that operates on an IEnumerable<T> and that also returns an IEnumerable<T> can use the yield keyword to apply selection criteria to items in the source data to produce a reduced set of results.

6.	Explain the syntax of a lambda expression. The term “lambda expression” originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930’s. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.
- Del del = X => X*X;
- It makes a method expression shorter, using less memory to calculate.

7.	This will require some outside research. What is the distinction between an anonymously typed variable and a dynamically typed variable?
- anonymously typed variable means that this type has no name. The compiler will generate a very long, very random, unique and illegal name for the type and put that name in wherever the anonymous type appears.
- means that this variable, parameter, method, field, property ... whatever is dynamically typed, i.e. that its type will be checked at runtime. Everything that is not typed as dynamic is statically typed.

8.	You are having a discussion about C# with a friend of yours that uses another language. You are tellig him about C#’s LINQ library. How would you describe to him the difference between LINQ’s SQL-like notation and LINQ’s dot notation?
- The "dot" notation is usually called Lambda syntax. Lambda is more concise but performing multiple table joins is a nightmare. Joins are just much cleaner with the query syntax.

9.	What, exactly, does the await keyword do?
- The await operator suspends evaluation of the enclosing async method until the asynchronous operation represented by its operand completes. When the asynchronous operation completes, the await operator returns the result of the operation, if any..
10.	What is the connection between await and the async keywords?
- In MVC, asynchronous methods can be used to improve the overall performance of an application by allowing the server more flexibility in the way that requests are scheduled and executed. Two C# keywords—async and await—are used to perform work asynchronously.
