using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data;
using Repositories.Interface;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private FPTContext __context;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;

        public RepositoryManager(FPTContext FPTContext)
        {
            __context = FPTContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(__context);
                return _companyRepository;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(__context);
                return _employeeRepository;
            }
        }

        public void Save() => __context.SaveChanges();
    }
}
