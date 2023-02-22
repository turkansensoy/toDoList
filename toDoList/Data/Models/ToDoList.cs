namespace toDoList.Data.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsThingstoDoComplete { get; set; }
        public bool IsBeingComplete { get; set; }
        public bool IsDoneComplete { get; set; }

    }
}
