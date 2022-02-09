using System;
using System.Collections.Generic;
using System.Linq;

namespace Api
{
    public class EmployeeService : IEmployeeService
    {
        private EmpContext _context;

        public EmployeeService(EmpContext context)
        {
            _context = context;
        }

        /// <summary>
        /// get list of all employees
        /// </summary>
        /// <returns></returns>
        public List<Employees> GetEmployeesList()
        {
            List<Employees> empList;
            try
            {
                empList = _context.Set<Employees>().ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return empList;
        }
    }

}