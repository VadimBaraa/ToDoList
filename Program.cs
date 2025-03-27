using System;
using System.Collections.Generic;

class Program
{
    // Список для хранения задач
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== To-Do List ===");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Отметить как выполненную");
            Console.WriteLine("4. Показать все задачи");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    RemoveTask();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    ShowTasks();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // Метод для добавления задачи
    static void AddTask()
    {
        Console.Write("Введите название задачи: ");
        string title = Console.ReadLine();
        tasks.Add(new TaskItem(title));
        Console.WriteLine("Задача добавлена!");
        Console.ReadKey();
    }

    // Метод для удаления задачи
    static void RemoveTask()
    {
        ShowTasks();
        Console.Write("Введите номер задачи для удаления: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Задача удалена!");
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
        Console.ReadKey();
    }

    // Метод для отметки задачи как выполненной
    static void CompleteTask()
    {
        ShowTasks();
        Console.Write("Введите номер выполненной задачи: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks[index - 1].IsCompleted = true;
            Console.WriteLine("Задача отмечена как выполненная!");
        }
        else
        {
            Console.WriteLine("Неверный номер.");
        }
        Console.ReadKey();
    }

    // Метод для отображения списка задач
    static void ShowTasks()
    {
        Console.Clear();
        Console.WriteLine("=== Список задач ===");

        if (tasks.Count == 0)
        {
            Console.WriteLine("Список пуст.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Title}");
            }
        }
        Console.WriteLine("=====================");
    }
}

// Класс для задачи
class TaskItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public TaskItem(string title)
    {
        Title = title;
        IsCompleted = false;
    }
}
