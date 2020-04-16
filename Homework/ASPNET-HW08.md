# AJ McCray
#### March 25th, 2020
1. Configuring the ASP.NET Core Application
1. Set up shared objects that can be used throughout the application through the dependency injection feature
1. Extension method that sets up the shared objects used in MVC applications
1. The domain model. This is the heart because it is the starting point of all applications, this is the starting point because
1. To allow the caller to obtain a sequence of objects. Derived from the IEnumerable<T> interface, represents a collection of objects that can be queried, such as those managed by a database.
1. You can make a change in one part of the application without having to make corresponding changes elsewhere. This is important because if your components are too tightly coupled, then making one small change could cause a bug or crash in another component.
1. A new FakeProductRepository object should be created each time the IProductRepository interface is needed
1. Dependency injection is where one object supplies the dependencies of another object. The dependency is just an object that can be used in place of another object. Injecting means that you are using the objects needed by a class typically through a constructor.
1. They ensure that vies are consistent and contain important javascript files and CSS stylesheets
1. The bridge between the application and the Entity Framework Core and provides access to the application's data using model objects.
1. The EnsurePopulated method obtains an ApplicationDbContext object through the IApplicationBuilder interface and calls the Database. Migrate method to ensure that the migration has been applied, which means that the database will be created and prepared so that it can store Product
objects.
1. The ViewModel contains fields that are represented in the view. View models only render views, while the model is an object that sends information to the database to perform business calculations and to render a view.
1. A composable URL is an URL with a specific name that the user can relate the web application to.
1. A fragment of content that you can embed into another view, like a template. Another way to explain a partial view is that it can be used as a child view in multiple other views. It eliminates duplicates coding by reusing same partial view.
