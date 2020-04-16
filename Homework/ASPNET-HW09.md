# Core MVC Chapter 9
#### --AJ McCray
1. In the Configure() method of the Startup.cs file, note the four map routes defined in the book.
    -  lists the first page, Page2 lists the specified page, /Soccer shows the first page of items from a specific category, /Soccer/Page2 shows the specified page of items from the specified category
    - The routes are applied in the order in which they are defined.
    - You will get odd effects if you change the order
1. When you define tag helpers, you can specify a prefix for the attribute name.
    - All of them are received all together within a single collection.
    - You don't have to re-state the tag helpers in a different collection.
1. The value of any attribute whose name begins with the prefix will be added to the dictionary that is assigned.
1.  A view component is a c# class that provides a small amount of reusable application logic with the ability to select and display RAzor partial views.
1.  You can build a list using C# language and object oriented programming.
1.  View components are initialized through @await Component.InvokeAsync("InformationSidebar")
1.  Provides info about how the request URl was handled by the routing system.  The RouteData property is used to access the request data in order to get the value for the currently selected category in a list.
1.  The data stored at the server and associated with a series of requests made by a user. To store the details of the user's cart
1.  Instead of writing code to retrieve values from forms and route data manually, Model binding automates the process. Model binding retrieves data from various sources such as route data, provides the data to controllers and razor pages in method parameters and public properties, converts string data to .NET types, and updates properties of complex types.
1. This method is used to redirect to specified action instead of rendering the HTML.
