
using System.Text.RegularExpressions;
namespace BinarySearchTree
{
    internal class EmployeeTree
    {
        public EmployeeNode? Root;
        public void Add()
        {
            string name = AddName();
            double salary = AddSalary();
            var node = new EmployeeNode { Salary = salary, Name = name };
            if (Root == null)
            {
                Root = node;
                return;
            }
            AddNode(Root, node);
        }
        private static string AddName()
        {
            string? name;
            do
            {
                Console.WriteLine("Enter employee name: ");
                name = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"));
            return name;
        }
        private static double AddSalary()
        {
            double salary;
            bool isValidSalary;
            do
            {
                Console.WriteLine("Enter employee salary: ");
                string? input = Console.ReadLine();
                isValidSalary = double.TryParse(input, out salary);
                if (!isValidSalary)
                {
                    Console.WriteLine("Invalid input. Please enter a valid salary");
                }
                else if (salary < 0)
                {
                    Console.WriteLine("Salary can not be negative");
                }
            } while (!isValidSalary); return salary;
        }
        private void AddNode(EmployeeNode parent, EmployeeNode nodeToAdd)
        {
            if (nodeToAdd.Salary < parent.Salary)
            {
                if (parent.Left == null)
                {
                    parent.Left = nodeToAdd;
                }
                else
                {
                    AddNode(parent.Left, nodeToAdd);
                }
            }
            else
            {
                if (parent.Right == null)
                {
                    parent.Right = nodeToAdd;
                }
                else
                {
                    AddNode(parent.Right, nodeToAdd);
                }
            }
        }
        public void Find(EmployeeNode? root, double salary)
        {
            if (root == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            if (salary == root.Salary)
            {
                Console.WriteLine($"this salary belong to: {root.Name}");
                return;
            }
            if (salary < root.Salary)
            {
                Find(root.Left, salary);
            }
            else
            {
                Find(root.Right, salary);
            }
        }
        public void Traverse(EmployeeNode? node)
        {
            if (node == null)
            {
                return;
            }
            Traverse(node.Left);
            Console.WriteLine($"{node.Name}: {node.Salary}");
            Traverse(node.Right);
        }
    }
}
