# Purplebricks Developer Test

The aim of this test is to give us an idea about how you approach the development and maintenance of web applications. You will work from a GitHub repository which contains an existing web application. The UI should be functional, but there is no expectation that you modify the brand theme. We are looking for a solution that shows how you build maintainable, scalable and secure software. The test is based on an overly simplified version of our business domain.

The existing web application supports two types of customer. Sellers are able to upload information about a property and list the property for sale. Buyers can search for a property and make an offer. When an offer has been placed on a property the seller should be able to accept or reject the offer.

## Test Objectives

### Objective 1 - Extend an existing feature

We need you to extend the offer functionality of the web application so that when a seller accepts an offer the buyer that placed the offer can see that their offer has been accepted.

**User Story:** *As a buyer I want to see when my offer has been accepted so that I can proceed with the property purchase.*

### Objective 2 – Add a new feature

We need you to add the ability for a buyer to book a viewing. It’s unlikely a customer would want to make an offer on a property without booking a viewing.

**User Story:** *As a buyer I want to book a viewing appointment at a property so that I can determine whether I would like to make an offer.*

### Objective 3 - Review the existing code

Write a short review of the existing sample codebase. Let us know what you think is good or bad about it. Feel free to fix any problems and commit these changes to the solution.

#### Deliverables

Your submission should be delivered in as a Visual Studio solution compatible with Visual Studio 2015. The solution should compile. For data persistence please use the existing Entity Framework model with SQL. Feel free to add migrations if you need to. 
We would prefer that the solution is delivered via GitHub. If you are not able to fork this original repository publically then please fork to a private repository and then provide us with the zip file from the download option in GitHub.

Good luck!

## FAQs

* Should I show my commit history?
    * Showing your commit history is recommended so that we can see your approach.

* How long should I spend working on the assignment?
    * You can take as long as you need to complete the assignment. But do remember that this is throwaway code and the aim is to demonstrate your approach rather than build a complete system.

* Do I need to deploy the application?
    * If you wish to demonstrate your working app then you may deploy it to Azure on a free trial account. This is not mandatory.

## Sample code review

* Existing sample of code looked for me clean and easy to read. First time I had contact with Code First Migrations so I had to take a close look, my first impression is very good but I will need some more training of best practices. Also I have small experience with Unit Tests, unfortunately I couldn't run them, got an empty Test Explorer view and Test output so I was unable to prepare any new for additional features. I used newest standards of Microsoft MVC only at home, on my previous job there was an implementation of some internal solutions for .NET MVC but it was way more complex than it should be. So I finally really like that sample of code you provided. Also I really liked command handlers as a separate layer of controllers, it makes code more readable. As a summary I would like to improve my skills in provided technology because I really enjoyed it.

* In future to avoid unreadable code we could provide separate views for Sellers and Buyers. For example Index property view have some functionality only for Sellers but also visible for Buyers. At this point I decided just to show buttons if a logged in person Role is a Buyer. If Seller have no need to look at this list we could show that view only for Buyers and it will also solve it.
