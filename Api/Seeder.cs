using System.Linq;

namespace Api
{
    public class Seeder
    {
        private readonly EmpContext _context;
        public Seeder(EmpContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            AddNewType(new Employees()
            {
                Designation = "Engineer",
                EmployeeFirstName = "Ankit",
                EmployeeLastName = "Verma",
                Salary = 1000000000000
            });
            AddNewType(new Employees()
            {
                Designation = "Engineer",
                EmployeeFirstName = "Ankush",
                EmployeeLastName = "Verma",
                Salary = 1000000000000
            });
            AddNewType(new Employees()
            {
                Designation = "Engineer",
                EmployeeFirstName = "Anuj",
                EmployeeLastName = "Verma",
                Salary = 1000000000000
            });
            AddNewType(new Employees()
            {
                Designation = "Engineer",
                EmployeeFirstName = "Anu",
                EmployeeLastName = "Verma",
                Salary = 1000000000000
            });
            AddNewType(new Employees()
            {
                Designation = "Engineer",
                EmployeeFirstName = "Aman",
                EmployeeLastName = "Verma",
                Salary = 1000000000000
            });
            AddNewType(new Employees()
            {
                Designation = "Engineer",
                EmployeeFirstName = "Gaurav",
                EmployeeLastName = "Verma",
                Salary = 1000000000000
            });
            _context.SaveChanges();
        }

        // since we run this seeder when the app starts
        // we should avoid adding duplicates, so check first
        // then add
        private void AddNewType(Employees postType)
        {
            var existingType = _context.Employees.FirstOrDefault(p => p.EmployeeFirstName == postType.EmployeeFirstName);
            if (existingType == null)
            {
                _context.Employees.Add(postType);
            }
        }
    }
}
