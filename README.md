# Senior .NET Developer Hands On Test - Employees Salaries
## Task

The objetive of this project is to challenge the coding abilities of the developer.

### Installing

Clone the source repository from Github.

```
git clone https://github.com/difer300/MasGlobal-employees-salaries.git
```

Click in "MasGlobal.EmployeesSalaries.sln" to open the Solution.

In the Solution Explorer window go to the solution name.

```
right-click and select the option "Restore NuGet Packages"
```
```
right-click "Clean Solution" and then "Rebuild Solution"
```

Go to the project "MasGlobal.EmployeesSalaries.Web". 
```
right-click and "Set as StartUp Project"
```

Run the application
```
F5
```

If there some error in the application please repeat one more time 
```
right-click "Clean Solution" and then "Rebuild Solution"
```

## Running the tests

The run the unit test cases go to the project "MasGlobal.EmployeesSalaries.Tests". 
```
right-click "Run unit tests"
```

The program automatically run all the unit test included and show the results in the Unit Tests window. 

## Solution

The Solution include five projects: 
### MasGlobal-employees-salaries.DAL
Inlcude the Data layer with API Helper to call the service that expose the data of the application

### MasGlobal-employees-salaries.BLL
Inlcude the Logic layer that process all the DTO's to Employees objects. 

### MasGlobal-employees-salaries.Models
Inlcude the Model layer that support the process for the DAL, BLL and Web.

### MasGlobal-employees-salaries.Web
Inlcude the Web layer that containts the web application to show all the data of the employees. 

### MasGlobal-employees-salaries.Test
Inlcude the unit test cases for the BLL layer. 

## Built With

* SDK: .Net Framework 4.6.1
* [Newtonsoft](https://www.newtonsoft.com/json) - Json Converter
* [AutoFixture.AutoMoq](https://www.nuget.org/packages/AutoFixture.AutoMoq/) - Used to create mocks

## Authors

* **[Diego Navarro]** - https://github.com/difer300

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
