# LandlordStudio full-stack recruitment test

Thanks for taking the time to do our full-stack coding test. This will have three parts:

1. a [task](#frontend) to create a create a list of payable transaction displayed in a react-based website.

2. a [task](#backend) to create an REST API for retrieval and update of those rental payments, and an error scenario.

3. some [follow-up questions](./FOLLOW-UP.md) (please commit the follow-up question answers to at least one of the front or back end repositories).

**NOTE:** If you browse our github organisation you should have two invitations waiting for you, these will give you access two repositories named something like ls-recruitment-front-{YOUR NAME} and ls-recruitment-back-{YOUR-NAME}. If you don't not see the invitations or cannot see the repositories with your name on them, please contact us. (Please do not branch or make PRs for the repositories that do not have your name on them).

You will be assessed based on the following being met:

- You complete the tasks described in the [backend](#backend) and [frontend](#frontend) tasks, and that the applications you produce functions as described in those tasks.

- Your website roughly looks like the provided [design](./design-spec/payment_list.png) (please note that nothing has to be exact in terms of the look of the site).

If you run into any issues, or if anything is unclear, please contact us - any feedback will help us improve our test.

---

## Tasks

The tasks for this recruitment test are below, please complete everything described in [backend](#backend) and [frontend](#frontend).

Both the frontend and backend applications should be able to run on both OSX and Windows.  
The frontend application should be able to run without installing anything other than node+npm (it will require at least version 14 of node js), and the backend application should be able to run without installing anything other than .NET 6.

Neither application should depend on the existence of any other application outside of these recruitment tasks.

### Backend

We would like you to implement a REST API using .NET. Please feel free to incorporate any Nuget packages you are comfortable with.
We have provided you with a repository that is copied from [here](https://github.com/LandlordStudio-Recruitment/ls-recruitment-back) to get you started.  
Two classes, `Payment.cs` and `PaymentRepository.cs` have been provided for you - you do not have to use these and they do not indicate any sort of style or pattern that we require. They are merely there to remove some of the more mundane boilerplate for the test if you should choose to utilize them.  
Please make commits/PRs to this repository like you would at work.

The API should expose at minimum two operations.

- The first should load a list of upcoming rental payment items from the provided payments.json file into memory, modify them in any manner you deem necessary, and return them so they can be used by the website you develop in the [frontend](#frontend) task. Note that amounts for each payment will be in cents, so must be converted to dollars.
- The second should update the status of an individual payment to `Paid` (a mock payment operation).

#### _Backend Error Scenario_

We would like you to handle a specific error scenario in the API. If the amount of the payment being paid is over \$1000 (100,000 cents), then the API should return a error/non-success response indicating that the client does not have sufficient funds.

**NB:** We do not expect you to integrate this error scenario into your frontend - this task is here to demonstrate how you design and implement error handling scenarios in a REST API.

#### _Backend Tests_

For the backend, please include at least one unit (or integration) test. This is to demonstrate how you structure tests as well as what you prioritize when testing, we do not require complete coverage.

### Frontend

We would like you to implement a website using React and Typescript.  
Please feel free to use whatever other front-end libraries you are comfortable with.

The main focus of the website is to display a list of upcoming rent payments.
A basic design for the website can be found [here](./design-spec/payment_list.png).

When the user navigates to the `Dashboard` for the first time, fetch upcoming rent payments from the API you developed in [backend](#backend), and format them in user readable results.

- The payment due dates should be formatted as MMM DD.
- The status of each payment should be `Paid` or `Unpaid`, depending on the payment status.
- A pay button should only be displayed for payments that are not `Paid`.
- The amount should be formatted as a US dollar amount (e.g. \$10.00).
  **Note**: Payment amounts returned from the API will be in cents and must be converted to dollars.
- Payments should be listed in ascending chronological order.

Once the you have displayed the payments, clicking the `Pay` button on each applicable payment item should do the following:

- A call should be made to the REST API that updates the state of that payment to `Paid`.
- The result of that call should be used to then update the status of that payment in the list that is displayed to the user.
- While the call to pay an individual payment is being made, the user should not be able to pay again (i.e. the user interface should attempt to prevent the user from double paying).

**NB:**
You are not expected to match any of the styles, colour, fonts etc in the given design images exactly. These are just guidelines for how we would roughly like the site to be laid out and look.

The frontend repository was created using `create-react-app ls-recruitment-front --template typescript`, with a few changes (see [here](https://create-react-app.dev/docs/documentation-intro) for more information on create-react-app).

## Running the frontend project

To startup the frontend client run the following command.

- `npm install` - This will fetch the required node modules for the website to run (and for the other scripts below).
- `npm start` - This will start the application for development.

## Running the backend project

The backend project can be run via the [.NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run) or using Visual Studio.

## Submission Guidelines

Please notify us once you are ready for your work to be assessed. We will be cloning the master branch of the repositories created for you and running the applications from there.
