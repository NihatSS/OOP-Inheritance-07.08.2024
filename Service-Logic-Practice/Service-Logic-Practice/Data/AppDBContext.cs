using Service_Logic_Practice.Model;

namespace Service_Logic_Practice.Data
{
    internal class AppDBContext
    {
        public Employee[] GetEmployees()
        {
            Employee emp1 = new()
            {
                name = "Nihat",
                surname = "Soltanov",
                age = 17,
                email = "nihat@code.edu.az",
                address = "9 mkr",
                finCode = "7gahppp",
                birthday = new DateTime(2006, 09, 12)
            };

            Employee emp2 = new()
            {
                name = "Ferdi",
                surname = "Ismayilzade",
                age = 18,
                email = "ferdi@code.edu.az",
                address = "Ecemi",
                finCode = "123F",
                birthday = new DateTime(2003, 04, 25)
            };

            Employee emp3 = new()
            {
                name = "Hemid",
                surname = "Eliyev",
                age = 38,
                email = "hemid@code.edu.az",
                address = "Nesimi",
                finCode = "123H",
                birthday = new DateTime(1996, 08, 28)
            };

            Employee emp4= new()
            {
                name = "Nergiz",
                surname = "Nadirli",
                age = 20,
                email = "nergiz@code.edu.az",
                address = "Mehemmedli",
                finCode = "123N",
                birthday = new DateTime(2000, 01, 02)
            };

            Employee[] employees = { emp1, emp2, emp3, emp4 };

            return employees;
        } 
    }
}
