// See https://aka.ms/new-console-template for more information
class ToDoList()
{

    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nTo-Do List Menu:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    ViewTasks(tasks);
                    break;
                case "3":
                    RemoveTask(tasks);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
        Console.WriteLine("Welcome to the To-Do List Application!");
        // Here you can add more functionality like adding tasks, viewing tasks, etc.
    }

    static void AddTask(List<string> tasks)
    {
        Console.Write("Write a task to add to your To-Do List: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks(List<string> tasks)
    {
        Console.WriteLine("Your To-Do List:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in your To-Do List.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void RemoveTask(List<string> tasks)
    {
        ViewTasks(tasks);
        if (tasks.Count > 0) return;

        Console.Write("Enter the number of the task you want to remove: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task removed successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
