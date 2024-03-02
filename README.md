# Selenium with C# using POM
A page object model (POM) using selenium with C# for the page - http://horse.industryconnect.io/
I will be using Visual Studio and NUnit test framework

## Pre Requisites
Install the following needed applications
- [Visual Studio Community](https://www.visualstudio.com/vs/community/) - IDE
  > (install the **'.NET Desktop Development'** and **'ASP.NET and web development'** workloads)

  ### Packages
  Packages or libraries in Visual Studio to install

  | Title | Notes |
  |-------|-------|
  | Selenium.Webdriver | choose latest version
  | Selenium.Support | 
  | DotNetSeleniumExtras.PageObjects.Core | to use page factory
  | Selenium.WebDriver.ChromeDriver | webdriver for chrome
  | System.Configuration.ConfigurationManager | access config files
  | DotNetSeleniumExtras.WaitHelpers | implementation of ExpectedConditions
  | Microsoft.NETCore.App | optional, deprecated

## Getting Started
- Create a new project - NUnit Test Project (.NET Core). User Latest framework e.g. .NET 6.0 (Long-term support)
- Install needed libraries by going to Project > Manage NuGet Packages... or through Solution Explorer > Dependencies > right-click Packages > Manage NuGet Packages...
- Under Project, Add New Folder - Source > Pages, Tests

## Running Test from CLI

- Open Terminal and run dotnet from project directory:
`C:\se-csharp-iconnect> dotnet test --filter "Category=Regression"`
  > dotnet test will run all tests
- Html report will be generated under the reports folder

## References
- [Selenium .NET API Docs](https://www.selenium.dev/selenium/docs/api/dotnet/)

## Notes
>#### gitignore
>Search for VisualStudio under Add .gitignore in GitHub

## Contact
If you have any questions or need some help, please do contact me

