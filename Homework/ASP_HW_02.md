
#### Roxanna Barahona
#### February 27, 2020
#### ISTA322 HW Ch2

1. Describe what a controller does in the MVC design pattern.

- It takes the input and changes it to commands for the model or view.
2. What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do?
- HomeController.cs is the default controller class that is uses in MVVC application.
3. What is the name of the routing configuration file? Where is it located?

- ASP.NET Routing is enabled in your application's Web configuration file (Web.config file).
- system.web.httpModules section, the system.web.httpHandlers section, the system.webserver.modules section, and the system.webserver.handlers section.
4. What is Razor? How does Razor treat an expression beginning with the at symbol (@)?

- Razor is a syntax for getting server based code into webpages such as C# or HTML
- When an `@` symbol is followed by a Razor reserved keyword, it transitions into Razor-specific markup. Otherwise, it transitions into plain C#.
5. . How do View methods work?

- View handles the app's data presentation and user interaction.
- The default behavior of the View method (return View();) is to return a view with the same name as the action method from which it's called.
6. What is the purpose of MVC models?

- ITs to separate your views from your model and controller. It allows the two to be separate so they don't affect each other. Usually its used for GUUI stuff.
7. What is a strongly typed view and why do we use strongly typed views?

- A strongly typed view is intended to render a specific model type, and if I specify the type I want to work with (the GuestResponse class in the PartyInvites.Models namespace in this case), MVC can create some helpful shortcuts to make it easier.
- By specifying the type of data, you get access to IntelliSense for the model class
8. What is the purpose of setting a start page URL?

- So you have somewhere consistent to go and you know the url instead of it changing.
9. . Describe the differences between HTTP GET and HTTP POST.

- Post is a more secure way to transfer data from client to server because it carries request parameter in message body instead of the url string.
10. Describe the two approaches to validation in web applications
- Client side Validation allows validation on the client side or personal computer, it is less secure and can be changed by the user, but it is also faster.
- Server side Validation validates the input submitted on a server. It is more secure but it is much slower then client side because it has to travel their and back.
11. . What is the role of Cascading Style Sheets (CSS) in web development?
- CSS only defines the structure and content presentation of a website. It has nothing to do with the design of a website. You can control positioning , color, style, font, and more with CSS to really customize your website.
