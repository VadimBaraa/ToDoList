using System;
using System.Collections.Generic;
using System.Globalization;

namespace ToDoList
{
    public static class TaskAdder
    {
        public static void Add(List<TaskItem> tasks)
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Название задачи не может быть пустым.");
                Console.ReadKey();
                return; 
            }

            Console.Write("Введите дату и время выполнения (формат: дд.ММ.гггг чч:мм): ");
            DateTime dueDate;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dueDate))
            {
                Console.Write("Некорректный формат! Повторите ввод (дд.ММ.гггг чч:мм): ");
            }

            tasks.Add(new TaskItem(title, dueDate));
            Console.WriteLine("Задача добавлена!");
            Console.ReadKey();
        }
    }
}
