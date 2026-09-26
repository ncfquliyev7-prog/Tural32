using ConsoleApp2.Entities;
using ConsoleApp2.Entities.Mapping;
using Tural.Data.Access;
using Tural.Repository.Repo;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseContext context = new BaseContext();

            CompanyRepo companyRepo = new CompanyRepo(context);
            EmployeeRepo employeeRepo = new EmployeeRepo(context);


            
            Company company = new Company
            {
                Name = "Microsoft",
                Address = "Baku",
                Phone = "0501234567"
            };

            companyRepo.Add(company);


            
            Employee employee = new Employee
            {
                FullName = "Tural Aliyev",
                Salary = 1500,
                Position = "Developer",
                CompanyId = company.Id
            };

            employeeRepo.Add(employee);


          
            Console.WriteLine("COMPANIES:");

            var companies = companyRepo.GetAll();

            foreach (var item in companies)
            {
                Console.WriteLine(
                    $"Id: {item.Id}, Name: {item.Name}, Address: {item.Address}, Phone: {item.Phone}"
                );
            }


            
            Console.WriteLine("\nEMPLOYEES:");

            var employees = employeeRepo.GetAll();

            foreach (var item in employees)
            {
                Console.WriteLine(
                    $"Id: {item.Id}, FullName: {item.FullName}, Salary: {item.Salary}, Position: {item.Position}, CompanyId: {item.CompanyId}"
                );
            }
        }
    }
}