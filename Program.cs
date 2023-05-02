namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeTree employee = new();

            while (true)
            {
                Console.WriteLine("Enter 'add' to add a new employee or press Enter to exit:");
                string? command = Console.ReadLine();

                if (string.IsNullOrEmpty(command))
                {
                    break;
                }
                else if (command.ToLower() == "add")
                {
                    employee.Add();
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }

            employee.Traverse(employee.Root);
            int choise;
            do
            {
                Console.WriteLine("Enter emount of salary");
                double inputSalary = double.Parse(Console.ReadLine());
                employee.Find(employee.Root, inputSalary);
                Console.WriteLine("Enter 0 to restart programm or 1 to continue search");
                choise = int.Parse(Console.ReadLine());


            } while (choise != 0);




        }





    }

}