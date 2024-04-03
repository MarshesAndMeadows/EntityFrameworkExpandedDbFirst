using DatabaseFirstScaffolding.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using BusinessLogic;

namespace DataAccess
{
    public class DataAccess
    {
        EmployeeTestContext db = new EmployeeTestContext();

        //Create
        public async Task<bool> CreateAsync(EmployeeUI employeeUI)
        {
            Employee employee = new Employee();
            employee.EmployeeId = employeeUI.EmployeeId;
            employee.FirstName = employeeUI.FirstName;
            employee.LastName = employeeUI.LastName;
            employee.PhoneNumbers = (ICollection<PhoneNumber>)employeeUI.PhoneNumbers;
            employee.Emails = (ICollection<Email>)employeeUI.Emails;
            employee.Addresses = (ICollection<Address>)employeeUI.Addresses;    
            
            await db.Employees.AddAsync(employee);
            int tmp = await db.SaveChangesAsync();
            if (tmp > 0)
            {
                return true;
            }
            return false;
        }


        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await db.Employees.ToListAsync();
        }

    }
}