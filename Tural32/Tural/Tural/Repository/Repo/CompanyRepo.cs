using ConsoleApp2.Entities;
using ConsoleApp2.Repository.Abstract;
using Tural.Data.Access;

namespace Tural.Repository.Repo
{
    public class CompanyRepo : IRepository<Company>
    {
        private readonly BaseContext _context = new BaseContext();

        public CompanyRepo(BaseContext context)
        {
            _context = context;
        }

        public List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.Companies.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == id);

            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
        }
    }
}