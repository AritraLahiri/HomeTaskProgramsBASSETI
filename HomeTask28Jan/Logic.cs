using HomeTasksModels;

namespace HomeTasksLogic
{
    internal class Logic
    {

        private EmployeeDetails[] empArr = new EmployeeDetails[2];


        public static void UserInput(EmployeeDetails emp)
        {

            Console.WriteLine("Enter Emp Id");
            emp.Id = Console.ReadLine();
            Console.WriteLine("Enter Emp Name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter Emp Email");
            emp.Email = Console.ReadLine();
            Console.WriteLine("Enter Emp Password");
            emp.Password = Console.ReadLine();

        }

        public static void Display(EmployeeDetails e)
        {
            Console.WriteLine($"The Emp Id {e.Id}");
            Console.WriteLine($"Enter Emp Name {e.Name}");
            Console.WriteLine($"Enter Emp Email {e.Email}");
            Console.WriteLine($"Enter Emp Password {e.Password}");

        }

        public void SetValueToArray()
        {
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine($"Employee {i + 1}");
                empArr[i] = new EmployeeDetails();
                UserInput(empArr[i]);

            }
        }
        public void IsValidId(string Id)
        {
            foreach (EmployeeDetails emp in empArr)
            {
                if (emp.Id == Id)
                {
                    Display(emp);
                    return;
                }
            }
            Console.WriteLine($"Inval id is {Id}");
        }
        public void IsValidName(string name)
        {
            foreach (EmployeeDetails emp in empArr)
            {
                if (emp.Name == name)
                {
                    Display(emp);
                    return;
                }
            }
            Console.WriteLine($"Invalid Name {name}");
        }
        public void IsValidPass(string pass)
        {
            foreach (EmployeeDetails emp in empArr)
            {
                if (emp.Password == pass)
                {
                    Display(emp);
                    return;
                }
            }
            Console.WriteLine($"Invalid Password {pass}");
        }






    }
}
