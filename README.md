# LandlordStudio full-stack recruitment test

Thanks for taking the time to do our full-stack coding test. This will have four parts:

1) a [task](#frontend) to create a create a list of payable transaction displayed in a react-based website.

2) a [task](#backend) to create an REST API for retrieval and update of those rental payments.

3) a [task](#errorhandling) to extend the api and website with error handling.

4) some [follow-up questions](./FOLLOW-UP.md)

----

You will be assessed based on the following being met:

* You complete the tasks described in [backend](#backend), [frontend](#frontend), and [error handling](#errorhandling) tasks, and that the applications you produce functions as described in those tasks.

* Your website roughly looks like the provided [design](./design-spec/layout_and_list.png).

----

## Tasks

The tasks for this recruitment test are below, please complete everything described in [backend](#backend) and [frontend](#frontend), and at least one of the items described under [extensions](#extensions).

Both the frontend and backend applications should be able to run on both OSX and Windows.  
The frontend application should be able to run without installing anything other than node+npm, and the backend application should be able to run without installing anything other than .NET Core (3.1).
  
Neither application should depend on the existence of any other application outside of these recruiment tasks.

### Bankend

We would like you to implement a REST API using .NET Core. Please feel free to incorporate any Nuget packages you are comfortable with.
We have provided you with a repository that is copied from [here](https://github.com/LandlordStudio-Recruitment/ls-recruitment-back) to get you started.  
Please make commits/PRs to this repository like you would at work.

The API should expose at minimum two operations.
- The first should load a list of upcoming rental payment items from the provided payments.json file into memory, modify them in any manner you deem necessary, and return them so they can be used by the website you develop in the [frontend](#frontend) task. Note that amounts for each payment will be in cents, so must be converted to dollars.
- The second should update the status of an individual payment to `Paid` (a mock payment operation). Updates should be presisted for at least the lifetime of the application.

Ideally this server should run on port 5000.

### Frontend

We would like you to implement a website using React, Redux and Typescript.  
Please feel free to use whatever other front-end libraries you are comfortable with.  
We have provided you with a repository that is copied from [here](https://github.com/LandlordStudio-Recruitment/ls-recruitment-front) to get you started.  
Please make commits/PRs to this repository like you would at work.  
  
The frontend repository was created using `create-react-app ls-recruitment-front --template redux-typescript`, with a few minor changes.  
Ideally this application would run on port 3000.  
  
The main focus of the website is to display a list of upcoming rent payments, it also includes a left-hand navigation menu.  
A basic design for the website can be found [here](./design-spec/layout_and_list.png).  

When the user navigates to the `Dashboard` for the first time, fetch upcoming rent payments from the API you developed in [backend](#backend), and format them in client readable results.  
  
- The payment due dates should be formatted as MMM DD.
- The status of each payment should be blank, `Paid`, or `Overdue` depending on the payments status and due date.
- The pay button should only be displayed for payments that are not `Paid`
- The amount should be formatted as a US dollar amount (e.g. $10.00)
- Payments should be listed in ascending chronological order.

The header with the welcome message above the list of payments should be dynamic based on the current sate of the payments;
 If there is a payment over due, it should end with "you have a rent payment overdue", if there is a payment due today, it should end with "you have a rent payment due today", if tomorrow, "you have a rent payment due tomorrow", otherwise "you have a rent payment due in X days".

If a user clicks on the `Pay` button, a dialog detailed [here](./design-spec/pay.png) should be shown to the user.  
Upon confirmation, a call should be made to the REST API that updates the state of that payment to `Paid` (if successful).  
The result of that call should be used to then update the status of that transaction in the list that is displayed to the user.
This should also update the welcome message header above the list of payments if applicable.  

For the left-hand navigation. The other two menu items do not have to do anything in particular. But they should be distinguishable from one-another (e.g. a simple component that just displays the name of the menu item is fine). They are merely there for you to demonstrate navigation between content using React.  
  
**NB:**
You are not expected to match any of the styles, colour, fonts etc in the given design images exactly. These are just guidelines for how we would roughly like the site to be laid out and look.  

### Error Handling

Extend the dialog in detailed in the [frontend](#frontend) section to accept an amount.
If the amount is over $1000, an error should be thrown from the REST API detailing that the user has insufficient funds.
The website should handle this error and display an appopriate error message to the user.
  
## Running the frontend project

To startup the frontend client run the following command.

* `npm install` - This will fetch the required node modules for the website to run (and for the other scripts below).
* `npm start` - This will start the application for development
* `npm run build` - Will create a production optimised build
* `npm test` - Will run the front end tests

## Running the backend project

The backend project can be run via the [.NET Core CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run) or using Visual Studio.

## Submission Guidelines

Please notify us once you are ready for your work to be assessed. We will be cloning the master branch of the repositories created for you and running the applications from there.