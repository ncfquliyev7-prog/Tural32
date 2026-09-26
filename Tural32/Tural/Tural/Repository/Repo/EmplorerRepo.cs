using ConsoleApp2.Entities;
using ConsoleApp2.Entities.Mapping;
using ConsoleApp2.Repository.Abstract;
using Tural.Data.Access;

namespace Tural.Repository.Repo
{
    public class EmployeeRepo : IRepository<Employee>
    {
        private readonly BaseContext _enployer = new BaseContext();
        private BaseContext context;

        public EmployeeRepo(BaseContext context)
        {
            this.context = context;
        }

        public List<Employee> GetAll()
        {
            return _enployer.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _enployer.Employees.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Employee employee)
        {
            _enployer.Employees.Add(employee);
            _enployer.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _enployer.Employees.Update(employee);
            _enployer.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _enployer.Employees.FirstOrDefault(x => x.Id == id);

            if (employee != null)
            {
                _enployer.Employees.Remove(employee);
                _enployer.SaveChanges();
            }
        }
    }
}