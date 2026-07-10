using System;

class Task
{
    public int TaskId;
    public string TaskName;
    public string Status;
    public Task Next;

    public Task(int id, string name, string status)
    {
        TaskId = id;
        TaskName = name;
        Status = status;
        Next = null;
    }
}

class TaskManagement
{
    Task head = null;

    // Add Task
    public void AddTask(int id, string name, string status)
    {
        Task newTask = new Task(id, name, status);

        if (head == null)
        {
            head = newTask;
        }
        else
        {
            Task temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
        }

        Console.WriteLine("Task Added");
    }

    // Display Tasks
    public void DisplayTasks()
    {
        Console.WriteLine("\nTask List:");

        Task temp = head;

        while (temp != null)
        {
            Console.WriteLine($"{temp.TaskId} {temp.TaskName} {temp.Status}");
            temp = temp.Next;
        }
    }

    // Search Task
    public void SearchTask(int id)
    {
        Task temp = head;

        while (temp != null)
        {
            if (temp.TaskId == id)
            {
                Console.WriteLine("\nTask Found:");
                Console.WriteLine($"{temp.TaskId} {temp.TaskName} {temp.Status}");
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Task Not Found");
    }

    // Delete Task
    public void DeleteTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is Empty");
            return;
        }

        if (head.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task Deleted");
            return;
        }

        Task current = head;

        while (current.Next != null && current.Next.TaskId != id)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine("Task Not Found");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Task Deleted");
        }
    }
}

class Program
{
    static void Main()
    {
        TaskManagement task = new TaskManagement();

        task.AddTask(101, "Design UI", "Pending");
        task.AddTask(102, "Develop API", "In Progress");
        task.AddTask(103, "Testing", "Pending");

        task.DisplayTasks();

        task.SearchTask(102);

        task.DeleteTask(102);

        task.DisplayTasks();
    }
}