using System.Collections.Generic;

namespace Api
{

    public interface IEmployeeService
    {
        /// <summary>
        /// get list of all employees
        /// </summary>
        /// <returns></returns>
        List<Employees> GetEmployeesList();

    }
}
