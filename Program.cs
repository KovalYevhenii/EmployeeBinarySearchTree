namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeTree employee = new();

            while (true)
            {
                try
                {
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
                    while (true)
                    {
                        Console.WriteLine("Enter emount of salary");
                        try
                        {
                            double inputSalary = double.Parse(Console.ReadLine());

                            employee.Find(employee.Root, inputSalary);
                            Console.WriteLine("Enter 0 to restart programm or 1 to continue search or 2 to close the programm");
                            choise = int.Parse(Console.ReadLine());
                            switch(choise)
                            {
                                case 0:
                                    employee = new();
                                    break;
                                case 1:
                                    continue;
                                case 2:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Invalid input");
                                    continue;
                            }
                            if (choise == 0)
                            {
                               
                            }
                            else if (choise == 1) continue;
                            else if (choise == 2) Environment.Exit(0);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Wrong input exception");
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected arror occurred : {ex.Message}");
                }
            }
        }
    }
}
