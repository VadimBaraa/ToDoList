namespace ToDoList
{
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

        public TaskItem(string title, DateTime dueDate)
        {
            Title = title;
            DueDate = dueDate;
            IsCompleted = false;
        }
    }
}