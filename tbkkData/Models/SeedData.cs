using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace tbkkData.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.EmployeeType.Any())
                {
                    return;   // DB has been seeded
                }

                context.Company.AddRange(
                new Company
                {
                    CompanyName = "TBKK",
                    Category = "P.8"

                }
                );

                context.Company.AddRange(
                new Company
                {
                    CompanyName = "TBKK",
                    Category = "P.10"

                }
                );
                context.Department.AddRange(
               new Department
               {
                   DepartmentName = "Information Technology",
                   Status = "open"
               }
               );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Production Department",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Sales Department",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Accounting Department",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Human Resource",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                 new Department
                 {
                     DepartmentName = "CEO",
                     Status = "open"
                 }
                 );

                context.EmployeeType.AddRange(
                   new EmployeeType
                   {
                       EmployeeTypeName = "Full Time"
                   }
                   );
                context.EmployeeType.AddRange(
                   new EmployeeType
                   {
                       EmployeeTypeName = "Part Time"
                   }
                   );

                

                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Barron",
                   LastName = "Caspar",
                   Address = "West Lloydminster ",
                   Email = "London@gmail.com",
                   Telephone = "0988294410"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Calvyn",
                   LastName = "Dylan",
                   Address = "London ",
                   Email = "Calvyn@hotmail.com",
                   Telephone = "063156338"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Samuel",
                   LastName = "William",
                   Address = "Cheltenham",
                   Email = "Samuel@gmail.com",
                   Telephone = "0871502842"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Charlie",
                   LastName = "Damian",
                   Address = "Newcastle upon Tyne",
                   Email = "Charlie@hotmail.com",
                   Telephone = "0909688292"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Christopher",
                   LastName = "Dante",
                   Address = "Bolton",
                   Email = "Christopher@hotmail.com",
                   Telephone = "0810025909"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Edward",
                   LastName = "Harper",
                   Address = "Birkenhead",
                   Email = "Edward@gmail.com",
                   Telephone = "0665231498"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Ivan",
                   LastName = "Jacob",
                   Address = "Middlesbrough",
                   Email = "Ivan_Jacob@co.th",
                   Telephone = "0633214569"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Jordan",
                   LastName = "Kevin",
                   Address = "Loughborough",
                   Email = "Jordan@hotmail.com",
                   Telephone = "0879465321"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Lincoln",
                   LastName = "Maglorix",
                   Address = "Westminster City",
                   Email = "Lincoln@hotmail.com",
                   Telephone = "0633214528"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Matthew",
                   LastName = "Nicholas",
                   Address = "Exeter",
                   Email = "Matthew@gmail.com",
                   Telephone = "0632144567"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Oscar",
                   LastName = "Rohan",
                   Address = "Oxford",
                   Email = "Oscar@hotmail.com",
                   Telephone = "0874125896"
               }
               );
                context.Customer.AddRange(
               new Customer
               {
                   FirsName = "Richard",
                   LastName = "Serafim",
                   Address = "High Wycombe",
                   Email = "Richard@hotmail.com",
                   Telephone = "0987412351"
               }
               );

               

                context.Rival.AddRange(
               new Rival
               {
                   Name = "Robert Bosch",
                   Address = "London ",
                   Email = "Robert_Bosch@hotmail.com",
                   Telephone = "0988294410"
               }
               );

                context.Rival.AddRange(
                new Rival
                {
                    Name = "Johnson Controls",
                    Address = "Blackburn",
                    Email = "Johnson_Controls@gmail.com",
                    Telephone = "0811572158"
                }
                );

                context.Rival.AddRange(
                new Rival
                {
                    Name = "Magna International",
                    Address = "Winchester",
                    Email = "Magna_International@ac.th",
                    Telephone = "0631135758"
                }
                );
                context.Position.AddRange(
             new Position
             {
                 PositionName = "admin"
             }
             );

                context.Position.AddRange(
                new Position
                {
                    PositionName = "Manager"
                }
                );
                context.Position.AddRange(
                new Position
                {
                    PositionName = "Employee"
                }
                );
                context.Position.AddRange(
               new Position
               {
                   PositionName = "CEO"
               }
                 );



                context.SaveChanges();
            }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
                {
                    // Look for any movies.

                    if (context.Login.Any())
                    {
                        return;   // DB has been seeded
                    }
                    context.Employee.AddRange(
              new Employee
              {
                  FirstName = "Charlotte",
                  LastName = "Daisy",
                  Address = "London",
                  Telephone = "0632158475",
                  Salary = 16000,
                  Email = "Charlotte@gmail.com",
                 
                  Birthday = DateTime.Parse("2539-3-2"),
                  Status = "Working",
                  Date_of_employment = DateTime.Parse("2020-3-2"),
                  Gender = "Male",
                  CompanyID = 1,
                  DepartmentID = 1,
                  EmployeeTypeID = 1,
                  PositionID = 1
                  
              }
              );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Chloe",
                   LastName = "Ella",
                   Address = "Gloucester",
                   Telephone = "0621453339",
                   Salary = 15000,
                   Email = "Chloe@hotmail.com",
                   
                   Birthday = DateTime.Parse("2531-3-21"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 1,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Camilla",
                   LastName = "Emma",
                   Address = "Sheffield",
                   Telephone = "0817829346",
                   Salary = 15000,
                   Email = "Camilla@gmail.com",
                   
                   Birthday = DateTime.Parse("2521-12-12"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 2,
                   DepartmentID = 2,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Eva",
                   LastName = "Freya",
                   Address = "Doncaster",
                   Telephone = "0985742566",
                   Salary = 20000,
                   Email = "Eva_Freya@ac.th",
                   
                   Birthday = DateTime.Parse("2519-9-19"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 2,
                   DepartmentID = 6,
                   EmployeeTypeID = 1,
                   PositionID = 3
                   
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Ella",
                   LastName = "Grace",
                   Address = "Nottingham",
                   Telephone = "0623145287",
                   Salary = 19000,
                   Email = "Ella_Grace@ac.th",
                  
                   Birthday = DateTime.Parse("2530-8-30"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 3,
                   EmployeeTypeID = 1,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Gracie",
                   LastName = "Hannah",
                   Address = "Bournemouth",
                   Telephone = "0874125960",
                   Salary = 25000,
                   Email = "Gracie@hotmail.com",
                   
                   Birthday = DateTime.Parse("2538-8-13"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 2,
                   DepartmentID = 4,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Holly",
                   LastName = "Isabella",
                   Address = "Reims",
                   Telephone = "0985214763",
                   Salary = 24000,
                   Email = "Holly_Isabella@ac.th",
                   
                   Birthday = DateTime.Parse("2537-7-3"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 1,
                   DepartmentID = 4,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Jennifer",
                   LastName = "Katie",
                   Address = "Plymouth",
                   Telephone = "0985742314",
                   Salary = 23000,
                   Status = "Working",
                   Email = "Jennifer@hotmail.com",
                   
                   Birthday = DateTime.Parse("2529-3-29"),
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 1,
                   DepartmentID = 3,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Jasmine",
                   LastName = "Katie",
                   Address = "Middlesbrough",
                   Telephone = "0632145887",
                   Salary = 22000,
                   Email = "Jasmine@gmail.com",
                   
                   Birthday = DateTime.Parse("2517-7-17"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 2,
                   EmployeeTypeID = 1,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Jessica",
                   LastName = "Leah",
                   Address = "Winchester",
                   Telephone = "0874529863",
                   Salary = 21000,
                   Email = "Jessica@hotmail.com",
                  
                   Birthday = DateTime.Parse("2515-5-15"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 2,
                   DepartmentID = 1,
                   EmployeeTypeID = 1,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Lilly",
                   LastName = "Maisie",
                   Address = "Stourbridge",
                   Telephone = "087452139",
                   Salary = 20000,
                   Email = "Lilly@hotmail.com",
                   
                   Birthday = DateTime.Parse("2527-7-27"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 1,
                   EmployeeTypeID = 1,
                   PositionID = 3
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Arthur",
                   LastName = "Brooke",
                   Address = "Ancient Britain ",
                   Telephone = "0632154789",
                   Salary = 17000,
                   Email = "Arthur@hotmail.com",
                   Birthday = DateTime.Parse("2535-3-5"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 2,
                   EmployeeTypeID = 1,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Lucy",
                   LastName = "Megan",
                   Address = "Manchester ",
                   Telephone = "0874562103",
                   Salary = 18000,
                   Email = "Lucy_Megan@ac.th",
                   
                   Birthday = DateTime.Parse("2526-6-26"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 1,
                   DepartmentID = 3,
                   EmployeeTypeID = 2,
                   PositionID = 3
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Millie",
                   LastName = "Olivia",
                   Address = "Cheltenham",
                   Telephone = "0986521453",
                   Salary = 19000,
                   Email = "Millie@gmail.com",
                   
                   Birthday = DateTime.Parse("2513-3-31"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 2,
                   DepartmentID = 4,
                   EmployeeTypeID = 1,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Melyssa",
                   LastName = "Opal",
                   Address = "Birkenhead",
                   Telephone = "0933659987",
                   Salary = 20000,
                   Email = "Melyssa@gmail.com",
                   
                   Birthday = DateTime.Parse("2511-3-12"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 5,
                   EmployeeTypeID = 1,
                   PositionID = 4
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Phoebe",
                   LastName = "Ruby",
                   Address = "Manchester",
                   Telephone = "0879652140",
                   Salary = 15000,
                   Email = "Phoebe@hotmail.com",
                   
                   Birthday = DateTime.Parse("2525-5-2"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 2,
                   DepartmentID = 5,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Poppy",
                   LastName = "Sophia",
                   Address = "Loughborough",
                   Telephone = "0632897452",
                   Salary = 16000,
                   Email = "Poppy@hotmail.com",
                   
                   Birthday = DateTime.Parse("2534-4-3"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 4,
                   EmployeeTypeID = 1,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Addison",
                   LastName = "Benjamin",
                   Address = "Liverpool",
                   Telephone = "0632145687",
                   Salary = 17000,
                   Email = "Addison@gmail.com",
                   
                   Birthday = DateTime.Parse("2533-3-3"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Female",
                   CompanyID = 1,
                   DepartmentID = 3,
                   EmployeeTypeID = 1,
                   PositionID = 2
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Alvis",
                   LastName = "Brayden",
                   Address = "Wolverhampton",
                   Telephone = "0874125896",
                   Salary = 18000,
                   Email = "Alvis@hotmail.com",
                   
                   Birthday = DateTime.Parse("2525-1-11"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 1,
                   DepartmentID = 2,
                   EmployeeTypeID = 2,
                   PositionID = 1
               }
               );
                context.Employee.AddRange(
               new Employee
               {
                   FirstName = "Andrew",
                   LastName = "Brighton",
                   Address = "Oxford",
                   Telephone = "0987456321",
                   Salary = 19000,
                   Email = "Andrew@gmail.com",
                   
                   Birthday = DateTime.Parse("2509-9-2"),
                   Status = "Working",
                   Date_of_employment = DateTime.Parse("2020-3-2"),
                   Gender = "Male",
                   CompanyID = 2,
                   DepartmentID = 1,
                   EmployeeTypeID = 1,
                   PositionID = 2
               }
               );

                context.Login.AddRange(
               new Login
               {
                   Username = "59160001",
                   Password = "Daisy0001",
                   EmployeeID = 1
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160002",
                   Password = "Ella0002",
                   EmployeeID = 2
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160003",
                   Password = "Emma0003",
                   EmployeeID = 3
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160004",
                   Password = "Freya0004",
                   EmployeeID = 4
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160005",
                   Password = "Grace0005",
                   EmployeeID = 5
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160006",
                   Password = "Hannah0006",
                   EmployeeID = 6
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160007",
                   Password = "Isabella0007",
                   EmployeeID = 7
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160008",
                   Password = "Katie0008",
                   EmployeeID = 8
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160009",
                   Password = "Khet0009",
                   EmployeeID = 9
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160010",
                   Password = "Leah0010",
                   EmployeeID = 10
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160011",
                   Password = "Maisie0011",
                   EmployeeID = 11
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160012",
                   Password = "Kate0012",
                   EmployeeID = 12
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160013",
                   Password = "Megan0013",
                   EmployeeID = 13
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160014",
                   Password = "Opp0014",
                   EmployeeID = 14
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160015",
                   Password = "Krirk0015",
                   EmployeeID = 15
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160016",
                   Password = "Ruby0016",
                   EmployeeID = 16
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160017",
                   Password = "Kate0017",
                   EmployeeID = 17
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160018",
                   Password = "Krirk0018",
                   EmployeeID = 18
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160019",
                   Password = "Brayden0019",
                   EmployeeID = 19
               }
               );
                context.Login.AddRange(
               new Login
               {
                   Username = "59160020",
                   Password = "Krirk0020",
                   EmployeeID = 20
               }
               );


                context.Project.AddRange(
               new Project
               {
                   Name = "Disc brakes",
                   Cost = 95000,
                   StartDate = DateTime.Parse("2020-1-2"),
                   EndDate = DateTime.Parse("2020-2-2"),
                   CostGoal = 133000,
                   Status = "Completed",
                   EmployeeID = 3
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Caliper",
                   Cost = 55000,
                   StartDate = DateTime.Parse("2020-2-2"),
                   EndDate = DateTime.Parse("2020-3-2"),
                   CostGoal = 77000,
                   Status = "Completed",
                   EmployeeID = 5
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Brake caliper",
                   Cost = 50000,
                   StartDate = DateTime.Parse("2020-3-2"),
                   EndDate = DateTime.Parse("2020-4-2"),
                   CostGoal = 70000,
                   Status = "Completed",
                   EmployeeID = 8
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Hydraulic cylinder",
                   Cost = 77500,
                   StartDate = DateTime.Parse("2020-4-2"),
                   EndDate = DateTime.Parse("2020-5-2"),
                   CostGoal = 108500,
                   Status = "In progress",
                   EmployeeID = 9
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Brake cylinder",
                   Cost = 75000,
                   StartDate = DateTime.Parse("2020-5-2"),
                   EndDate = DateTime.Parse("2020-6-2"),
                   CostGoal = 105000,
                   Status = "completed",
                   EmployeeID = 12
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Clutch Master Cylinder",
                   Cost = 87500,
                   StartDate = DateTime.Parse("2020-6-2"),
                   EndDate = DateTime.Parse("2020-7-2"),
                   CostGoal = 122500,
                   Status = "Completed",
                   EmployeeID = 13
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Shock absorber",
                   Cost = 57500,
                   StartDate = DateTime.Parse("2020-7-2"),
                   EndDate = DateTime.Parse("2020-8-2"),
                   CostGoal = 80500,
                   Status = "Completed",
                   EmployeeID = 18
               }
               );
                context.Project.AddRange(
               new Project
               {
                   Name = "Brake Booster",
                   Cost = 150000,
                   StartDate = DateTime.Parse("2020-8-2"),
                   EndDate = DateTime.Parse("2020-9-2"),
                   CostGoal = 180000,
                   Status = "In progress",
                   EmployeeID = 19
               }
               );

                context.Order.AddRange(
             new Order
             {
                 OrDate = DateTime.Parse("2020-9-12"),
                 ShippedDate = DateTime.Parse("2020-10-2"),
                 Invoice = "INV-0001",
                 Total = 37500,
                 Status = "Complete",
                 CustomerID = 1,
                 EmployeeID = 5
             }
             ) ;

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-10-12"),
                   ShippedDate = DateTime.Parse("2020-11-2"),
                   Invoice = "INV-0002",
                   Total = 90000,
                   Status = "Complete",
                   CustomerID = 2,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-11-12"),
                   ShippedDate = DateTime.Parse("2020-12-2"),
                   Invoice = "INV-0003",
                   Total = 67500,
                   Status = "Complete",
                   CustomerID = 3,
                   EmployeeID = 13
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-12-12"),
                   ShippedDate = DateTime.Parse("2020-1-2"),
                   Invoice = "INV-0004",
                   Total = 55000,
                   Status = "Complete",
                   CustomerID = 4,
                   EmployeeID = 18
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-6-12"),
                   ShippedDate = DateTime.Parse("2020-7-2"),
                   Invoice = "INV-0005",
                   Total = 75000,
                   Status = "Complete",
                   CustomerID = 5,
                   EmployeeID = 5
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-7-12"),
                   ShippedDate = DateTime.Parse("2020-8-2"),
                   Invoice = "INV-0006",
                   Total = 110000,
                   Status = "Complete",
                   CustomerID = 6,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-8-12"),
                   ShippedDate = DateTime.Parse("2020-9-2"),
                   Invoice = "INV-0007",
                   Total = 27500,
                   Status = "Complete",
                   CustomerID = 7,
                   EmployeeID = 13
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-9-12"),
                   ShippedDate = DateTime.Parse("2020-10-2"),
                   Invoice = "INV-0008",
                   Total = 55000,
                   Status = "Complete",
                   CustomerID = 8,
                   EmployeeID = 5
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-11-12"),
                   ShippedDate = DateTime.Parse("2020-12-2"),
                   Invoice = "INV-0009",
                   Total = 90000,
                   Status = "Complete",
                   CustomerID = 9,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-12-12"),
                   ShippedDate = DateTime.Parse("2020-1-2"),
                   Invoice = "INV-0010",
                   Total = 75000,
                   Status = "Complete",
                   CustomerID = 10,
                   EmployeeID = 5
               }
               );
                context.Order.AddRange(
            new Order
            {
                OrDate = DateTime.Parse("2020-2-12"),
                ShippedDate = DateTime.Parse("2020-3-2"),
                Invoice = "INV-0011",
                Total = 45000,
                Status = "Complete",
                CustomerID = 1,
                EmployeeID = 5
            }
            );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-3-12"),
                   ShippedDate = DateTime.Parse("2020-4-2"),
                   Invoice = "INV-0012",
                   Total = 70000,
                   Status = "Complete",
                   CustomerID = 2,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-4-12"),
                   ShippedDate = DateTime.Parse("2020-5-2"),
                   Invoice = "INV-0013",
                   Total = 100000,
                   Status = "Complete",
                   CustomerID = 3,
                   EmployeeID = 13
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-5-12"),
                   ShippedDate = DateTime.Parse("2020-6-2"),
                   Invoice = "INV-0014",
                   Total = 25000,
                   Status = "Complete",
                   CustomerID = 4,
                   EmployeeID = 18
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-6-12"),
                   ShippedDate = DateTime.Parse("2020-7-2"),
                   Invoice = "INV-0015",
                   Total = 23000,
                   Status = "Complete",
                   CustomerID = 5,
                   EmployeeID = 5
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-7-12"),
                   ShippedDate = DateTime.Parse("2020-8-2"),
                   Invoice = "INV-0016",
                   Total = 20000,
                   Status = "Complete",
                   CustomerID = 6,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-8-12"),
                   ShippedDate = DateTime.Parse("2020-9-2"),
                   Invoice = "INV-0017",
                   Total = 45000,
                   Status = "Complete",
                   CustomerID = 7,
                   EmployeeID = 13
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-9-12"),
                   ShippedDate = DateTime.Parse("2020-10-2"),
                   Invoice = "INV-0018",
                   Total = 24000,
                   Status = "Complete",
                   CustomerID = 8,
                   EmployeeID = 5
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-10-12"),
                   ShippedDate = DateTime.Parse("2020-11-2"),
                   Invoice = "INV-0019",
                   Total = 72000,
                   Status = "Complete",
                   CustomerID = 9,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-11-12"),
                   ShippedDate = DateTime.Parse("2020-12-2"),
                   Invoice = "INV-0020",
                   Total = 58500,
                   Status = "Complete",
                   CustomerID = 10,
                   EmployeeID = 5
               }
               );
                context.Order.AddRange(
            new Order
            {
                OrDate = DateTime.Parse("2020-12-12"),
                ShippedDate = DateTime.Parse("2020-1-2"),
                Invoice = "INV-0021",
                Total = 50000,
                Status = "Complete",
                CustomerID = 1,
                EmployeeID = 5
            }
            );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-1-12"),
                   ShippedDate = DateTime.Parse("2020-2-2"),
                   Invoice = "INV-0022",
                   Total = 35000,
                   Status = "Complete",
                   CustomerID = 2,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-2-12"),
                   ShippedDate = DateTime.Parse("2020-3-2"),
                   Invoice = "INV-0023",
                   Total = 24500,
                   Status = "Complete",
                   CustomerID = 3,
                   EmployeeID = 13
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-3-12"),
                   ShippedDate = DateTime.Parse("2020-4-2"),
                   Invoice = "INV-0024",
                   Total = 54000,
                   Status = "Complete",
                   CustomerID = 4,
                   EmployeeID = 18
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-4-12"),
                   ShippedDate = DateTime.Parse("2020-5-2"),
                   Invoice = "INV-0025",
                   Total = 38000,
                   Status = "Complete",
                   CustomerID = 5,
                   EmployeeID = 5
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-5-12"),
                   ShippedDate = DateTime.Parse("2020-6-2"),
                   Invoice = "INV-0026",
                   Total = 26000,
                   Status = "Complete",
                   CustomerID = 6,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-6-12"),
                   ShippedDate = DateTime.Parse("2020-7-2"),
                   Invoice = "INV-0027",
                   Total = 52500,
                   Status = "Complete",
                   CustomerID = 7,
                   EmployeeID = 13
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-7-12"),
                   ShippedDate = DateTime.Parse("2020-8-2"),
                   Invoice = "INV-0028",
                   Total = 193500,
                   Status = "Complete",
                   CustomerID = 8,
                   EmployeeID = 5
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-8-12"),
                   ShippedDate = DateTime.Parse("2020-9-2"),
                   Invoice = "INV-0029",
                   Total = 50000,
                   Status = "Complete",
                   CustomerID = 9,
                   EmployeeID = 8
               }
               );

                context.Order.AddRange(
               new Order
               {
                   OrDate = DateTime.Parse("2020-9-12"),
                   ShippedDate = DateTime.Parse("2020-10-2"),
                   Invoice = "INV-0030",
                   Total = 44000,
                   Status = "Complete",
                   CustomerID = 10,
                   EmployeeID = 5
               }
               );

                context.SaveChanges();
            }
        }
    }
}
