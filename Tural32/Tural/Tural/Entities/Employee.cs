using ConsoleApp2.Entities.Mapping;

namespace ConsoleApp2.Entities.Mapping
{
     public class Employee
    {
       public int Id { get; set; }
        public string? FullName { get; set; }
        public int Salary { get; set; }
        public string? Position { get; set; }
        public int CompanyId { get; set; }
        
        public Company companys { get; set; }



    }
}