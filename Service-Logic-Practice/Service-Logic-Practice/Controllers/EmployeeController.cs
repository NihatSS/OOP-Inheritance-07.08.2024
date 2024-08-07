using Service_Logic_Practice.EmployeeService;

namespace Service_Logic_Practice.Controllers

{
    internal class EmployeeController
    {
        public void GetAll()
        {

            //EmployeeService den instance almaq isteyenda alinmirdi error verirdi adin deyisdim duzeldi
            //goresen niye?

            EmployeService employeeService = new EmployeService();

            var result = employeeService.GetAll();


            foreach (var item in result)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
