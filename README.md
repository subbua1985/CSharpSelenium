SeleniumTest
This is an automation project using Selenium WebDriver with NUnit for functional testing of a sample web application.

Project Description
The project automates tests for a sample website (Jupiter Cloud) using Selenium WebDriver. It tests the following:

TestCase1: Verify that the contact form displays error messages when submitted without any data and submits successfully with valid data.
TestCase2: Verify successful form submission with valid data.
TestCase3: Add multiple products to the cart and verify the total price.
The project uses NUnit for test management and ChromeDriver and FirefoxDriver for browser automation. The WebDriver paths are managed via a configuration file (JSON format).

Prerequisites
Visual Studio (version 2022 or higher recommended)
.NET 9.0 SDK (or higher)
NUnit3TestAdapter NuGet package for test discovery in Test Explorer
Selenium WebDriver NuGet package
ChromeDriver and GeckoDriver (Firefox) executables for running tests in Chrome and Firefox browsers
Installation and Setup

1. Clone the Repository
bash
Copy code
git clone https://github.com/your-repo/SeleniumTest.git
cd SeleniumTest
2. Install Dependencies
Install the necessary NuGet packages:

Selenium WebDriver
NUnit
NUnit3TestAdapter
Newtonsoft.Json (for reading configuration)
Use the following commands to install dependencies:

bash
Copy code
dotnet add package Selenium.WebDriver
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Newtonsoft.Json

3. Build the Project
After setting up everything, build the project:

bash
Copy code
dotnet build

4. Running Tests from Test Explorer
Open the project in Visual Studio.
Go to Test > Test Explorer.
Click Run All Tests or use the green Run button next to an individual test to run them.
The tests should appear in the Test Explorer if everything is set up correctly.

5. Run Tests via Command Line (Optional)
You can also run the tests from the command line using the following command:

bash
Copy code
dotnet test

Test Cases

TestCase1: Contact Form Error Handling
Submits the contact form with no data and verifies that error messages are displayed.
Submits the form with valid data and verifies that a success message is displayed.

TestCase2: Successful Form Submission
Fills out the contact form with valid data and submits it, verifying that a success message appears.

TestCase3: Shopping Cart Functionality
Adds multiple products to the shopping cart.
Navigates to the cart and verifies the total price.

6. Project Structure
SeleniumTest: Main test project that contains the test files and page object models.
Pages: Contains page object classes (HomePage, ContactPage, ShopPage, CartPage) that interact with the elements on the webpage.