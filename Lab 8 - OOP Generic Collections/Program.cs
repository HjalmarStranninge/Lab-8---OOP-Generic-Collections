namespace Lab_8___OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating four instances of the Employee class.

            var firstEmployee = new Employee("1234", "Jordan Belfort", "Male", 100000000);
            var secondEmployee = new Employee("2345", "Frodo Baggins", "Male", 1);
            var thirdEmployee = new Employee("3456", "Andy Dufresne", "Male", 370000);
            var fourthEmployee = new Employee("4567", "Clarice Starling", "Female", 109965);
            var fifthEmployee = new Employee("5678", "Jack Torrance", "Male", 237);


            // Creating a stack to contain my newly created objects and using .Push to add the elements.

            Stack<Employee> employeeInfo = new Stack<Employee>();

            employeeInfo.Push(firstEmployee);
            employeeInfo.Push(secondEmployee);
            employeeInfo.Push(thirdEmployee);
            employeeInfo.Push(fourthEmployee);
            employeeInfo.Push(fifthEmployee);


            // Iterates through the stack, printing each element to the console, as well as a count of how many objects are in the stack.

            foreach (var employee in employeeInfo)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in the stack: {employeeInfo.Count}");
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Retrieve Using Pop Method");


            // Iterates through the stack again, but using Pop() to remove each object after it has been printed.

            while (employeeInfo.Count > 0 )
            {
                var employee = employeeInfo.Pop();
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in the stack: {employeeInfo.Count}");
            }

            // Adding the objects back into the stack.


            employeeInfo.Push(firstEmployee);
            employeeInfo.Push(secondEmployee);
            employeeInfo.Push(thirdEmployee);
            employeeInfo.Push(fourthEmployee);
            employeeInfo.Push(fifthEmployee);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Retrieve Using Peek Method");


            // Checking for elements in the stack before retrieving with Peek().

            if (employeeInfo.Count > 0 )
            {
                var employee = employeeInfo.Peek();
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in the stack: {employeeInfo.Count}");
             
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in the stack: {employeeInfo.Count}");
            }

            Console.WriteLine("-----------------------------------------------");


            // Using Contains() to check if my third object is in the stack and typing the result to the console.

            if (employeeInfo.Contains(thirdEmployee))
            {
                Console.WriteLine($"Object 3 is in the stack.");
            }
            else
            {
                Console.WriteLine("Object 3 is not in the stack.");
            }

            // Separating the stack and list sections for readability, 

            Console.WriteLine();
            Console.WriteLine("-------------       <LISTS>        ------------");
            Console.WriteLine();
            

            // Creating a new list and adding my Employee objects to it.

            List <Employee> employeeList = new List<Employee>();

            employeeList.Add(firstEmployee);
            employeeList.Add(secondEmployee);
            employeeList.Add(thirdEmployee);
            employeeList.Add(fourthEmployee);
            employeeList.Add(fifthEmployee);

            if (employeeList.Contains(secondEmployee))
            {
                Console.WriteLine("Object 2 is in the list.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Object 2 is not in the list.");
                Console.WriteLine();
            }

            Console.WriteLine(employeeList.Find(employee => employee.Gender == "Male"));
            Console.WriteLine();


            // Creating a new list for storing the male employees and extract them from the complete list using the FindAll() method.

            List<Employee> maleEmployees = employeeList.FindAll(employee => employee.Gender == "Male");


            // Checks if any male employees were found and writes them to the console if that is the case.

            if (maleEmployees.Count > 0)
            {
                foreach (var employee in maleEmployees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("No male employees found.");
            }            
        }
    }
}