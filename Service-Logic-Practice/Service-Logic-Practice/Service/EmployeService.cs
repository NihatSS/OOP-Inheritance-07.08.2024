using Service_Logic_Practice.Data;
using Service_Logic_Practice.Model;

namespace Service_Logic_Practice.EmployeeService
{
    internal class EmployeService
    {
        public Employee[] GetAll()
        {
            AppDBContext context = new();
            return context.GetEmployees();
        }
    }
}
