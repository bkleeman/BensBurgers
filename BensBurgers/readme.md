# Ben's Burgers

In Spring 2019, I took a User Interface Development course, in which I learned the fundamentals of C# and .NET by building console, WPF, and ASP.NET Web Forms applications. 

For my final project, I used .NET Web Forms to develop an SSL-enabled e-commerce website for a fictitious restaurant: “Ben’s Burgers.” The website features a front-end styled with Bootstrap 4, a back-end driven by Entity Framework, third-party login support via OAuth for users who wish to use their Google accounts to login securely, and a sandboxed checkout process through PayPal API calls. I built the site guided by the tutorial “Getting Started with ASP.NET 4.5 Web Forms and Visual Studio 2013” from Microsoft. While the website is not an entirely custom solution, I did learn a great deal about full-stack .NET development in an e-commerce environment with some degree of scalability in mind. For testing/demo purposes, your own PayPal API credentials are required. 

## Getting Started

1. Clone the repo
2. Open BensBurgers.sln in Visual Studio
3. Navigate to Logic > PayPalFunctions.cs and add your PayPal API credentials:
  3a. Replace <Your API Username> with your API Username
  3b. Replace <Your API Password> with your API Password
  3c. Replace <Your Signature> with your Signature
4. Run the application with IIS Express

## Built With

* Visual Studio 2017 Enterprise
* [ASP.NET Web Forms](https://dotnet.microsoft.com/apps/aspnet/web-forms)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/) - Object-relational mapping for data access
* [Bootstrap 4](https://getbootstrap.com/docs/4.0/getting-started/introduction/) - CSS styling
* [OAuth](https://oauth.net/) - Secure authorization/Google account login
* [PayPal Checkout API](https://developer.paypal.com/) - Sandboxed checkout process

## Details

Entity Framework is used to maintain and sync with a database that keeps individual records of products, product categories, orders, order details, and cart items. These values are stored for admin review/modification and to render data values dynamically to bindings in the .NET Web Forms markup files. The Products page maintains a grid view that is populated by all items contained in the Products record, which will update to reflect any new items added or removed by an administrative user. End users may also filter by product category to display only items sharing the same category ID in the database. 

Data pertaining to cart items are associated with user accounts either created locally or integrated via OAuth for secure authorization. When a user logs in or registers for a new account, any products in their anonymous shopping cart are migrated over to the cart associated with their account. The user is able to modify quantity or remove items from the cart, and can also go through the full process of PayPal checkout, albeit in a simulated, sandboxed environment -- so no money changes hands as this is a fictitious website built for project experience. To ensure that the website functions appropriately, those testing the application must add their own PayPal API credentials (username, password, signature) to the PayPalFunctions.cs logic class.

Administrative users are given the ability to view an otherwise hidden Admin view that becomes available via the navbar upon successful authentication. From the Admin view, an authorized user may add or remove products and associate them with a category in the database. The new database entry is validated by required fields and regular expression matching to ensure a valid price is assigned, and may also include images which are restricted to a set of image file extensions via a file upload control.

The website has many othe features, but these are what really drive the website and I what I gained the most from focusing on. I plan to carry the skills I’ve learned here and the understanding I’ve developed throughout the course of this project with me to my future full-stack web development projects, whether that be moving forward into ASP.NET MVC or otherwise.

## Authors

* **Benjamin Kleeman** - *Developer* - [Personal Website](https://benjaminkleeman.surge.sh/) // [LinkedIn](https://www.linkedin.com/in/benjamin-kleeman/)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Thanks go out to the following: 
  * Professor Anthony Zoko whose inspirational lectures convinced me to love C# and .NET
  * [Erik Reitan](https://github.com/Erikre) for his fantastic [tutorial](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/getting-started/getting-started-with-aspnet-45-web-forms/introduction-and-overview)
