##INSTALLATION and SETUP##

-Install Visual Studio Community 2017
-Clone the project from GitHub
-Open the CompareTheMarketProject.sln in Visual Studio
-Check the references to Selenium.Webdriver and Selenium.Support, if not go to Manage NuGet packages and install them
-Add the geckodriver.exe and firefox in PATH in environment variables
-Have used BDDfy in the tests, so enusure TestStack.BDDfy is installed


##CompareTheMarketProject##

The project tests the workflow of the energy page of the website www.comparethemarket.com 
and provides the estimated energy rates for a particular area based on the details provided.


-In the solution there are 2 projects:
  1)CompareTheMarketProject - has all the classes
  2)AutomatedAcceptanceTest - has 3 Acceptance tests(UnitTestFramework)
-Make sure the AutomatedAcceptanceTest has a reference to CompareTheMarketProject
-Have used Firefox as the default browser
-Build and Run the tests

Note:Make sure the browser cache is cleared in Firefox before you run the test.
     All the tests have been run and passed in Firefox Version-47 and Selenium 3.3.0.0
     More asserts need to be added to improve the test to meet customer requirements, given more time I would be able to do the same.

##Tools##

OS used : Windows
Automation Tool : Selenium Webdriver v3.3
Language : C#
IDE : Visual Studio Community 2017
BDD Tool :Teststack.BDDfy
Browser : Firefox v47