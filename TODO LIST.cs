using System;
using System.Collections.Generic;

public class TodoItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public TodoItem(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
{
    return (IsCompleted ? "[✓]" : "[ ]") + " " + Description;
}

}

public class Program
{
    static List<TodoItem> todoList = new List<TodoItem>();

    public static void Main()
    {
		Console.WriteLine("Welcome to Monica  TODO list!");
		List<string> todoListItems = new List<string>();
		
        while (true)
        {
            ShowMenu();
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                    AddTodo();
                    break;
                case "2":
                    ListTodos();
                    break;
                case "3":
                    MarkTodoAsCompleted();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("HELLO MONII");
        Console.WriteLine("1. MY TODO");
        Console.WriteLine("2. TODAY'S TASK ");
        Console.WriteLine("3. HURRAY YOU HAVE COMPLETED");
        Console.WriteLine("4. DONE FOR THE DAY !EXIT MON");
        Console.Write("Select an option: ");
    }

    static void AddTodo()
    {
        Console.Write("MONICA YOUR TASK FOR THE DAY IS: ");
        string description = Console.ReadLine();
        todoList.Add(new TodoItem(description));
        Console.WriteLine(" TODO ADDED!  Press Enter to continue...");
        Console.ReadLine();
    }

    static void ListTodos()
    {
        Console.WriteLine("YOUR TASK FOR THE DAY:");
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + todoList[i]);
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void MarkTodoAsCompleted()
    {
        ListTodos();
        Console.Write("ENTER THE TASK YOU HAVE COMPLETED TODAY: ");
        string input = Console.ReadLine();

        int index;
        if (int.TryParse(input, out index) && index > 0 && index <= todoList.Count)
        {
            todoList[index - 1].MarkAsCompleted();
            Console.WriteLine("HURRAY YOU HAVE COMPLETED MON! Press Enter to continue...");
        }
        else
        {
            Console.WriteLine("Invalid number, press Enter to continue...");
        }
        Console.ReadLine();
    }
}


